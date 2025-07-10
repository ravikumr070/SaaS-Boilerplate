using Domain.RoleMenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RoleMenuMaster;
public class GetRoleMenuMasterRequest : IRequest<RoleMenuMasterDto>
{
    public int Id { get; set; }
    public GetRoleMenuMasterRequest(int id) => Id = id;
}
public class RoleMenuMasterByIdSpec : Specification<RoleMenuMasterModel, RoleMenuMasterDto>, ISingleResultSpecification
{
    public RoleMenuMasterByIdSpec(int id) =>
        Query.Where(p => p.Id == id);
}

public class GetRoleMenuMasterRequestHandler : IRequestHandler<GetRoleMenuMasterRequest, RoleMenuMasterDto>
{
    private readonly IRepository<RoleMenuMasterModel> _repository;
    private readonly IStringLocalizer<GetRoleMenuMasterRequestHandler> _localizer;

    public GetRoleMenuMasterRequestHandler(IRepository<RoleMenuMasterModel> repository, IStringLocalizer<GetRoleMenuMasterRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<RoleMenuMasterDto> Handle(GetRoleMenuMasterRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<RoleMenuMasterModel, RoleMenuMasterDto>)new RoleMenuMasterByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["RoleMenuMaster notfound"], request.Id));
}
