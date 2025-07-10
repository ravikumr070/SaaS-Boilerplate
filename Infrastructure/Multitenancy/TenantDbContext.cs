using Domain.MasterTenant;
using Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Multitenancy;

public class TenantDbContext : DbContext
{
    public TenantDbContext(DbContextOptions<TenantDbContext> options)
        : base(options)
    {
    }
    public DbSet<Tenant> Tenants => Set<Tenant>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TenantInfo>().ToTable("Tenant", SchemaNames.MultiTenancy);
    }
}