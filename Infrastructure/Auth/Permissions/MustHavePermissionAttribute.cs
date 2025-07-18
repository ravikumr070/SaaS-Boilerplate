using Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Auth.Permissions;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = UserPermission.NameFor(action, resource);
}