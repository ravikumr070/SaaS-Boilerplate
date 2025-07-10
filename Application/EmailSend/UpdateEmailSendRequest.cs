using Domain.EmailSend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailSend;
public class UpdateEmailSendRequest : IRequest<EmailSendModel>
{
    public int Id { get; set; }
    public UpdateEmailSendRequest(int id) => Id = id;
    public int Email_Send_Id { get;  set; }
    public string? Customer_Name { get;  set; }
    public string Customer_Email { get;  set; }

    public string? Email_Subject { get;  set; }
    public string? Email_body { get;  set; }

    public DateTime? Email_date { get;  set; }
    public string Customer_EmailBCC { get;  set; }

    public string? ErrorMSG { get;  set; }



}
public class UpdateEmailSendRequestValidator : CustomValidator<UpdateEmailSendRequest>
{
    public UpdateEmailSendRequestValidator(IRepository<EmailSendModel> repository, IStringLocalizer<UpdateEmailSendRequestValidator> localizer) { }

}
public class UpdateEmailSendRequestHandler : IRequestHandler<UpdateEmailSendRequest, EmailSendModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<EmailSendModel> _repository;
    private readonly IStringLocalizer<UpdateEmailSendRequestHandler> _localizer;

    public UpdateEmailSendRequestHandler(IRepositoryWithEvents<EmailSendModel> repository, IStringLocalizer<UpdateEmailSendRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);
    public async Task<EmailSendModel> Handle(UpdateEmailSendRequest request, CancellationToken cancellationToken)
    {
        var EmailSend = await _repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EmailSend ?? throw new NotFoundException(string.Format(_localizer["EmailSend notfound"], request.Id));
        EmailSend.Update(
            request.Email_Send_Id,
        request.Customer_Name,
        request.Customer_Email,
        request.Email_Subject,
        request.Email_body,
        request.Email_date,
        request.Customer_EmailBCC,
        request.ErrorMSG
            );
        await _repository.UpdateAsync(EmailSend, cancellationToken);
        return EmailSend;
    }
}
