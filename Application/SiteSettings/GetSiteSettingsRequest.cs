using Domain.SiteSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SiteSettings;
public class GetSiteSettingsRequest : IRequest<SiteSettingsDto>
{
    public long Id { get; set; }
    public GetSiteSettingsRequest(long id) => Id = id;
}
public class SiteSettingsByIdSpec : Specification<SiteSettingsModel, SiteSettingsDto>, ISingleResultSpecification
{
    public SiteSettingsByIdSpec(long id) =>
        Query.Where(p => p.Id == id);
}

public class GetSiteSettingsRequestHandler : IRequestHandler<GetSiteSettingsRequest, SiteSettingsDto>
{
    private readonly IRepository<SiteSettingsModel> _repository;
    private readonly IStringLocalizer<GetSiteSettingsRequestHandler> _localizer;

    public GetSiteSettingsRequestHandler(IRepository<SiteSettingsModel> repository, IStringLocalizer<GetSiteSettingsRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<SiteSettingsDto> Handle(GetSiteSettingsRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<SiteSettingsModel, SiteSettingsDto>)new SiteSettingsByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["SiteSettings notfound"], request.Id));
}
