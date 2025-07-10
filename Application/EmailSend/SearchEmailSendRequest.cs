using Domain.EmailSend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailSend;
public class SearchEmailSendRequest : PaginationFilter, IRequest<PaginationResponse<EmailSendDto>>
{
}
public class EmailSendBySearchRequestSpec : EntitiesByPaginationFilterSpec<EmailSendModel, EmailSendDto>
{
    public EmailSendBySearchRequestSpec(SearchEmailSendRequest request)
      : base(request) =>
      Query.OrderBy(c => c.CreatedOn, !request.HasOrderBy());
}

public class SearchEmailSendRequestHandler : IRequestHandler<SearchEmailSendRequest, PaginationResponse<EmailSendDto>>
{
    private readonly IReadRepository<EmailSendModel> _repository;

    public SearchEmailSendRequestHandler(IReadRepository<EmailSendModel> repository) => _repository = repository;

    public async Task<PaginationResponse<EmailSendDto>> Handle(SearchEmailSendRequest request, CancellationToken cancellationToken)
    {
        var spec = new EmailSendBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}
