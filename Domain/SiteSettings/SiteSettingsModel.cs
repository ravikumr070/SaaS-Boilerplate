using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SiteSettings;
public class SiteSettingsModel : AuditableEntity, IAggregateRoot
{
    public long Id { get; private set; }
    public long settingsID { get; private set; }
    public long? SiteId { get; private set; }
    [StringLength(500)]
    public string? SitePhoneNumber { get; private set; }
    [StringLength(500)]
    public string? SiteCompanyAddress { get; private set; }
    [StringLength(500)]
    public string? ContactUsEmailAddress { get; private set; }
    [StringLength(500)]
    public string? OrdersEmailAddress { get; private set; }
    [StringLength(500)]
    public string? TwitterURL { get; private set; }
    [StringLength(500)]
    public string? FacebookURL { get; private set; }
    [StringLength(500)]
    public string? InstagramURL { get; private set; }
    [StringLength(500)]
    public string? MinimumOrderValue { get; private set; }
    [StringLength(500)]
    public string? FreeDeliveryLevel { get; private set; }
    [StringLength(500)]
    public string? GoogleAnalyticsTrackingID { get; private set; }
    [StringLength(500)]
    public string? EmailBCC { get; private set; }
    [StringLength(250)]
    public string? RegistrationNo { get; private set; }
    public string? EmailFooter { get; private set; }
    public string? SiteLogo { get; private set; }
    public string? SiteFavicon { get; private set; }
    public string? HeaderBanner { get; private set; }
    public string? RetailPriceLabel { get; private set; }
    public string? TradePriceLabel { get; private set; }
    public bool? SKU { get; private set; }
    public bool? STOCK { get; private set; }
    public bool? QTYADD { get; private set; }
    public bool? REVIEWS { get; private set; }
    public bool? CASEQTY { get; private set; }
    public bool? QTYBREAK { get; private set; }
    [StringLength(50)]
    public string? RetailPriceLabel1 { get; private set; }
    [StringLength(50)]
    public string? TradePriceLabel1 { get; private set; }
    public bool? SKU1 { get; private set; }
    public bool? STOCK1 { get; private set; }
    public bool? QTYADD1 { get; private set; }
    public bool? REVIEWS1 { get; private set; }
    public bool? CASEQTY1 { get; private set; }
    public bool? QTYBREAK1 { get; private set; }
    public bool? EnableDemoStoreMessage { get; private set; }
    public bool? CreateTradeAccountLogin { get; private set; }
    public bool? EnableLiveChat { get; private set; }
    public string? ZoopimScript { get; private set; }
    public bool? EnableReviews { get; private set; }
    public bool? EnableGuestCheckout { get; private set; }
    public bool? CurencyConversion { get; private set; }
    public string? MageMenuPromotionalMessage { get; private set; }
    public bool? ShowHomeLink { get; private set; }
    public int? CategoryMenuCount { get; private set; }
    public bool? EnablePredictiveSearch { get; private set; }
    public bool? EnableSuperClass { get; private set; }
    public bool? AllowOrder { get; private set; }
    public short? selectedtab { get; private set; }
    public bool? ShowBarcode { get; private set; }
    [StringLength(50)]
    public string? UnitForSize { get; private set; }
    [StringLength(50)]
    public string? UnitForWeight { get; private set; }
    public bool? ShowRRPWithoutLogin { get; private set; }
    public bool? ShowRRPWithStrike { get; private set; }
    public bool? ShowPriceWithoutLogin { get; private set; }
    public bool? EnableOnCollection { get; private set; }
    public bool? IsVatApplicable { get; private set; }
    public int? DeiveryRestrictedBy { get; private set; }
    public bool? EnableBestSellers { get; private set; }
    public bool? EnableLatestProducts { get; private set; }
    public bool? EnableSpecialOffers { get; private set; }
    public bool? EnableDeliveryDate { get; private set; }
    [StringLength(100)]
    public string? DeliveryDateLabel { get; private set; }
    public bool? ShowOutOfStockItem { get; private set; }
    public bool? Ordertype { get; private set; }
    public bool? ShowStockDueDate { get; private set; }
    public bool? ShowCatBannerHeading { get; private set; }
    public bool? EnableGoogleTranslater { get; private set; }
    [StringLength(500)]
    public string? LinkedInURL { get; private set; }
    [StringLength(500)]

    public string? YoutubeURL { get; private set; }
    [StringLength(500)]
    public string? PrinterestURL { get; private set; }
    public bool? EmableMultipleCurrency { get; private set; }
    public bool? EnableMinimumOrderByCountry { get; private set; }
    public bool? EnableMultipleSKU { get; private set; }
    public string? ReportLogo { get; private set; }
    public bool? EnableExistingCustomer { get; private set; }
    public bool? EnablePaymentLimit { get; private set; }
    public long? DefaultSortingField { get; private set; }
    public bool? IsBestSellersFromAdmin { get; private set; }
    public bool? IsLatestProductsFromAdmin { get; private set; }
    public bool? IsSpecialOffersFromAdmin { get; private set; }
    public bool? IsImageCompressed { get; private set; }
    [StringLength(100)]
    public string? Mailchimp_listid { get; private set; }
    [StringLength(250)]
    public string? Mailchimp_apiKey { get; private set; }
    public bool? SubscribeMailchimp { get; private set; }
    public bool? EnableRoundleOnDetails { get; private set; }
    public bool? IsNewLayout { get; private set; }
    public bool? IsUpdated { get; private set; }
    public bool? ChekoutEditableAddr { get; private set; }
    public bool? EnablePendingBasketMail { get; private set; }
    public int? setDurationAfterAddedbasket { get; private set; }
    public DateTime? LastSendingMail { get; private set; }
    public bool? DeliveryAddressAtLogin { get; private set; }

    public string? DemoStoreMessage { get; private set; }
    [StringLength(250)]

    public string? DemoStoreMessageLink { get; private set; }
    public bool? EnablepriceFilter { get; private set; }
    public bool? EnableRightClick { get; private set; }
    public string? WelcomeMessageAfterLogin { get; private set; }
    public bool? EnableFooterSiteMapLink { get; private set; }
    public bool? EnableFooterNewsLink { get; private set; }
    public bool? EnableStockQty { get; private set; }
    public bool? EnableNewsforInactiveCus { get; private set; }
    public int? DeliveryOptionMethod { get; private set; }
    public bool? DeliveryOption { get; private set; }
    public bool? EnableCustomerAlsoBoughtFeature { get; private set; }
    public bool? EnableAbandonedMailfeature { get; private set; }
    [StringLength(350)]

    public string? CopyrightText { get; private set; }
    public bool? EnableProductSocialShring { get; private set; }
    public bool? IsNextDayDelivery { get; private set; }
    public bool EnableEmailBackInStock { get; private set; }
    [StringLength(250)]

    public string TagManagerTrackingId { get; private set; }
    public bool? IsSavedBasket { get; private set; }
    public bool? MinOrderExvat { get; private set; }
    [StringLength(10)]

    public string? CalculateVatFrom { get; private set; }
    [StringLength(250)]

    public string? Brand { get; private set; }
    public bool? EnableCallForPrice { get; private set; }
    public bool? EnableDownloadTab { get; private set; }
    [StringLength(200)]

    public string? DownloadTabOption { get; private set; }
    public bool? HideCategoryImage { get; private set; }
    public bool? GoogleLangSwitchPosition { get; private set; }
    public bool? EnableReserveStock { get; private set; }
    public decimal? ReserveStockLevel { get; private set; }
    public bool? EnableFooterEventsLink { get; private set; }
    public bool? EnableStockManagement { get; private set; }
    [StringLength(50)]

    public string? Vat { get; private set; }
    public bool? GoogleCustomerReviews { get; private set; }
    public bool? ShowProductInMenu { get; private set; }
    [StringLength(250)]

    public string? VimeoLink { get; private set; }
    public bool? CurrencyConversion_BeforeLogin { get; private set; }
    public bool? CurrencyConversion_AfterLogin { get; private set; }
    public bool? ShowTwoProductInCategoryView { get; private set; }
    [StringLength(200)]

    public string? ProductZoom { get; private set; }
    public bool? isShowFooterPaymentLogo { get; private set; }
    public bool? IsEnableProductReviewsEmailReminder { get; private set; }
    [StringLength(20)]

    public string? ProductDetail { get; private set; }
    [StringLength(20)]

    public string? Delivery { get; private set; }
    [StringLength(20)]

    public string? Materials { get; private set; }
    public bool EnableBuyOutOfStock { get; private set; }
    public int? HeaderMenuType { get; private set; }
    public bool EnableWareHouse { get; private set; }
    public byte? EnableSalesRepCode { get; private set; }
    public bool? EnableCustomerSpecificeCatalogue { get; private set; }
    public bool? IsCustomerEncrypted { get; private set; }
    public bool? HideDeliveryChangeFromCheckout { get; private set; }
    public bool? HideVoucherCode { get; private set; }
    public bool? showmSellerOrder { get; private set; }
    public bool? EnableMultiLanguage { get; private set; }
    public bool? EnablePunchout { get; private set; }
    public bool? EnableLocalTax { get; private set; }
    public bool EnableYotpoReviews { get; private set; }
    public bool EnableVatverification { get; private set; }
    public int? BaseCountry { get; private set; }
    public bool? EnableQuickOrder { get; private set; }
    public bool? IsOfferPriceFromProduct { get; private set; }
    public bool? EnableDownloadOrdersProductImages { get; private set; }
    public bool? IsEnableCapitalisationOnSite { get; private set; }
    public bool ShowStockStatusFilter { get; private set; }
    public bool EnableComments { get; private set; }
    [StringLength(200)]

    public string? GooglePlusLink { get; private set; }
    public bool IsEnableNewExtendingDelivery { get; private set; }
    public bool ShowDeliveryBreakdown { get; private set; }
    public int? PrioritySetting { get; private set; }
    public int? BasketCheckoutAlert { get; private set; }
    [StringLength(2000)]

    public string? BasketCheckoutAlertText { get; private set; }
    [StringLength(2000)]

    public string? NonSaleableMessage { get; private set; }
    public bool EnableUserType { get; private set; }
    public bool EnableSpendLimits { get; private set; }
    public bool EnableAuthorisationOnly { get; private set; }
    public int? LimitingPredictiveSearch { get; private set; }
    public bool? ShowThumbnailWithPredictiveSearch { get; private set; }
    [StringLength(250)]

    public string? FacebookTrackingID { get; private set; }
    public bool IsBespokeMenuEnabled { get; private set; }
    public bool SortCategoryByAlphabetically { get; private set; }
    public bool EnableCustomerRef { get; private set; }
    public int? PriceDecimalPlace { get; private set; }
    public bool? EnableCheckoutBillAddress { get; private set; }
    public bool? ShowPriceIncVat { get; private set; }
    public bool? ShowPriceIncVat1 { get; private set; }
    public bool? ShowDualPrices { get; private set; }

    public string? PageBuilderFontsFiles { get; private set; }
    [StringLength(250)]

    public string? PageBuilderCSSFiles { get; private set; }
    [StringLength(250)]

    public string? PageBuilderJSFiles { get; private set; }
    public bool DisableLineLevelPO { get; private set; }
    public int? Site404Page { get; private set; }
    [StringLength(100)]

    public string? GoogleMapApiKey { get; private set; }
    [StringLength(50)]

    public string? IndexRankLabel { get; private set; }
    public int? DefaultSearchSortingOrder { get; private set; }
    public bool EnableCustomerSpecificeProducts { get; private set; }
    public int? LayoutSelection { get; private set; }
    public bool CalculatedUnitsGridRestricted { get; private set; }
    public bool EnableRMARequests { get; private set; }
    public int CustomerCatalogueMode { get; private set; }
    public bool EnableBundleQty { get; private set; }
    public bool EnableDualPrice { get; private set; }
    public bool CategoryViewDropdownVarients { get; private set; }
    public bool EnableProductSKUBasket { get; private set; }
    [StringLength(15)]

    public string LiveChatVisibility { get; private set; }
    [StringLength(100)]

    public string? CalculatedUnits { get; private set; }
    public int EnableGridView { get; private set; }
    public int EnableListView { get; private set; }
    public int EnableTradeView { get; private set; }
    public bool ApplyVATtoDelivery { get; private set; }
    public bool EnableAnotherAddress { get; private set; }
    public bool DeliveryNoteDispatchCutOff { get; private set; }
    public TimeSpan? DeliveryNoteDispatchCutOffTime { get; private set; }
    public bool DeliveryNoteFutureDeliveryDate { get; private set; }
    public bool ShowSaveAmount { get; private set; }
    public byte DetailpageLayout { get; private set; }
    public bool AllowEditingDeliveryAddressONCheckout { get; private set; }

    public bool EnableTotalUnit { get; private set; }
    [StringLength(50)]

    public string? NoDeliveryChoiceMessage { get; private set; }
    public bool? EnableOrderSplit { get; private set; }

    public string? DeliveryNoteComment { get; private set; }
    [StringLength(250)]

    public string? BingWebmasterTrackingId { get; private set; }
    public byte EnableCheckoutEmailAddress { get; private set; }
    public bool? ShowQtyAsQuantityStock { get; private set; }
    public bool CalculateDefaultPrice { get; private set; }
    public byte Productlistlayout { get; private set; }
    public bool EnableMultiWarehouse { get; private set; }
    public bool EnableEmailInvoice { get; private set; }
    public int InvoiceTemplate { get; private set; }
    public bool ShowDeliveryAddressonQuote { get; private set; }
    [StringLength(500)]

    public string? LoginPageURL { get; private set; }
    public bool EnableCustomerDueStock { get; private set; }
    public int DueStockQty { get; private set; }
    [StringLength(25)]

    public string? InStockColour { get; private set; }
    [StringLength(25)]

    public string? OutofStockColour { get; private set; }
    [StringLength(25)]

    public string? DueStockColour { get; private set; }
    public int ShowFromPrice { get; private set; }
    public bool Favourites_BeforLogin { get; private set; }
    public bool Favourites_AfterLogin { get; private set; }
    public bool ShowCategoryImagesOnLandingPage { get; private set; }
    public long? ShipingTax { get; private set; }
    public bool DisableSubTotal { get; private set; }
    public int ProductVatMethod { get; private set; }
    [StringLength(100)]

    public string? SupCatBgColorCode { get; private set; }
    [StringLength(50)]

    public string? RRPcurrency { get; private set; }
    public bool ShowRRP { get; private set; }
    public bool ShowRRP1 { get; private set; }
    public int ProductIframeZoom { get; private set; }
    [StringLength(20)]

    public string? Detailpagetextcolor1 { get; private set; }
    [StringLength(20)]

    public string? Detailpagetextcolor2 { get; private set; }
    [StringLength(20)]


    public string? Detailpagetextcolor3 { get; private set; }
    [StringLength(20)]

    public string? Tabbottombordercolour { get; private set; }
    public bool DisablePriceUpdateOnBasket { get; private set; }
    public bool EnableBranchName { get; private set; }
    [StringLength(500)]

    public string? QuoteEmailAddress { get; private set; }
    public int MiniBasket { get; private set; }
    public bool TransparentHeader { get; private set; }
    [StringLength(50)]

    public string? InvoicePaymentType { get; private set; }
    public bool EnablePaymentOfInvoices { get; private set; }
    public int PartialPaymentOrder { get; private set; }
    public bool EnableAccountAgedDebt { get; private set; }
    [StringLength(500)]

    public string? BusinessDays { get; private set; }
    public bool DisableLineLevelDeliveryDate { get; private set; }
    public bool EnableLinkMultiAccount { get; private set; }
    [StringLength(100)]

    public string? BackOrderText { get; private set; }
    public bool EnableTrustedShops { get; private set; }
    [StringLength(200)]

