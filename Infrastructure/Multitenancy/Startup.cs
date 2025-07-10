using Application.Common.Persistence;
using Application.Multitenancy;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Shared.Authorization;
using Shared.Multitenancy;

namespace Infrastructure.Multitenancy;

internal static class Startup
{
    internal static IServiceCollection AddMultitenancy(this IServiceCollection services, IConfiguration config)
    {
        // Register master DB for tenants list
        services.AddDbContext<TenantDbContext>((sp, options) =>
        {
            var dbSettings = sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
            options.UseDatabase(dbSettings.DBProvider, dbSettings.ConnectionString);
        });

        // Register core tenant services
        services.AddHttpContextAccessor();
        services.AddScoped<ITenantProvider, TenantProvider>();
        services.AddScoped<ITenantService, TenantService>();
        return services;
    }

    internal static IApplicationBuilder UseMultiTenancy(this IApplicationBuilder app)
    {  
        return app.UseMiddleware<TenantResolutionMiddleware>();
    }
}