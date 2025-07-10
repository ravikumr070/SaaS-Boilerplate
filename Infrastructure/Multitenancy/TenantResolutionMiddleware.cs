using Application.Common.Persistence;
using Application.Multitenancy;
using Domain.MasterTenant;
using Microsoft.AspNetCore.Http;
using Shared.Multitenancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Multitenancy
{
    public class TenantResolutionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ITenantService _tenantService;

        public TenantResolutionMiddleware(RequestDelegate next, ITenantService tenantService)
        {
            _next = next;
            _tenantService = tenantService;
        }

        public async Task InvokeAsync(HttpContext context, ITenantProvider tenantProvider)
        {
            string? tenantKey = MultitenancyConstants.TenantIdName;
            string? tenantId = context.Request.Headers[tenantKey].FirstOrDefault()
                               ?? context.Request.Query[tenantKey].FirstOrDefault()
                               ?? context.Request.Host.Host.Split('.').FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(tenantId))
            {
                try
                {
                    var tenantInfo = await _tenantService.GetByIdAsync(tenantId);

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
