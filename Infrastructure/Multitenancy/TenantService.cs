using Application.Common.Exceptions;
using Application.Common.Persistence;
using Application.Multitenancy;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Initialization;
using Mapster;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Domain.MasterTenant;

namespace Infrastructure.Multitenancy;

internal class TenantService : ITenantService
{
    private readonly TenantDbContext _tenantDbContext;
    private readonly IConnectionStringSecurer _csSecurer;
    private readonly IDatabaseInitializer _dbInitializer;
    private readonly IStringLocalizer _t;
    private readonly DatabaseSettings _dbSettings;

    public TenantService(
        TenantDbContext tenantDbContext,
        IConnectionStringSecurer csSecurer,
        IDatabaseInitializer dbInitializer,
        IStringLocalizer<TenantService> localizer,
        IOptions<DatabaseSettings> dbSettings)
    {
        _tenantDbContext = tenantDbContext;
        _csSecurer = csSecurer;
        _dbInitializer = dbInitializer;
        _t = localizer;
        _dbSettings = dbSettings.Value;
    }

    public async Task<List<TenantDto>> GetAllAsync()
    {
        var tenants = await _tenantDbContext.Tenants.AsNoTracking().ToListAsync();
        var dtos = tenants.Adapt<List<TenantDto>>();
        dtos.ForEach(t => t.ConnectionString = _csSecurer.MakeSecure(t.ConnectionString));
        return dtos;
    }

    public async Task<bool> ExistsWithIdAsync(string id) =>
        await _tenantDbContext.Tenants.AnyAsync(t => t.Id == id);

    public async Task<bool> ExistsWithNameAsync(string name) =>
        await _tenantDbContext.Tenants.AnyAsync(t => t.Name == name);

    public async Task<TenantDto> GetByIdAsync(string id)
    {
        var tenant = await GetTenantInfoAsync(id);
        var dto = tenant.Adapt<TenantDto>();
        dto.ConnectionString = _csSecurer.MakeSecure(dto.ConnectionString);
        return dto;
    }

    public async Task<TenantSiteUrlDto> GetBySiteUrlAsync(string siteUrl)
    {
        var tenant = await _tenantDbContext.Tenants
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.SiteUrl.Contains(siteUrl));

        return tenant?.Adapt<TenantSiteUrlDto>()
               ?? throw new NotFoundException(_t["{0} {1} Not Found.", nameof(Tenant), siteUrl]);
    }

    public async Task<string> CreateAsync(CreateTenantRequest request, CancellationToken cancellationToken)
    {
        if (request.ConnectionString?.Trim() == _dbSettings.ConnectionString.Trim()) request.ConnectionString = string.Empty;
        if (string.IsNullOrWhiteSpace(request.ConnectionString))
        {
            SqlConnectionStringBuilder builder = new(_dbSettings.ConnectionString.Trim());
            string mainDatabaseName = builder.InitialCatalog; // retrieve the database name
            string tenantDbName = mainDatabaseName + "-" + request.Id;
            builder.InitialCatalog = tenantDbName; // set new database name
            string modifiedConnectionString = builder.ConnectionString; // create new connection string
            request.ConnectionString = modifiedConnectionString;
        }

        var tenant = new TenantInfo(request.Id, request.Name, request.ConnectionString, request.AdminEmail, request.SiteName, request.SiteUrl, request.Issuer);
        _tenantDbContext.Tenants.Add(tenant);
        await _tenantDbContext.SaveChangesAsync(cancellationToken);

        try
        {
            await _dbInitializer.InitializeApplicationDbForTenantAsync(tenant, cancellationToken);
        }
        catch
        {
            _tenantDbContext.Tenants.Remove(tenant);
            await _tenantDbContext.SaveChangesAsync(cancellationToken);
            throw;
        }

        return tenant.Id;
    }

    public async Task<string> ActivateAsync(string id)
    {
        var tenant = await GetTenantInfoAsync(id);

        if (tenant.IsActive)
        {
            throw new ConflictException(_t["Tenant is already Activated."]);
        }

        tenant.IsActive = true;
        await _tenantDbContext.SaveChangesAsync();

        return _t["Tenant {0} is now Activated.", id];
    }

    public async Task<string> DeactivateAsync(string id)
    {
        var tenant = await GetTenantInfoAsync(id);

        if (!tenant.IsActive)
        {
            throw new ConflictException(_t["Tenant is already Deactivated."]);
        }

        tenant.IsActive = false;
        await _tenantDbContext.SaveChangesAsync();

        return _t[$"Tenant {0} is now Deactivated.", id];
    }

    public async Task<string> UpdateSubscription(string id, DateTime extendedExpiryDate)
    {
        var tenant = await GetTenantInfoAsync(id);
        _ = tenant.ValidUpto < extendedExpiryDate
            ? extendedExpiryDate
            : throw new Exception("Subscription cannot be backdated.");
        tenant.ValidUpto=extendedExpiryDate;
        await _tenantDbContext.SaveChangesAsync();
        return _t[$"Tenant {0}'s Subscription Upgraded. Now Valid till {1}.", id, tenant.ValidUpto];
    }
    //private async Task<Tenant> GetTenantInfoAsync(string id) =>
    //    await _tenantDbContext.Tenants
    //        .FirstOrDefaultAsync(t => t.Id == id)
    //    ?? throw new NotFoundException(_t["{0} {1} Not Found.", nameof(Tenant), id]);
    private async Task<Tenant> GetTenantInfoAsync(string id)
    {
        var tenant = await _tenantDbContext.Tenants.FirstOrDefaultAsync(t => t.Id == id);
        if (tenant is null)
        {
            var message = _t[$"{nameof(Tenant)} {id} Not Found."];
            throw new NotFoundException(message);
        }

        return tenant;
    }
}
