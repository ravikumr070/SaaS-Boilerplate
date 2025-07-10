using MediatR;

namespace Application.LoginAttempt;

public class GetLoginAttemptRequest : IRequest<List<LoginAttemptDto>>
{
}

public class GetLoginAttemptRequestHandler : IRequestHandler<GetLoginAttemptRequest, List<LoginAttemptDto>>
{
    private readonly ICurrentUser _currentUser;
    private readonly ILoginAttemptService _auditService;

    public GetLoginAttemptRequestHandler(ICurrentUser currentUser, ILoginAttemptService auditService) =>
        (_currentUser, _auditService) = (currentUser, auditService);

    public Task<List<LoginAttemptDto>> Handle(GetLoginAttemptRequest request, CancellationToken cancellationToken) =>
        _auditService.GetLoginAttemptAsync(Convert.ToString(_currentUser.GetUserId()));

}