using Domain.EmailLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailLog;
public class CreateEmailLogRequest : IRequest<EmailLogModel>
{
    public int Id { get; set; }


    public int Email_Log_Id { get;  set; }
    public string? Customer_Name { get;  set; }
    public string Customer_Email { get;  set; }

    public string? Email_Subject { get;  set; }
    public string? Email_body { get;  set; }

    public DateTime? Email_date { get;  set; }
    public string Customer_EmailBCC { get;  set; }

    public string ErrorMSG { get;  set; }

    public bool IsMailSent { get;  set; }



}
public class CreateTblEmailLogRequestValidator : CustomValidator<CreateEmailLogRequest>
{
    public CreateTblEmailLogRequestValidator(IReadRepository<EmailLogModel> repository, IStringLocalizer<CreateTblEmailLogRequestValidator> localizer) { }
}
public class CreateEmailLogRequestHandler : IRequestHandler<CreateEmailLogRequest, EmailLogModel>
{
    private readonly IRepositoryWithEvents<EmailLogModel> _repository;

    public CreateEmailLogRequestHandler(IRepositoryWithEvents<EmailLogModel> repository) => _repository = repository;
    public async Task<EmailLogModel> Handle(CreateEmailLogRequest request, CancellationToken cancellationToken)
    {
        var EmailLog = new EmailLogModel(
        request.Id,
        request.Email_Log_Id,
        request.Customer_Name,
        request.Customer_Email,
        request.Email_Subject,
        request.Email_body,
        request.Email_date,
        request.Customer_EmailBCC,
        request.ErrorMSG,
        request.IsMailSent
        );
        var ouptput = await _repository.AddAsync(EmailLog, cancellationToken);
        return ouptput;

    }

}
