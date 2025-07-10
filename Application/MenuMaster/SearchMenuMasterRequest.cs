using Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class SearchMenuMasterRequest : PaginationFilter, IRequest<PaginationResponse<MenuMasterDto>>
{
}
public class MenuMasterBySearchRequestSpec : EntitiesByPaginationFilterSpec<MenuMasterModel, MenuMasterDto>
{
    public MenuMasterBySearchRequestSpec(SearchMenuMasterRequest request)
      : base(request) =>
      Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}

public class SearchMenuMasterRequestHandler : IRequestHandler<SearchMenuMasterRequest, PaginationResponse<MenuMasterDto>>
{
    private readonly IReadRepository<MenuMasterModel> _repository;

    public SearchMenuMasterRequestHandler(IReadRepository<MenuMasterModel> repository) => _repository = repository;

    public async Task<PaginationResponse<MenuMasterDto>> Handle(SearchMenuMasterRequest request, CancellationToken cancellationToken)
    {
        var spec = new MenuMasterBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}

