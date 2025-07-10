using Domain.RoleMenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RoleMenuMaster;
public class UpdateRoleMenuMasterRequest : IRequest<RoleMenuMasterModel>
{
    public int Id { get; set; }
    public UpdateRoleMenuMasterRequest(int id) => Id = id;
    public string RoleName { get; set; }
    public int MenuId { get; set; }





}
public class UpdateRoleMenuMasterRequestValidator : CustomValidator<UpdateRoleMenuMasterRequest>
{
    public UpdateRoleMenuMasterRequestValidator(IRepository<RoleMenuMasterModel> repository, IStringLocalizer<UpdateRoleMenuMasterRequestValidator> localizer) { }

}
public class UpdateRoleMenuMasterRequestHandler : IRequestHandler<UpdateRoleMenuMasterRequest, RoleMenuMasterModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<RoleMenuMasterModel> _repository;
    private readonly IStringLocalizer<UpdateRoleMenuMasterRequestHandler> _localizer;


    public UpdateRoleMenuMasterRequestHandler(IRepositoryWithEvents<RoleMenuMasterModel> repository, IStringLocalizer<UpdateRoleMenuMasterRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);
    public async Task<RoleMenuMasterModel> Handle(UpdateRoleMenuMasterRequest request, CancellationToken cancellationToken)
    {
        var RoleMenuMaster = await _repository.GetByIdAsync(request.Id, cancellationToken);
        _ = RoleMenuMaster ?? throw new NotFoundException(string.Format(_localizer["RoleMenuMaster notfound"], request.Id));
        RoleMenuMaster.Update(
             request.RoleName,
        request.MenuId
            );
        await _repository.UpdateAsync(RoleMenuMaster, cancellationToken);
        return RoleMenuMaster;
    }
}
