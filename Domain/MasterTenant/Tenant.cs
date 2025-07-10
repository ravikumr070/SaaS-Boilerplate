

namespace Domain.MasterTenant
{
    public class Tenant
    {
        public string Id { get; set; } = default!;
        public string Identifier { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string ConnectionString { get; set; } = default!;
        public string AdminEmail { get;  set; } = default!;
        public bool IsActive { get; set; }
        public DateTime ValidFromDate { get; set; }
        public DateTime ValidUpto { get; set; }
        public string? Issuer { get; set; }
        public string? SiteName { get; set; }
        public string? SiteUrl { get; set; }
       
    }
}
