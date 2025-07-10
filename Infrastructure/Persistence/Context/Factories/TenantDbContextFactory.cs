using Infrastructure.Multitenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence.Context.Factories
{
    public class TenantDbContextFactory : IDesignTimeDbContextFactory<TenantDbContext>
    {
        public TenantDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TenantDbContext>();

            // Use a placeholder or valid connection string for design-time
            var connectionString = "Data Source=WCL-INDIA-WIN11\\SQLEXPRESS;Initial Catalog=RavTest;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseSqlServer(connectionString, b =>
            //{
            //    b.MigrationsAssembly("Migrators.MSSQL");
            //});

            return new TenantDbContext(optionsBuilder.Options);
        }
    }
}
