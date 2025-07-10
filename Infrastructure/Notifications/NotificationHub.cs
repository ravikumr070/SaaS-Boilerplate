using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Application.Common.Persistence;
using Domain.MasterTenant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Notifications;

[Authorize]
public class NotificationHub : Hub, ITransientService
{
    private readonly ITenantProvider? _tenantProvider;
    private readonly ILogger<NotificationHub> _logger;
    private readonly Tenant? _currentTenant;
    public NotificationHub(ITenantProvider? tenantProvider, ILogger<NotificationHub> logger)
    {
        _tenantProvider = tenantProvider;
        _currentTenant = _tenantProvider.GetTenant();
        _logger = logger;
    }

    public override async Task OnConnectedAsync()
    {
        if (_currentTenant is null)
        {
            throw new UnauthorizedException("Authentication Failed.");
        }

        await Groups.AddToGroupAsync(Context.ConnectionId, $"GroupTenant-{_currentTenant.Id}");

        await base.OnConnectedAsync();

        _logger.LogInformation("A client connected to NotificationHub: {connectionId}", Context.ConnectionId);
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"GroupTenant-{_currentTenant!.Id}");

        await base.OnDisconnectedAsync(exception);

        _logger.LogInformation("A client disconnected from NotificationHub: {connectionId}", Context.ConnectionId);
    }
}