using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class MenuMasterDto : IDto
{
    public int? Id { get; set; }
    public int? ParentId { get; set; }
    public int Sequence { get; set; }
    public string MenuText { get; set; }
    public string IconClass { get; set; }
    public string PageUrl { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public string? PageType { get; set; }
}
public class AllMenuMasterDto :IDto
{
    public int? Id { get; set; }
    public int? ParentId { get; set; }
    public int Sequence { get; set; }
    public string? MenuText { get; set; }
    public string? IconClass { get; set; }
    public string? PageUrl { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public string? PageType { get; set; }
    public virtual MenuMasterDto? Parent { get; set; }
    public virtual List<AllMenuMasterDto>? Children { get; set; }
}
public class RoleByMenuMasterDto 
{
    public int? Id { get; set; }
    public int? ParentId { get; set; }
    public int Sequence { get; set; }
    public string? MenuText { get; set; }
    public string? IconClass { get; set; }
    public string? PageUrl { get; set; }
    public string? RoleName { get; set; }
    public string? PageType { get; set; }
    public List<RoleByMenuMasterDto> Children { get; set; }
}
public class RoleByMenuList
{
    public int? Id { get; set; }
    public string? RoleName { get; set; }
}