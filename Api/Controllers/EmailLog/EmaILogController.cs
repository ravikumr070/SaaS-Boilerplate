using Application.EmailLog;
using Domain.EmailLog;

namespace Host.Controllers.EmailLog;

public class EmaILogController:VersionedApiController
{

    [HttpPost("search")]
    [MustHavePermission(UserAction.Search, UserResource.EmailLog)]
    [OpenApiOperation("Search EmailLog using available filters.", "")]
    public Task<PaginationResponse<EmailLogDto>> SearchAsync(SearchEmailLogRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    [MustHavePermission(UserAction.Create, UserResource.EmailLog)]
    [OpenApiOperation("Create a new EmailLog", "")]
    public Task<EmailLogModel> CreateAsync(CreateEmailLogRequest request)
    {
        return Mediator.Send(request);
    }
    [HttpDelete("{id:int}")]
    [MustHavePermission(UserAction.Delete, UserResource.EmailLog)]
    [OpenApiOperation("Delete a EmailLog", "")]
    public Task<EmailLogModel> DeleteAsync(int id)
    {
        return Mediator.Send(new DeleteEmailLogRequest(id));
    }
    [HttpGet("{id:int}")]
    [MustHavePermission(UserAction.View, UserResource.EmailLog)]
    [OpenApiOperation("Get EmailLog details.", "")]
    public Task<EmailLogDto> GetAsync(int id)
    {
        return Mediator.Send(new GetEmailLogRequest(id));
    }
    [HttpPut("{id:int}")]
    [MustHavePermission(UserAction.Update, UserResource.EmailLog)]
    [OpenApiOperation("Update a EmailLog.", "")]
    public async Task<ActionResult<EmailLogModel>> UpdateAsync(UpdateEmailLogRequest request, int id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
