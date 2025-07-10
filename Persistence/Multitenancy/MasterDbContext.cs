using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MasterTenant;

namespace Persistence.Multitenancy
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext(DbContextOptions<MasterDbContext> options) : base(options) { }

        public DbSet<Tenant> Tenants => Set<Tenant>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Tenant>().HasIndex(t => t.Domain).IsUnique();
        }
    }
}
