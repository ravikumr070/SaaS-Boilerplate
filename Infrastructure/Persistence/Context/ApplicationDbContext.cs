
using Application.Common.Events;
using Application.Common.Interfaces;
using Application.Common.Persistence;
using Domain.EmailLog;
using Domain.EmailSend;
using Domain.LogException;
using Domain.MenuMaster;
using Domain.RoleMenuMaster;
using Domain.SiteSettings;
using Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantProvider tenantProvider, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events, IOptions<AzureDatabaseSettings> azuredbSettings)
        : base(tenantProvider, options, currentUser, serializer, dbSettings, events, azuredbSettings)
    {
    }
    public DbSet<SiteSettingsModel> SiteSettings => Set<SiteSettingsModel>();
    public DbSet<LogExceptionModel> LogException => Set<LogExceptionModel>();
    public DbSet<EmailSendModel> EmailSend => Set<EmailSendModel>();
    public DbSet<EmailLogModel> Emaillog => Set<EmailLogModel>();
    public DbSet<MenuMasterModel> MenuMaster => Set<MenuMasterModel>();
    public DbSet<RoleMenuMasterModel> RoleMenuMaster => Set<RoleMenuMasterModel>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       // modelBuilder.HasDefaultSchema(SchemaNames.Catalog);
    }
}