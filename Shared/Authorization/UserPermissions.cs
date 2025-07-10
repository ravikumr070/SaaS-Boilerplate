using System.Collections.ObjectModel;

namespace Shared.Authorization;

public static class UserAction
{
    public const string View = nameof(View);
    public const string Search = nameof(Search);
    public const string Create = nameof(Create);
    public const string Update = nameof(Update);
    public const string Delete = nameof(Delete);
    public const string Export = nameof(Export);
    public const string Generate = nameof(Generate);
    public const string Clean = nameof(Clean);
    public const string UpgradeSubscription = nameof(UpgradeSubscription);
}

public static class UserResource
{
    public const string Tenants = nameof(Tenants);
    public const string Dashboard = nameof(Dashboard);
    public const string Hangfire = nameof(Hangfire);
    public const string Users = nameof(Users);
    public const string UserRoles = nameof(UserRoles);
    public const string Roles = nameof(Roles);
    public const string RoleClaims = nameof(RoleClaims);
    public const string EmailSend = nameof(EmailSend);
    public const string EmailLog = nameof(EmailLog);
    public const string MenuMaster = nameof(MenuMaster);
    public const string RoleMenuMaster = nameof(RoleMenuMaster);
    public const string LogException = nameof(LogException);
    public const string SiteSettings = nameof(SiteSettings);
}

public static class UserPermissions
{
    private static readonly UserPermission[] _all = new UserPermission[]
    {
        new("View Dashboard", UserAction.View, UserResource.Dashboard),
        new("View Hangfire", UserAction.View, UserResource.Hangfire),
        new("View Users", UserAction.View, UserResource.Users),
        new("Search Users", UserAction.Search, UserResource.Users),
        new("Create Users", UserAction.Create, UserResource.Users),
        new("Update Users", UserAction.Update, UserResource.Users),
        new("Delete Users", UserAction.Delete, UserResource.Users),
        new("Export Users", UserAction.Export, UserResource.Users),
        new("View UserRoles", UserAction.View, UserResource.UserRoles),
        new("Update UserRoles", UserAction.Update, UserResource.UserRoles),
        new("View Roles", UserAction.View, UserResource.Roles),
        new("Create Roles", UserAction.Create, UserResource.Roles),
        new("Update Roles", UserAction.Update, UserResource.Roles),
        new("Delete Roles", UserAction.Delete, UserResource.Roles),
        new("View RoleClaims", UserAction.View, UserResource.RoleClaims),
        new("Update RoleClaims", UserAction.Update, UserResource.RoleClaims),
        new("View Tenants", UserAction.View, UserResource.Tenants, IsRoot: true),
        new("Create Tenants", UserAction.Create, UserResource.Tenants, IsRoot: true),
        new("Update Tenants", UserAction.Update, UserResource.Tenants, IsRoot: true),
        new("Upgrade Tenant Subscription", UserAction.UpgradeSubscription, UserResource.Tenants, IsRoot: true),
        new("View MenuMaster ", UserAction.View, UserResource.MenuMaster, IsBasic: true),
        new("Search MenuMaster", UserAction.Search, UserResource.MenuMaster, IsBasic: true),
        new("Create MenuMaster", UserAction.Create, UserResource.MenuMaster),
        new("Update MenuMaster", UserAction.Update, UserResource.MenuMaster),
        new("Delete MenuMaster", UserAction.Delete, UserResource.MenuMaster),
        new("Generate MenuMaster", UserAction.Generate, UserResource.MenuMaster),
        new("Clean MenuMaster", UserAction.Clean, UserResource.MenuMaster),
        new("View RoleMenuMaster ", UserAction.View, UserResource.RoleMenuMaster, IsBasic: true),
        new("Search RoleMenuMaster", UserAction.Search, UserResource.RoleMenuMaster, IsBasic: true),
        new("Create RoleMenuMaster", UserAction.Create, UserResource.RoleMenuMaster),
        new("Update RoleMenuMaster", UserAction.Update, UserResource.RoleMenuMaster),
        new("Delete RoleMenuMaster", UserAction.Delete, UserResource.RoleMenuMaster),
        new("Generate RoleMenuMaster", UserAction.Generate, UserResource.RoleMenuMaster),
        new("Clean RoleMenuMaster", UserAction.Clean, UserResource.RoleMenuMaster),
        new("View LogException ", UserAction.View, UserResource.LogException, IsBasic: true),
        new("Search LogException", UserAction.Search, UserResource.LogException, IsBasic: true),
        new("Create LogException", UserAction.Create, UserResource.LogException),
        new("Update LogException", UserAction.Update, UserResource.LogException),
        new("Delete LogException", UserAction.Delete, UserResource.LogException),
        new("Generate LogException", UserAction.Generate, UserResource.LogException),
        new("Clean LogException", UserAction.Clean, UserResource.LogException),
        new("View SiteSettings ", UserAction.View, UserResource.SiteSettings, IsBasic: true),
        new("Search SiteSettings", UserAction.Search, UserResource.SiteSettings, IsBasic: true),
        new("Create SiteSettings", UserAction.Create, UserResource.SiteSettings),
        new("Update SiteSettings", UserAction.Update, UserResource.SiteSettings),
        new("Delete SiteSettings", UserAction.Delete, UserResource.SiteSettings),
        new("Generate SiteSettings", UserAction.Generate, UserResource.SiteSettings),
        new("Clean SiteSettings", UserAction.Clean, UserResource.SiteSettings),

    };

    public static IReadOnlyList<UserPermission> All { get; } = new ReadOnlyCollection<UserPermission>(_all);
    public static IReadOnlyList<UserPermission> Root { get; } = new ReadOnlyCollection<UserPermission>(_all.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<UserPermission> Admin { get; } = new ReadOnlyCollection<UserPermission>(_all.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<UserPermission> Basic { get; } = new ReadOnlyCollection<UserPermission>(_all.Where(p => p.IsBasic).ToArray());
}

public record UserPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
}