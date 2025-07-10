using Application.SiteSettings;
using Domain.SiteSettings;

namespace Host.Controllers.SiteSettings;

public class SiteSettingsController:VersionedApiController
{


    [HttpPost("search")]
    [MustHavePermission(UserAction.Search, UserResource.SiteSettings)]
    [OpenApiOperation("Search SiteSettings using available filters.", "")]
    public Task<PaginationResponse<SiteSettingsDto>> SearchAsync(SearchSiteSettingsRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    [MustHavePermission(UserAction.Create, UserResource.SiteSettings)]
    [OpenApiOperation("Create a new SiteSettings", "")]
    public Task<SiteSettingsModel> CreateAsync(CreateSiteSettingsRequest request)
    {
        return Mediator.Send(request);
    }
    [HttpDelete("{id:int}")]
    [MustHavePermission(UserAction.Delete, UserResource.SiteSettings)]
    [OpenApiOperation("Delete a SiteSettings", "")]
    public Task<SiteSettingsModel> DeleteAsync(int id)
    {
        return Mediator.Send(new DeleteSiteSettingsRequest(id));
    }
    [HttpGet("{id:long}")]
    [MustHavePermission(UserAction.View, UserResource.SiteSettings)]
    [OpenApiOperation("Get SiteSettings details.", "")]
    public Task<SiteSettingsDto> GetAsync(int id)
    {
        return Mediator.Send(new GetSiteSettingsRequest(id));
    }
    [HttpPut("{id:long}")]
    [MustHavePermission(UserAction.Update, UserResource.SiteSettings)]
    [OpenApiOperation("Update a SiteSettings.", "")]
    public async Task<ActionResult<SiteSettingsModel>> UpdateAsync(UpdateSiteSettingsRequest request, int id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
