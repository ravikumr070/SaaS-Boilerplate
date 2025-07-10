using Application.Common.Caching;
using Application.Common.Exceptions;
using Application.MenuMaster;
using Domain.MenuMaster;
using Shared.Authorization;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity;

internal partial class UserService
{
    public async Task<List<string>> GetPermissionsAsync(string userId, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(userId);

        _ = user ?? throw new UnauthorizedException("Authentication Failed.");

        var userRoles = await _userManager.GetRolesAsync(user);
        var permissions = new List<string>();
        foreach (var role in await _roleManager.Roles
            .Where(r => userRoles.Contains(r.Name))
            .ToListAsync(cancellationToken))
        {
            permissions.AddRange(await _db.RoleClaims
                .Where(rc => rc.RoleId == role.Id && rc.ClaimType == UserClaims.Permission)
                .Select(rc => rc.ClaimValue)
                .ToListAsync(cancellationToken));
        }

        return permissions.Distinct().ToList();
    }
    public async Task<List<RoleByMenuMasterDto>> GetRoleByMenuMastersAsync(string userId, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(userId);

        _ = user ?? throw new NotFoundException(_t["User Not Found."]);

        var userRoles = await _userManager.GetRolesAsync(user);
        var RolesMenus = new List<MenuMasterModel>();
        var MenuIds = new List<RoleByMenuMasterDto>();
        foreach (var role in await _roleManager.Roles
            .Where(r => userRoles.Contains(r.Name))
            .ToListAsync(cancellationToken))
        {
            RolesMenus= await _db.MenuMaster.Include(ch => ch.Children).ThenInclude(ch => ch.Children).ThenInclude(ch => ch.Children)
                 .Where(x =>
                    x.IsActive &&
                    !x.IsDeleted &&
                    x.ParentId == null &&
                    x.RoleMenuMaster.Any(rm => rm.RoleName.Contains(role.Name)))
                .OrderBy(c => c.Sequence)
                .ToListAsync();

            MenuIds.AddRange( RolesMenus.Adapt<List<RoleByMenuMasterDto>>());
        }

        // RolesMenus = RolesMenus.Where(allAssignedMenu => MenuIds.All(m => m.Id == allAssignedMenu.Id)).ToList();
        return MenuIds.Distinct().ToList();
    }
    public async Task<bool> HasPermissionAsync(string userId, string permission, CancellationToken cancellationToken)
    {
        var permissions = await _cache.GetOrSetAsync(
            _cacheKeys.GetCacheKey(UserClaims.Permission, userId),
            () => GetPermissionsAsync(userId, cancellationToken),
            cancellationToken: cancellationToken);

        return permissions?.Contains(permission) ?? false;
    }
    public List<RoleByMenuMasterDto> GetChildren(int parentId)
    {
        return _db.MenuMaster
                .Where(c => c.ParentId == parentId && c.IsActive &&
                    !c.IsDeleted)
                .Select(c => new RoleByMenuMasterDto
                {
                    Id = c.Id,
                    ParentId = c.ParentId,
                    Sequence = c.Sequence,
                    MenuText = c.MenuText,
                    IconClass = c.IconClass,
                    PageUrl = c.PageUrl,
                   // Children = GetChildren(menus, c.Id),
                })
                .ToList();
    }
    public List<RoleByMenuMasterDto> GetChildrenVM(List<RoleByMenuMasterDto>menus,int parentId)
    {
        return (from ch in menus
                where ch.ParentId == parentId
                select ch).ToList();
    }
    public Task InvalidatePermissionCacheAsync(string userId, CancellationToken cancellationToken) =>
            _cache.RemoveAsync(_cacheKeys.GetCacheKey(UserClaims.Permission, userId), cancellationToken);
}