using Domain.RoleMenuMaster;

namespace Domain.MenuMaster;
public class MenuMasterModel : AuditableEntity, IAggregateRoot
{
    public int Id { get; private set; }
    public int? ParentId { get; private set; }
    public int Sequence { get; private set; }
    public string MenuText { get; private set; }
    public string IconClass { get; private set; }
    public string PageUrl { get; private set; }
    public bool IsActive { get; private set; }
    public bool IsDeleted { get; private set; }
    public string PageType { get; private set; }
    public virtual MenuMasterModel Parent { get; private set; }
    public virtual List<MenuMasterModel> Children { get; private set; }
    public virtual List<RoleMenuMasterModel> RoleMenuMaster { get; private set; }

    public MenuMasterModel(
     int Id,
     int? ParentId,
     int Sequence,
     string MenuText,
     string IconClass,
     string PageUrl,
     bool IsActive,
     bool IsDeleted,
     string PageType
        )
    {
        this.Id = Id;
        this.ParentId = ParentId;
        this.Sequence = Sequence;
        this.MenuText = MenuText;
        this.IconClass = IconClass;
        this.PageUrl = PageUrl;
        this.IsActive = IsActive;
        this.IsDeleted = IsDeleted;
        this.PageType = PageType;
    }
    public MenuMasterModel Update(
    int? ParentId,
    int Sequence,
    string MenuText,
    string IconClass,
    string PageUrl,
    bool IsActive,
    bool IsDeleted,
    string PageType
    )
    {
        this.ParentId = ParentId;
        this.Sequence = Sequence;
        this.MenuText = MenuText;
        this.IconClass = IconClass;
        this.PageUrl = PageUrl;
        this.IsActive = IsActive;
        this.IsDeleted = IsDeleted;
        this.PageType = PageType;
        return this;
    }
}
