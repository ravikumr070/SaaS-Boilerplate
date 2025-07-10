using Domain.RoleMenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RoleMenuMaster;
public class SearchRoleMenuMasterRequest : PaginationFilter, IRequest<PaginationResponse<RoleMenuMasterDto>>
{
}
public class RoleMenuMasterBySearchRequestSpec : EntitiesByPaginationFilterSpec<RoleMenuMasterModel, RoleMenuMasterDto>
{
    public RoleMenuMasterBySearchRequestSpec(SearchRoleMenuMasterRequest request)
      : base(request) =>
      Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}

public class SearchRoleMenuMasterRequestHandler : IRequestHandler<SearchRoleMenuMasterRequest, PaginationResponse<RoleMenuMasterDto>>
{
    private readonly IReadRepository<RoleMenuMasterModel> _repository;

    public SearchRoleMenuMasterRequestHandler(IReadRepository<RoleMenuMasterModel> repository) => _repository = repository;

    public async Task<PaginationResponse<RoleMenuMasterDto>> Handle(SearchRoleMenuMasterRequest request, CancellationToken cancellationToken)
    {
        var spec = new RoleMenuMasterBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}

