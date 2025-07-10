using Domain.Common.Contracts;

namespace Infrastructure.LoginAttempt;

public class LoginAttempt : BaseEntity<long>
{
    public int Id { get; set; }
    public string? Tenant { get; set; }
    public string UserId { get; set; }
    public string? UserNameOrEmailAddress { get; set; }
    public string? ClientIpAddress { get; set; }
    public string? ClientName { get; set; }
    public string? BrowserInfo { get; set; }
    public DateTime DateTime { get; set; }= DateTime.Now;
}