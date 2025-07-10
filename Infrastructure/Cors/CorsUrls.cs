using Application.Multitenancy;

namespace Infrastructure.Cors;

public class CorsUrls : ICorsUrls
{
    private readonly ITenantService _tenant;
    public CorsUrls(ITenantService tenant) => _tenant = tenant;
    public Task<List<TenantDto>> GetCorsURL()
    {
        return _tenant.GetAllAsync();
    }
}
public interface ICorsUrls
{
    Task<List<TenantDto>> GetCorsURL();
}