using Application.Dashboard;
using Infrastructure.Auth.Permissions;
using NSwag.Annotations;

namespace Host.Controllers.Dashboard;

public class DashboardController : VersionedApiController
{
    [HttpGet]
    [MustHavePermission(UserAction.View, UserResource.Dashboard)]
    [OpenApiOperation("Get statistics for the dashboard.", "")]
    public Task<StatsDto> GetAsync()
    {
        return Mediator.Send(new GetStatsRequest());
    }
}