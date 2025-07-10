using Domain.MasterTenant;
using Infrastructure.Multitenancy;

namespace Infrastructure.Persistence.Initialization;

internal interface IDatabaseInitializer
{
    Task InitializeDatabasesAsync(CancellationToken cancellationToken);
    Task InitializeApplicationDbForTenantAsync(Tenant tenant, CancellationToken cancellationToken);
    Task UpdateCorsAsync(CancellationToken cancellationToken);
}