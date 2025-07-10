using Domain.LogException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogException;
public class CreateLogExceptionRequest : IRequest<LogExceptionModel>
{
    public long Id { get; set; }

    public string InnerException { get; set; }
    public string? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? ErrorDatetime { get; set; }
    public string? ControllerName { get; set; }
    public string? ActionName { get; set; }
    public string? ExtraData { get; set; }


}
public class CreateTblLogExceptionRequestValidator : CustomValidator<CreateLogExceptionRequest>
{
    public CreateTblLogExceptionRequestValidator(IReadRepository<LogExceptionModel> repository, IStringLocalizer<CreateTblLogExceptionRequestValidator> localizer) { }
}
public class CreateLogExceptionRequestHandler : IRequestHandler<CreateLogExceptionRequest, LogExceptionModel>
{
    readonly IRepositoryWithEvents<LogExceptionModel> _repository;

    public CreateLogExceptionRequestHandler(IRepositoryWithEvents<LogExceptionModel> repository) => _repository = repository;
    public async Task<LogExceptionModel> Handle(CreateLogExceptionRequest request, CancellationToken cancellationToken)
    {
        var LogException = new LogExceptionModel(
            request.Id,
            request.InnerException,
            request.ErrorCode,
            request.ErrorMessage,
            request.ErrorDatetime,
            request.ControllerName,
            request.ActionName,
            request.ExtraData
                 
      
        );
        var ouptput = await _repository.AddAsync(LogException, cancellationToken);
        return ouptput;

    }
}
