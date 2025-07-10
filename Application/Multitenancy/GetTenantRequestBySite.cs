namespace Application.Multitenancy;

public class GetTenantRequestBySite : IRequest<TenantSiteUrlDto>
{
    public string TenantSiteUrl { get; set; } = default!;
}

public class GetTenantRequestBySiteValidator : CustomValidator<GetTenantRequestBySite>
{
    public GetTenantRequestBySiteValidator() =>
        RuleFor(t => t.TenantSiteUrl)
            .NotEmpty();
}

public class GetTenantRequestBySiteHandler : IRequestHandler<GetTenantRequestBySite, TenantSiteUrlDto>
{
    private readonly ITenantService _tenantService;

    public GetTenantRequestBySiteHandler(ITenantService tenantService) => _tenantService = tenantService;

    public Task<TenantSiteUrlDto> Handle(GetTenantRequestBySite request, CancellationToken cancellationToken) =>
        _tenantService.GetBySiteUrlAsync(request.TenantSiteUrl);
}