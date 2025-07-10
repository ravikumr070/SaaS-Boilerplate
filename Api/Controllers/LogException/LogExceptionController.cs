using Application.LogException;
using Domain.LogException;

namespace Controllers.LogException;

public class LogExceptionController:VersionedApiController
{

    [HttpPost("search")]
    [MustHavePermission(UserAction.Search, UserResource.LogException)]
    [OpenApiOperation("Search LogException using available filters.", "")]
    public Task<PaginationResponse<LogExceptionDto>> SearchAsync(SearchLogExceptionRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    [MustHavePermission(UserAction.Create, UserResource.LogException)]
    [OpenApiOperation("Create a new LogException", "")]
    public Task<LogExceptionModel> CreateAsync(CreateLogExceptionRequest request)
    {
        return Mediator.Send(request);
    }
    [HttpDelete("{id:long}")]
    [MustHavePermission(UserAction.Delete, UserResource.LogException)]
    [OpenApiOperation("Delete a LogException", "")]
    public Task<LogExceptionModel> DeleteAsync(long id)
    {
        return Mediator.Send(new DeleteLogExceptionRequest(id));
    }
    [HttpGet("{id:long}")]
    [MustHavePermission(UserAction.View, UserResource.LogException)]
    [OpenApiOperation("Get LogException details.", "")]
    public Task<LogExceptionDto> GetAsync(long id)
    {
        return Mediator.Send(new GetLogExceptionRequest(id));
    }
    [HttpPut("{id:long}")]
    [MustHavePermission(UserAction.Update, UserResource.LogException)]
    [OpenApiOperation("Update a LogException.", "")]
    public async Task<ActionResult<LogExceptionModel>> UpdateAsync(UpdateLogExceptionRequest request, long id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
