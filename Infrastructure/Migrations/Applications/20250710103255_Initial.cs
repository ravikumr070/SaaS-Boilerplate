using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations.Applications
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Auditing");

            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateTable(
                name: "AuditTrails",
                schema: "Auditing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTrails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emaillog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email_Log_Id = table.Column<int>(type: "int", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Customer_Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email_Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email_body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Customer_EmailBCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorMSG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMailSent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emaillog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailSend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email_Send_Id = table.Column<int>(type: "int", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Customer_Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email_Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email_body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Customer_EmailBCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorMSG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogException",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InnerException = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ErrorDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExtraData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogException", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginAttempt",
                schema: "Auditing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNameOrEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrowserInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAttempt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    MenuText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuMaster_MenuMaster_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MenuMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    settingsID = table.Column<long>(type: "bigint", nullable: false),
                    SiteId = table.Column<long>(type: "bigint", nullable: true),
                    SitePhoneNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SiteCompanyAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContactUsEmailAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OrdersEmailAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TwitterURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FacebookURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MinimumOrderValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FreeDeliveryLevel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GoogleAnalyticsTrackingID = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EmailBCC = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RegistrationNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteFavicon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderBanner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailPriceLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradePriceLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKU = table.Column<bool>(type: "bit", nullable: true),
                    STOCK = table.Column<bool>(type: "bit", nullable: true),
                    QTYADD = table.Column<bool>(type: "bit", nullable: true),
                    REVIEWS = table.Column<bool>(type: "bit", nullable: true),
                    CASEQTY = table.Column<bool>(type: "bit", nullable: true),
                    QTYBREAK = table.Column<bool>(type: "bit", nullable: true),
                    RetailPriceLabel1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TradePriceLabel1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SKU1 = table.Column<bool>(type: "bit", nullable: true),
                    STOCK1 = table.Column<bool>(type: "bit", nullable: true),
                    QTYADD1 = table.Column<bool>(type: "bit", nullable: true),
                    REVIEWS1 = table.Column<bool>(type: "bit", nullable: true),
                    CASEQTY1 = table.Column<bool>(type: "bit", nullable: true),
                    QTYBREAK1 = table.Column<bool>(type: "bit", nullable: true),
                    EnableDemoStoreMessage = table.Column<bool>(type: "bit", nullable: true),
                    CreateTradeAccountLogin = table.Column<bool>(type: "bit", nullable: true),
                    EnableLiveChat = table.Column<bool>(type: "bit", nullable: true),
                    ZoopimScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableReviews = table.Column<bool>(type: "bit", nullable: true),
                    EnableGuestCheckout = table.Column<bool>(type: "bit", nullable: true),
                    CurencyConversion = table.Column<bool>(type: "bit", nullable: true),
                    MageMenuPromotionalMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowHomeLink = table.Column<bool>(type: "bit", nullable: true),
                    CategoryMenuCount = table.Column<int>(type: "int", nullable: true),
                    EnablePredictiveSearch = table.Column<bool>(type: "bit", nullable: true),
                    EnableSuperClass = table.Column<bool>(type: "bit", nullable: true),
                    AllowOrder = table.Column<bool>(type: "bit", nullable: true),
                    selectedtab = table.Column<short>(type: "smallint", nullable: true),
                    ShowBarcode = table.Column<bool>(type: "bit", nullable: true),
                    UnitForSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UnitForWeight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShowRRPWithoutLogin = table.Column<bool>(type: "bit", nullable: true),
                    ShowRRPWithStrike = table.Column<bool>(type: "bit", nullable: true),
                    ShowPriceWithoutLogin = table.Column<bool>(type: "bit", nullable: true),
                    EnableOnCollection = table.Column<bool>(type: "bit", nullable: true),
                    IsVatApplicable = table.Column<bool>(type: "bit", nullable: true),
                    DeiveryRestrictedBy = table.Column<int>(type: "int", nullable: true),
                    EnableBestSellers = table.Column<bool>(type: "bit", nullable: true),
                    EnableLatestProducts = table.Column<bool>(type: "bit", nullable: true),
                    EnableSpecialOffers = table.Column<bool>(type: "bit", nullable: true),
                    EnableDeliveryDate = table.Column<bool>(type: "bit", nullable: true),
                    DeliveryDateLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShowOutOfStockItem = table.Column<bool>(type: "bit", nullable: true),
                    Ordertype = table.Column<bool>(type: "bit", nullable: true),
                    ShowStockDueDate = table.Column<bool>(type: "bit", nullable: true),
                    ShowCatBannerHeading = table.Column<bool>(type: "bit", nullable: true),
                    EnableGoogleTranslater = table.Column<bool>(type: "bit", nullable: true),
                    LinkedInURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    YoutubeURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PrinterestURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EmableMultipleCurrency = table.Column<bool>(type: "bit", nullable: true),
                    EnableMinimumOrderByCountry = table.Column<bool>(type: "bit", nullable: true),
                    EnableMultipleSKU = table.Column<bool>(type: "bit", nullable: true),
                    ReportLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableExistingCustomer = table.Column<bool>(type: "bit", nullable: true),
                    EnablePaymentLimit = table.Column<bool>(type: "bit", nullable: true),
                    DefaultSortingField = table.Column<long>(type: "bigint", nullable: true),
                    IsBestSellersFromAdmin = table.Column<bool>(type: "bit", nullable: true),
                    IsLatestProductsFromAdmin = table.Column<bool>(type: "bit", nullable: true),
                    IsSpecialOffersFromAdmin = table.Column<bool>(type: "bit", nullable: true),
                    IsImageCompressed = table.Column<bool>(type: "bit", nullable: true),
                    Mailchimp_listid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Mailchimp_apiKey = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubscribeMailchimp = table.Column<bool>(type: "bit", nullable: true),
                    EnableRoundleOnDetails = table.Column<bool>(type: "bit", nullable: true),
                    IsNewLayout = table.Column<bool>(type: "bit", nullable: true),
                    IsUpdated = table.Column<bool>(type: "bit", nullable: true),
                    ChekoutEditableAddr = table.Column<bool>(type: "bit", nullable: true),
                    EnablePendingBasketMail = table.Column<bool>(type: "bit", nullable: true),
                    setDurationAfterAddedbasket = table.Column<int>(type: "int", nullable: true),
                    LastSendingMail = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryAddressAtLogin = table.Column<bool>(type: "bit", nullable: true),
                    DemoStoreMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DemoStoreMessageLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EnablepriceFilter = table.Column<bool>(type: "bit", nullable: true),
                    EnableRightClick = table.Column<bool>(type: "bit", nullable: true),
                    WelcomeMessageAfterLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableFooterSiteMapLink = table.Column<bool>(type: "bit", nullable: true),
                    EnableFooterNewsLink = table.Column<bool>(type: "bit", nullable: true),
                    EnableStockQty = table.Column<bool>(type: "bit", nullable: true),
                    EnableNewsforInactiveCus = table.Column<bool>(type: "bit", nullable: true),
                    DeliveryOptionMethod = table.Column<int>(type: "int", nullable: true),
                    DeliveryOption = table.Column<bool>(type: "bit", nullable: true),
                    EnableCustomerAlsoBoughtFeature = table.Column<bool>(type: "bit", nullable: true),
                    EnableAbandonedMailfeature = table.Column<bool>(type: "bit", nullable: true),
                    CopyrightText = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    EnableProductSocialShring = table.Column<bool>(type: "bit", nullable: true),
                    IsNextDayDelivery = table.Column<bool>(type: "bit", nullable: true),
                    EnableEmailBackInStock = table.Column<bool>(type: "bit", nullable: false),
                    TagManagerTrackingId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsSavedBasket = table.Column<bool>(type: "bit", nullable: true),
                    MinOrderExvat = table.Column<bool>(type: "bit", nullable: true),
                    CalculateVatFrom = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EnableCallForPrice = table.Column<bool>(type: "bit", nullable: true),
                    EnableDownloadTab = table.Column<bool>(type: "bit", nullable: true),
                    DownloadTabOption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HideCategoryImage = table.Column<bool>(type: "bit", nullable: true),
                    GoogleLangSwitchPosition = table.Column<bool>(type: "bit", nullable: true),
                    EnableReserveStock = table.Column<bool>(type: "bit", nullable: true),
                    ReserveStockLevel = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EnableFooterEventsLink = table.Column<bool>(type: "bit", nullable: true),
                    EnableStockManagement = table.Column<bool>(type: "bit", nullable: true),
                    Vat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GoogleCustomerReviews = table.Column<bool>(type: "bit", nullable: true),
                    ShowProductInMenu = table.Column<bool>(type: "bit", nullable: true),
                    VimeoLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CurrencyConversion_BeforeLogin = table.Column<bool>(type: "bit", nullable: true),
                    CurrencyConversion_AfterLogin = table.Column<bool>(type: "bit", nullable: true),
                    ShowTwoProductInCategoryView = table.Column<bool>(type: "bit", nullable: true),
                    ProductZoom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    isShowFooterPaymentLogo = table.Column<bool>(type: "bit", nullable: true),
                    IsEnableProductReviewsEmailReminder = table.Column<bool>(type: "bit", nullable: true),
                    ProductDetail = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Delivery = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Materials = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EnableBuyOutOfStock = table.Column<bool>(type: "bit", nullable: false),
                    HeaderMenuType = table.Column<int>(type: "int", nullable: true),
                    EnableWareHouse = table.Column<bool>(type: "bit", nullable: false),
                    EnableSalesRepCode = table.Column<byte>(type: "tinyint", nullable: true),
                    EnableCustomerSpecificeCatalogue = table.Column<bool>(type: "bit", nullable: true),
                    IsCustomerEncrypted = table.Column<bool>(type: "bit", nullable: true),
                    HideDeliveryChangeFromCheckout = table.Column<bool>(type: "bit", nullable: true),
                    HideVoucherCode = table.Column<bool>(type: "bit", nullable: true),
                    showmSellerOrder = table.Column<bool>(type: "bit", nullable: true),
                    EnableMultiLanguage = table.Column<bool>(type: "bit", nullable: true),
                    EnablePunchout = table.Column<bool>(type: "bit", nullable: true),
                    EnableLocalTax = table.Column<bool>(type: "bit", nullable: true),
                    EnableYotpoReviews = table.Column<bool>(type: "bit", nullable: false),
                    EnableVatverification = table.Column<bool>(type: "bit", nullable: false),
                    BaseCountry = table.Column<int>(type: "int", nullable: true),
                    EnableQuickOrder = table.Column<bool>(type: "bit", nullable: true),
                    IsOfferPriceFromProduct = table.Column<bool>(type: "bit", nullable: true),
                    EnableDownloadOrdersProductImages = table.Column<bool>(type: "bit", nullable: true),
                    IsEnableCapitalisationOnSite = table.Column<bool>(type: "bit", nullable: true),
                    ShowStockStatusFilter = table.Column<bool>(type: "bit", nullable: false),
                    EnableComments = table.Column<bool>(type: "bit", nullable: false),
                    GooglePlusLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsEnableNewExtendingDelivery = table.Column<bool>(type: "bit", nullable: false),
                    ShowDeliveryBreakdown = table.Column<bool>(type: "bit", nullable: false),
                    PrioritySetting = table.Column<int>(type: "int", nullable: true),
                    BasketCheckoutAlert = table.Column<int>(type: "int", nullable: true),
                    BasketCheckoutAlertText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    NonSaleableMessage = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    EnableUserType = table.Column<bool>(type: "bit", nullable: false),
                    EnableSpendLimits = table.Column<bool>(type: "bit", nullable: false),
                    EnableAuthorisationOnly = table.Column<bool>(type: "bit", nullable: false),
                    LimitingPredictiveSearch = table.Column<int>(type: "int", nullable: true),
                    ShowThumbnailWithPredictiveSearch = table.Column<bool>(type: "bit", nullable: true),
                    FacebookTrackingID = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsBespokeMenuEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SortCategoryByAlphabetically = table.Column<bool>(type: "bit", nullable: false),
                    EnableCustomerRef = table.Column<bool>(type: "bit", nullable: false),
                    PriceDecimalPlace = table.Column<int>(type: "int", nullable: true),
                    EnableCheckoutBillAddress = table.Column<bool>(type: "bit", nullable: true),
                    ShowPriceIncVat = table.Column<bool>(type: "bit", nullable: true),
                    ShowPriceIncVat1 = table.Column<bool>(type: "bit", nullable: true),
                    ShowDualPrices = table.Column<bool>(type: "bit", nullable: true),
                    PageBuilderFontsFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBuilderCSSFiles = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PageBuilderJSFiles = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DisableLineLevelPO = table.Column<bool>(type: "bit", nullable: false),
                    Site404Page = table.Column<int>(type: "int", nullable: true),
                    GoogleMapApiKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IndexRankLabel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DefaultSearchSortingOrder = table.Column<int>(type: "int", nullable: true),
                    EnableCustomerSpecificeProducts = table.Column<bool>(type: "bit", nullable: false),
                    LayoutSelection = table.Column<int>(type: "int", nullable: true),
                    CalculatedUnitsGridRestricted = table.Column<bool>(type: "bit", nullable: false),
                    EnableRMARequests = table.Column<bool>(type: "bit", nullable: false),
                    CustomerCatalogueMode = table.Column<int>(type: "int", nullable: false),
                    EnableBundleQty = table.Column<bool>(type: "bit", nullable: false),
                    EnableDualPrice = table.Column<bool>(type: "bit", nullable: false),
                    CategoryViewDropdownVarients = table.Column<bool>(type: "bit", nullable: false),
                    EnableProductSKUBasket = table.Column<bool>(type: "bit", nullable: false),
                    LiveChatVisibility = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CalculatedUnits = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnableGridView = table.Column<int>(type: "int", nullable: false),
                    EnableListView = table.Column<int>(type: "int", nullable: false),
                    EnableTradeView = table.Column<int>(type: "int", nullable: false),
                    ApplyVATtoDelivery = table.Column<bool>(type: "bit", nullable: false),
                    EnableAnotherAddress = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryNoteDispatchCutOff = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryNoteDispatchCutOffTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    DeliveryNoteFutureDeliveryDate = table.Column<bool>(type: "bit", nullable: false),
                    ShowSaveAmount = table.Column<bool>(type: "bit", nullable: false),
                    DetailpageLayout = table.Column<byte>(type: "tinyint", nullable: false),
                    AllowEditingDeliveryAddressONCheckout = table.Column<bool>(type: "bit", nullable: false),
                    EnableTotalUnit = table.Column<bool>(type: "bit", nullable: false),
                    NoDeliveryChoiceMessage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnableOrderSplit = table.Column<bool>(type: "bit", nullable: true),
                    DeliveryNoteComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BingWebmasterTrackingId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EnableCheckoutEmailAddress = table.Column<byte>(type: "tinyint", nullable: false),
                    ShowQtyAsQuantityStock = table.Column<bool>(type: "bit", nullable: true),
                    CalculateDefaultPrice = table.Column<bool>(type: "bit", nullable: false),
                    Productlistlayout = table.Column<byte>(type: "tinyint", nullable: false),
                    EnableMultiWarehouse = table.Column<bool>(type: "bit", nullable: false),
                    EnableEmailInvoice = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceTemplate = table.Column<int>(type: "int", nullable: false),
                    ShowDeliveryAddressonQuote = table.Column<bool>(type: "bit", nullable: false),
                    LoginPageURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnableCustomerDueStock = table.Column<bool>(type: "bit", nullable: false),
                    DueStockQty = table.Column<int>(type: "int", nullable: false),
                    InStockColour = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    OutofStockColour = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DueStockColour = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ShowFromPrice = table.Column<int>(type: "int", nullable: false),
                    Favourites_BeforLogin = table.Column<bool>(type: "bit", nullable: false),
                    Favourites_AfterLogin = table.Column<bool>(type: "bit", nullable: false),
                    ShowCategoryImagesOnLandingPage = table.Column<bool>(type: "bit", nullable: false),
                    ShipingTax = table.Column<long>(type: "bigint", nullable: true),
                    DisableSubTotal = table.Column<bool>(type: "bit", nullable: false),
                    ProductVatMethod = table.Column<int>(type: "int", nullable: false),
                    SupCatBgColorCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RRPcurrency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShowRRP = table.Column<bool>(type: "bit", nullable: false),
                    ShowRRP1 = table.Column<bool>(type: "bit", nullable: false),
                    ProductIframeZoom = table.Column<int>(type: "int", nullable: false),
                    Detailpagetextcolor1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Detailpagetextcolor2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Detailpagetextcolor3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Tabbottombordercolour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DisablePriceUpdateOnBasket = table.Column<bool>(type: "bit", nullable: false),
                    EnableBranchName = table.Column<bool>(type: "bit", nullable: false),
                    QuoteEmailAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MiniBasket = table.Column<int>(type: "int", nullable: false),
                    TransparentHeader = table.Column<bool>(type: "bit", nullable: false),
                    InvoicePaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnablePaymentOfInvoices = table.Column<bool>(type: "bit", nullable: false),
                    PartialPaymentOrder = table.Column<int>(type: "int", nullable: false),
                    EnableAccountAgedDebt = table.Column<bool>(type: "bit", nullable: false),
                    BusinessDays = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DisableLineLevelDeliveryDate = table.Column<bool>(type: "bit", nullable: false),
                    EnableLinkMultiAccount = table.Column<bool>(type: "bit", nullable: false),
                    BackOrderText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnableTrustedShops = table.Column<bool>(type: "bit", nullable: false),
                    TrustedShops = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShowMaxOrderQtyOnProductDetailPage = table.Column<bool>(type: "bit", nullable: false),
                    PersonalisedLandingPages = table.Column<bool>(type: "bit", nullable: false),
                    DefaultCustomRegistrationForm = table.Column<bool>(type: "bit", nullable: false),
                    EnablePersonalisation = table.Column<bool>(type: "bit", nullable: false),
                    IsQuickorderAutocomplete = table.Column<bool>(type: "bit", nullable: true),
                    CustomiseSearchText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnableCompanyMandatory = table.Column<int>(type: "int", nullable: true),
                    EnableDeliveryAddressEmails = table.Column<bool>(type: "bit", nullable: false),
                    EnableFinalDestination = table.Column<bool>(type: "bit", nullable: true),
                    Trade_View_Attribute_ID = table.Column<int>(type: "int", nullable: true),
                    IsQuotesOnly = table.Column<bool>(type: "bit", nullable: true),
                    EnableNewInvoice = table.Column<bool>(type: "bit", nullable: false),
                    EnableCheckoutquestion = table.Column<bool>(type: "bit", nullable: true),
                    Checkoutmessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnableProductSKU = table.Column<bool>(type: "bit", nullable: false),
                    EnableProductName = table.Column<bool>(type: "bit", nullable: false),
                    AttributeTabText = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Documentation = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EnableDropShipemailsforQuotes = table.Column<bool>(type: "bit", nullable: true),
                    DateFormat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactUsPopUp = table.Column<bool>(type: "bit", nullable: false),
                    CustomContactUsField = table.Column<bool>(type: "bit", nullable: false),
                    AllowRegistration = table.Column<bool>(type: "bit", nullable: false),
                    EnableCustomerQuestion = table.Column<bool>(type: "bit", nullable: false),
                    EnableProductLedger = table.Column<bool>(type: "bit", nullable: false),
                    EnableHotJarAnalytics = table.Column<bool>(type: "bit", nullable: false),
                    SearchableFields = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    HotjarTrackingCodeID = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HotjarSnippetVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackOrderTextColour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShowDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnablePrintBasket = table.Column<bool>(type: "bit", nullable: false),
                    EnableAttributeTab = table.Column<bool>(type: "bit", nullable: true),
                    VideoTabText = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Gridpagesize = table.Column<int>(type: "int", nullable: true),
                    GridLayoutColour1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GridLayoutColour2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PaymentMethodPrices = table.Column<bool>(type: "bit", nullable: false),
                    EnableCommaSeperatedNumbers = table.Column<bool>(type: "bit", nullable: false),
                    InvoicesManageAvailableBalance = table.Column<bool>(type: "bit", nullable: true),
                    SoftCreditLimitMessages = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    hardCreditLimitMessages = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnableTermlyCookie = table.Column<bool>(type: "bit", nullable: false),
                    TermlyCookieEmbedId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TermlyManageCookiePreferencesLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShowAvailableBlanceChckout = table.Column<bool>(type: "bit", nullable: true),
                    GridViewAttributeDisplay = table.Column<int>(type: "int", nullable: true),
                    EnablePAFIntegration = table.Column<bool>(type: "bit", nullable: false),
                    PAFIntegrationService = table.Column<int>(type: "int", nullable: false),
                    CreateCustomerRecord = table.Column<bool>(type: "bit", nullable: false),
                    EnableQtyChangeAtCheckout = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceType = table.Column<int>(type: "int", nullable: false),
                    InvoiceAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDocName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoiceCompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InvoiceAdd1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InvoiceAdd2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InvoiceCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoiceCounty = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoicePostCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoiceVatNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoiceTel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoiceFax = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnableFeefoReview = table.Column<bool>(type: "bit", maxLength: 100, nullable: false),
                    MerchantIdentifier = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PricingColour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EnableDonations = table.Column<bool>(type: "bit", nullable: false),
                    DonationsSKU = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DonationsItemDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DonationsSectionText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CategoryLayoutOption = table.Column<int>(type: "int", nullable: false),
                    RestrictCategoryListview = table.Column<bool>(type: "bit", nullable: false),
                    EnableRelatedWhenOutOfStock = table.Column<bool>(type: "bit", nullable: false),
                    ChannableImport = table.Column<bool>(type: "bit", nullable: false),
                    ChannableURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannableToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannableFrequency = table.Column<int>(type: "int", nullable: false),
                    CheckoutPageType = table.Column<byte>(type: "tinyint", nullable: false),
                    SelectCreditBalance = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImagesLayout = table.Column<byte>(type: "tinyint", nullable: true),
                    ShowSKUCodeOnDetail = table.Column<bool>(type: "bit", nullable: true),
                    ShowCategoryDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnableSelfVATExemption = table.Column<bool>(type: "bit", nullable: false),
                    SelfVATExemptionComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GridAddToBasket = table.Column<bool>(type: "bit", nullable: false),
                    GridImage = table.Column<int>(type: "int", nullable: false),
                    DonationGiftAidText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DonationAccountType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnableFreeDeliveryCalculation = table.Column<bool>(type: "bit", nullable: true),
                    EnablePersonalisationMultipleQty = table.Column<bool>(type: "bit", nullable: false),
                    reCaptchaSiteKey = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    reCaptchaSecretKey = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    DisplayCategoryAltImages = table.Column<bool>(type: "bit", nullable: true),
                    EnableCategoryStockQty = table.Column<bool>(type: "bit", nullable: true),
                    DeliverToBillAddress = table.Column<bool>(type: "bit", nullable: false),
                    CheckoutMessage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPinchToZoom = table.Column<bool>(type: "bit", nullable: false),
                    IsRegistrationActive = table.Column<bool>(type: "bit", nullable: false),
                    EnableDescriptionsPhoneOrders = table.Column<bool>(type: "bit", nullable: true),
                    PhoneOrderDescriptionOptions = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CustomerAmendCreditLimit = table.Column<bool>(type: "bit", nullable: false),
                    IsAltTextBlank = table.Column<bool>(type: "bit", nullable: false),
                    AddToBasketPosition = table.Column<int>(type: "int", nullable: true),
                    IsMultiLocationWarning = table.Column<bool>(type: "bit", nullable: false),
                    MultiLocationWarningMsg = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnableMenuDefaultExpanded = table.Column<bool>(type: "bit", nullable: false),
                    EnableGridViewSetting = table.Column<bool>(type: "bit", nullable: false),
                    EnableTradeViewSetting = table.Column<bool>(type: "bit", nullable: false),
                    Ishoverbasket = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableShipperHQ = table.Column<bool>(type: "bit", nullable: false),
                    EnableYourPrice = table.Column<bool>(type: "bit", nullable: true),
                    HeaderBannerAltText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    reCaptchaSiteKeyV2 = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    EnablePartFinder = table.Column<bool>(type: "bit", nullable: false),
                    ShowCollectionAddress = table.Column<bool>(type: "bit", nullable: false),
                    V2FallbackScoreLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    reCaptchaSecretKeyV2 = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    SiteNoImageAltText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AnchorLayout = table.Column<bool>(type: "bit", nullable: false),
                    DefaultAutoCategorySortingOrder = table.Column<long>(type: "bigint", nullable: false),
                    OverrideDefaultChecksonBasket = table.Column<bool>(type: "bit", nullable: false),
                    GridViewAttributeDisplay1 = table.Column<int>(type: "int", nullable: false),
                    ShowFromPrice1 = table.Column<int>(type: "int", nullable: false),
                    GridAddToBasket1 = table.Column<bool>(type: "bit", nullable: false),
                    GridImage1 = table.Column<int>(type: "int", nullable: false),
                    ExportTradeView = table.Column<bool>(type: "bit", nullable: false),
                    EnableViewBasketButton = table.Column<bool>(type: "bit", nullable: false),
                    PAFIntegrationResult = table.Column<int>(type: "int", nullable: false),
                    EnableExtendedUOS = table.Column<bool>(type: "bit", nullable: false),
                    BasketPersonalisationDisplay = table.Column<bool>(type: "bit", nullable: false),
                    EnableSyrenisCookie = table.Column<bool>(type: "bit", nullable: false),
                    SyrenisCookieLicenseID = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SyrenisCookieAccessKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SyrenisCookieStyleSheet = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DeliveryAddressZoneDefault = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableCreditHoldMsgBanner = table.Column<bool>(type: "bit", nullable: false),
                    EnablePreLoad = table.Column<bool>(type: "bit", nullable: false),
                    BackOrderSetting = table.Column<int>(type: "int", nullable: false),
                    HideOrderButtons = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CatDescTextColor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EnableCirrusCallRecording = table.Column<bool>(type: "bit", nullable: false),
                    CirrusUsername = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CirrusPassword = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DeliveryBreakdownLevel = table.Column<bool>(type: "bit", nullable: false),
                    TopRowIsDefault = table.Column<bool>(type: "bit", nullable: false),
                    ProductTitleColour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TitleTextSize = table.Column<int>(type: "int", nullable: false),
                    SelectedTabColour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TableHeaderBackgroundColour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TableHeaderTextColour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreditHoldBannerMsg = table.Column<int>(type: "int", nullable: false),
                    AttributeFilterView = table.Column<int>(type: "int", nullable: false),
                    SeenCheaperPrice = table.Column<bool>(type: "bit", nullable: false),
                    TaxCalculationDecimalPlaces = table.Column<int>(type: "int", nullable: false),
                    EnableCustomerRegistration = table.Column<bool>(type: "bit", nullable: false),
                    SiteUnderMaintenance = table.Column<bool>(type: "bit", nullable: false),
                    PredictiveSearchAttribute = table.Column<int>(type: "int", nullable: false),
                    EnableMyAccountSalesRep = table.Column<bool>(type: "bit", nullable: false),
                    beforeFromPriceColor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    afterFromPriceColor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EnableCivicCookie = table.Column<bool>(type: "bit", nullable: false),
                    CivicCookieAPIKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CivicCookieProduct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AllowPopularSearchesAndLastUserSearches = table.Column<bool>(type: "bit", nullable: false),
                    SuperClassURL = table.Column<bool>(type: "bit", nullable: false),
                    EnableDedicatedBrandsPage = table.Column<bool>(type: "bit", nullable: false),
                    AddtoBasketNotification = table.Column<bool>(type: "bit", nullable: false),
                    StockMessageLocation = table.Column<int>(type: "int", nullable: false),
                    OrderReceiptPaymentType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FinalDestinationEmail = table.Column<bool>(type: "bit", nullable: false),
                    ShowEmail_CallUs = table.Column<bool>(type: "bit", nullable: false),
                    ProductDescription5Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductDescription6Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShowInBasketQuantity = table.Column<bool>(type: "bit", nullable: false),
                    EnablePaidonResults = table.Column<bool>(type: "bit", nullable: false),
                    MerchantId_Paidon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FooterScript_PaidonResult = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TransactionalEmail_DownloadableProduct = table.Column<bool>(type: "bit", nullable: false),
                    OrderMin_MaxErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultipleCollectionLocation = table.Column<bool>(type: "bit", nullable: false),
                    EnhancedErrorValidation = table.Column<bool>(type: "bit", nullable: false),
                    HeaderScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUseStockStatusLabel = table.Column<bool>(type: "bit", nullable: false),
                    BasketArchive = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EnableBackOrderMessage = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryDateAlertMessage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SelectedBrandDirectory = table.Column<int>(type: "int", nullable: false),
                    IsEnableDeliveryByOrderPercentage = table.Column<bool>(type: "bit", nullable: false),
                    PercentageDeliveryCharge_Type = table.Column<bool>(type: "bit", nullable: false),
                    EnableInvoiceOrderComments = table.Column<bool>(type: "bit", nullable: false),
                    CurrencySymbol = table.Column<bool>(type: "bit", nullable: false),
                    MultiProductImagesOption = table.Column<bool>(type: "bit", nullable: false),
                    EnableAgedDebtTable = table.Column<bool>(type: "bit", nullable: false),
                    EnableAgedDebtBreakdown = table.Column<bool>(type: "bit", nullable: false),
                    AgedDebtBreakdownItems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCurrentPasswordRequired = table.Column<bool>(type: "bit", nullable: false),
                    EnableLoyaltyLedger = table.Column<bool>(type: "bit", nullable: false),
                    EnableRedeemPaymentMethod = table.Column<bool>(type: "bit", nullable: false),
                    RedeemPaymentMethod = table.Column<int>(type: "int", nullable: false),
                    EnablePointsAwardInCloudfy = table.Column<bool>(type: "bit", nullable: false),
                    PointsDefaultExpiryPeriod = table.Column<int>(type: "int", nullable: false),
                    PointsDefaultExpiryPeriodType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FTPUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPBaseRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockReduction = table.Column<int>(type: "int", nullable: false),
                    DropShipmentSplit = table.Column<int>(type: "int", nullable: false),
                    BrandPageTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BrandPageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BrandPageDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsMobileAppLoginAccess = table.Column<int>(type: "int", nullable: false),
                    EnableSortingGrid = table.Column<bool>(type: "bit", nullable: false),
                    ExternalRefFieldforOrderNumber = table.Column<bool>(type: "bit", nullable: false),
                    LoginToSeePriceText = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Calculateshowoftoplevelmenu = table.Column<bool>(type: "bit", nullable: false),
                    EnableLoyaltyPointsToVoucher = table.Column<bool>(type: "bit", nullable: false),
                    StaticPageSearch = table.Column<bool>(type: "bit", nullable: false),
                    ProductLayouts_ProductType = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObjectId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenuMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenuMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMenuMaster_MenuMaster_MenuId",
                        column: x => x.MenuId,
                        principalTable: "MenuMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuMaster_ParentId",
                table: "MenuMaster",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuMaster_MenuId",
                table: "RoleMenuMaster",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditTrails",
                schema: "Auditing");

            migrationBuilder.DropTable(
                name: "Emaillog");

            migrationBuilder.DropTable(
                name: "EmailSend");

            migrationBuilder.DropTable(
                name: "LogException");

            migrationBuilder.DropTable(
                name: "LoginAttempt",
                schema: "Auditing");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "RoleMenuMaster");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "MenuMaster");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Identity");
        }
    }
}