    public string? TrustedShops { get; private set; }
    public bool ShowMaxOrderQtyOnProductDetailPage { get; private set; }
    public bool PersonalisedLandingPages { get; private set; }
    public bool DefaultCustomRegistrationForm { get; private set; }
    public bool EnablePersonalisation { get; private set; }
    public bool? IsQuickorderAutocomplete { get; private set; }
    [StringLength(100)]

    public string? CustomiseSearchText { get; private set; }
    public int? EnableCompanyMandatory { get; private set; }
    public bool EnableDeliveryAddressEmails { get; private set; }
    public bool? EnableFinalDestination { get; private set; }
    public int? Trade_View_Attribute_ID { get; private set; }
    public bool? IsQuotesOnly { get; private set; }
    public bool EnableNewInvoice { get; private set; }
    public bool? EnableCheckoutquestion { get; private set; }
    [StringLength(500)]

    public string? Checkoutmessage { get; private set; }
    public bool EnableProductSKU { get; private set; }
    public bool EnableProductName { get; private set; }
    [StringLength(25)]

    public string? AttributeTabText { get; private set; }
    [StringLength(25)]

    public string? Documentation { get; private set; }
    public bool? EnableDropShipemailsforQuotes { get; private set; }
    [StringLength(100)]

    public string? DateFormat { get; private set; }
    public bool ContactUsPopUp { get; private set; }
    public bool CustomContactUsField { get; private set; }
    public bool AllowRegistration { get; private set; }
    public bool EnableCustomerQuestion { get; private set; }
    public bool EnableProductLedger { get; private set; }
    public bool EnableHotJarAnalytics { get; private set; }
    [StringLength(1000)]

    public string? SearchableFields { get; private set; }
    [StringLength(150)]

    public string? HotjarTrackingCodeID { get; private set; }
    [StringLength(50)]

    public string? HotjarSnippetVersion { get; private set; }
    [StringLength(20)]

    public string? BackOrderTextColour { get; private set; }
    [StringLength(100)]

    public string? ShowDescription { get; private set; }
    public bool EnablePrintBasket { get; private set; }
    public bool? EnableAttributeTab { get; private set; }
    [StringLength(25)]

    public string? VideoTabText { get; private set; }
    public int? Gridpagesize { get; private set; }
    [StringLength(15)]

    public string? GridLayoutColour1 { get; private set; }
    [StringLength(15)]

    public string? GridLayoutColour2 { get; private set; }
    public bool PaymentMethodPrices { get; private set; }
    public bool EnableCommaSeperatedNumbers { get; private set; }
    public bool? InvoicesManageAvailableBalance { get; private set; }
    [StringLength(500)]

    public string? SoftCreditLimitMessages { get; private set; }
    [StringLength(500)]

    public string? hardCreditLimitMessages { get; private set; }
    public bool EnableTermlyCookie { get; private set; }
    [StringLength(500)]

    public string? TermlyCookieEmbedId { get; private set; }
    [StringLength(50)]

    public string? TermlyManageCookiePreferencesLocation { get; private set; }
    public bool? ShowAvailableBlanceChckout { get; private set; }
    public int? GridViewAttributeDisplay { get; private set; }
    public bool EnablePAFIntegration { get; private set; }
    public int PAFIntegrationService { get; private set; }
    public bool CreateCustomerRecord { get; private set; }
    public bool EnableQtyChangeAtCheckout { get; private set; }
    public int InvoiceType { get; private set; }

    public string? InvoiceAdditionalInfo { get; private set; }
    [StringLength(100)]

    public string? InvoiceDocName { get; private set; }
    [StringLength(200)]

    public string? InvoiceCompanyName { get; private set; }
    [StringLength(500)]

    public string? InvoiceAdd1 { get; private set; }
    [StringLength(500)]

    public string? InvoiceAdd2 { get; private set; }
    [StringLength(100)]

    public string? InvoiceCity { get; private set; }
    [StringLength(100)]

    public string? InvoiceCounty { get; private set; }
    [StringLength(100)]

    public string? InvoicePostCode { get; private set; }
    [StringLength(100)]

    public string? InvoiceVatNo { get; private set; }
    [StringLength(100)]

    public string? InvoiceTel { get; private set; }
    [StringLength(100)]

    public string? InvoiceFax { get; private set; }
    [StringLength(100)]

    public bool EnableFeefoReview { get; private set; }
    [StringLength(250)]

    public string? MerchantIdentifier { get; private set; }
    [StringLength(20)]

    public string? PricingColour { get; private set; }
    public bool EnableDonations { get; private set; }
    [StringLength(200)]

    public string? DonationsSKU { get; private set; }
    [StringLength(500)]

    public string? DonationsItemDescription { get; private set; }
    [StringLength(200)]

    public string? DonationsSectionText { get; private set; }
    public int CategoryLayoutOption { get; private set; }
    public bool RestrictCategoryListview { get; private set; }
    public bool EnableRelatedWhenOutOfStock { get; private set; }
    public bool ChannableImport { get; private set; }

    public string? ChannableURL { get; private set; }
    public string? ChannableToken { get; private set; }
    public int ChannableFrequency { get; private set; }
    public byte CheckoutPageType { get; private set; }
    [StringLength(200)]

    public string? SelectCreditBalance { get; private set; }
    public byte? ImagesLayout { get; private set; }
    public bool? ShowSKUCodeOnDetail { get; private set; }
    [StringLength(50)]

    public string? ShowCategoryDescription { get; private set; }
    public bool EnableSelfVATExemption { get; private set; }


    public string? SelfVATExemptionComment { get; private set; }
    public bool GridAddToBasket { get; private set; }
    public int GridImage { get; private set; }
    [StringLength(500)]

    public string? DonationGiftAidText { get; private set; }
    [StringLength(100)]

    public string? DonationAccountType { get; private set; }
    public bool? EnableFreeDeliveryCalculation { get; private set; }
    public bool EnablePersonalisationMultipleQty { get; private set; }
    [StringLength(350)]

    public string? reCaptchaSiteKey { get; private set; }
    [StringLength(350)]

    public string? reCaptchaSecretKey { get; private set; }
    public bool? DisplayCategoryAltImages { get; private set; }
    public bool? EnableCategoryStockQty { get; private set; }
    public bool DeliverToBillAddress { get; private set; }

    public string? CheckoutMessage2 { get; private set; }
    public bool IsPinchToZoom { get; private set; }
    public bool IsRegistrationActive { get; private set; }
    public bool? EnableDescriptionsPhoneOrders { get; private set; }
    [StringLength(250)]

    public string? PhoneOrderDescriptionOptions { get; private set; }
    public bool CustomerAmendCreditLimit { get; private set; }
    public bool IsAltTextBlank { get; private set; }
    public int? AddToBasketPosition { get; private set; }
    public bool IsMultiLocationWarning { get; private set; }
    [StringLength(500)]

    public string? MultiLocationWarningMsg { get; private set; }
    public bool EnableMenuDefaultExpanded { get; private set; }
    public bool EnableGridViewSetting { get; private set; }
    public bool EnableTradeViewSetting { get; private set; }
    public bool Ishoverbasket { get; private set; }
    public bool IsEnableShipperHQ { get; private set; }
    public bool? EnableYourPrice { get; private set; }
    [StringLength(100)]

    public string? HeaderBannerAltText { get; private set; }
    [StringLength(350)]

    public string? reCaptchaSiteKeyV2 { get; private set; }
    public bool EnablePartFinder { get; private set; }
    public bool ShowCollectionAddress { get; private set; }
    public decimal V2FallbackScoreLimit { get; private set; }
    [StringLength(350)]

    public string? reCaptchaSecretKeyV2 { get; private set; }
    [StringLength(100)]

    public string? SiteNoImageAltText { get; private set; }
    public bool AnchorLayout { get; private set; }
    public long DefaultAutoCategorySortingOrder { get; private set; }
    public bool OverrideDefaultChecksonBasket { get; private set; }
    public int GridViewAttributeDisplay1 { get; private set; }
    public int ShowFromPrice1 { get; private set; }
    public bool GridAddToBasket1 { get; private set; }
    public int GridImage1 { get; private set; }
    public bool ExportTradeView { get; private set; }
    public bool EnableViewBasketButton { get; private set; }
    public int PAFIntegrationResult { get; private set; }
    public bool EnableExtendedUOS { get; private set; }
    public bool BasketPersonalisationDisplay { get; private set; }
    public bool EnableSyrenisCookie { get; private set; }
    [StringLength(500)]

    public string? SyrenisCookieLicenseID { get; private set; }
    [StringLength(500)]

    public string? SyrenisCookieAccessKey { get; private set; }
    [StringLength(500)]

    public string? SyrenisCookieStyleSheet { get; private set; }
    public string? DeliveryAddressZoneDefault { get; private set; }
    public bool EnableCreditHoldMsgBanner { get; private set; }
    public bool EnablePreLoad { get; private set; }
    public int BackOrderSetting { get; private set; }
    [StringLength(200)]

    public string? HideOrderButtons { get; private set; }
    [StringLength(200)]

    public string? CatDescTextColor { get; private set; }

    public bool EnableCirrusCallRecording { get; private set; }
    [StringLength(100)]

    public string? CirrusUsername { get; private set; }
    [StringLength(150)]

    public string? CirrusPassword { get; private set; }
    public bool DeliveryBreakdownLevel { get; private set; }
    public bool TopRowIsDefault { get; private set; }
    [StringLength(20)]


    public string? ProductTitleColour { get; private set; }
    public int TitleTextSize { get; private set; }
    [StringLength(20)]

    public string? SelectedTabColour { get; private set; }
    [StringLength(20)]

    public string? TableHeaderBackgroundColour { get; private set; }
    [StringLength(20)]

    public string? TableHeaderTextColour { get; private set; }
    public int CreditHoldBannerMsg { get; private set; }
    public int AttributeFilterView { get; private set; }
    public bool SeenCheaperPrice { get; private set; }
    public int TaxCalculationDecimalPlaces { get; private set; }
    public bool EnableCustomerRegistration { get; private set; }
    public bool SiteUnderMaintenance { get; private set; }
    public int PredictiveSearchAttribute { get; private set; }
    public bool EnableMyAccountSalesRep { get; private set; }
    [StringLength(200)]

    public string? beforeFromPriceColor { get; private set; }
    [StringLength(200)]

    public string? afterFromPriceColor { get; private set; }
    public bool EnableCivicCookie { get; private set; }
    [StringLength(200)]

    public string? CivicCookieAPIKey { get; private set; }
    [StringLength(200)]

    public string? CivicCookieProduct { get; private set; }
    public bool AllowPopularSearchesAndLastUserSearches { get; private set; }
    public bool SuperClassURL { get; private set; }
    public bool EnableDedicatedBrandsPage { get; private set; }
    public bool AddtoBasketNotification { get; private set; }
    public int StockMessageLocation { get; private set; }
    [StringLength(250)]

    public string? OrderReceiptPaymentType { get; private set; }
    public bool FinalDestinationEmail { get; private set; }
    public bool ShowEmail_CallUs { get; private set; }
    [StringLength(200)]

    public string? ProductDescription5Text { get; private set; }
    [StringLength(200)]

    public string? ProductDescription6Text { get; private set; }
    public bool ShowInBasketQuantity { get; private set; }
    public bool EnablePaidonResults { get; private set; }
    [StringLength(200)]

    public string? MerchantId_Paidon { get; private set; }
    [StringLength(1000)]

    public string? FooterScript_PaidonResult { get; private set; }
    public bool TransactionalEmail_DownloadableProduct { get; private set; }
    public string? OrderMin_MaxErrorMessage { get; private set; }
    public bool MultipleCollectionLocation { get; private set; }
    public bool EnhancedErrorValidation { get; private set; }
    public string? HeaderScript { get; private set; }
    public string? FooterScript { get; private set; }
    public bool IsUseStockStatusLabel { get; private set; }
    [StringLength(20)]

    public string BasketArchive { get; private set; }
    public bool EnableBackOrderMessage { get; private set; }
    [StringLength(200)]

    public string? DeliveryDateAlertMessage { get; private set; }
    public int SelectedBrandDirectory { get; private set; }
    public bool IsEnableDeliveryByOrderPercentage { get; private set; }
    public bool PercentageDeliveryCharge_Type { get; private set; }
    public bool EnableInvoiceOrderComments { get; private set; }
    public bool CurrencySymbol { get; private set; }
    public bool MultiProductImagesOption { get; private set; }
    public bool EnableAgedDebtTable { get; private set; }
    public bool EnableAgedDebtBreakdown { get; private set; }
    public string? AgedDebtBreakdownItems { get; private set; }
    public bool IsCurrentPasswordRequired { get; private set; }
    public bool EnableLoyaltyLedger { get; private set; }
    public bool EnableRedeemPaymentMethod { get; private set; }
    public int RedeemPaymentMethod { get; private set; }
    public bool EnablePointsAwardInCloudfy { get; private set; }

    public int PointsDefaultExpiryPeriod { get; private set; }
    [StringLength(10)]

    public string PointsDefaultExpiryPeriodType { get; private set; }
    public string? FTPUrl { get; private set; }
    public string? FTPHost { get; private set; }
    public string? FTPLogin { get; private set; }
    public string? FTPPassword { get; private set; }
    public string? FTPBaseRoute { get; private set; }
    public int StockReduction { get; private set; }
    public int DropShipmentSplit { get; private set; }
    [StringLength(500)]

    public string? BrandPageTitle { get; private set; }
    [StringLength(500)]

    public string? BrandPageUrl { get; private set; }
    [StringLength(500)]

    public string? BrandPageDescription { get; private set; }
    public int IsMobileAppLoginAccess { get; private set; }
    public bool EnableSortingGrid { get; private set; }
    public bool ExternalRefFieldforOrderNumber { get; private set; }
    [StringLength(250)]

    public string? LoginToSeePriceText { get; private set; }
    public bool Calculateshowoftoplevelmenu { get; private set; }
    public bool EnableLoyaltyPointsToVoucher { get; private set; }
    public bool StaticPageSearch { get; private set; }
    public bool ProductLayouts_ProductType { get; private set; }

