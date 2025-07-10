using Domain.MasterTenant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Multitenancy;

namespace Persistence.Multitenancy
{
    public class TenantDbContextFactory : ITenantDbContextFactory
    {
        private readonly ITenantProvider _tenantProvider;

        public TenantDbContextFactory(ITenantProvider tenantProvider)
        {
            _tenantProvider = tenantProvider;
        }

        public AppDbContext Create()
        {
            var tenant = _tenantProvider.CurrentTenant
                         ?? throw new InvalidOperationException("Tenant not resolved.");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(tenant.ConnectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
