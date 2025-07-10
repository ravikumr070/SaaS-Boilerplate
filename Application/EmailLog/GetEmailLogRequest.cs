using Domain.EmailLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailLog;
public class GetEmailLogRequest : IRequest<EmailLogDto>
{
    public int Id { get; set; }
    public GetEmailLogRequest(int id) => Id = id;
}
public class EmailLogByIdSpec : Specification<EmailLogModel, EmailLogDto>, ISingleResultSpecification
{
    public EmailLogByIdSpec(int id) =>
        Query.Where(p => p.Id == id);
}

public class GetEmailLogRequestHandler : IRequestHandler<GetEmailLogRequest, EmailLogDto>
{
    private readonly IRepository<EmailLogModel> _repository;
    private readonly IStringLocalizer<GetEmailLogRequestHandler> _localizer;

    public GetEmailLogRequestHandler(IRepository<EmailLogModel> repository, IStringLocalizer<GetEmailLogRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<EmailLogDto> Handle(GetEmailLogRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<EmailLogModel, EmailLogDto>)new EmailLogByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["EmailLog notfound"], request.Id));
}

