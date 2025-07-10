using Domain.MasterTenant;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Multitenancy
{
    public static class HttpContextExtensions
    {
        private const string TenantKey = "Tenant";

        public static void TrySetTenantInfo(this HttpContext context, Tenant tenant, bool overwrite = false)
        {
            if (context == null || tenant == null)
                return;

            if (overwrite || !context.Items.ContainsKey(TenantKey))
                context.Items[TenantKey] = tenant;
        }

        public static Tenant? GetTenantInfo(this HttpContext context)
        {
            if (context == null)
                return null;

            return context.Items.TryGetValue(TenantKey, out var value) && value is Tenant tenant
                ? tenant
                : null;
        }
    }
}
