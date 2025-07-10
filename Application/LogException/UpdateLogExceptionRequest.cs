using Domain.LogException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogException;
public class UpdateLogExceptionRequest : IRequest<LogExceptionModel>
{
    public long Id { get; set; }
    public UpdateLogExceptionRequest(long id) => Id = id;
    public string InnerException { get; set; }
    public string? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? ErrorDatetime { get; set; }
    public string? ControllerName { get; set; }
    public string? ActionName { get; set; }
    public string? ExtraData { get; set; }

}
public class UpdateLogExceptionRequestValidator : CustomValidator<UpdateLogExceptionRequest>
{
    public UpdateLogExceptionRequestValidator(IRepository<LogExceptionModel> repository, IStringLocalizer<UpdateLogExceptionRequestValidator> localizer) { }

}
public class UpdateLogExceptionRequestHandler : IRequestHandler<UpdateLogExceptionRequest, LogExceptionModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<LogExceptionModel> _repository;
    private readonly IStringLocalizer<UpdateLogExceptionRequestHandler> _localizer;

    public UpdateLogExceptionRequestHandler(IRepositoryWithEvents<LogExceptionModel> repository, IStringLocalizer<UpdateLogExceptionRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);
    public async Task<LogExceptionModel> Handle(UpdateLogExceptionRequest request, CancellationToken cancellationToken)
    {
        var LogException = await _repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LogException ?? throw new NotFoundException(string.Format(_localizer["LogException notfound"], request.Id));
        LogException.Update(
              request.InnerException,
            request.ErrorCode,
            request.ErrorMessage,
            request.ErrorDatetime,
            request.ControllerName,
            request.ActionName,
            request.ExtraData
            );
        await _repository.UpdateAsync(LogException, cancellationToken);
        return LogException;
    }
}



