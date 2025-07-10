using Application.EmailSend;
using Domain.EmailSend;

namespace Controllers.EmailSend;

public class EmailSendController:VersionedApiController
{

    [HttpPost("search")]
    [MustHavePermission(UserAction.Search, UserResource.EmailSend)]
    [OpenApiOperation("Search EmailSend using available filters.", "")]
    public Task<PaginationResponse<EmailSendDto>> SearchAsync(SearchEmailSendRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    [MustHavePermission(UserAction.Create, UserResource.EmailSend)]
    [OpenApiOperation("Create a new EmailSend", "")]
    public Task<EmailSendModel> CreateAsync(CreateEmailSendRequest request)
    {
        return Mediator.Send(request);
    }
    [HttpDelete("{id:int}")]
    [MustHavePermission(UserAction.Delete, UserResource.EmailSend)]
    [OpenApiOperation("Delete a EmailSend", "")]
    public Task<EmailSendModel> DeleteAsync(int id)
    {
        return Mediator.Send(new DeleteEmailSendRequest(id));
    }
    [HttpGet("{id:int}")]
    [MustHavePermission(UserAction.View, UserResource.EmailSend)]
    [OpenApiOperation("Get EmailSend details.", "")]
    public Task<EmailSendDto> GetAsync(int id)
    {
        return Mediator.Send(new GetEmailSendRequest(id));
    }
    [HttpPut("{id:int}")]
    [MustHavePermission(UserAction.Update, UserResource.EmailSend)]
    [OpenApiOperation("Update a EmailSend.", "")]
    public async Task<ActionResult<EmailSendModel>> UpdateAsync(UpdateEmailSendRequest request, int id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }
}
