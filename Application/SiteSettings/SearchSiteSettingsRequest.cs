using Domain.SiteSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SiteSettings;
public class SearchSiteSettingsRequest : PaginationFilter, IRequest<PaginationResponse<SiteSettingsDto>>
{
}
public class SiteSettingsBySearchRequestSpec : EntitiesByPaginationFilterSpec<SiteSettingsModel, SiteSettingsDto>
{
    public SiteSettingsBySearchRequestSpec(SearchSiteSettingsRequest request)
      : base(request) =>
      Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}

public class SearchSiteSettingsRequestHandler : IRequestHandler<SearchSiteSettingsRequest, PaginationResponse<SiteSettingsDto>>
{
    private readonly IReadRepository<SiteSettingsModel> _repository;

    public SearchSiteSettingsRequestHandler(IReadRepository<SiteSettingsModel> repository) => _repository = repository;

    public async Task<PaginationResponse<SiteSettingsDto>> Handle(SearchSiteSettingsRequest request, CancellationToken cancellationToken)
    {
        var spec = new SiteSettingsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}



