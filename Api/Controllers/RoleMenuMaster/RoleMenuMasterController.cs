using Application.RoleMenuMaster;
using Domain.RoleMenuMaster;

namespace Host.Controllers.RoleMenuMaster;

public class RoleMenuMasterController:VersionedApiController
{

    [HttpPost("search")]
    [MustHavePermission(UserAction.Search, UserResource.RoleMenuMaster)]
    [OpenApiOperation("Search RoleMenuMaster using available filters.", "")]
    public Task<PaginationResponse<RoleMenuMasterDto>> SearchAsync(SearchRoleMenuMasterRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    [MustHavePermission(UserAction.Create, UserResource.RoleMenuMaster)]
    [OpenApiOperation("Create a new RoleMenuMaster", "")]
    public Task<RoleMenuMasterModel> CreateAsync(CreateRoleMenuMasterRequest request)
    {
        return Mediator.Send(request);
    }
    [HttpDelete("{id:int}")]
    [MustHavePermission(UserAction.Delete, UserResource.RoleMenuMaster)]
    [OpenApiOperation("Delete a RoleMenuMaster", "")]
    public Task<RoleMenuMasterModel> DeleteAsync(int id)
    {
        return Mediator.Send(new DeleteRoleMenuMasterRequest(id));
    }
    [HttpGet("{id:int}")]
    [MustHavePermission(UserAction.View, UserResource.RoleMenuMaster)]
    [OpenApiOperation("Get RoleMenuMaster details.", "")]
    public Task<RoleMenuMasterDto> GetAsync(int id)
    {
        return Mediator.Send(new GetRoleMenuMasterRequest(id));
    }
    [HttpPut("{id:int}")]
    [MustHavePermission(UserAction.Update, UserResource.RoleMenuMaster)]
    [OpenApiOperation("Update a RoleMenuMaster.", "")]
    public async Task<ActionResult<RoleMenuMasterModel>> UpdateAsync(UpdateRoleMenuMasterRequest request, int id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
