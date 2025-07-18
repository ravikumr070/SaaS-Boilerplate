﻿
using Application.Common.Persistence;
using Infrastructure.Common;
using Shared.Multitenancy;
using Hangfire.Client;
using Hangfire.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shared.Authorization;

namespace Infrastructure.BackgroundJobs;

public class JobFilter : IClientFilter
{
    private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

    private readonly IServiceProvider _services;

    public JobFilter(IServiceProvider services) => _services = services;

    public void OnCreating(CreatingContext context)
    {
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Logger.InfoFormat("Set TenantId and UserId parameters to job {0}.{1}...", context.Job.Method.ReflectedType?.FullName, context.Job.Method.Name);

        using var scope = _services.CreateScope();

        var httpContext = scope.ServiceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext;
        _ = httpContext ?? throw new InvalidOperationException("Can't create a TenantJob without HttpContext.");

        var tenantInfo = scope.ServiceProvider.GetRequiredService<ITenantProvider>();
        context.SetJobParameter(MultitenancyConstants.TenantIdName, tenantInfo);

        string? userId = httpContext.User.GetUserId();
        context.SetJobParameter(QueryStringKeys.UserId, userId);
    }

    public void OnCreated(CreatedContext context) =>
        Logger.InfoFormat(
            "Job created with parameters {0}",
            context.Parameters.Select(x => x.Key + "=" + x.Value).Aggregate((s1, s2) => s1 + ";" + s2));
}