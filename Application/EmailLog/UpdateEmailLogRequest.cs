using Domain.EmailLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailLog;
public class UpdateEmailLogRequest : IRequest<EmailLogModel>
{
    public int Id { get; set; }
    public UpdateEmailLogRequest(int id) => Id = id;
    public int Email_Log_Id { get; set; }
    public string? Customer_Name { get; set; }
    public string Customer_Email { get; set; }

    public string? Email_Subject { get; set; }
    public string? Email_body { get; set; }

    public DateTime? Email_date { get; set; }
    public string Customer_EmailBCC { get; set; }

    public string? ErrorMSG { get; set; }
    public bool IsMailSent { get; set; }




}
public class UpdateEmailLogRequestValidator : CustomValidator<UpdateEmailLogRequest>
{
    public UpdateEmailLogRequestValidator(IRepository<EmailLogModel> repository, IStringLocalizer<UpdateEmailLogRequestValidator> localizer) { }

}
public class UpdateEmailLogRequestHandler : IRequestHandler<UpdateEmailLogRequest, EmailLogModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<EmailLogModel> _repository;
    private readonly IStringLocalizer<UpdateEmailLogRequestHandler> _localizer;

    public UpdateEmailLogRequestHandler(IRepositoryWithEvents<EmailLogModel> repository, IStringLocalizer<UpdateEmailLogRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);
    public async Task<EmailLogModel> Handle(UpdateEmailLogRequest request, CancellationToken cancellationToken)
    {
        var EmailLog = await _repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EmailLog ?? throw new NotFoundException(string.Format(_localizer["EmailLog notfound"], request.Id));
        EmailLog.Update(
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
        await _repository.UpdateAsync(EmailLog, cancellationToken);
        return EmailLog;
    }
}

