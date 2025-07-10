using Domain.SiteSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SiteSettings;
public class DeleteSiteSettingsRequest : IRequest<SiteSettingsModel>
{
    public long Id { get; set; }

    public DeleteSiteSettingsRequest(long id) => Id = id;
}
public class DeleteSiteSettingsRequestHandler : IRequestHandler<DeleteSiteSettingsRequest, SiteSettingsModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<SiteSettingsModel> _SiteSettingsRepo;

    private readonly IStringLocalizer<DeleteSiteSettingsRequestHandler> _localizer;

    public DeleteSiteSettingsRequestHandler(IRepositoryWithEvents<SiteSettingsModel> SiteSettingsRepo, IStringLocalizer<DeleteSiteSettingsRequestHandler> localizer) =>
        (_SiteSettingsRepo, _localizer) = (SiteSettingsRepo, localizer);

    public async Task<SiteSettingsModel> Handle(DeleteSiteSettingsRequest request, CancellationToken cancellationToken)
    {

        var SiteSettings = await _SiteSettingsRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = SiteSettings ?? throw new NotFoundException(_localizer["SiteSettings notfound"]);

        await _SiteSettingsRepo.DeleteAsync(SiteSettings, cancellationToken);

        return SiteSettings;
    }

}

