using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LoginAttempt;
public class LoginAttemptDto : IDto
{
    public int Id { get; set; }
    public string? Tenant { get;  set; }
    public string UserId { get;  set; }
    public string? UserNameOrEmailAddress { get;  set; }
    public string? ClientIpAddress { get;  set; }
    public string? ClientName { get;  set; }
    public string? BrowserInfo { get;  set; }


}
