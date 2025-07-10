using Domain.RoleMenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RoleMenuMaster;
public class CreateRoleMenuMasterRequest : IRequest<RoleMenuMasterModel>
{
    public int Id { get; set; }
    public string RoleName { get;  set; }
    public int MenuId { get;  set; }



}
public class CreateTblRoleMenuMasterRequestValidator : CustomValidator<CreateRoleMenuMasterRequest>
{
    public CreateTblRoleMenuMasterRequestValidator(IReadRepository<RoleMenuMasterModel> repository, IStringLocalizer<CreateTblRoleMenuMasterRequestValidator> localizer) { }
}
public class CreateRoleMenuMasterRequestHandler : IRequestHandler<CreateRoleMenuMasterRequest, RoleMenuMasterModel>
{
    private readonly IRepositoryWithEvents<RoleMenuMasterModel> _repository;

    public CreateRoleMenuMasterRequestHandler(IRepositoryWithEvents<RoleMenuMasterModel> repository) => _repository = repository;
    public async Task<RoleMenuMasterModel> Handle(CreateRoleMenuMasterRequest request, CancellationToken cancellationToken)
    {
        var RoleMenuMaster = new RoleMenuMasterModel(
        request.Id,
        request.RoleName,
        request.MenuId
        );
        var ouptput = await _repository.AddAsync(RoleMenuMaster, cancellationToken);
        return ouptput;

    }

}
