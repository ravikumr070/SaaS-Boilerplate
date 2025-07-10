using Application.Interfaces.Multitenancy;
using Domain.MasterTenant;
using Microsoft.AspNetCore.Http;

namespace Persistence.Multitenancy
{
    public class TenantProvider : ITenantProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Tenant? CurrentTenant =>
            _httpContextAccessor.HttpContext?.Items["Tenant"] as Tenant;
    }
}
