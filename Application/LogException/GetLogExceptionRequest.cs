using Domain.LogException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogException;
public class GetLogExceptionRequest : IRequest<LogExceptionDto>
{
    public long Id { get; set; }
    public GetLogExceptionRequest(long id) => Id = id;
}
public class LogExceptionByIdSpec : Specification<LogExceptionModel, LogExceptionDto>, ISingleResultSpecification
{
    public LogExceptionByIdSpec(long id) =>
        Query.Where(p => p.Id == id);
}

public class GetLogExceptionRequestHandler : IRequestHandler<GetLogExceptionRequest, LogExceptionDto>
{
    private readonly IRepository<LogExceptionModel> _repository;
    private readonly IStringLocalizer<GetLogExceptionRequestHandler> _localizer;

    public GetLogExceptionRequestHandler(IRepository<LogExceptionModel> repository, IStringLocalizer<GetLogExceptionRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<LogExceptionDto> Handle(GetLogExceptionRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<LogExceptionModel, LogExceptionDto>)new LogExceptionByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["LogException notfound"], request.Id));
}


