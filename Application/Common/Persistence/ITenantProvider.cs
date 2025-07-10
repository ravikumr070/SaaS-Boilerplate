using Domain.MasterTenant;


namespace Application.Common.Persistence
{
    public interface ITenantProvider
    {
        Tenant? GetTenant();
        void SetTenant(Tenant tenant);
    }
}
