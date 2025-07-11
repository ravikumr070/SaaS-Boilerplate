using Infrastructure.Common;
using Hangfire;
using Hangfire.Console;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Hangfire.SqlServer;

namespace Infrastructure.BackgroundJobs;

internal static class Startup
{
    private static readonly ILogger _logger = Log.ForContext(typeof(Startup));

    internal static IServiceCollection AddBackgroundJobs(this IServiceCollection services, IConfiguration config)
    {
        services.AddHangfireServer(options => config.GetSection("HangfireSettings:Server").Bind(options));

        //services.AddHangfireConsoleExtensions();

        var storageSettings = config.GetSection("HangfireSettings:Storage").Get<HangfireStorageSettings>();

        if (string.IsNullOrEmpty(storageSettings.StorageProvider)) throw new Exception("Hangfire Storage Provider is not configured.");
        if (string.IsNullOrEmpty(storageSettings.ConnectionString)) throw new Exception("Hangfire Storage Provider ConnectionString is not configured.");
        _logger.Information($"Hangfire: Current Storage Provider : {storageSettings.StorageProvider}");
        _logger.Information("For more Hangfire storage, visit https://www.hangfire.io/extensions.html");

        services.AddSingleton<JobActivator, JobActivator>();

        services.AddHangfire((provider, hangfireConfig) => hangfireConfig
            .UseDatabase(storageSettings.StorageProvider, storageSettings.ConnectionString, config)
            .UseFilter(new JobFilter(provider))
            .UseFilter(new LogJobFilter())
            .UseConsole());

        return services;
    }

    private static IGlobalConfiguration UseDatabase(this IGlobalConfiguration hangfireConfig, string dbProvider, string connectionString, IConfiguration config) =>
        dbProvider.ToLowerInvariant() switch
        {
           
            DbProviderKeys.SqlServer =>
                hangfireConfig.UseSqlServerStorage(connectionString, config.GetSection("HangfireSettings:Storage:Options").Get<SqlServerStorageOptions>()),
            _ => throw new Exception($"Hangfire Storage Provider {dbProvider} is not supported.")
        };

    internal static IApplicationBuilder UseHangfireDashboard(this IApplicationBuilder app, IConfiguration config)
    {
        var dashboardOptions = config.GetSection("HangfireSettings:Dashboard").Get<DashboardOptions>();

        dashboardOptions.Authorization = new[]
        {
           new HangfireCustomBasicAuthenticationFilter
           {
                User = config.GetSection("HangfireSettings:Credentials:User").Value,
                Pass = config.GetSection("HangfireSettings:Credentials:Password").Value
           }
        };

        return app.UseHangfireDashboard(config["HangfireSettings:Route"], dashboardOptions);
    }
}