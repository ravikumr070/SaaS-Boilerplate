namespace Application.LoginAttempt;

public interface ILoginAttemptService : ITransientService
{
    Task<List<LoginAttemptDto>> GetLoginAttemptAsync(string userId);
    Task<string> AddLoginAttemptAsync(LoginAttemptDto request);
    Task<List<LoginAttemptDto>> GetLoginAttemptAsync();
}