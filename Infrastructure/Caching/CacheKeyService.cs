
using Application.Common.Caching;
using Application.Common.Persistence;

namespace Infrastructure.Caching;

public class CacheKeyService : ICacheKeyService
{
    private readonly ITenantProvider? _tenantProvider;

    public CacheKeyService(ITenantProvider tenantProvider) => _tenantProvider = tenantProvider;

    public string GetCacheKey(string name, object id, bool includeTenantId = true)
    {
        string tenantId = includeTenantId
            ? _tenantProvider?.GetTenant().Id ?? throw new InvalidOperationException("GetCacheKey: includeTenantId set to true and no ITenantInfo available.")
            : "GLOBAL";
        return $"{tenantId}-{name}-{id}";
    }
}