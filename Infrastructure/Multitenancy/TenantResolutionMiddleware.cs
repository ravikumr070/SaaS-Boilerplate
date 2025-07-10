
using Application.Common.Persistence;
using Application.Multitenancy;
using Domain.MasterTenant;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shared.Multitenancy;

namespace Infrastructure.Multitenancy
{
    public class TenantResolutionMiddleware
    {
        private readonly RequestDelegate _next;
        public TenantResolutionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var tenantService = context.RequestServices.GetRequiredService<ITenantService>();
            var tenantProvider = context.RequestServices.GetRequiredService<ITenantProvider>();

            string? tenantKey = MultitenancyConstants.TenantIdName;
            string? tenantId = context.Request.Headers[tenantKey].FirstOrDefault()
                               ?? context.Request.Query[tenantKey].FirstOrDefault()
                               ?? context.Request.Host.Host.Split('.').FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(tenantId))
            {
                try
                {
                    var tenantInfo = await tenantService.GetByIdAsync(tenantKey);

                    var tenant = new Tenant
                    {
                        Id = tenantInfo.Id,
                        Name = tenantInfo.Name,
                        ConnectionString = tenantInfo.ConnectionString,
                        SiteUrl = tenantInfo.SiteUrl,
                        IsActive = tenantInfo.IsActive,
                        ValidUpto = tenantInfo.ValidUpto
                    };

                    tenantProvider.SetTenant(tenant);
                    context.Items["Tenant"] = tenant;
                }
                catch
                {
                    // optional: handle missing tenant (return 403/404/etc.)
                }
            }

            await _next(context);
        }
    }
}
