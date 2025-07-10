using Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RoleMenuMaster;
public class RoleMenuMasterModel : AuditableEntity, IAggregateRoot
{
    public int Id { get; set; }
    public string RoleName { get; set; }
    public int MenuId { get; set; }

    public virtual MenuMasterModel Menu { get; private set; }
    public RoleMenuMasterModel(int Id, string RoleName, int MenuId)
    {
        this.Id = Id;
        this.RoleName = RoleName;
        this.MenuId = MenuId;
    }
    public RoleMenuMasterModel Update(string RoleName, int MenuId)
    {
        this.RoleName = RoleName;
        this.MenuId = MenuId;
        return this;
    }
}