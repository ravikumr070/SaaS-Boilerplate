using Application.Common.Interfaces;
using Application.Common.Persistence;
using Infrastructure.Cors;
using Infrastructure.Multitenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Shared.Multitenancy;
using System.Reflection;
using Domain.MasterTenant;

namespace Infrastructure.Persistence.Initialization;

internal class DatabaseInitializer : IDatabaseInitializer
{
    private readonly TenantDbContext _tenantDbContext;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<DatabaseInitializer> _logger;
    private readonly ISerializerService _serializerService;
    public DatabaseInitializer(TenantDbContext tenantDbContext, IServiceProvider serviceProvider, ILogger<DatabaseInitializer> logger, ISerializerService serializerService)
    {
        _tenantDbContext = tenantDbContext;
        _serviceProvider = serviceProvider;
        _logger = logger;
        _serializerService = serializerService;
    }

    public async Task InitializeDatabasesAsync(CancellationToken cancellationToken)
    {
        await InitializeTenantDbAsync(cancellationToken);

        foreach (var tenant in await _tenantDbContext.Tenants.ToListAsync(cancellationToken))
        {
            await InitializeApplicationDbForTenantAsync(tenant, cancellationToken);
        }

        await UpdateCorsAsync(cancellationToken);
        _logger.LogInformation("File is up");
        _logger.LogInformation("Open Source Code");
    }

    public async Task InitializeApplicationDbForTenantAsync(Tenant tenant, CancellationToken cancellationToken)
    {
        using var scope = _serviceProvider.CreateScope();
        var tenantProvider = scope.ServiceProvider.GetRequiredService<ITenantProvider>();
        (tenantProvider as TenantProvider)?.SetTenant(tenant);

        var dbInitializer = scope.ServiceProvider.GetRequiredService<ApplicationDbInitializer>();
        await dbInitializer.InitializeAsync(cancellationToken);
    }

    private async Task InitializeTenantDbAsync(CancellationToken cancellationToken)
    {
        if (_tenantDbContext.Database.GetPendingMigrations().Any())
        {
            _logger.LogInformation("Applying Root Migrations.");
            await _tenantDbContext.Database.MigrateAsync(cancellationToken);
        }

        await SeedRootTenantAsync(cancellationToken);
    }

    private async Task SeedRootTenantAsync(CancellationToken cancellationToken)
    {
        if (await _tenantDbContext.Tenants.FindAsync(new object?[] { MultitenancyConstants.Root.Id }, cancellationToken: cancellationToken) is null)
        {
            var rootTenant = new TenantInfo(
                MultitenancyConstants.Root.Id,
                MultitenancyConstants.Root.Name,
                string.Empty,
                MultitenancyConstants.Root.EmailAddress,
                MultitenancyConstants.Root.SiteName,
                MultitenancyConstants.Root.SiteUrl
                );

            rootTenant.SetValidity(DateTime.UtcNow.AddYears(1));

            _tenantDbContext.Tenants.Add(rootTenant);

            await _tenantDbContext.SaveChangesAsync(cancellationToken);
        }
    }
    public async Task UpdateCorsAsync(CancellationToken cancellationToken)
    {
        string? path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        try
        {
            _logger.LogInformation("Started to Update Cors.");
            string corsData = await File.ReadAllTextAsync(path + "/Configurations/cors.json", cancellationToken);
            var cors = _serializerService.Deserialize<CorsSettingData>(corsData);
            var corsnewData = _tenantDbContext.Tenants.ToList().Select(t => t.SiteUrl).ToList();
            string corsValidUrl = string.Empty;
            if (corsnewData is not null) corsValidUrl = string.Join(';', corsnewData);
            if(!string.IsNullOrEmpty(corsValidUrl))
            {
                cors.CorsSettings.Data = corsValidUrl;
                string corsjsData = _serializerService.Serialize(cors);
                await File.WriteAllTextAsync(path + "/Configurations/cors.json", corsjsData, cancellationToken);
            }
        }
        catch (Exception ex)
        {
            _logger.LogInformation($"Update Cors failed .{ex.Message}");
        }
    }
}