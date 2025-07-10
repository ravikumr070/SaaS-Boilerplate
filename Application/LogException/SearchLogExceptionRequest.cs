using Domain.LogException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogException;
public class SearchLogExceptionRequest : PaginationFilter, IRequest<PaginationResponse<LogExceptionDto>>
{
}
public class LogExceptionBySearchRequestSpec : EntitiesByPaginationFilterSpec<LogExceptionModel, LogExceptionDto>
{
    public LogExceptionBySearchRequestSpec(SearchLogExceptionRequest request)
      : base(request) =>
      Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}

public class SearchLogExceptionRequestHandler : IRequestHandler<SearchLogExceptionRequest, PaginationResponse<LogExceptionDto>>
{
    private readonly IReadRepository<LogExceptionModel> _repository;

    public SearchLogExceptionRequestHandler(IReadRepository<LogExceptionModel> repository) => _repository = repository;

    public async Task<PaginationResponse<LogExceptionDto>> Handle(SearchLogExceptionRequest request, CancellationToken cancellationToken)
    {
        var spec = new LogExceptionBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}

