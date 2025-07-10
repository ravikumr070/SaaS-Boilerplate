using Domain.EmailSend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailSend;
public class DeleteEmailSendRequest : IRequest<EmailSendModel>
{
    public int Id { get; set; }

    public DeleteEmailSendRequest(int id) => Id = id;
}
public class DeleteEmailSendRequestHandler : IRequestHandler<DeleteEmailSendRequest, EmailSendModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<EmailSendModel> _EmailSendRepo;

    private readonly IStringLocalizer<DeleteEmailSendRequestHandler> _localizer;

    public DeleteEmailSendRequestHandler(IRepositoryWithEvents<EmailSendModel> EmailSendRepo, IStringLocalizer<DeleteEmailSendRequestHandler> localizer) =>
        (_EmailSendRepo, _localizer) = (EmailSendRepo, localizer);

    public async Task<EmailSendModel> Handle(DeleteEmailSendRequest request, CancellationToken cancellationToken)
    {

        var EmailSend = await _EmailSendRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = EmailSend ?? throw new NotFoundException(_localizer["EmailSend notfound"]);

        await _EmailSendRepo.DeleteAsync(EmailSend, cancellationToken);

        return EmailSend;
    }
}

