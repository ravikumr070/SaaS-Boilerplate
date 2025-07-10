using Domain.EmailSend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailSend;
public class CreateEmailSendRequest : IRequest<EmailSendModel>
{
    public int Id { get; set; }


    public int Email_Send_Id { get;  set; }
    public string? Customer_Name { get;  set; }
    public string Customer_Email { get;  set; }

    public string? Email_Subject { get;  set; }
    public string? Email_body { get;  set; }

    public DateTime? Email_date { get;  set; }
    public string Customer_EmailBCC { get;  set; }

    public string? ErrorMSG { get;  set; }



}
public class CreateTblEmailSendRequestValidator : CustomValidator<CreateEmailSendRequest>
{
    public CreateTblEmailSendRequestValidator(IReadRepository<EmailSendModel> repository, IStringLocalizer<CreateTblEmailSendRequestValidator> localizer) { }
}
public class CreateEmailSendRequestHandler : IRequestHandler<CreateEmailSendRequest, EmailSendModel>
{
    private readonly IRepositoryWithEvents<EmailSendModel> _repository;

    public CreateEmailSendRequestHandler(IRepositoryWithEvents<EmailSendModel> repository) => _repository = repository;
    public async Task<EmailSendModel> Handle(CreateEmailSendRequest request, CancellationToken cancellationToken)
    {
        var EmailSend = new EmailSendModel(
        request.Id,
        request.Email_Send_Id,
        request.Customer_Name,
        request.Customer_Email,
        request.Email_Subject,
        request.Email_body,
        request.Email_date,
        request.Customer_EmailBCC,
        request.ErrorMSG
        );
        var ouptput = await _repository.AddAsync(EmailSend, cancellationToken);
        return ouptput;

    }

}

