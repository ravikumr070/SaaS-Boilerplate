using Domain.RoleMenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RoleMenuMaster;
public class DeleteRoleMenuMasterRequest : IRequest<RoleMenuMasterModel>
{
    public int Id { get; set; }

    public DeleteRoleMenuMasterRequest(int id) => Id = id;
}
public class DeleteRoleMenuMasterRequestHandler : IRequestHandler<DeleteRoleMenuMasterRequest, RoleMenuMasterModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<RoleMenuMasterModel> _RoleMenuMasterRepo;

    private readonly IStringLocalizer<DeleteRoleMenuMasterRequestHandler> _localizer;

    public DeleteRoleMenuMasterRequestHandler(IRepositoryWithEvents<RoleMenuMasterModel> RoleMenuMasterRepo, IStringLocalizer<DeleteRoleMenuMasterRequestHandler> localizer) =>
        (_RoleMenuMasterRepo, _localizer) = (RoleMenuMasterRepo, localizer);

    public async Task<RoleMenuMasterModel> Handle(DeleteRoleMenuMasterRequest request, CancellationToken cancellationToken)
    {

        var RoleMenuMaster = await _RoleMenuMasterRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = RoleMenuMaster ?? throw new NotFoundException(_localizer["RoleMenuMaster notfound"]);

        await _RoleMenuMasterRepo.DeleteAsync(RoleMenuMaster, cancellationToken);

        return RoleMenuMaster;
    }
}
