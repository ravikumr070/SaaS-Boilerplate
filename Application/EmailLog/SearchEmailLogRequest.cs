using Domain.EmailLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailLog;
public class SearchEmailLogRequest : PaginationFilter, IRequest<PaginationResponse<EmailLogDto>>
{
}
public class EmailLogBySearchRequestSpec : EntitiesByPaginationFilterSpec<EmailLogModel, EmailLogDto>
{
    public EmailLogBySearchRequestSpec(SearchEmailLogRequest request)
      : base(request) =>
      Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}

public class SearchEmailLogRequestHandler : IRequestHandler<SearchEmailLogRequest, PaginationResponse<EmailLogDto>>
{
    private readonly IReadRepository<EmailLogModel> _repository;

    public SearchEmailLogRequestHandler(IReadRepository<EmailLogModel> repository) => _repository = repository;

    public async Task<PaginationResponse<EmailLogDto>> Handle(SearchEmailLogRequest request, CancellationToken cancellationToken)
    {
        var spec = new EmailLogBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}
