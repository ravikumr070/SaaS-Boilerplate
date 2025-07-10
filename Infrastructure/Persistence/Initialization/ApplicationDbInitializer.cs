using Application.Common.Persistence;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;
using Azure;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace Infrastructure.Persistence.Initialization;

internal class ApplicationDbInitializer
{
    private readonly ApplicationDbContext _dbContext;
    private readonly ITenantProvider _tenantProvider;
    private readonly ApplicationDbSeeder _dbSeeder;
    private readonly ILogger<ApplicationDbInitializer> _logger;
    private readonly IWebHostEnvironment _environment;
    private readonly AzureDatabaseSettings _azuredbSettings;
    public ApplicationDbInitializer(ApplicationDbContext dbContext, ITenantProvider tenantProvider, ApplicationDbSeeder dbSeeder, ILogger<ApplicationDbInitializer> logger, IWebHostEnvironment environment, IOptions<AzureDatabaseSettings> azuredbSettings)
    {
        _dbContext = dbContext;
        _tenantProvider = tenantProvider;
        _dbSeeder = dbSeeder;
        _logger = logger;
        _environment = environment;
        _azuredbSettings = azuredbSettings.Value;
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        var tenant = _tenantProvider.GetTenant();
        if (tenant == null)
            throw new Exception("Tenant not found");
        if (_environment.IsDevelopment()) // localhost code
        {
            if (_dbContext.Database.GetMigrations().Any())
            {
                if ((await _dbContext.Database.GetPendingMigrationsAsync(cancellationToken)).Any())
                {
                    _logger.LogInformation("Applying Migrations for '{tenantId}' tenant.", tenant.Name);
                    await _dbContext.Database.MigrateAsync(cancellationToken);
                }

                if (await _dbContext.Database.CanConnectAsync(cancellationToken))
                {
                    _logger.LogInformation("Connection to {tenantId}'s Database Succeeded.", tenant.Name);

                    await _dbSeeder.SeedDatabaseAsync(_dbContext, cancellationToken);
                }
            }
        }
        else // azure code
        {
            SqlConnectionStringBuilder builder = new(tenant.ConnectionString.Trim());
            string mainDatabaseName = builder.InitialCatalog;
            DefaultAzureCredential credential = new();
            ArmClient armClient = new(credential, _azuredbSettings.SubscriptionId);
            Azure.Response<SqlServerResource> sqlServer = await armClient.GetResourceGroupResource(
                    new ResourceIdentifier(
                        $"/subscriptions/{_azuredbSettings.SubscriptionId}/resourceGroups/{_azuredbSettings.ResourceGroupName}"))
                .GetAsync()
                .Result
                .Value.GetSqlServerAsync(_azuredbSettings.SqlServerName);

            // Create a new database in the Elastic Pool
            ArmOperation<SqlDatabaseResource> databaseResponse = await sqlServer.Value
                .GetSqlDatabases().CreateOrUpdateAsync(WaitUntil.Completed,
                    mainDatabaseName,
                    new SqlDatabaseData(new AzureLocation(sqlServer.Value.Data.Location))
                    {
                        ElasticPoolId =
                            (await sqlServer.Value.GetElasticPoolAsync(
                                _azuredbSettings.ElasticPoolName))
                            .Value.Data.Id
                    });

            // apply migrations to the new database
            if (_dbContext.Database.GetMigrations().Any())
            {
                if ((await _dbContext.Database.GetPendingMigrationsAsync(cancellationToken)).Any())
                {
                    _logger.LogInformation("Applying Migrations for '{tenantId}' tenant.", tenant.Name);
                    await _dbContext.Database.MigrateAsync(cancellationToken);
                }

                if (await _dbContext.Database.CanConnectAsync(cancellationToken))
                {
                    _logger.LogInformation("Connection to {tenantId}'s Database Succeeded.", tenant.Name);

                    await _dbSeeder.SeedDatabaseAsync(_dbContext, cancellationToken);
                }
            }
            if (databaseResponse.Value.Data.Id is null)
            {
                throw new Exception("Couldn't create DB on azure");
            }
        }
    }
}