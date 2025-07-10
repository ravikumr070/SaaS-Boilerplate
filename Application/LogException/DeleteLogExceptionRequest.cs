using Domain.LogException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogException;
public class DeleteLogExceptionRequest : IRequest<LogExceptionModel>
{
    public long Id { get; set; }

    public DeleteLogExceptionRequest(long id) => Id = id;
}
public class DeleteLogExceptionRequestHandler : IRequestHandler<DeleteLogExceptionRequest, LogExceptionModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<LogExceptionModel> _LogExceptionRepo;

    private readonly IStringLocalizer<DeleteLogExceptionRequestHandler> _localizer;

    public DeleteLogExceptionRequestHandler(IRepositoryWithEvents<LogExceptionModel> LogExceptionRepo, IStringLocalizer<DeleteLogExceptionRequestHandler> localizer) =>
        (_LogExceptionRepo, _localizer) = (LogExceptionRepo, localizer);

    public async Task<LogExceptionModel> Handle(DeleteLogExceptionRequest request, CancellationToken cancellationToken)
    {

        var LogException = await _LogExceptionRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = LogException ?? throw new NotFoundException(_localizer["LogException notfound"]);

        await _LogExceptionRepo.DeleteAsync(LogException, cancellationToken);

        return LogException;
    }

}

