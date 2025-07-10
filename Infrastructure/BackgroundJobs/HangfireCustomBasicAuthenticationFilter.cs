
using Hangfire.Dashboard;

namespace Infrastructure.BackgroundJobs
{
    
    public class HangfireCustomBasicAuthenticationFilter : IDashboardAuthorizationFilter
    {
        public string? User { get; set; }
        public string? Pass { get; set; }

        public bool Authorize(DashboardContext context)
        {
            var httpContext = context.GetHttpContext();

            string? header = httpContext.Request.Headers["Authorization"];
            if (!string.IsNullOrWhiteSpace(header) && header.StartsWith("Basic "))
            {
                var encodedUsernamePassword = header.Substring("Basic ".Length).Trim();
                var encoding = System.Text.Encoding.UTF8;
                var usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));

                int separatorIndex = usernamePassword.IndexOf(':');
                if (separatorIndex >= 0)
                {
                    var username = usernamePassword.Substring(0, separatorIndex);
                    var password = usernamePassword.Substring(separatorIndex + 1);

                    return string.Equals(username, User, StringComparison.InvariantCultureIgnoreCase) &&
                           string.Equals(password, Pass, StringComparison.InvariantCulture);
                }
            }

            httpContext.Response.Headers["WWW-Authenticate"] = "Basic";
            httpContext.Response.StatusCode = 401;
            return false;
        }
    }
}