    public SiteSettingsModel(


     long Id,
     long settingsID,
     long? SiteId,

     string? SitePhoneNumber,

     string? SiteCompanyAddress,

     string? ContactUsEmailAddress,

     string? OrdersEmailAddress,

     string? TwitterURL,

     string? FacebookURL,

     string? InstagramURL,

     string? MinimumOrderValue,

     string? FreeDeliveryLevel,

     string? GoogleAnalyticsTrackingID,

     string? EmailBCC,

     string? RegistrationNo,
     string? EmailFooter,

     string? SiteLogo,

     string? SiteFavicon,

     string? HeaderBanner,


     string? RetailPriceLabel,


     string? TradePriceLabel,


     bool? SKU,
     bool? STOCK,
     bool? QTYADD,
     bool? REVIEWS,
     bool? CASEQTY,
     bool? QTYBREAK,


     string? RetailPriceLabel1,


     string? TradePriceLabel1,
     bool? SKU1,
     bool? STOCK1,
     bool? QTYADD1,
     bool? REVIEWS1,
     bool? CASEQTY1,
     bool? QTYBREAK1,
     bool? EnableDemoStoreMessage,
     bool? CreateTradeAccountLogin,
     bool? EnableLiveChat,
     string? ZoopimScript,
     bool? EnableReviews,
     bool? EnableGuestCheckout,
     bool? CurencyConversion,
     string? MageMenuPromotionalMessage,
     bool? ShowHomeLink,
     int? CategoryMenuCount,
     bool? EnablePredictiveSearch,
     bool? EnableSuperClass,
     bool? AllowOrder,
     short? selectedtab,
     bool? ShowBarcode,


     string? UnitForSize,


     string? UnitForWeight,
     bool? ShowRRPWithoutLogin,
     bool? ShowRRPWithStrike,
     bool? ShowPriceWithoutLogin,
     bool? EnableOnCollection,
     bool? IsVatApplicable,
     int? DeiveryRestrictedBy,
     bool? EnableBestSellers,
     bool? EnableLatestProducts,
     bool? EnableSpecialOffers,
     bool? EnableDeliveryDate,


     string? DeliveryDateLabel,
     bool? ShowOutOfStockItem,
     bool? Ordertype,
     bool? ShowStockDueDate,
     bool? ShowCatBannerHeading,
     bool? EnableGoogleTranslater,


     string? LinkedInURL,


     string? YoutubeURL,


     string? PrinterestURL,
     bool? EmableMultipleCurrency,
     bool? EnableMinimumOrderByCountry,
     bool? EnableMultipleSKU,


     string? ReportLogo,
     bool? EnableExistingCustomer,
     bool? EnablePaymentLimit,
     long? DefaultSortingField,
     bool? IsBestSellersFromAdmin,
     bool? IsLatestProductsFromAdmin,
     bool? IsSpecialOffersFromAdmin,
     bool? IsImageCompressed,


     string? Mailchimp_listid,


     string? Mailchimp_apiKey,
     bool? SubscribeMailchimp,
     bool? EnableRoundleOnDetails,
     bool? IsNewLayout,
     bool? IsUpdated,
     bool? ChekoutEditableAddr,
     bool? EnablePendingBasketMail,
     int? setDurationAfterAddedbasket,
     DateTime? LastSendingMail,
     bool? DeliveryAddressAtLogin,

     string? DemoStoreMessage,


     string? DemoStoreMessageLink,
     bool? EnablepriceFilter,
     bool? EnableRightClick,
     string? WelcomeMessageAfterLogin,
     bool? EnableFooterSiteMapLink,
     bool? EnableFooterNewsLink,
     bool? EnableStockQty,
     bool? EnableNewsforInactiveCus,
     int? DeliveryOptionMethod,
     bool? DeliveryOption,
     bool? EnableCustomerAlsoBoughtFeature,
     bool? EnableAbandonedMailfeature,


     string? CopyrightText,
     bool? EnableProductSocialShring,
     bool? IsNextDayDelivery,
     bool EnableEmailBackInStock,


     string TagManagerTrackingId,
     bool? IsSavedBasket,
     bool? MinOrderExvat,

     string? CalculateVatFrom,


     string? Brand,
     bool? EnableCallForPrice,
     bool? EnableDownloadTab,


     string? DownloadTabOption,
     bool? HideCategoryImage,
     bool? GoogleLangSwitchPosition,
     bool? EnableReserveStock,
     decimal? ReserveStockLevel,
     bool? EnableFooterEventsLink,
     bool? EnableStockManagement,


     string? Vat,
     bool? GoogleCustomerReviews,
     bool? ShowProductInMenu,


     string? VimeoLink,
     bool? CurrencyConversion_BeforeLogin,
     bool? CurrencyConversion_AfterLogin,
     bool? ShowTwoProductInCategoryView,


     string? ProductZoom,
     bool? isShowFooterPaymentLogo,
     bool? IsEnableProductReviewsEmailReminder,


     string? ProductDetail,


     string? Delivery,


     string? Materials,
     bool EnableBuyOutOfStock,
     int? HeaderMenuType,
     bool EnableWareHouse,
     byte? EnableSalesRepCode,
     bool? EnableCustomerSpecificeCatalogue,
     bool? IsCustomerEncrypted,
     bool? HideDeliveryChangeFromCheckout,
     bool? HideVoucherCode,
     bool? showmSellerOrder,
     bool? EnableMultiLanguage,
     bool? EnablePunchout,
     bool? EnableLocalTax,
     bool EnableYotpoReviews,
     bool EnableVatverification,
     int? BaseCountry,
     bool? EnableQuickOrder,
     bool? IsOfferPriceFromProduct,
     bool? EnableDownloadOrdersProductImages,
     bool? IsEnableCapitalisationOnSite,
     bool ShowStockStatusFilter,
     bool EnableComments,


     string? GooglePlusLink,
     bool IsEnableNewExtendingDelivery,
     bool ShowDeliveryBreakdown,
     int? PrioritySetting,
     int? BasketCheckoutAlert,


     string? BasketCheckoutAlertText,


     string? NonSaleableMessage,
     bool EnableUserType,
     bool EnableSpendLimits,
     bool EnableAuthorisationOnly,
     int? LimitingPredictiveSearch,
     bool? ShowThumbnailWithPredictiveSearch,


     string? FacebookTrackingID,
     bool IsBespokeMenuEnabled,
     bool SortCategoryByAlphabetically,
     bool EnableCustomerRef,
     int? PriceDecimalPlace,
     bool? EnableCheckoutBillAddress,
     bool? ShowPriceIncVat,
     bool? ShowPriceIncVat1,
     bool? ShowDualPrices,

     string? PageBuilderFontsFiles,


     string? PageBuilderCSSFiles,


     string? PageBuilderJSFiles,
     bool DisableLineLevelPO,
     int? Site404Page,


     string? GoogleMapApiKey,


     string? IndexRankLabel,
     int? DefaultSearchSortingOrder,
     bool EnableCustomerSpecificeProducts,
     int? LayoutSelection,
     bool CalculatedUnitsGridRestricted,
     bool EnableRMARequests,
     int CustomerCatalogueMode,
     bool EnableBundleQty,
     bool EnableDualPrice,
     bool CategoryViewDropdownVarients,
     bool EnableProductSKUBasket,

     string LiveChatVisibility,


     string? CalculatedUnits,
     int EnableGridView,
     int EnableListView,
     int EnableTradeView,
     bool ApplyVATtoDelivery,
     bool EnableAnotherAddress,
     bool DeliveryNoteDispatchCutOff,
     TimeSpan? DeliveryNoteDispatchCutOffTime,
     bool DeliveryNoteFutureDeliveryDate,
     bool ShowSaveAmount,
     byte DetailpageLayout,
     bool AllowEditingDeliveryAddressONCheckout,

     bool EnableTotalUnit,


     string? NoDeliveryChoiceMessage,
     bool? EnableOrderSplit,

     string? DeliveryNoteComment,


     string? BingWebmasterTrackingId,
     byte EnableCheckoutEmailAddress,
     bool? ShowQtyAsQuantityStock,
     bool CalculateDefaultPrice,
     byte Productlistlayout,
     bool EnableMultiWarehouse,
     bool EnableEmailInvoice,
     int InvoiceTemplate,
     bool ShowDeliveryAddressonQuote,


     string? LoginPageURL,
     bool EnableCustomerDueStock,
     int DueStockQty,


     string? InStockColour,


     string? OutofStockColour,


     string? DueStockColour,
     int ShowFromPrice,
     bool Favourites_BeforLogin,
     bool Favourites_AfterLogin,
     bool ShowCategoryImagesOnLandingPage,
     long? ShipingTax,
     bool DisableSubTotal,
     int ProductVatMethod,


     string? SupCatBgColorCode,


     string? RRPcurrency,
     bool ShowRRP,
     bool ShowRRP1,
     int ProductIframeZoom,


     string? Detailpagetextcolor1,


     string? Detailpagetextcolor2,



     string? Detailpagetextcolor3,


     string? Tabbottombordercolour,
     bool DisablePriceUpdateOnBasket,
     bool EnableBranchName,


     string? QuoteEmailAddress,
     int MiniBasket,
     bool TransparentHeader,


     string? InvoicePaymentType,
     bool EnablePaymentOfInvoices,
     int PartialPaymentOrder,
     bool EnableAccountAgedDebt,


     string? BusinessDays,
     bool DisableLineLevelDeliveryDate,
     bool EnableLinkMultiAccount,


     string? BackOrderText,
     bool EnableTrustedShops,


     string? TrustedShops,
     bool ShowMaxOrderQtyOnProductDetailPage,
     bool PersonalisedLandingPages,
     bool DefaultCustomRegistrationForm,
     bool EnablePersonalisation,
     bool? IsQuickorderAutocomplete,


     string? CustomiseSearchText,
     int? EnableCompanyMandatory,
     bool EnableDeliveryAddressEmails,
     bool? EnableFinalDestination,
     int? Trade_View_Attribute_ID,
     bool? IsQuotesOnly,
     bool EnableNewInvoice,
     bool? EnableCheckoutquestion,


     string? Checkoutmessage,
     bool EnableProductSKU,
     bool EnableProductName,


     string? AttributeTabText,


     string? Documentation,
     bool? EnableDropShipemailsforQuotes,


     string? DateFormat,
     bool ContactUsPopUp,
     bool CustomContactUsField,
     bool AllowRegistration,
     bool EnableCustomerQuestion,
     bool EnableProductLedger,
     bool EnableHotJarAnalytics,

     string? SearchableFields,


     string? HotjarTrackingCodeID,


     string? HotjarSnippetVersion,


     string? BackOrderTextColour,


     string? ShowDescription,
     bool EnablePrintBasket,
     bool? EnableAttributeTab,


     string? VideoTabText,
     int? Gridpagesize,

     string? GridLayoutColour1,

     string? GridLayoutColour2,
     bool PaymentMethodPrices,
     bool EnableCommaSeperatedNumbers,
     bool? InvoicesManageAvailableBalance,


     string? SoftCreditLimitMessages,


     string? hardCreditLimitMessages,
     bool EnableTermlyCookie,


     string? TermlyCookieEmbedId,


     string? TermlyManageCookiePreferencesLocation,
     bool? ShowAvailableBlanceChckout,
     int? GridViewAttributeDisplay,
     bool EnablePAFIntegration,
     int PAFIntegrationService,
     bool CreateCustomerRecord,
     bool EnableQtyChangeAtCheckout,
     int InvoiceType,

     string? InvoiceAdditionalInfo,


     string? InvoiceDocName,


     string? InvoiceCompanyName,


     string? InvoiceAdd1,


     string? InvoiceAdd2,


     string? InvoiceCity,


     string? InvoiceCounty,


     string? InvoicePostCode,


     string? InvoiceVatNo,


     string? InvoiceTel,


     string? InvoiceFax,


     bool EnableFeefoReview,


     string? MerchantIdentifier,


     string? PricingColour,
     bool EnableDonations,


     string? DonationsSKU,


     string? DonationsItemDescription,


     string? DonationsSectionText,
     int CategoryLayoutOption,
     bool RestrictCategoryListview,
     bool EnableRelatedWhenOutOfStock,
     bool ChannableImport,

     string? ChannableURL,
     string? ChannableToken,
     int ChannableFrequency,
     byte CheckoutPageType,


     string? SelectCreditBalance,
     byte? ImagesLayout,
     bool? ShowSKUCodeOnDetail,


     string? ShowCategoryDescription,
     bool EnableSelfVATExemption,


     string? SelfVATExemptionComment,
     bool GridAddToBasket,
     int GridImage,


     string? DonationGiftAidText,


     string? DonationAccountType,
     bool? EnableFreeDeliveryCalculation,
     bool EnablePersonalisationMultipleQty,


     string? reCaptchaSiteKey,


     string? reCaptchaSecretKey,
     bool? DisplayCategoryAltImages,
     bool? EnableCategoryStockQty,
     bool DeliverToBillAddress,

     string? CheckoutMessage2,
     bool IsPinchToZoom,
     bool IsRegistrationActive,
     bool? EnableDescriptionsPhoneOrders,


     string? PhoneOrderDescriptionOptions,
     bool CustomerAmendCreditLimit,
     bool IsAltTextBlank,
     int? AddToBasketPosition,
     bool IsMultiLocationWarning,


     string? MultiLocationWarningMsg,
     bool EnableMenuDefaultExpanded,
     bool EnableGridViewSetting,
     bool EnableTradeViewSetting,
     bool Ishoverbasket,
     bool IsEnableShipperHQ,
     bool? EnableYourPrice,


     string? HeaderBannerAltText,


     string? reCaptchaSiteKeyV2,
     bool EnablePartFinder,
     bool ShowCollectionAddress,
     decimal V2FallbackScoreLimit,


     string? reCaptchaSecretKeyV2,


     string? SiteNoImageAltText,
     bool AnchorLayout,
     long DefaultAutoCategorySortingOrder,
     bool OverrideDefaultChecksonBasket,
     int GridViewAttributeDisplay1,
     int ShowFromPrice1,
     bool GridAddToBasket1,
     int GridImage1,
     bool ExportTradeView,
     bool EnableViewBasketButton,
     int PAFIntegrationResult,
     bool EnableExtendedUOS,
     bool BasketPersonalisationDisplay,
     bool EnableSyrenisCookie,


     string? SyrenisCookieLicenseID,


     string? SyrenisCookieAccessKey,


     string? SyrenisCookieStyleSheet,
     string? DeliveryAddressZoneDefault,
     bool EnableCreditHoldMsgBanner,
     bool EnablePreLoad,
     int BackOrderSetting,


     string? HideOrderButtons,


     string? CatDescTextColor,

     bool EnableCirrusCallRecording,


     string? CirrusUsername,


     string? CirrusPassword,
     bool DeliveryBreakdownLevel,
     bool TopRowIsDefault,



     string? ProductTitleColour,
     int TitleTextSize,


     string? SelectedTabColour,


     string? TableHeaderBackgroundColour,


     string? TableHeaderTextColour,
     int CreditHoldBannerMsg,
     int AttributeFilterView,
     bool SeenCheaperPrice,
     int TaxCalculationDecimalPlaces,
     bool EnableCustomerRegistration,
     bool SiteUnderMaintenance,
     int PredictiveSearchAttribute,
     bool EnableMyAccountSalesRep,


     string? beforeFromPriceColor,


     string? afterFromPriceColor,
     bool EnableCivicCookie,


     string? CivicCookieAPIKey,


     string? CivicCookieProduct,
     bool AllowPopularSearchesAndLastUserSearches,
     bool SuperClassURL,
     bool EnableDedicatedBrandsPage,
     bool AddtoBasketNotification,
     int StockMessageLocation,


     string? OrderReceiptPaymentType,
     bool FinalDestinationEmail,
     bool ShowEmail_CallUs,


     string? ProductDescription5Text,


     string? ProductDescription6Text,
     bool ShowInBasketQuantity,
     bool EnablePaidonResults,


     string? MerchantId_Paidon,

     string? FooterScript_PaidonResult,
     bool TransactionalEmail_DownloadableProduct,
     string? OrderMin_MaxErrorMessage,
     bool MultipleCollectionLocation,
     bool EnhancedErrorValidation,
     string? HeaderScript,
     string? FooterScript,
     bool IsUseStockStatusLabel,


     string BasketArchive,
     bool EnableBackOrderMessage,


     string? DeliveryDateAlertMessage,
     int SelectedBrandDirectory,
     bool IsEnableDeliveryByOrderPercentage,
     bool PercentageDeliveryCharge_Type,
     bool EnableInvoiceOrderComments,
     bool CurrencySymbol,
     bool MultiProductImagesOption,
     bool EnableAgedDebtTable,
     bool EnableAgedDebtBreakdown,
     string? AgedDebtBreakdownItems,
     bool IsCurrentPasswordRequired,
     bool EnableLoyaltyLedger,
     bool EnableRedeemPaymentMethod,
     int RedeemPaymentMethod,
     bool EnablePointsAwardInCloudfy,

     int PointsDefaultExpiryPeriod,
     string PointsDefaultExpiryPeriodType,
     string? FTPUrl,
     string? FTPHost,
     string? FTPLogin,
     string? FTPPassword,
     string? FTPBaseRoute,
     int StockReduction,
     int DropShipmentSplit,


     string? BrandPageTitle,


     string? BrandPageUrl,


     string? BrandPageDescription,
     int IsMobileAppLoginAccess,
     bool EnableSortingGrid,
     bool ExternalRefFieldforOrderNumber,


     string? LoginToSeePriceText,
     bool Calculateshowoftoplevelmenu,
     bool EnableLoyaltyPointsToVoucher,
     bool StaticPageSearch,
     bool ProductLayouts_ProductType
        )
    {

        this.Id = Id;
        this.settingsID = settingsID;
        this.SiteId = SiteId;


        this.SitePhoneNumber = SitePhoneNumber;


        this.SiteCompanyAddress = SiteCompanyAddress;


        this.ContactUsEmailAddress = ContactUsEmailAddress;


        this.OrdersEmailAddress = OrdersEmailAddress;


        this.TwitterURL = TwitterURL;


        this.FacebookURL = FacebookURL;


        this.InstagramURL = InstagramURL;


        this.MinimumOrderValue = MinimumOrderValue;


        this.FreeDeliveryLevel = FreeDeliveryLevel;


        this.GoogleAnalyticsTrackingID = GoogleAnalyticsTrackingID;


        this.EmailBCC = EmailBCC;


        this.RegistrationNo = RegistrationNo;
        this.EmailFooter = EmailFooter;


        this.SiteLogo = SiteLogo;


        this.SiteFavicon = SiteFavicon;


        this.HeaderBanner = HeaderBanner;



        this.RetailPriceLabel = RetailPriceLabel;



        this.TradePriceLabel = TradePriceLabel;



        this.SKU = SKU;
        this.STOCK = STOCK;
        this.QTYADD = QTYADD;
        this.REVIEWS = REVIEWS;
        this.CASEQTY = CASEQTY;
        this.QTYBREAK = QTYBREAK;



        this.RetailPriceLabel1 = RetailPriceLabel1;



        this.TradePriceLabel1 = TradePriceLabel1;
        this.SKU1 = SKU1;
        this.STOCK1 = STOCK1;
        this.QTYADD1 = QTYADD1;
        this.REVIEWS1 = REVIEWS1;
        this.CASEQTY1 = CASEQTY1;
        this.QTYBREAK1 = QTYBREAK1;
        this.EnableDemoStoreMessage = EnableDemoStoreMessage;
        this.CreateTradeAccountLogin = CreateTradeAccountLogin;
        this.EnableLiveChat = EnableLiveChat;
        this.ZoopimScript = ZoopimScript;
        this.EnableReviews = EnableReviews;
        this.EnableGuestCheckout = EnableGuestCheckout;
        this.CurencyConversion = CurencyConversion;
        this.MageMenuPromotionalMessage = MageMenuPromotionalMessage;
        this.ShowHomeLink = ShowHomeLink;
        this.CategoryMenuCount = CategoryMenuCount;
        this.EnablePredictiveSearch = EnablePredictiveSearch;
        this.EnableSuperClass = EnableSuperClass;
        this.AllowOrder = AllowOrder;
        this.selectedtab = selectedtab;
        this.ShowBarcode = ShowBarcode;



        this.UnitForSize = UnitForSize;



        this.UnitForWeight = UnitForWeight;
        this.ShowRRPWithoutLogin = ShowRRPWithoutLogin;
        this.ShowRRPWithStrike = ShowRRPWithStrike;
        this.ShowPriceWithoutLogin = ShowPriceWithoutLogin;
        this.EnableOnCollection = EnableOnCollection;
        this.IsVatApplicable = IsVatApplicable;
        this.DeiveryRestrictedBy = DeiveryRestrictedBy;
        this.EnableBestSellers = EnableBestSellers;
        this.EnableLatestProducts = EnableLatestProducts;
        this.EnableSpecialOffers = EnableSpecialOffers;
        this.EnableDeliveryDate = EnableDeliveryDate;



        this.DeliveryDateLabel = DeliveryDateLabel;
        this.ShowOutOfStockItem = ShowOutOfStockItem;
        this.Ordertype = Ordertype;
        this.ShowStockDueDate = ShowStockDueDate;
        this.ShowCatBannerHeading = ShowCatBannerHeading;
        this.EnableGoogleTranslater = EnableGoogleTranslater;



        this.LinkedInURL = LinkedInURL;



        this.YoutubeURL = YoutubeURL;



        this.PrinterestURL = PrinterestURL;
        this.EmableMultipleCurrency = EmableMultipleCurrency;
        this.EnableMinimumOrderByCountry = EnableMinimumOrderByCountry;
        this.EnableMultipleSKU = EnableMultipleSKU;



        this.ReportLogo = ReportLogo;
        this.EnableExistingCustomer = EnableExistingCustomer;
        this.EnablePaymentLimit = EnablePaymentLimit;
        this.DefaultSortingField = DefaultSortingField;
        this.IsBestSellersFromAdmin = IsBestSellersFromAdmin;
        this.IsLatestProductsFromAdmin = IsLatestProductsFromAdmin;
        this.IsSpecialOffersFromAdmin = IsSpecialOffersFromAdmin;
        this.IsImageCompressed = IsImageCompressed;



        this.Mailchimp_listid = Mailchimp_listid;



        this.Mailchimp_apiKey = Mailchimp_apiKey;
        this.SubscribeMailchimp = SubscribeMailchimp;
        this.EnableRoundleOnDetails = EnableRoundleOnDetails;
        this.IsNewLayout = IsNewLayout;
        this.IsUpdated = IsUpdated;
        this.ChekoutEditableAddr = ChekoutEditableAddr;
        this.EnablePendingBasketMail = EnablePendingBasketMail;
        this.setDurationAfterAddedbasket = setDurationAfterAddedbasket;
        this.LastSendingMail = LastSendingMail;
        this.DeliveryAddressAtLogin = DeliveryAddressAtLogin;

        this.DemoStoreMessage = DemoStoreMessage;

        this.DemoStoreMessageLink = DemoStoreMessageLink;
        this.EnablepriceFilter = EnablepriceFilter;
        this.EnableRightClick = EnableRightClick;
        this.WelcomeMessageAfterLogin = WelcomeMessageAfterLogin;
        this.EnableFooterSiteMapLink = EnableFooterSiteMapLink;
        this.EnableFooterNewsLink = EnableFooterNewsLink;
        this.EnableStockQty = EnableStockQty;
        this.EnableNewsforInactiveCus = EnableNewsforInactiveCus;
        this.DeliveryOptionMethod = DeliveryOptionMethod;
        this.DeliveryOption = DeliveryOption;
        this.EnableCustomerAlsoBoughtFeature = EnableCustomerAlsoBoughtFeature;
        this.EnableAbandonedMailfeature = EnableAbandonedMailfeature;



        this.CopyrightText = CopyrightText;
        this.EnableProductSocialShring = EnableProductSocialShring;
        this.IsNextDayDelivery = IsNextDayDelivery;
        this.EnableEmailBackInStock = EnableEmailBackInStock;



        this.TagManagerTrackingId = TagManagerTrackingId;
        this.IsSavedBasket = IsSavedBasket;
        this.MinOrderExvat = MinOrderExvat;

        this.CalculateVatFrom = CalculateVatFrom;



        this.Brand = Brand;
        this.EnableCallForPrice = EnableCallForPrice;
        this.EnableDownloadTab = EnableDownloadTab;



        this.DownloadTabOption = DownloadTabOption;
        this.HideCategoryImage = HideCategoryImage;
        this.GoogleLangSwitchPosition = GoogleLangSwitchPosition;
        this.EnableReserveStock = EnableReserveStock;
        this.ReserveStockLevel = ReserveStockLevel;
        this.EnableFooterEventsLink = EnableFooterEventsLink;
        this.EnableStockManagement = EnableStockManagement;



        this.Vat = Vat;
        this.GoogleCustomerReviews = GoogleCustomerReviews;
        this.ShowProductInMenu = ShowProductInMenu;



        this.VimeoLink = VimeoLink;
        this.CurrencyConversion_BeforeLogin = CurrencyConversion_BeforeLogin;
        this.CurrencyConversion_AfterLogin = CurrencyConversion_AfterLogin;
        this.ShowTwoProductInCategoryView = ShowTwoProductInCategoryView;



        this.ProductZoom = ProductZoom;
        this.isShowFooterPaymentLogo = isShowFooterPaymentLogo;
        this.IsEnableProductReviewsEmailReminder = IsEnableProductReviewsEmailReminder;



        this.ProductDetail = ProductDetail;



        this.Delivery = Delivery;



        this.Materials = Materials;
        this.EnableBuyOutOfStock = EnableBuyOutOfStock;
        this.HeaderMenuType = HeaderMenuType;
        this.EnableWareHouse = EnableWareHouse;
        this.EnableSalesRepCode = EnableSalesRepCode;
        this.EnableCustomerSpecificeCatalogue = EnableCustomerSpecificeCatalogue;
        this.IsCustomerEncrypted = IsCustomerEncrypted;
        this.HideDeliveryChangeFromCheckout = HideDeliveryChangeFromCheckout;
        this.HideVoucherCode = HideVoucherCode;
        this.showmSellerOrder = showmSellerOrder;
        this.EnableMultiLanguage = EnableMultiLanguage;
        this.EnablePunchout = EnablePunchout;
        this.EnableLocalTax = EnableLocalTax;
        this.EnableYotpoReviews = EnableYotpoReviews;
        this.EnableVatverification = EnableVatverification;
        this.BaseCountry = BaseCountry;
        this.EnableQuickOrder = EnableQuickOrder;
        this.IsOfferPriceFromProduct = IsOfferPriceFromProduct;
        this.EnableDownloadOrdersProductImages = EnableDownloadOrdersProductImages;
        this.IsEnableCapitalisationOnSite = IsEnableCapitalisationOnSite;
        this.ShowStockStatusFilter = ShowStockStatusFilter;
        this.EnableComments = EnableComments;



        this.GooglePlusLink = GooglePlusLink;
        this.IsEnableNewExtendingDelivery = IsEnableNewExtendingDelivery;
        this.ShowDeliveryBreakdown = ShowDeliveryBreakdown;
        this.PrioritySetting = PrioritySetting;
        this.BasketCheckoutAlert = BasketCheckoutAlert;



        this.BasketCheckoutAlertText = BasketCheckoutAlertText;



        this.NonSaleableMessage = NonSaleableMessage;
        this.EnableUserType = EnableUserType;
        this.EnableSpendLimits = EnableSpendLimits;
        this.EnableAuthorisationOnly = EnableAuthorisationOnly;
        this.LimitingPredictiveSearch = LimitingPredictiveSearch;
        this.ShowThumbnailWithPredictiveSearch = ShowThumbnailWithPredictiveSearch;



        this.FacebookTrackingID = FacebookTrackingID;
        this.IsBespokeMenuEnabled = IsBespokeMenuEnabled;
        this.SortCategoryByAlphabetically = SortCategoryByAlphabetically;
        this.EnableCustomerRef = EnableCustomerRef;
        this.PriceDecimalPlace = PriceDecimalPlace;
        this.EnableCheckoutBillAddress = EnableCheckoutBillAddress;
        this.ShowPriceIncVat = ShowPriceIncVat;
        this.ShowPriceIncVat1 = ShowPriceIncVat1;
        this.ShowDualPrices = ShowDualPrices;

        this.PageBuilderFontsFiles = PageBuilderFontsFiles;



        this.PageBuilderCSSFiles = PageBuilderCSSFiles;



        this.PageBuilderJSFiles = PageBuilderJSFiles;
        this.DisableLineLevelPO = DisableLineLevelPO;
        this.Site404Page = Site404Page;



        this.GoogleMapApiKey = GoogleMapApiKey;



        this.IndexRankLabel = IndexRankLabel;
        this.DefaultSearchSortingOrder = DefaultSearchSortingOrder;
        this.EnableCustomerSpecificeProducts = EnableCustomerSpecificeProducts;
        this.LayoutSelection = LayoutSelection;
        this.CalculatedUnitsGridRestricted = CalculatedUnitsGridRestricted;
        this.EnableRMARequests = EnableRMARequests;
        this.CustomerCatalogueMode = CustomerCatalogueMode;
        this.EnableBundleQty = EnableBundleQty;
        this.EnableDualPrice = EnableDualPrice;
        this.CategoryViewDropdownVarients = CategoryViewDropdownVarients;
        this.EnableProductSKUBasket = EnableProductSKUBasket;

        this.LiveChatVisibility = LiveChatVisibility;



        this.CalculatedUnits = CalculatedUnits;
        this.EnableGridView = EnableGridView;
        this.EnableListView = EnableListView;
        this.EnableTradeView = EnableTradeView;
        this.ApplyVATtoDelivery = ApplyVATtoDelivery;
        this.EnableAnotherAddress = EnableAnotherAddress;
        this.DeliveryNoteDispatchCutOff = DeliveryNoteDispatchCutOff;
        this.DeliveryNoteDispatchCutOffTime = DeliveryNoteDispatchCutOffTime;
        this.DeliveryNoteFutureDeliveryDate = DeliveryNoteFutureDeliveryDate;
        this.ShowSaveAmount = ShowSaveAmount;
        this.DetailpageLayout = DetailpageLayout;
        this.AllowEditingDeliveryAddressONCheckout = AllowEditingDeliveryAddressONCheckout;

        this.EnableTotalUnit = EnableTotalUnit;



        this.NoDeliveryChoiceMessage = NoDeliveryChoiceMessage;
        this.EnableOrderSplit = EnableOrderSplit;

        this.DeliveryNoteComment = DeliveryNoteComment;



        this.BingWebmasterTrackingId = BingWebmasterTrackingId;
        this.EnableCheckoutEmailAddress = EnableCheckoutEmailAddress;
        this.ShowQtyAsQuantityStock = ShowQtyAsQuantityStock;
        this.CalculateDefaultPrice = CalculateDefaultPrice;
        this.Productlistlayout = Productlistlayout;
        this.EnableMultiWarehouse = EnableMultiWarehouse;
        this.EnableEmailInvoice = EnableEmailInvoice;
        this.InvoiceTemplate = InvoiceTemplate;
        this.ShowDeliveryAddressonQuote = ShowDeliveryAddressonQuote;



        this.LoginPageURL = LoginPageURL;
        this.EnableCustomerDueStock = EnableCustomerDueStock;
        this.DueStockQty = DueStockQty;



        this.InStockColour = InStockColour;



        this.OutofStockColour = OutofStockColour;



        this.DueStockColour = DueStockColour;
        this.ShowFromPrice = ShowFromPrice;
        this.Favourites_BeforLogin = Favourites_BeforLogin;
        this.Favourites_AfterLogin = Favourites_AfterLogin;
        this.ShowCategoryImagesOnLandingPage = ShowCategoryImagesOnLandingPage;
        this.ShipingTax = ShipingTax;
        this.DisableSubTotal = DisableSubTotal;
        this.ProductVatMethod = ProductVatMethod;



        this.SupCatBgColorCode = SupCatBgColorCode;



        this.RRPcurrency = RRPcurrency;
        this.ShowRRP = ShowRRP;
        this.ShowRRP1 = ShowRRP1;
        this.ProductIframeZoom = ProductIframeZoom;



        this.Detailpagetextcolor1 = Detailpagetextcolor1;



        this.Detailpagetextcolor2 = Detailpagetextcolor2;




        this.Detailpagetextcolor3 = Detailpagetextcolor3;



        this.Tabbottombordercolour = Tabbottombordercolour;
        this.DisablePriceUpdateOnBasket = DisablePriceUpdateOnBasket;
        this.EnableBranchName = EnableBranchName;



        this.QuoteEmailAddress = QuoteEmailAddress;
        this.MiniBasket = MiniBasket;
        this.TransparentHeader = TransparentHeader;



        this.InvoicePaymentType = InvoicePaymentType;
        this.EnablePaymentOfInvoices = EnablePaymentOfInvoices;
        this.PartialPaymentOrder = PartialPaymentOrder;
        this.EnableAccountAgedDebt = EnableAccountAgedDebt;



        this.BusinessDays = BusinessDays;
        this.DisableLineLevelDeliveryDate = DisableLineLevelDeliveryDate;
        this.EnableLinkMultiAccount = EnableLinkMultiAccount;



        this.BackOrderText = BackOrderText;
        this.EnableTrustedShops = EnableTrustedShops;



        this.TrustedShops = TrustedShops;
        this.ShowMaxOrderQtyOnProductDetailPage = ShowMaxOrderQtyOnProductDetailPage;
        this.PersonalisedLandingPages = PersonalisedLandingPages;
        this.DefaultCustomRegistrationForm = DefaultCustomRegistrationForm;
        this.EnablePersonalisation = EnablePersonalisation;
        this.IsQuickorderAutocomplete = IsQuickorderAutocomplete;



        this.CustomiseSearchText = CustomiseSearchText;
        this.EnableCompanyMandatory = EnableCompanyMandatory;
        this.EnableDeliveryAddressEmails = EnableDeliveryAddressEmails;
        this.EnableFinalDestination = EnableFinalDestination;
        this.Trade_View_Attribute_ID = Trade_View_Attribute_ID;
        this.IsQuotesOnly = IsQuotesOnly;
        this.EnableNewInvoice = EnableNewInvoice;
        this.EnableCheckoutquestion = EnableCheckoutquestion;



        this.Checkoutmessage = Checkoutmessage;
        this.EnableProductSKU = EnableProductSKU;
        this.EnableProductName = EnableProductName;



        this.AttributeTabText = AttributeTabText;



        this.Documentation = Documentation;
        this.EnableDropShipemailsforQuotes = EnableDropShipemailsforQuotes;



        this.DateFormat = DateFormat;
        this.ContactUsPopUp = ContactUsPopUp;
        this.CustomContactUsField = CustomContactUsField;
        this.AllowRegistration = AllowRegistration;
        this.EnableCustomerQuestion = EnableCustomerQuestion;
        this.EnableProductLedger = EnableProductLedger;
        this.EnableHotJarAnalytics = EnableHotJarAnalytics;

        this.SearchableFields = SearchableFields;



        this.HotjarTrackingCodeID = HotjarTrackingCodeID;



        this.HotjarSnippetVersion = HotjarSnippetVersion;



        this.BackOrderTextColour = BackOrderTextColour;



        this.ShowDescription = ShowDescription;
        this.EnablePrintBasket = EnablePrintBasket;
        this.EnableAttributeTab = EnableAttributeTab;



        this.VideoTabText = VideoTabText;
        this.Gridpagesize = Gridpagesize;

        this.GridLayoutColour1 = GridLayoutColour1;

        this.GridLayoutColour2 = GridLayoutColour2;
        this.PaymentMethodPrices = PaymentMethodPrices;
        this.EnableCommaSeperatedNumbers = EnableCommaSeperatedNumbers;
        this.InvoicesManageAvailableBalance = InvoicesManageAvailableBalance;



        this.SoftCreditLimitMessages = SoftCreditLimitMessages;



        this.hardCreditLimitMessages = hardCreditLimitMessages;
        this.EnableTermlyCookie = EnableTermlyCookie;



        this.TermlyCookieEmbedId = TermlyCookieEmbedId;



        this.TermlyManageCookiePreferencesLocation = TermlyManageCookiePreferencesLocation;
        this.ShowAvailableBlanceChckout = ShowAvailableBlanceChckout;
        this.GridViewAttributeDisplay = GridViewAttributeDisplay;
        this.EnablePAFIntegration = EnablePAFIntegration;
        this.PAFIntegrationService = PAFIntegrationService;
        this.CreateCustomerRecord = CreateCustomerRecord;
        this.EnableQtyChangeAtCheckout = EnableQtyChangeAtCheckout;
        this.InvoiceType = InvoiceType;

        this.InvoiceAdditionalInfo = InvoiceAdditionalInfo;



        this.InvoiceDocName = InvoiceDocName;



        this.InvoiceCompanyName = InvoiceCompanyName;



        this.InvoiceAdd1 = InvoiceAdd1;



        this.InvoiceAdd2 = InvoiceAdd2;



        this.InvoiceCity = InvoiceCity;



        this.InvoiceCounty = InvoiceCounty;



        this.InvoicePostCode = InvoicePostCode;



        this.InvoiceVatNo = InvoiceVatNo;



        this.InvoiceTel = InvoiceTel;



        this.InvoiceFax = InvoiceFax;



        this.EnableFeefoReview = EnableFeefoReview;



        this.MerchantIdentifier = MerchantIdentifier;



        this.PricingColour = PricingColour;
        this.EnableDonations = EnableDonations;



        this.DonationsSKU = DonationsSKU;



        this.DonationsItemDescription = DonationsItemDescription;



        this.DonationsSectionText = DonationsSectionText;
        this.CategoryLayoutOption = CategoryLayoutOption;
        this.RestrictCategoryListview = RestrictCategoryListview;
        this.EnableRelatedWhenOutOfStock = EnableRelatedWhenOutOfStock;
        this.ChannableImport = ChannableImport;

        this.ChannableURL = ChannableURL;
        this.ChannableToken = ChannableToken;
        this.ChannableFrequency = ChannableFrequency;
        this.CheckoutPageType = CheckoutPageType;



        this.SelectCreditBalance = SelectCreditBalance;
        this.ImagesLayout = ImagesLayout;
        this.ShowSKUCodeOnDetail = ShowSKUCodeOnDetail;



        this.ShowCategoryDescription = ShowCategoryDescription;
        this.EnableSelfVATExemption = EnableSelfVATExemption;



        this.SelfVATExemptionComment = SelfVATExemptionComment;
        this.GridAddToBasket = GridAddToBasket;
        this.GridImage = GridImage;



        this.DonationGiftAidText = DonationGiftAidText;



        this.DonationAccountType = DonationAccountType;
        this.EnableFreeDeliveryCalculation = EnableFreeDeliveryCalculation;
        this.EnablePersonalisationMultipleQty = EnablePersonalisationMultipleQty;



        this.reCaptchaSiteKey = reCaptchaSiteKey;



        this.reCaptchaSecretKey = reCaptchaSecretKey;
        this.DisplayCategoryAltImages = DisplayCategoryAltImages;
        this.EnableCategoryStockQty = EnableCategoryStockQty;
        this.DeliverToBillAddress = DeliverToBillAddress;

        this.CheckoutMessage2 = CheckoutMessage2;
        this.IsPinchToZoom = IsPinchToZoom;
        this.IsRegistrationActive = IsRegistrationActive;
        this.EnableDescriptionsPhoneOrders = EnableDescriptionsPhoneOrders;



        this.PhoneOrderDescriptionOptions = PhoneOrderDescriptionOptions;
        this.CustomerAmendCreditLimit = CustomerAmendCreditLimit;
        this.IsAltTextBlank = IsAltTextBlank;
        this.AddToBasketPosition = AddToBasketPosition;
        this.IsMultiLocationWarning = IsMultiLocationWarning;



        this.MultiLocationWarningMsg = MultiLocationWarningMsg;
        this.EnableMenuDefaultExpanded = EnableMenuDefaultExpanded;
        this.EnableGridViewSetting = EnableGridViewSetting;
        this.EnableTradeViewSetting = EnableTradeViewSetting;
        this.Ishoverbasket = Ishoverbasket;
        this.IsEnableShipperHQ = IsEnableShipperHQ;
        this.EnableYourPrice = EnableYourPrice;



        this.HeaderBannerAltText = HeaderBannerAltText;



        this.reCaptchaSiteKeyV2 = reCaptchaSiteKeyV2;
        this.EnablePartFinder = EnablePartFinder;
        this.ShowCollectionAddress = ShowCollectionAddress;
        this.V2FallbackScoreLimit = V2FallbackScoreLimit;



        this.reCaptchaSecretKeyV2 = reCaptchaSecretKeyV2;



        this.SiteNoImageAltText = SiteNoImageAltText;
        this.AnchorLayout = AnchorLayout;
        this.DefaultAutoCategorySortingOrder = DefaultAutoCategorySortingOrder;
        this.OverrideDefaultChecksonBasket = OverrideDefaultChecksonBasket;
        this.GridViewAttributeDisplay1 = GridViewAttributeDisplay1;
        this.ShowFromPrice1 = ShowFromPrice1;
        this.GridAddToBasket1 = GridAddToBasket1;
        this.GridImage1 = GridImage1;
        this.ExportTradeView = ExportTradeView;
        this.EnableViewBasketButton = EnableViewBasketButton;
        this.PAFIntegrationResult = PAFIntegrationResult;
        this.EnableExtendedUOS = EnableExtendedUOS;
        this.BasketPersonalisationDisplay = BasketPersonalisationDisplay;
        this.EnableSyrenisCookie = EnableSyrenisCookie;



        this.SyrenisCookieLicenseID = SyrenisCookieLicenseID;



        this.SyrenisCookieAccessKey = SyrenisCookieAccessKey;



        this.SyrenisCookieStyleSheet = SyrenisCookieStyleSheet;
        this.DeliveryAddressZoneDefault = DeliveryAddressZoneDefault;
        this.EnableCreditHoldMsgBanner = EnableCreditHoldMsgBanner;
        this.EnablePreLoad = EnablePreLoad;
        this.BackOrderSetting = BackOrderSetting;



        this.HideOrderButtons = HideOrderButtons;



        this.CatDescTextColor = CatDescTextColor;

        this.EnableCirrusCallRecording = EnableCirrusCallRecording;



        this.CirrusUsername = CirrusUsername;



        this.CirrusPassword = CirrusPassword;
        this.DeliveryBreakdownLevel = DeliveryBreakdownLevel;
        this.TopRowIsDefault = TopRowIsDefault;




        this.ProductTitleColour = ProductTitleColour;
        this.TitleTextSize = TitleTextSize;



        this.SelectedTabColour = SelectedTabColour;



        this.TableHeaderBackgroundColour = TableHeaderBackgroundColour;



        this.TableHeaderTextColour = TableHeaderTextColour;
        this.CreditHoldBannerMsg = CreditHoldBannerMsg;
        this.AttributeFilterView = AttributeFilterView;
        this.SeenCheaperPrice = SeenCheaperPrice;
        this.TaxCalculationDecimalPlaces = TaxCalculationDecimalPlaces;
        this.EnableCustomerRegistration = EnableCustomerRegistration;
        this.SiteUnderMaintenance = SiteUnderMaintenance;
        this.PredictiveSearchAttribute = PredictiveSearchAttribute;
        this.EnableMyAccountSalesRep = EnableMyAccountSalesRep;



        this.beforeFromPriceColor = beforeFromPriceColor;



        this.afterFromPriceColor = afterFromPriceColor;
        this.EnableCivicCookie = EnableCivicCookie;



        this.CivicCookieAPIKey = CivicCookieAPIKey;



        this.CivicCookieProduct = CivicCookieProduct;
        this.AllowPopularSearchesAndLastUserSearches = AllowPopularSearchesAndLastUserSearches;
        this.SuperClassURL = SuperClassURL;
        this.EnableDedicatedBrandsPage = EnableDedicatedBrandsPage;
        this.AddtoBasketNotification = AddtoBasketNotification;
        this.StockMessageLocation = StockMessageLocation;



        this.OrderReceiptPaymentType = OrderReceiptPaymentType;
        this.FinalDestinationEmail = FinalDestinationEmail;
        this.ShowEmail_CallUs = ShowEmail_CallUs;



        this.ProductDescription5Text = ProductDescription5Text;



        this.ProductDescription6Text = ProductDescription6Text;
        this.ShowInBasketQuantity = ShowInBasketQuantity;
        this.EnablePaidonResults = EnablePaidonResults;



        this.MerchantId_Paidon = MerchantId_Paidon;

        this.FooterScript_PaidonResult = FooterScript_PaidonResult;
        this.TransactionalEmail_DownloadableProduct = TransactionalEmail_DownloadableProduct;
        this.OrderMin_MaxErrorMessage = OrderMin_MaxErrorMessage;
        this.MultipleCollectionLocation = MultipleCollectionLocation;
        this.EnhancedErrorValidation = EnhancedErrorValidation;
        this.HeaderScript = HeaderScript;
        this.FooterScript = FooterScript;
        this.IsUseStockStatusLabel = IsUseStockStatusLabel;



        this.BasketArchive = BasketArchive;
        this.EnableBackOrderMessage = EnableBackOrderMessage;



        this.DeliveryDateAlertMessage = DeliveryDateAlertMessage;
        this.SelectedBrandDirectory = SelectedBrandDirectory;
        this.IsEnableDeliveryByOrderPercentage = IsEnableDeliveryByOrderPercentage;
        this.PercentageDeliveryCharge_Type = PercentageDeliveryCharge_Type;
        this.EnableInvoiceOrderComments = EnableInvoiceOrderComments;
        this.CurrencySymbol = CurrencySymbol;
        this.MultiProductImagesOption = MultiProductImagesOption;
        this.EnableAgedDebtTable = EnableAgedDebtTable;
        this.EnableAgedDebtBreakdown = EnableAgedDebtBreakdown;
        this.AgedDebtBreakdownItems = AgedDebtBreakdownItems;
        this.IsCurrentPasswordRequired = IsCurrentPasswordRequired;
        this.EnableLoyaltyLedger = EnableLoyaltyLedger;
        this.EnableRedeemPaymentMethod = EnableRedeemPaymentMethod;
        this.RedeemPaymentMethod = RedeemPaymentMethod;
        this.EnablePointsAwardInCloudfy = EnablePointsAwardInCloudfy;

        this.PointsDefaultExpiryPeriod = PointsDefaultExpiryPeriod;
        this.PointsDefaultExpiryPeriodType = PointsDefaultExpiryPeriodType;
        this.FTPUrl = FTPUrl;
        this.FTPHost = FTPHost;
        this.FTPLogin = FTPLogin;
        this.FTPPassword = FTPPassword;
        this.FTPBaseRoute = FTPBaseRoute;
        this.StockReduction = StockReduction;
        this.DropShipmentSplit = DropShipmentSplit;



        this.BrandPageTitle = BrandPageTitle;



        this.BrandPageUrl = BrandPageUrl;



        this.BrandPageDescription = BrandPageDescription;
        this.IsMobileAppLoginAccess = IsMobileAppLoginAccess;
        this.EnableSortingGrid = EnableSortingGrid;
        this.ExternalRefFieldforOrderNumber = ExternalRefFieldforOrderNumber;



        this.LoginToSeePriceText = LoginToSeePriceText;
        this.Calculateshowoftoplevelmenu = Calculateshowoftoplevelmenu;
        this.EnableLoyaltyPointsToVoucher = EnableLoyaltyPointsToVoucher;
        this.StaticPageSearch = StaticPageSearch;
        this.ProductLayouts_ProductType = ProductLayouts_ProductType;

    }
    public SiteSettingsModel Update(


   long settingsID,
   long? SiteId,

   string? SitePhoneNumber,

   string? SiteCompanyAddress,

   string? ContactUsEmailAddress,

   string? OrdersEmailAddress,

   string? TwitterURL,

   string? FacebookURL,

   string? InstagramURL,

   string? MinimumOrderValue,

   string? FreeDeliveryLevel,

   string? GoogleAnalyticsTrackingID,

   string? EmailBCC,

   string? RegistrationNo,
   string? EmailFooter,

   string? SiteLogo,

   string? SiteFavicon,

   string? HeaderBanner,


   string? RetailPriceLabel,


   string? TradePriceLabel,


   bool? SKU,
   bool? STOCK,
   bool? QTYADD,
   bool? REVIEWS,
   bool? CASEQTY,
   bool? QTYBREAK,


   string? RetailPriceLabel1,


   string? TradePriceLabel1,
   bool? SKU1,
   bool? STOCK1,
   bool? QTYADD1,
   bool? REVIEWS1,
   bool? CASEQTY1,
   bool? QTYBREAK1,
   bool? EnableDemoStoreMessage,
   bool? CreateTradeAccountLogin,
   bool? EnableLiveChat,
   string? ZoopimScript,
   bool? EnableReviews,
   bool? EnableGuestCheckout,
   bool? CurencyConversion,
   string? MageMenuPromotionalMessage,
   bool? ShowHomeLink,
   int? CategoryMenuCount,
   bool? EnablePredictiveSearch,
   bool? EnableSuperClass,
   bool? AllowOrder,
   short? selectedtab,
   bool? ShowBarcode,


   string? UnitForSize,


   string? UnitForWeight,
   bool? ShowRRPWithoutLogin,
   bool? ShowRRPWithStrike,
   bool? ShowPriceWithoutLogin,
   bool? EnableOnCollection,
   bool? IsVatApplicable,
   int? DeiveryRestrictedBy,
   bool? EnableBestSellers,
   bool? EnableLatestProducts,
   bool? EnableSpecialOffers,
   bool? EnableDeliveryDate,


   string? DeliveryDateLabel,
   bool? ShowOutOfStockItem,
   bool? Ordertype,
   bool? ShowStockDueDate,
   bool? ShowCatBannerHeading,
   bool? EnableGoogleTranslater,


   string? LinkedInURL,


   string? YoutubeURL,


   string? PrinterestURL,
   bool? EmableMultipleCurrency,
   bool? EnableMinimumOrderByCountry,
   bool? EnableMultipleSKU,


   string? ReportLogo,
   bool? EnableExistingCustomer,
   bool? EnablePaymentLimit,
   long? DefaultSortingField,
   bool? IsBestSellersFromAdmin,
   bool? IsLatestProductsFromAdmin,
   bool? IsSpecialOffersFromAdmin,
   bool? IsImageCompressed,


   string? Mailchimp_listid,


   string? Mailchimp_apiKey,
   bool? SubscribeMailchimp,
   bool? EnableRoundleOnDetails,
   bool? IsNewLayout,
   bool? IsUpdated,
   bool? ChekoutEditableAddr,
   bool? EnablePendingBasketMail,
   int? setDurationAfterAddedbasket,
   DateTime? LastSendingMail,
   bool? DeliveryAddressAtLogin,

   string? DemoStoreMessage,


   string? DemoStoreMessageLink,
   bool? EnablepriceFilter,
   bool? EnableRightClick,
   string? WelcomeMessageAfterLogin,
   bool? EnableFooterSiteMapLink,
   bool? EnableFooterNewsLink,
   bool? EnableStockQty,
   bool? EnableNewsforInactiveCus,
   int? DeliveryOptionMethod,
   bool? DeliveryOption,
   bool? EnableCustomerAlsoBoughtFeature,
   bool? EnableAbandonedMailfeature,


   string? CopyrightText,
   bool? EnableProductSocialShring,
   bool? IsNextDayDelivery,
   bool EnableEmailBackInStock,


   string TagManagerTrackingId,
   bool? IsSavedBasket,
   bool? MinOrderExvat,

   string? CalculateVatFrom,


   string? Brand,
   bool? EnableCallForPrice,
   bool? EnableDownloadTab,


   string? DownloadTabOption,
   bool? HideCategoryImage,
   bool? GoogleLangSwitchPosition,
   bool? EnableReserveStock,
   decimal? ReserveStockLevel,
   bool? EnableFooterEventsLink,
   bool? EnableStockManagement,


   string? Vat,
   bool? GoogleCustomerReviews,
   bool? ShowProductInMenu,


   string? VimeoLink,
   bool? CurrencyConversion_BeforeLogin,
   bool? CurrencyConversion_AfterLogin,
   bool? ShowTwoProductInCategoryView,


   string? ProductZoom,
   bool? isShowFooterPaymentLogo,
   bool? IsEnableProductReviewsEmailReminder,


   string? ProductDetail,


   string? Delivery,


   string? Materials,
   bool EnableBuyOutOfStock,
   int? HeaderMenuType,
   bool EnableWareHouse,
   byte? EnableSalesRepCode,
   bool? EnableCustomerSpecificeCatalogue,
   bool? IsCustomerEncrypted,
   bool? HideDeliveryChangeFromCheckout,
   bool? HideVoucherCode,
   bool? showmSellerOrder,
   bool? EnableMultiLanguage,
   bool? EnablePunchout,
   bool? EnableLocalTax,
   bool EnableYotpoReviews,
   bool EnableVatverification,
   int? BaseCountry,
   bool? EnableQuickOrder,
   bool? IsOfferPriceFromProduct,
   bool? EnableDownloadOrdersProductImages,
   bool? IsEnableCapitalisationOnSite,
   bool ShowStockStatusFilter,
   bool EnableComments,


   string? GooglePlusLink,
   bool IsEnableNewExtendingDelivery,
   bool ShowDeliveryBreakdown,
   int? PrioritySetting,
   int? BasketCheckoutAlert,


   string? BasketCheckoutAlertText,


   string? NonSaleableMessage,
   bool EnableUserType,
   bool EnableSpendLimits,
   bool EnableAuthorisationOnly,
   int? LimitingPredictiveSearch,
   bool? ShowThumbnailWithPredictiveSearch,


   string? FacebookTrackingID,
   bool IsBespokeMenuEnabled,
   bool SortCategoryByAlphabetically,
   bool EnableCustomerRef,
   int? PriceDecimalPlace,
   bool? EnableCheckoutBillAddress,
   bool? ShowPriceIncVat,
   bool? ShowPriceIncVat1,
   bool? ShowDualPrices,

   string? PageBuilderFontsFiles,


   string? PageBuilderCSSFiles,


   string? PageBuilderJSFiles,
   bool DisableLineLevelPO,
   int? Site404Page,


   string? GoogleMapApiKey,


   string? IndexRankLabel,
   int? DefaultSearchSortingOrder,
   bool EnableCustomerSpecificeProducts,
   int? LayoutSelection,
   bool CalculatedUnitsGridRestricted,
   bool EnableRMARequests,
   int CustomerCatalogueMode,
   bool EnableBundleQty,
   bool EnableDualPrice,
   bool CategoryViewDropdownVarients,
   bool EnableProductSKUBasket,

   string LiveChatVisibility,


   string? CalculatedUnits,
   int EnableGridView,
   int EnableListView,
   int EnableTradeView,
   bool ApplyVATtoDelivery,
   bool EnableAnotherAddress,
   bool DeliveryNoteDispatchCutOff,
   TimeSpan? DeliveryNoteDispatchCutOffTime,
   bool DeliveryNoteFutureDeliveryDate,
   bool ShowSaveAmount,
   byte DetailpageLayout,
   bool AllowEditingDeliveryAddressONCheckout,

   bool EnableTotalUnit,


   string? NoDeliveryChoiceMessage,
   bool? EnableOrderSplit,

   string? DeliveryNoteComment,


   string? BingWebmasterTrackingId,
   byte EnableCheckoutEmailAddress,
   bool? ShowQtyAsQuantityStock,
   bool CalculateDefaultPrice,
   byte Productlistlayout,
   bool EnableMultiWarehouse,
   bool EnableEmailInvoice,
   int InvoiceTemplate,
   bool ShowDeliveryAddressonQuote,


   string? LoginPageURL,
   bool EnableCustomerDueStock,
   int DueStockQty,


   string? InStockColour,


   string? OutofStockColour,


   string? DueStockColour,
   int ShowFromPrice,
   bool Favourites_BeforLogin,
   bool Favourites_AfterLogin,
   bool ShowCategoryImagesOnLandingPage,
   long? ShipingTax,
   bool DisableSubTotal,
   int ProductVatMethod,


   string? SupCatBgColorCode,


   string? RRPcurrency,
   bool ShowRRP,
   bool ShowRRP1,
   int ProductIframeZoom,


   string? Detailpagetextcolor1,


   string? Detailpagetextcolor2,



   string? Detailpagetextcolor3,


   string? Tabbottombordercolour,
   bool DisablePriceUpdateOnBasket,
   bool EnableBranchName,


   string? QuoteEmailAddress,
   int MiniBasket,
   bool TransparentHeader,


   string? InvoicePaymentType,
   bool EnablePaymentOfInvoices,
   int PartialPaymentOrder,
   bool EnableAccountAgedDebt,


   string? BusinessDays,
   bool DisableLineLevelDeliveryDate,
   bool EnableLinkMultiAccount,


   string? BackOrderText,
   bool EnableTrustedShops,


   string? TrustedShops,
   bool ShowMaxOrderQtyOnProductDetailPage,
   bool PersonalisedLandingPages,
   bool DefaultCustomRegistrationForm,
   bool EnablePersonalisation,
   bool? IsQuickorderAutocomplete,


   string? CustomiseSearchText,
   int? EnableCompanyMandatory,
   bool EnableDeliveryAddressEmails,
   bool? EnableFinalDestination,
   int? Trade_View_Attribute_ID,
   bool? IsQuotesOnly,
   bool EnableNewInvoice,
   bool? EnableCheckoutquestion,


   string? Checkoutmessage,
   bool EnableProductSKU,
   bool EnableProductName,


   string? AttributeTabText,


   string? Documentation,
   bool? EnableDropShipemailsforQuotes,


   string? DateFormat,
   bool ContactUsPopUp,
   bool CustomContactUsField,
   bool AllowRegistration,
   bool EnableCustomerQuestion,
   bool EnableProductLedger,
   bool EnableHotJarAnalytics,

   string? SearchableFields,


   string? HotjarTrackingCodeID,


   string? HotjarSnippetVersion,


   string? BackOrderTextColour,


   string? ShowDescription,
   bool EnablePrintBasket,
   bool? EnableAttributeTab,


   string? VideoTabText,
   int? Gridpagesize,

   string? GridLayoutColour1,

   string? GridLayoutColour2,
   bool PaymentMethodPrices,
   bool EnableCommaSeperatedNumbers,
   bool? InvoicesManageAvailableBalance,


   string? SoftCreditLimitMessages,


   string? hardCreditLimitMessages,
   bool EnableTermlyCookie,


   string? TermlyCookieEmbedId,


   string? TermlyManageCookiePreferencesLocation,
   bool? ShowAvailableBlanceChckout,
   int? GridViewAttributeDisplay,
   bool EnablePAFIntegration,
   int PAFIntegrationService,
   bool CreateCustomerRecord,
   bool EnableQtyChangeAtCheckout,
   int InvoiceType,

   string? InvoiceAdditionalInfo,


   string? InvoiceDocName,


   string? InvoiceCompanyName,


   string? InvoiceAdd1,


   string? InvoiceAdd2,


   string? InvoiceCity,


   string? InvoiceCounty,


   string? InvoicePostCode,


   string? InvoiceVatNo,


   string? InvoiceTel,


   string? InvoiceFax,


   bool EnableFeefoReview,


   string? MerchantIdentifier,


   string? PricingColour,
   bool EnableDonations,


   string? DonationsSKU,


   string? DonationsItemDescription,


   string? DonationsSectionText,
   int CategoryLayoutOption,
   bool RestrictCategoryListview,
   bool EnableRelatedWhenOutOfStock,
   bool ChannableImport,

   string? ChannableURL,
   string? ChannableToken,
   int ChannableFrequency,
   byte CheckoutPageType,


   string? SelectCreditBalance,
   byte? ImagesLayout,
   bool? ShowSKUCodeOnDetail,


   string? ShowCategoryDescription,
   bool EnableSelfVATExemption,


   string? SelfVATExemptionComment,
   bool GridAddToBasket,
   int GridImage,


   string? DonationGiftAidText,


   string? DonationAccountType,
   bool? EnableFreeDeliveryCalculation,
   bool EnablePersonalisationMultipleQty,


   string? reCaptchaSiteKey,


   string? reCaptchaSecretKey,
   bool? DisplayCategoryAltImages,
   bool? EnableCategoryStockQty,
   bool DeliverToBillAddress,

   string? CheckoutMessage2,
   bool IsPinchToZoom,
   bool IsRegistrationActive,
   bool? EnableDescriptionsPhoneOrders,


   string? PhoneOrderDescriptionOptions,
   bool CustomerAmendCreditLimit,
   bool IsAltTextBlank,
   int? AddToBasketPosition,
   bool IsMultiLocationWarning,


   string? MultiLocationWarningMsg,
   bool EnableMenuDefaultExpanded,
   bool EnableGridViewSetting,
   bool EnableTradeViewSetting,
   bool Ishoverbasket,
   bool IsEnableShipperHQ,
   bool? EnableYourPrice,


   string? HeaderBannerAltText,


   string? reCaptchaSiteKeyV2,
   bool EnablePartFinder,
   bool ShowCollectionAddress,
   decimal V2FallbackScoreLimit,


   string? reCaptchaSecretKeyV2,


   string? SiteNoImageAltText,
   bool AnchorLayout,
   long DefaultAutoCategorySortingOrder,
   bool OverrideDefaultChecksonBasket,
   int GridViewAttributeDisplay1,
   int ShowFromPrice1,
   bool GridAddToBasket1,
   int GridImage1,
   bool ExportTradeView,
   bool EnableViewBasketButton,
   int PAFIntegrationResult,
   bool EnableExtendedUOS,
   bool BasketPersonalisationDisplay,
   bool EnableSyrenisCookie,


   string? SyrenisCookieLicenseID,


   string? SyrenisCookieAccessKey,


   string? SyrenisCookieStyleSheet,
   string? DeliveryAddressZoneDefault,
   bool EnableCreditHoldMsgBanner,
   bool EnablePreLoad,
   int BackOrderSetting,


   string? HideOrderButtons,


   string? CatDescTextColor,

   bool EnableCirrusCallRecording,


   string? CirrusUsername,


   string? CirrusPassword,
   bool DeliveryBreakdownLevel,
   bool TopRowIsDefault,



   string? ProductTitleColour,
   int TitleTextSize,


   string? SelectedTabColour,


   string? TableHeaderBackgroundColour,


   string? TableHeaderTextColour,
   int CreditHoldBannerMsg,
   int AttributeFilterView,
   bool SeenCheaperPrice,
   int TaxCalculationDecimalPlaces,
   bool EnableCustomerRegistration,
   bool SiteUnderMaintenance,
   int PredictiveSearchAttribute,
   bool EnableMyAccountSalesRep,


   string? beforeFromPriceColor,


   string? afterFromPriceColor,
   bool EnableCivicCookie,


   string? CivicCookieAPIKey,


   string? CivicCookieProduct,
   bool AllowPopularSearchesAndLastUserSearches,
   bool SuperClassURL,
   bool EnableDedicatedBrandsPage,
   bool AddtoBasketNotification,
   int StockMessageLocation,


   string? OrderReceiptPaymentType,
   bool FinalDestinationEmail,
   bool ShowEmail_CallUs,


   string? ProductDescription5Text,


   string? ProductDescription6Text,
   bool ShowInBasketQuantity,
   bool EnablePaidonResults,


   string? MerchantId_Paidon,

   string? FooterScript_PaidonResult,
   bool TransactionalEmail_DownloadableProduct,
   string? OrderMin_MaxErrorMessage,
   bool MultipleCollectionLocation,
   bool EnhancedErrorValidation,
   string? HeaderScript,
   string? FooterScript,
   bool IsUseStockStatusLabel,


   string BasketArchive,
   bool EnableBackOrderMessage,


   string? DeliveryDateAlertMessage,
   int SelectedBrandDirectory,
   bool IsEnableDeliveryByOrderPercentage,
   bool PercentageDeliveryCharge_Type,
   bool EnableInvoiceOrderComments,
   bool CurrencySymbol,
   bool MultiProductImagesOption,
   bool EnableAgedDebtTable,
   bool EnableAgedDebtBreakdown,
   string? AgedDebtBreakdownItems,
   bool IsCurrentPasswordRequired,
   bool EnableLoyaltyLedger,
   bool EnableRedeemPaymentMethod,
   int RedeemPaymentMethod,
   bool EnablePointsAwardInCloudfy,

   int PointsDefaultExpiryPeriod,
   string PointsDefaultExpiryPeriodType,
   string? FTPUrl,
   string? FTPHost,
   string? FTPLogin,
   string? FTPPassword,
   string? FTPBaseRoute,
   int StockReduction,
   int DropShipmentSplit,


   string? BrandPageTitle,


   string? BrandPageUrl,


   string? BrandPageDescription,
   int IsMobileAppLoginAccess,
   bool EnableSortingGrid,
   bool ExternalRefFieldforOrderNumber,


   string? LoginToSeePriceText,
   bool Calculateshowoftoplevelmenu,
   bool EnableLoyaltyPointsToVoucher,
   bool StaticPageSearch,
   bool ProductLayouts_ProductType
      )
    {

        this.settingsID = settingsID;
        this.SiteId = SiteId;


        this.SitePhoneNumber = SitePhoneNumber;


        this.SiteCompanyAddress = SiteCompanyAddress;


        this.ContactUsEmailAddress = ContactUsEmailAddress;


        this.OrdersEmailAddress = OrdersEmailAddress;


        this.TwitterURL = TwitterURL;


        this.FacebookURL = FacebookURL;


        this.InstagramURL = InstagramURL;


        this.MinimumOrderValue = MinimumOrderValue;


        this.FreeDeliveryLevel = FreeDeliveryLevel;


        this.GoogleAnalyticsTrackingID = GoogleAnalyticsTrackingID;


        this.EmailBCC = EmailBCC;


        this.RegistrationNo = RegistrationNo;
        this.EmailFooter = EmailFooter;


        this.SiteLogo = SiteLogo;


        this.SiteFavicon = SiteFavicon;


        this.HeaderBanner = HeaderBanner;



        this.RetailPriceLabel = RetailPriceLabel;



        this.TradePriceLabel = TradePriceLabel;



        this.SKU = SKU;
        this.STOCK = STOCK;
        this.QTYADD = QTYADD;
        this.REVIEWS = REVIEWS;
        this.CASEQTY = CASEQTY;
        this.QTYBREAK = QTYBREAK;



        this.RetailPriceLabel1 = RetailPriceLabel1;



        this.TradePriceLabel1 = TradePriceLabel1;
        this.SKU1 = SKU1;
        this.STOCK1 = STOCK1;
        this.QTYADD1 = QTYADD1;
        this.REVIEWS1 = REVIEWS1;
        this.CASEQTY1 = CASEQTY1;
        this.QTYBREAK1 = QTYBREAK1;
        this.EnableDemoStoreMessage = EnableDemoStoreMessage;
        this.CreateTradeAccountLogin = CreateTradeAccountLogin;
        this.EnableLiveChat = EnableLiveChat;
        this.ZoopimScript = ZoopimScript;
        this.EnableReviews = EnableReviews;
        this.EnableGuestCheckout = EnableGuestCheckout;
        this.CurencyConversion = CurencyConversion;
        this.MageMenuPromotionalMessage = MageMenuPromotionalMessage;
        this.ShowHomeLink = ShowHomeLink;
        this.CategoryMenuCount = CategoryMenuCount;
        this.EnablePredictiveSearch = EnablePredictiveSearch;
        this.EnableSuperClass = EnableSuperClass;
        this.AllowOrder = AllowOrder;
        this.selectedtab = selectedtab;
        this.ShowBarcode = ShowBarcode;



        this.UnitForSize = UnitForSize;



        this.UnitForWeight = UnitForWeight;
        this.ShowRRPWithoutLogin = ShowRRPWithoutLogin;
        this.ShowRRPWithStrike = ShowRRPWithStrike;
        this.ShowPriceWithoutLogin = ShowPriceWithoutLogin;
        this.EnableOnCollection = EnableOnCollection;
        this.IsVatApplicable = IsVatApplicable;
        this.DeiveryRestrictedBy = DeiveryRestrictedBy;
        this.EnableBestSellers = EnableBestSellers;
        this.EnableLatestProducts = EnableLatestProducts;
        this.EnableSpecialOffers = EnableSpecialOffers;
        this.EnableDeliveryDate = EnableDeliveryDate;



        this.DeliveryDateLabel = DeliveryDateLabel;
        this.ShowOutOfStockItem = ShowOutOfStockItem;
        this.Ordertype = Ordertype;
        this.ShowStockDueDate = ShowStockDueDate;
        this.ShowCatBannerHeading = ShowCatBannerHeading;
        this.EnableGoogleTranslater = EnableGoogleTranslater;



        this.LinkedInURL = LinkedInURL;



        this.YoutubeURL = YoutubeURL;



        this.PrinterestURL = PrinterestURL;
        this.EmableMultipleCurrency = EmableMultipleCurrency;
        this.EnableMinimumOrderByCountry = EnableMinimumOrderByCountry;
        this.EnableMultipleSKU = EnableMultipleSKU;



        this.ReportLogo = ReportLogo;
        this.EnableExistingCustomer = EnableExistingCustomer;
        this.EnablePaymentLimit = EnablePaymentLimit;
        this.DefaultSortingField = DefaultSortingField;
        this.IsBestSellersFromAdmin = IsBestSellersFromAdmin;
        this.IsLatestProductsFromAdmin = IsLatestProductsFromAdmin;
        this.IsSpecialOffersFromAdmin = IsSpecialOffersFromAdmin;
        this.IsImageCompressed = IsImageCompressed;



        this.Mailchimp_listid = Mailchimp_listid;



        this.Mailchimp_apiKey = Mailchimp_apiKey;
        this.SubscribeMailchimp = SubscribeMailchimp;
        this.EnableRoundleOnDetails = EnableRoundleOnDetails;
        this.IsNewLayout = IsNewLayout;
        this.IsUpdated = IsUpdated;
        this.ChekoutEditableAddr = ChekoutEditableAddr;
        this.EnablePendingBasketMail = EnablePendingBasketMail;
        this.setDurationAfterAddedbasket = setDurationAfterAddedbasket;
        this.LastSendingMail = LastSendingMail;
        this.DeliveryAddressAtLogin = DeliveryAddressAtLogin;

        this.DemoStoreMessage = DemoStoreMessage;

        this.DemoStoreMessageLink = DemoStoreMessageLink;
        this.EnablepriceFilter = EnablepriceFilter;
        this.EnableRightClick = EnableRightClick;
        this.WelcomeMessageAfterLogin = WelcomeMessageAfterLogin;
        this.EnableFooterSiteMapLink = EnableFooterSiteMapLink;
        this.EnableFooterNewsLink = EnableFooterNewsLink;
        this.EnableStockQty = EnableStockQty;
        this.EnableNewsforInactiveCus = EnableNewsforInactiveCus;
        this.DeliveryOptionMethod = DeliveryOptionMethod;
        this.DeliveryOption = DeliveryOption;
        this.EnableCustomerAlsoBoughtFeature = EnableCustomerAlsoBoughtFeature;
        this.EnableAbandonedMailfeature = EnableAbandonedMailfeature;



        this.CopyrightText = CopyrightText;
        this.EnableProductSocialShring = EnableProductSocialShring;
        this.IsNextDayDelivery = IsNextDayDelivery;
        this.EnableEmailBackInStock = EnableEmailBackInStock;



        this.TagManagerTrackingId = TagManagerTrackingId;
        this.IsSavedBasket = IsSavedBasket;
        this.MinOrderExvat = MinOrderExvat;

        this.CalculateVatFrom = CalculateVatFrom;



        this.Brand = Brand;
        this.EnableCallForPrice = EnableCallForPrice;
        this.EnableDownloadTab = EnableDownloadTab;



        this.DownloadTabOption = DownloadTabOption;
        this.HideCategoryImage = HideCategoryImage;
        this.GoogleLangSwitchPosition = GoogleLangSwitchPosition;
        this.EnableReserveStock = EnableReserveStock;
        this.ReserveStockLevel = ReserveStockLevel;
        this.EnableFooterEventsLink = EnableFooterEventsLink;
        this.EnableStockManagement = EnableStockManagement;



        this.Vat = Vat;
        this.GoogleCustomerReviews = GoogleCustomerReviews;
        this.ShowProductInMenu = ShowProductInMenu;



        this.VimeoLink = VimeoLink;
        this.CurrencyConversion_BeforeLogin = CurrencyConversion_BeforeLogin;
        this.CurrencyConversion_AfterLogin = CurrencyConversion_AfterLogin;
        this.ShowTwoProductInCategoryView = ShowTwoProductInCategoryView;



        this.ProductZoom = ProductZoom;
        this.isShowFooterPaymentLogo = isShowFooterPaymentLogo;
        this.IsEnableProductReviewsEmailReminder = IsEnableProductReviewsEmailReminder;



        this.ProductDetail = ProductDetail;



        this.Delivery = Delivery;



        this.Materials = Materials;
        this.EnableBuyOutOfStock = EnableBuyOutOfStock;
        this.HeaderMenuType = HeaderMenuType;
        this.EnableWareHouse = EnableWareHouse;
        this.EnableSalesRepCode = EnableSalesRepCode;
        this.EnableCustomerSpecificeCatalogue = EnableCustomerSpecificeCatalogue;
        this.IsCustomerEncrypted = IsCustomerEncrypted;
        this.HideDeliveryChangeFromCheckout = HideDeliveryChangeFromCheckout;
        this.HideVoucherCode = HideVoucherCode;
        this.showmSellerOrder = showmSellerOrder;
        this.EnableMultiLanguage = EnableMultiLanguage;
        this.EnablePunchout = EnablePunchout;
        this.EnableLocalTax = EnableLocalTax;
        this.EnableYotpoReviews = EnableYotpoReviews;
        this.EnableVatverification = EnableVatverification;
        this.BaseCountry = BaseCountry;
        this.EnableQuickOrder = EnableQuickOrder;
        this.IsOfferPriceFromProduct = IsOfferPriceFromProduct;
        this.EnableDownloadOrdersProductImages = EnableDownloadOrdersProductImages;
        this.IsEnableCapitalisationOnSite = IsEnableCapitalisationOnSite;
        this.ShowStockStatusFilter = ShowStockStatusFilter;
        this.EnableComments = EnableComments;



        this.GooglePlusLink = GooglePlusLink;
        this.IsEnableNewExtendingDelivery = IsEnableNewExtendingDelivery;
        this.ShowDeliveryBreakdown = ShowDeliveryBreakdown;
        this.PrioritySetting = PrioritySetting;
        this.BasketCheckoutAlert = BasketCheckoutAlert;



        this.BasketCheckoutAlertText = BasketCheckoutAlertText;



        this.NonSaleableMessage = NonSaleableMessage;
        this.EnableUserType = EnableUserType;
        this.EnableSpendLimits = EnableSpendLimits;
        this.EnableAuthorisationOnly = EnableAuthorisationOnly;
        this.LimitingPredictiveSearch = LimitingPredictiveSearch;
        this.ShowThumbnailWithPredictiveSearch = ShowThumbnailWithPredictiveSearch;



        this.FacebookTrackingID = FacebookTrackingID;
        this.IsBespokeMenuEnabled = IsBespokeMenuEnabled;
        this.SortCategoryByAlphabetically = SortCategoryByAlphabetically;
        this.EnableCustomerRef = EnableCustomerRef;
        this.PriceDecimalPlace = PriceDecimalPlace;
        this.EnableCheckoutBillAddress = EnableCheckoutBillAddress;
        this.ShowPriceIncVat = ShowPriceIncVat;
        this.ShowPriceIncVat1 = ShowPriceIncVat1;
        this.ShowDualPrices = ShowDualPrices;

        this.PageBuilderFontsFiles = PageBuilderFontsFiles;



        this.PageBuilderCSSFiles = PageBuilderCSSFiles;



        this.PageBuilderJSFiles = PageBuilderJSFiles;
        this.DisableLineLevelPO = DisableLineLevelPO;
        this.Site404Page = Site404Page;



        this.GoogleMapApiKey = GoogleMapApiKey;



        this.IndexRankLabel = IndexRankLabel;
        this.DefaultSearchSortingOrder = DefaultSearchSortingOrder;
        this.EnableCustomerSpecificeProducts = EnableCustomerSpecificeProducts;
        this.LayoutSelection = LayoutSelection;
        this.CalculatedUnitsGridRestricted = CalculatedUnitsGridRestricted;
        this.EnableRMARequests = EnableRMARequests;
        this.CustomerCatalogueMode = CustomerCatalogueMode;
        this.EnableBundleQty = EnableBundleQty;
        this.EnableDualPrice = EnableDualPrice;
        this.CategoryViewDropdownVarients = CategoryViewDropdownVarients;
        this.EnableProductSKUBasket = EnableProductSKUBasket;

        this.LiveChatVisibility = LiveChatVisibility;



        this.CalculatedUnits = CalculatedUnits;
        this.EnableGridView = EnableGridView;
        this.EnableListView = EnableListView;
        this.EnableTradeView = EnableTradeView;
        this.ApplyVATtoDelivery = ApplyVATtoDelivery;
        this.EnableAnotherAddress = EnableAnotherAddress;
        this.DeliveryNoteDispatchCutOff = DeliveryNoteDispatchCutOff;
        this.DeliveryNoteDispatchCutOffTime = DeliveryNoteDispatchCutOffTime;
        this.DeliveryNoteFutureDeliveryDate = DeliveryNoteFutureDeliveryDate;
        this.ShowSaveAmount = ShowSaveAmount;
        this.DetailpageLayout = DetailpageLayout;
        this.AllowEditingDeliveryAddressONCheckout = AllowEditingDeliveryAddressONCheckout;

        this.EnableTotalUnit = EnableTotalUnit;



        this.NoDeliveryChoiceMessage = NoDeliveryChoiceMessage;
        this.EnableOrderSplit = EnableOrderSplit;

        this.DeliveryNoteComment = DeliveryNoteComment;



        this.BingWebmasterTrackingId = BingWebmasterTrackingId;
        this.EnableCheckoutEmailAddress = EnableCheckoutEmailAddress;
        this.ShowQtyAsQuantityStock = ShowQtyAsQuantityStock;
        this.CalculateDefaultPrice = CalculateDefaultPrice;
        this.Productlistlayout = Productlistlayout;
        this.EnableMultiWarehouse = EnableMultiWarehouse;
        this.EnableEmailInvoice = EnableEmailInvoice;
        this.InvoiceTemplate = InvoiceTemplate;
        this.ShowDeliveryAddressonQuote = ShowDeliveryAddressonQuote;



        this.LoginPageURL = LoginPageURL;
        this.EnableCustomerDueStock = EnableCustomerDueStock;
        this.DueStockQty = DueStockQty;



        this.InStockColour = InStockColour;



        this.OutofStockColour = OutofStockColour;



        this.DueStockColour = DueStockColour;
        this.ShowFromPrice = ShowFromPrice;
        this.Favourites_BeforLogin = Favourites_BeforLogin;
        this.Favourites_AfterLogin = Favourites_AfterLogin;
        this.ShowCategoryImagesOnLandingPage = ShowCategoryImagesOnLandingPage;
        this.ShipingTax = ShipingTax;
        this.DisableSubTotal = DisableSubTotal;
        this.ProductVatMethod = ProductVatMethod;



        this.SupCatBgColorCode = SupCatBgColorCode;



        this.RRPcurrency = RRPcurrency;
        this.ShowRRP = ShowRRP;
        this.ShowRRP1 = ShowRRP1;
        this.ProductIframeZoom = ProductIframeZoom;



        this.Detailpagetextcolor1 = Detailpagetextcolor1;



        this.Detailpagetextcolor2 = Detailpagetextcolor2;




        this.Detailpagetextcolor3 = Detailpagetextcolor3;



        this.Tabbottombordercolour = Tabbottombordercolour;
        this.DisablePriceUpdateOnBasket = DisablePriceUpdateOnBasket;
        this.EnableBranchName = EnableBranchName;



        this.QuoteEmailAddress = QuoteEmailAddress;
        this.MiniBasket = MiniBasket;
        this.TransparentHeader = TransparentHeader;



        this.InvoicePaymentType = InvoicePaymentType;
        this.EnablePaymentOfInvoices = EnablePaymentOfInvoices;
        this.PartialPaymentOrder = PartialPaymentOrder;
        this.EnableAccountAgedDebt = EnableAccountAgedDebt;



        this.BusinessDays = BusinessDays;
        this.DisableLineLevelDeliveryDate = DisableLineLevelDeliveryDate;
        this.EnableLinkMultiAccount = EnableLinkMultiAccount;



        this.BackOrderText = BackOrderText;
        this.EnableTrustedShops = EnableTrustedShops;



        this.TrustedShops = TrustedShops;
        this.ShowMaxOrderQtyOnProductDetailPage = ShowMaxOrderQtyOnProductDetailPage;
        this.PersonalisedLandingPages = PersonalisedLandingPages;
        this.DefaultCustomRegistrationForm = DefaultCustomRegistrationForm;
        this.EnablePersonalisation = EnablePersonalisation;
        this.IsQuickorderAutocomplete = IsQuickorderAutocomplete;



        this.CustomiseSearchText = CustomiseSearchText;
        this.EnableCompanyMandatory = EnableCompanyMandatory;
        this.EnableDeliveryAddressEmails = EnableDeliveryAddressEmails;
        this.EnableFinalDestination = EnableFinalDestination;
        this.Trade_View_Attribute_ID = Trade_View_Attribute_ID;
        this.IsQuotesOnly = IsQuotesOnly;
        this.EnableNewInvoice = EnableNewInvoice;
        this.EnableCheckoutquestion = EnableCheckoutquestion;



        this.Checkoutmessage = Checkoutmessage;
        this.EnableProductSKU = EnableProductSKU;
        this.EnableProductName = EnableProductName;



        this.AttributeTabText = AttributeTabText;



        this.Documentation = Documentation;
        this.EnableDropShipemailsforQuotes = EnableDropShipemailsforQuotes;



        this.DateFormat = DateFormat;
        this.ContactUsPopUp = ContactUsPopUp;
        this.CustomContactUsField = CustomContactUsField;
        this.AllowRegistration = AllowRegistration;
        this.EnableCustomerQuestion = EnableCustomerQuestion;
        this.EnableProductLedger = EnableProductLedger;
        this.EnableHotJarAnalytics = EnableHotJarAnalytics;

        this.SearchableFields = SearchableFields;



        this.HotjarTrackingCodeID = HotjarTrackingCodeID;



        this.HotjarSnippetVersion = HotjarSnippetVersion;



        this.BackOrderTextColour = BackOrderTextColour;



        this.ShowDescription = ShowDescription;
        this.EnablePrintBasket = EnablePrintBasket;
        this.EnableAttributeTab = EnableAttributeTab;



        this.VideoTabText = VideoTabText;
        this.Gridpagesize = Gridpagesize;

        this.GridLayoutColour1 = GridLayoutColour1;

        this.GridLayoutColour2 = GridLayoutColour2;
        this.PaymentMethodPrices = PaymentMethodPrices;
        this.EnableCommaSeperatedNumbers = EnableCommaSeperatedNumbers;
        this.InvoicesManageAvailableBalance = InvoicesManageAvailableBalance;



        this.SoftCreditLimitMessages = SoftCreditLimitMessages;



        this.hardCreditLimitMessages = hardCreditLimitMessages;
        this.EnableTermlyCookie = EnableTermlyCookie;



        this.TermlyCookieEmbedId = TermlyCookieEmbedId;



        this.TermlyManageCookiePreferencesLocation = TermlyManageCookiePreferencesLocation;
        this.ShowAvailableBlanceChckout = ShowAvailableBlanceChckout;
        this.GridViewAttributeDisplay = GridViewAttributeDisplay;
        this.EnablePAFIntegration = EnablePAFIntegration;
        this.PAFIntegrationService = PAFIntegrationService;
        this.CreateCustomerRecord = CreateCustomerRecord;
        this.EnableQtyChangeAtCheckout = EnableQtyChangeAtCheckout;
        this.InvoiceType = InvoiceType;

        this.InvoiceAdditionalInfo = InvoiceAdditionalInfo;



        this.InvoiceDocName = InvoiceDocName;



        this.InvoiceCompanyName = InvoiceCompanyName;



        this.InvoiceAdd1 = InvoiceAdd1;



        this.InvoiceAdd2 = InvoiceAdd2;



        this.InvoiceCity = InvoiceCity;



        this.InvoiceCounty = InvoiceCounty;



        this.InvoicePostCode = InvoicePostCode;



        this.InvoiceVatNo = InvoiceVatNo;



        this.InvoiceTel = InvoiceTel;



        this.InvoiceFax = InvoiceFax;



        this.EnableFeefoReview = EnableFeefoReview;



        this.MerchantIdentifier = MerchantIdentifier;



        this.PricingColour = PricingColour;
        this.EnableDonations = EnableDonations;



        this.DonationsSKU = DonationsSKU;



        this.DonationsItemDescription = DonationsItemDescription;



        this.DonationsSectionText = DonationsSectionText;
        this.CategoryLayoutOption = CategoryLayoutOption;
        this.RestrictCategoryListview = RestrictCategoryListview;
        this.EnableRelatedWhenOutOfStock = EnableRelatedWhenOutOfStock;
        this.ChannableImport = ChannableImport;

        this.ChannableURL = ChannableURL;
        this.ChannableToken = ChannableToken;
        this.ChannableFrequency = ChannableFrequency;
        this.CheckoutPageType = CheckoutPageType;



        this.SelectCreditBalance = SelectCreditBalance;
        this.ImagesLayout = ImagesLayout;
        this.ShowSKUCodeOnDetail = ShowSKUCodeOnDetail;



        this.ShowCategoryDescription = ShowCategoryDescription;
        this.EnableSelfVATExemption = EnableSelfVATExemption;



        this.SelfVATExemptionComment = SelfVATExemptionComment;
        this.GridAddToBasket = GridAddToBasket;
        this.GridImage = GridImage;



        this.DonationGiftAidText = DonationGiftAidText;



        this.DonationAccountType = DonationAccountType;
        this.EnableFreeDeliveryCalculation = EnableFreeDeliveryCalculation;
        this.EnablePersonalisationMultipleQty = EnablePersonalisationMultipleQty;



        this.reCaptchaSiteKey = reCaptchaSiteKey;



        this.reCaptchaSecretKey = reCaptchaSecretKey;
        this.DisplayCategoryAltImages = DisplayCategoryAltImages;
        this.EnableCategoryStockQty = EnableCategoryStockQty;
        this.DeliverToBillAddress = DeliverToBillAddress;

        this.CheckoutMessage2 = CheckoutMessage2;
        this.IsPinchToZoom = IsPinchToZoom;
        this.IsRegistrationActive = IsRegistrationActive;
        this.EnableDescriptionsPhoneOrders = EnableDescriptionsPhoneOrders;



        this.PhoneOrderDescriptionOptions = PhoneOrderDescriptionOptions;
        this.CustomerAmendCreditLimit = CustomerAmendCreditLimit;
        this.IsAltTextBlank = IsAltTextBlank;
        this.AddToBasketPosition = AddToBasketPosition;
        this.IsMultiLocationWarning = IsMultiLocationWarning;



        this.MultiLocationWarningMsg = MultiLocationWarningMsg;
        this.EnableMenuDefaultExpanded = EnableMenuDefaultExpanded;
        this.EnableGridViewSetting = EnableGridViewSetting;
        this.EnableTradeViewSetting = EnableTradeViewSetting;
        this.Ishoverbasket = Ishoverbasket;
        this.IsEnableShipperHQ = IsEnableShipperHQ;
        this.EnableYourPrice = EnableYourPrice;



        this.HeaderBannerAltText = HeaderBannerAltText;



        this.reCaptchaSiteKeyV2 = reCaptchaSiteKeyV2;
        this.EnablePartFinder = EnablePartFinder;
        this.ShowCollectionAddress = ShowCollectionAddress;
        this.V2FallbackScoreLimit = V2FallbackScoreLimit;



        this.reCaptchaSecretKeyV2 = reCaptchaSecretKeyV2;



        this.SiteNoImageAltText = SiteNoImageAltText;
        this.AnchorLayout = AnchorLayout;
        this.DefaultAutoCategorySortingOrder = DefaultAutoCategorySortingOrder;
        this.OverrideDefaultChecksonBasket = OverrideDefaultChecksonBasket;
        this.GridViewAttributeDisplay1 = GridViewAttributeDisplay1;
        this.ShowFromPrice1 = ShowFromPrice1;
        this.GridAddToBasket1 = GridAddToBasket1;
        this.GridImage1 = GridImage1;
        this.ExportTradeView = ExportTradeView;
        this.EnableViewBasketButton = EnableViewBasketButton;
        this.PAFIntegrationResult = PAFIntegrationResult;
        this.EnableExtendedUOS = EnableExtendedUOS;
        this.BasketPersonalisationDisplay = BasketPersonalisationDisplay;
        this.EnableSyrenisCookie = EnableSyrenisCookie;



        this.SyrenisCookieLicenseID = SyrenisCookieLicenseID;



        this.SyrenisCookieAccessKey = SyrenisCookieAccessKey;



        this.SyrenisCookieStyleSheet = SyrenisCookieStyleSheet;
        this.DeliveryAddressZoneDefault = DeliveryAddressZoneDefault;
        this.EnableCreditHoldMsgBanner = EnableCreditHoldMsgBanner;
        this.EnablePreLoad = EnablePreLoad;
        this.BackOrderSetting = BackOrderSetting;



        this.HideOrderButtons = HideOrderButtons;



        this.CatDescTextColor = CatDescTextColor;

        this.EnableCirrusCallRecording = EnableCirrusCallRecording;



        this.CirrusUsername = CirrusUsername;



        this.CirrusPassword = CirrusPassword;
        this.DeliveryBreakdownLevel = DeliveryBreakdownLevel;
        this.TopRowIsDefault = TopRowIsDefault;




        this.ProductTitleColour = ProductTitleColour;
        this.TitleTextSize = TitleTextSize;



        this.SelectedTabColour = SelectedTabColour;



        this.TableHeaderBackgroundColour = TableHeaderBackgroundColour;



        this.TableHeaderTextColour = TableHeaderTextColour;
        this.CreditHoldBannerMsg = CreditHoldBannerMsg;
        this.AttributeFilterView = AttributeFilterView;
        this.SeenCheaperPrice = SeenCheaperPrice;
        this.TaxCalculationDecimalPlaces = TaxCalculationDecimalPlaces;
        this.EnableCustomerRegistration = EnableCustomerRegistration;
        this.SiteUnderMaintenance = SiteUnderMaintenance;
        this.PredictiveSearchAttribute = PredictiveSearchAttribute;
        this.EnableMyAccountSalesRep = EnableMyAccountSalesRep;



        this.beforeFromPriceColor = beforeFromPriceColor;



        this.afterFromPriceColor = afterFromPriceColor;
        this.EnableCivicCookie = EnableCivicCookie;



        this.CivicCookieAPIKey = CivicCookieAPIKey;



        this.CivicCookieProduct = CivicCookieProduct;
        this.AllowPopularSearchesAndLastUserSearches = AllowPopularSearchesAndLastUserSearches;
        this.SuperClassURL = SuperClassURL;
        this.EnableDedicatedBrandsPage = EnableDedicatedBrandsPage;
        this.AddtoBasketNotification = AddtoBasketNotification;
        this.StockMessageLocation = StockMessageLocation;



        this.OrderReceiptPaymentType = OrderReceiptPaymentType;
        this.FinalDestinationEmail = FinalDestinationEmail;
        this.ShowEmail_CallUs = ShowEmail_CallUs;



        this.ProductDescription5Text = ProductDescription5Text;



        this.ProductDescription6Text = ProductDescription6Text;
        this.ShowInBasketQuantity = ShowInBasketQuantity;
        this.EnablePaidonResults = EnablePaidonResults;



        this.MerchantId_Paidon = MerchantId_Paidon;

        this.FooterScript_PaidonResult = FooterScript_PaidonResult;
        this.TransactionalEmail_DownloadableProduct = TransactionalEmail_DownloadableProduct;
        this.OrderMin_MaxErrorMessage = OrderMin_MaxErrorMessage;
        this.MultipleCollectionLocation = MultipleCollectionLocation;
        this.EnhancedErrorValidation = EnhancedErrorValidation;
        this.HeaderScript = HeaderScript;
        this.FooterScript = FooterScript;
        this.IsUseStockStatusLabel = IsUseStockStatusLabel;



        this.BasketArchive = BasketArchive;
        this.EnableBackOrderMessage = EnableBackOrderMessage;



        this.DeliveryDateAlertMessage = DeliveryDateAlertMessage;
        this.SelectedBrandDirectory = SelectedBrandDirectory;
        this.IsEnableDeliveryByOrderPercentage = IsEnableDeliveryByOrderPercentage;
        this.PercentageDeliveryCharge_Type = PercentageDeliveryCharge_Type;
        this.EnableInvoiceOrderComments = EnableInvoiceOrderComments;
        this.CurrencySymbol = CurrencySymbol;
        this.MultiProductImagesOption = MultiProductImagesOption;
        this.EnableAgedDebtTable = EnableAgedDebtTable;
        this.EnableAgedDebtBreakdown = EnableAgedDebtBreakdown;
        this.AgedDebtBreakdownItems = AgedDebtBreakdownItems;
        this.IsCurrentPasswordRequired = IsCurrentPasswordRequired;
        this.EnableLoyaltyLedger = EnableLoyaltyLedger;
        this.EnableRedeemPaymentMethod = EnableRedeemPaymentMethod;
        this.RedeemPaymentMethod = RedeemPaymentMethod;
        this.EnablePointsAwardInCloudfy = EnablePointsAwardInCloudfy;

        this.PointsDefaultExpiryPeriod = PointsDefaultExpiryPeriod;
        this.PointsDefaultExpiryPeriodType = PointsDefaultExpiryPeriodType;
        this.FTPUrl = FTPUrl;
        this.FTPHost = FTPHost;
        this.FTPLogin = FTPLogin;
        this.FTPPassword = FTPPassword;
        this.FTPBaseRoute = FTPBaseRoute;
        this.StockReduction = StockReduction;
        this.DropShipmentSplit = DropShipmentSplit;



        this.BrandPageTitle = BrandPageTitle;



        this.BrandPageUrl = BrandPageUrl;



        this.BrandPageDescription = BrandPageDescription;
        this.IsMobileAppLoginAccess = IsMobileAppLoginAccess;
        this.EnableSortingGrid = EnableSortingGrid;
        this.ExternalRefFieldforOrderNumber = ExternalRefFieldforOrderNumber;



        this.LoginToSeePriceText = LoginToSeePriceText;
        this.Calculateshowoftoplevelmenu = Calculateshowoftoplevelmenu;
        this.EnableLoyaltyPointsToVoucher = EnableLoyaltyPointsToVoucher;
        this.StaticPageSearch = StaticPageSearch;
        this.ProductLayouts_ProductType = ProductLayouts_ProductType;
        return this;
    }
}