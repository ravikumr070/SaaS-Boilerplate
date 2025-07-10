using Application.Common.Persistence;
using Domain.MasterTenant;
using Microsoft.AspNetCore.Http;


namespace Infrastructure.Multitenancy
{
    public class TenantProvider : ITenantProvider
    {
        private static readonly AsyncLocal<Tenant?> _currentTenant = new();
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Tenant? GetTenant()
        {
            // Priority: AsyncLocal (manual set) > HttpContext.Items (from middleware)
            return _currentTenant.Value ??
                   (_httpContextAccessor.HttpContext?.Items.TryGetValue("Tenant", out var tenantObj) == true
                       ? tenantObj as Tenant
                       : null);
        }

        public void SetTenant(Tenant tenant)
        {
            _currentTenant.Value = tenant;
        }
    }
}
