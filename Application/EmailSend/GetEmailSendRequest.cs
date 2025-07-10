using Domain.EmailSend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailSend;
public class GetEmailSendRequest : IRequest<EmailSendDto>
{
    public int Id { get; set; }
    public GetEmailSendRequest(int id) => Id = id;
}
public class EmailSendByIdSpec : Specification<EmailSendModel, EmailSendDto>, ISingleResultSpecification
{
    public EmailSendByIdSpec(int id) =>
        Query.Where(p => p.Id == id);
}

public class GetEmailSendRequestHandler : IRequestHandler<GetEmailSendRequest, EmailSendDto>
{
    private readonly IRepository<EmailSendModel> _repository;
    private readonly IStringLocalizer<GetEmailSendRequestHandler> _localizer;

    public GetEmailSendRequestHandler(IRepository<EmailSendModel> repository, IStringLocalizer<GetEmailSendRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<EmailSendDto> Handle(GetEmailSendRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<EmailSendModel, EmailSendDto>)new EmailSendByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["EmailSend notfound"], request.Id));
}


