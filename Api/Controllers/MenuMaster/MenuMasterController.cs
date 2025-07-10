using Application.MenuMaster;
using Domain.MenuMaster;

namespace Host.Controllers.MenuMaster;

public class MenuMasterController:VersionedApiController
{

    [HttpPost("search")]
    [MustHavePermission(UserAction.Search, UserResource.MenuMaster)]
    [OpenApiOperation("Search MenuMaster using available filters.", "")]
    public Task<PaginationResponse<MenuMasterDto>> SearchAsync(SearchMenuMasterRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    [MustHavePermission(UserAction.Create, UserResource.MenuMaster)]
    [OpenApiOperation("Create a new MenuMaster", "")]
    public Task<MenuMasterModel> CreateAsync(CreateMenuMasterRequest request)
    {
        return Mediator.Send(request);
    }
    [HttpDelete("{id:int}")]
    [MustHavePermission(UserAction.Delete, UserResource.MenuMaster)]
    [OpenApiOperation("Delete a MenuMaster", "")]
    public Task<MenuMasterModel> DeleteAsync(int id)
    {
        return Mediator.Send(new DeleteMenuMasterRequest(id));
    }
    [HttpGet("{id:int}")]
    [MustHavePermission(UserAction.View, UserResource.MenuMaster)]
    [OpenApiOperation("Get MenuMaster details.", "")]
    public Task<MenuMasterDto> GetAsync(int id)
    {
        return Mediator.Send(new GetMenuMasterRequest(id));
    }
    [HttpGet]
    [MustHavePermission(UserAction.View, UserResource.MenuMaster)]
    [OpenApiOperation("Get All MenuMaster List.", "")]
    public Task<List<AllMenuMasterDto>> GetAsync()
    {
        return Mediator.Send(new GetAllMenuMasterRequest());
    }
    [HttpPut("{id:int}")]
    [MustHavePermission(UserAction.Update, UserResource.MenuMaster)]
    [OpenApiOperation("Update a MenuMaster.", "")]
    public async Task<ActionResult<MenuMasterModel>> UpdateAsync(UpdateMenuMasterRequest request, int id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
