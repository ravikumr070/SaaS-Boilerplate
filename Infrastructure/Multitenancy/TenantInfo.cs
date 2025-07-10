using Domain.MasterTenant;
using Shared.Multitenancy;

namespace Infrastructure.Multitenancy;

public class TenantInfo:Tenant
{
    public TenantInfo(string id, string name, string? connectionString, string adminEmail, string siteName, string siteUrl, string? issuer = null)
    {
        Id = id;
        Identifier = id;
        Name = name;
        ConnectionString = connectionString ?? string.Empty;
        AdminEmail = adminEmail;
        IsActive = true;
        Issuer = issuer;
        ValidFromDate = DateTime.UtcNow;
        ValidUpto = DateTime.UtcNow.AddMonths(6);
        SiteName = siteName ?? id;
        SiteUrl = siteUrl ?? "http://localhost:4200";
    }

    
   

    public void AddValidity(int months) =>
        ValidUpto = ValidUpto.AddMonths(months);

    public void SetValidity(in DateTime validTill) =>
        ValidUpto = ValidUpto < validTill
            ? validTill
            : throw new Exception("Subscription cannot be backdated.");

    public void Activate()
    {
        if (Id == MultitenancyConstants.Root.Id)
        {
            throw new InvalidOperationException("Invalid Tenant");
        }

        IsActive = true;
    }

    public void Deactivate()
    {
        if (Id == MultitenancyConstants.Root.Id)
        {
            throw new InvalidOperationException("Invalid Tenant");
        }

        IsActive = false;
    }

}