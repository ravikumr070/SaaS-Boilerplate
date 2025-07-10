namespace Application.Multitenancy;

public class TenantSiteUrlDto
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? SiteUrl { get; set; }
}
public class TenantDto
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? ConnectionString { get; set; }
    public string AdminEmail { get; set; } = default!;
    public bool IsActive { get; set; }
    public DateTime ValidUpto { get; set; }
    public string? Issuer { get; set; }
    // Added Custom column
    public string? SiteName { get; set; }
    public string? SiteUrl { get; set; }
    public int? PaymentGateWay { get; set; }
    public int? Intregration { get; set; }
    public string? ContactUsEmail { get; set; }
    public string? OrderEmail { get; set; }
    public bool ShowProductWithoutLogin { get; set; }
    public bool ShowRRPWithoutLogin { get; set; }
    public int? CategoryLayoutOption { get; set; }
    public int? HomePageLayoutOption { get; set; }
    public string? ThemeColorCode { get; set; }
    public string? ThemeLogo { get; set; }
    public string? CustomCss { get; set; }
    public int? BaseCurrency { get; set; }
    public int? InternationalCurrency { get; set; }
    public int? ProductPerPage { get; set; }
    public string? Sitedb { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? SubscriptionID { get; set; }
    public string? FooterColor { get; set; }
    public string? SmtpClient { get; set; }
    public int? Port { get; set; }
    public bool IsSSLEnable { get; set; }
    public string? FromMail { get; set; }
    public string? FromDisplayMail { get; set; }
    public bool IsDeleted { get; set; }
    public int? ThemeId { get; set; }
    public string? HeaderColor { get; set; }
    public bool IsIntegration { get; set; }
    public string? SmtpPassword { get; set; }
    public bool BuyOutOfStock { get; set; }
    public int? HeaderMenuType { get; set; }
    public bool IsHttps { get; set; }
    public bool EnableCategoryTransfer { get; set; }
    public bool EnableStockTransfer { get; set; }
    public bool EnableCustomerRegistration { get; set; }
    public bool IsRegistrationActive { get; set; }
    public string? mSellerDirectory { get; set; }
    public bool EnableBestSellerVolumeBase { get; set; }
    public int BestSellerMinItemQty { get; set; }
    public int? SessionTimeout { get; set; }
    public string? smtpUsername { get; set; }
    public bool IssmtpUsername { get; set; }
    public string? TemplateOption { get; set; }
    public bool IsEmailReminderSent { get; set; }
    public bool IsEmailReminder { get; set; }
    public bool GoogleCustomerReviews { get; set; }
    public bool Warehouse { get; set; }
    public string? SiteType { get; set; }
    public bool ShowSiteWithoutLogin { get; set; }
    public bool EnableYotpo { get; set; }
    public bool? IsUPS { get; set; }
    public bool IsSiteLive { get; set; }
    public string? BusinessManagerLink { get; set; }
    public string? ReadMailFrom { get; set; }
    public string? ReadMailFromPassword { get; set; }
    public bool EnableShowCloudfylogo { get; set; }
    public string? CSSVersion { get; set; }
    public string? SiteLiveUrl { get; set; }
    public string? APIUrl { get; set; }
    public string? TwoFASitePrivateKey { get; set; }
    public string? GoogleAnalyticsId { get; set; }
}