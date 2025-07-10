using Domain.EmailLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailLog;
public class DeleteEmailLogRequest : IRequest<EmailLogModel>
{
    public int Id { get; set; }

    public DeleteEmailLogRequest(int id) => Id = id;
}
public class DeleteEmailLogRequestHandler : IRequestHandler<DeleteEmailLogRequest, EmailLogModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<EmailLogModel> _EmailLogRepo;

    private readonly IStringLocalizer<DeleteEmailLogRequestHandler> _localizer;

    public DeleteEmailLogRequestHandler(IRepositoryWithEvents<EmailLogModel> EmailLogRepo, IStringLocalizer<DeleteEmailLogRequestHandler> localizer) =>
        (_EmailLogRepo, _localizer) = (EmailLogRepo, localizer);

    public async Task<EmailLogModel> Handle(DeleteEmailLogRequest request, CancellationToken cancellationToken)
    {

        var EmailLog = await _EmailLogRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = EmailLog ?? throw new NotFoundException(_localizer["EmailLog notfound"]);

        await _EmailLogRepo.DeleteAsync(EmailLog, cancellationToken);

        return EmailLog;
    }
}
