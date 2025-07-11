using Application.Common.Events;
using Application.Common.Interfaces;
using Application.Common.Persistence;
using Domain.MasterTenant;
using Infrastructure.Common;
using Infrastructure.Multitenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Infrastructure.Persistence.Context.Factories
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Configurations/database.json", optional: false, reloadOnChange: true)
                .Build();
            var dbSettings = new DatabaseSettings();
            configuration.GetSection("DatabaseSettings").Bind(dbSettings);
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(dbSettings.ConnectionString);

            return new ApplicationDbContext(
                new DesignTimeTenantProvider(dbSettings.ConnectionString),
                optionsBuilder.Options,
                new DesignTimeCurrentUser(),
                new DesignTimeSerializerService(),
                Options.Create(new DatabaseSettings { DBProvider = DbProviderKeys.SqlServer }),
                new DesignTimeEventPublisher(),
                Options.Create(new AzureDatabaseSettings())
            );
        }

        private class DesignTimeTenantProvider : ITenantProvider
        {
            private readonly string _connectionString;

            public DesignTimeTenantProvider(string connectionString)
            {
                _connectionString = connectionString;
            }

            public string GetTenantId() => "design-tenant";

            public string GetConnectionString() => _connectionString;

            public Tenant? GetTenant() => new()
            {
                Id = "design-tenant",
                Name = "Design Tenant",
                ConnectionString = _connectionString,
                IsActive = true
            };

            public void SetTenant(Tenant tenant) { /* No-op */ }
        }

        private class DesignTimeCurrentUser : ICurrentUser
        {
            public string? Name => "Design User";

            public string? GetUserId() => Guid.Empty.ToString();

            Guid ICurrentUser.GetUserId() => Guid.Empty;

            public string? GetTenant() => "design-tenant";

            public string? GetUserEmail() => "design@example.com";

            public bool IsAuthenticated() => true;

            public bool IsInRole(string role) => true;

            public IEnumerable<Claim>? GetUserClaims() => new List<Claim>
        {
            new Claim(ClaimTypes.Name, "Design User")
        };
        }

        private class DesignTimeSerializerService : ISerializerService
        {
            public string Serialize<T>(T obj) => "{}";

            public T Deserialize<T>(string text) => JsonConvert.DeserializeObject<T>(text);

            public string Serialize<T>(T obj, Type type) => "{}";
        }

        private class DesignTimeEventPublisher : IEventPublisher
        {
            public Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : IEvent
                => Task.CompletedTask;

            public Task PublishAsync(IEvent @event)
                => Task.CompletedTask;
        }
    }
}
