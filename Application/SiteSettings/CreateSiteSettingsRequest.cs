﻿using Domain.SiteSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SiteSettings;
public class CreateSiteSettingsRequest : IRequest<SiteSettingsModel>
{


    public long Id { get; set; }
    public long settingsID { get; set; }
    public long? SiteId { get; set; }

    public string? SitePhoneNumber { get; set; }

    public string? SiteCompanyAddress { get; set; }

    public string? ContactUsEmailAddress { get; set; }

    public string? OrdersEmailAddress { get; set; }

    public string? TwitterURL { get; set; }

    public string? FacebookURL { get; set; }

    public string? InstagramURL { get; set; }

    public string? MinimumOrderValue { get; set; }

    public string? FreeDeliveryLevel { get; set; }

    public string? GoogleAnalyticsTrackingID { get; set; }

    public string? EmailBCC { get; set; }

    public string? RegistrationNo { get; set; }
    public string? EmailFooter { get; set; }

    public string? SiteLogo { get; set; }

    public string? SiteFavicon { get; set; }

    public string? HeaderBanner { get; set; }


    public string? RetailPriceLabel { get; set; }


    public string? TradePriceLabel { get; set; }


    public bool? SKU { get; set; }
    public bool? STOCK { get; set; }
    public bool? QTYADD { get; set; }
    public bool? REVIEWS { get; set; }
    public bool? CASEQTY { get; set; }
    public bool? QTYBREAK { get; set; }


    public string? RetailPriceLabel1 { get; set; }


    public string? TradePriceLabel1 { get; set; }
    public bool? SKU1 { get; set; }
    public bool? STOCK1 { get; set; }
    public bool? QTYADD1 { get; set; }
    public bool? REVIEWS1 { get; set; }
    public bool? CASEQTY1 { get; set; }
    public bool? QTYBREAK1 { get; set; }
    public bool? EnableDemoStoreMessage { get; set; }
    public bool? CreateTradeAccountLogin { get; set; }
    public bool? EnableLiveChat { get; set; }
    public string? ZoopimScript { get; set; }
    public bool? EnableReviews { get; set; }
    public bool? EnableGuestCheckout { get; set; }
    public bool? CurencyConversion { get; set; }
    public string? MageMenuPromotionalMessage { get; set; }
    public bool? ShowHomeLink { get; set; }
    public int? CategoryMenuCount { get; set; }
    public bool? EnablePredictiveSearch { get; set; }
    public bool? EnableSuperClass { get; set; }
    public bool? AllowOrder { get; set; }
    public short? selectedtab { get; set; }
    public bool? ShowBarcode { get; set; }


    public string? UnitForSize { get; set; }


    public string? UnitForWeight { get; set; }
    public bool? ShowRRPWithoutLogin { get; set; }
    public bool? ShowRRPWithStrike { get; set; }
    public bool? ShowPriceWithoutLogin { get; set; }
    public bool? EnableOnCollection { get; set; }
    public bool? IsVatApplicable { get; set; }
    public int? DeiveryRestrictedBy { get; set; }
    public bool? EnableBestSellers { get; set; }
    public bool? EnableLatestProducts { get; set; }
    public bool? EnableSpecialOffers { get; set; }
    public bool? EnableDeliveryDate { get; set; }


    public string? DeliveryDateLabel { get; set; }
    public bool? ShowOutOfStockItem { get; set; }
    public bool? Ordertype { get; set; }
    public bool? ShowStockDueDate { get; set; }
    public bool? ShowCatBannerHeading { get; set; }
    public bool? EnableGoogleTranslater { get; set; }


    public string? LinkedInURL { get; set; }


    public string? YoutubeURL { get; set; }


    public string? PrinterestURL { get; set; }
    public bool? EmableMultipleCurrency { get; set; }
    public bool? EnableMinimumOrderByCountry { get; set; }
    public bool? EnableMultipleSKU { get; set; }


    public string? ReportLogo { get; set; }
    public bool? EnableExistingCustomer { get; set; }
    public bool? EnablePaymentLimit { get; set; }
    public long? DefaultSortingField { get; set; }
    public bool? IsBestSellersFromAdmin { get; set; }
    public bool? IsLatestProductsFromAdmin { get; set; }
    public bool? IsSpecialOffersFromAdmin { get; set; }
    public bool? IsImageCompressed { get; set; }


    public string? Mailchimp_listid { get; set; }


    public string? Mailchimp_apiKey { get; set; }
    public bool? SubscribeMailchimp { get; set; }
    public bool? EnableRoundleOnDetails { get; set; }
    public bool? IsNewLayout { get; set; }
    public bool? IsUpdated { get; set; }
    public bool? ChekoutEditableAddr { get; set; }
    public bool? EnablePendingBasketMail { get; set; }
    public int? setDurationAfterAddedbasket { get; set; }
    public DateTime? LastSendingMail { get; set; }
    public bool? DeliveryAddressAtLogin { get; set; }

    public string? DemoStoreMessage { get; set; }


    public string? DemoStoreMessageLink { get; set; }
    public bool? EnablepriceFilter { get; set; }
    public bool? EnableRightClick { get; set; }
    public string? WelcomeMessageAfterLogin { get; set; }
    public bool? EnableFooterSiteMapLink { get; set; }
    public bool? EnableFooterNewsLink { get; set; }
    public bool? EnableStockQty { get; set; }
    public bool? EnableNewsforInactiveCus { get; set; }
    public int? DeliveryOptionMethod { get; set; }
    public bool? DeliveryOption { get; set; }
    public bool? EnableCustomerAlsoBoughtFeature { get; set; }
    public bool? EnableAbandonedMailfeature { get; set; }


    public string? CopyrightText { get; set; }
    public bool? EnableProductSocialShring { get; set; }
    public bool? IsNextDayDelivery { get; set; }
    public bool EnableEmailBackInStock { get; set; }


    public string TagManagerTrackingId { get; set; }
    public bool? IsSavedBasket { get; set; }
    public bool? MinOrderExvat { get; set; }

    public string? CalculateVatFrom { get; set; }


    public string? Brand { get; set; }
    public bool? EnableCallForPrice { get; set; }
    public bool? EnableDownloadTab { get; set; }


    public string? DownloadTabOption { get; set; }
    public bool? HideCategoryImage { get; set; }
    public bool? GoogleLangSwitchPosition { get; set; }
    public bool? EnableReserveStock { get; set; }
    public decimal? ReserveStockLevel { get; set; }
    public bool? EnableFooterEventsLink { get; set; }
    public bool? EnableStockManagement { get; set; }


    public string? Vat { get; set; }
    public bool? GoogleCustomerReviews { get; set; }
    public bool? ShowProductInMenu { get; set; }


    public string? VimeoLink { get; set; }
    public bool? CurrencyConversion_BeforeLogin { get; set; }
    public bool? CurrencyConversion_AfterLogin { get; set; }
    public bool? ShowTwoProductInCategoryView { get; set; }


    public string? ProductZoom { get; set; }
    public bool? isShowFooterPaymentLogo { get; set; }
    public bool? IsEnableProductReviewsEmailReminder { get; set; }


    public string? ProductDetail { get; set; }


    public string? Delivery { get; set; }


    public string? Materials { get; set; }
    public bool EnableBuyOutOfStock { get; set; }
    public int? HeaderMenuType { get; set; }
    public bool EnableWareHouse { get; set; }
    public byte? EnableSalesRepCode { get; set; }
    public bool? EnableCustomerSpecificeCatalogue { get; set; }
    public bool? IsCustomerEncrypted { get; set; }
    public bool? HideDeliveryChangeFromCheckout { get; set; }
    public bool? HideVoucherCode { get; set; }
    public bool? showmSellerOrder { get; set; }
    public bool? EnableMultiLanguage { get; set; }
    public bool? EnablePunchout { get; set; }
    public bool? EnableLocalTax { get; set; }
    public bool EnableYotpoReviews { get; set; }
    public bool EnableVatverification { get; set; }
    public int? BaseCountry { get; set; }
    public bool? EnableQuickOrder { get; set; }
    public bool? IsOfferPriceFromProduct { get; set; }
    public bool? EnableDownloadOrdersProductImages { get; set; }
    public bool? IsEnableCapitalisationOnSite { get; set; }
    public bool ShowStockStatusFilter { get; set; }
    public bool EnableComments { get; set; }


    public string? GooglePlusLink { get; set; }
    public bool IsEnableNewExtendingDelivery { get; set; }
    public bool ShowDeliveryBreakdown { get; set; }
    public int? PrioritySetting { get; set; }
    public int? BasketCheckoutAlert { get; set; }


    public string? BasketCheckoutAlertText { get; set; }


    public string? NonSaleableMessage { get; set; }
    public bool EnableUserType { get; set; }
    public bool EnableSpendLimits { get; set; }
    public bool EnableAuthorisationOnly { get; set; }
    public int? LimitingPredictiveSearch { get; set; }
    public bool? ShowThumbnailWithPredictiveSearch { get; set; }


    public string? FacebookTrackingID { get; set; }
    public bool IsBespokeMenuEnabled { get; set; }
    public bool SortCategoryByAlphabetically { get; set; }
    public bool EnableCustomerRef { get; set; }
    public int? PriceDecimalPlace { get; set; }
    public bool? EnableCheckoutBillAddress { get; set; }
    public bool? ShowPriceIncVat { get; set; }
    public bool? ShowPriceIncVat1 { get; set; }
    public bool? ShowDualPrices { get; set; }

    public string? PageBuilderFontsFiles { get; set; }


    public string? PageBuilderCSSFiles { get; set; }


    public string? PageBuilderJSFiles { get; set; }
    public bool DisableLineLevelPO { get; set; }
    public int? Site404Page { get; set; }


    public string? GoogleMapApiKey { get; set; }


    public string? IndexRankLabel { get; set; }
    public int? DefaultSearchSortingOrder { get; set; }
    public bool EnableCustomerSpecificeProducts { get; set; }
    public int? LayoutSelection { get; set; }
    public bool CalculatedUnitsGridRestricted { get; set; }
    public bool EnableRMARequests { get; set; }
    public int CustomerCatalogueMode { get; set; }
    public bool EnableBundleQty { get; set; }
    public bool EnableDualPrice { get; set; }
    public bool CategoryViewDropdownVarients { get; set; }
    public bool EnableProductSKUBasket { get; set; }

    public string LiveChatVisibility { get; set; }


    public string? CalculatedUnits { get; set; }
    public int EnableGridView { get; set; }
    public int EnableListView { get; set; }
    public int EnableTradeView { get; set; }
    public bool ApplyVATtoDelivery { get; set; }
    public bool EnableAnotherAddress { get; set; }
    public bool DeliveryNoteDispatchCutOff { get; set; }
    public TimeSpan? DeliveryNoteDispatchCutOffTime { get; set; }
    public bool DeliveryNoteFutureDeliveryDate { get; set; }
    public bool ShowSaveAmount { get; set; }
    public byte DetailpageLayout { get; set; }
    public bool AllowEditingDeliveryAddressONCheckout { get; set; }

    public bool EnableTotalUnit { get; set; }


    public string? NoDeliveryChoiceMessage { get; set; }
    public bool? EnableOrderSplit { get; set; }

    public string? DeliveryNoteComment { get; set; }


    public string? BingWebmasterTrackingId { get; set; }
    public byte EnableCheckoutEmailAddress { get; set; }
    public bool? ShowQtyAsQuantityStock { get; set; }
    public bool CalculateDefaultPrice { get; set; }
    public byte Productlistlayout { get; set; }
    public bool EnableMultiWarehouse { get; set; }
    public bool EnableEmailInvoice { get; set; }
    public int InvoiceTemplate { get; set; }
    public bool ShowDeliveryAddressonQuote { get; set; }


    public string? LoginPageURL { get; set; }
    public bool EnableCustomerDueStock { get; set; }
    public int DueStockQty { get; set; }


    public string? InStockColour { get; set; }


    public string? OutofStockColour { get; set; }


    public string? DueStockColour { get; set; }
    public int ShowFromPrice { get; set; }
    public bool Favourites_BeforLogin { get; set; }
    public bool Favourites_AfterLogin { get; set; }
    public bool ShowCategoryImagesOnLandingPage { get; set; }
    public long? ShipingTax { get; set; }
    public bool DisableSubTotal { get; set; }
    public int ProductVatMethod { get; set; }


    public string? SupCatBgColorCode { get; set; }


    public string? RRPcurrency { get; set; }
    public bool ShowRRP { get; set; }
    public bool ShowRRP1 { get; set; }
    public int ProductIframeZoom { get; set; }


    public string? Detailpagetextcolor1 { get; set; }


    public string? Detailpagetextcolor2 { get; set; }



    public string? Detailpagetextcolor3 { get; set; }


    public string? Tabbottombordercolour { get; set; }
    public bool DisablePriceUpdateOnBasket { get; set; }
    public bool EnableBranchName { get; set; }


    public string? QuoteEmailAddress { get; set; }
    public int MiniBasket { get; set; }
    public bool TransparentHeader { get; set; }


    public string? InvoicePaymentType { get; set; }
    public bool EnablePaymentOfInvoices { get; set; }
    public int PartialPaymentOrder { get; set; }
    public bool EnableAccountAgedDebt { get; set; }


    public string? BusinessDays { get; set; }
    public bool DisableLineLevelDeliveryDate { get; set; }
    public bool EnableLinkMultiAccount { get; set; }


    public string? BackOrderText { get; set; }
    public bool EnableTrustedShops { get; set; }


    public string? TrustedShops { get; set; }
    public bool ShowMaxOrderQtyOnProductDetailPage { get; set; }
    public bool PersonalisedLandingPages { get; set; }
    public bool DefaultCustomRegistrationForm { get; set; }
    public bool EnablePersonalisation { get; set; }
    public bool? IsQuickorderAutocomplete { get; set; }


    public string? CustomiseSearchText { get; set; }
    public int? EnableCompanyMandatory { get; set; }
    public bool EnableDeliveryAddressEmails { get; set; }
    public bool? EnableFinalDestination { get; set; }
    public int? Trade_View_Attribute_ID { get; set; }
    public bool? IsQuotesOnly { get; set; }
    public bool EnableNewInvoice { get; set; }
    public bool? EnableCheckoutquestion { get; set; }


    public string? Checkoutmessage { get; set; }
    public bool EnableProductSKU { get; set; }
    public bool EnableProductName { get; set; }


    public string? AttributeTabText { get; set; }


    public string? Documentation { get; set; }
    public bool? EnableDropShipemailsforQuotes { get; set; }


    public string? DateFormat { get; set; }
    public bool ContactUsPopUp { get; set; }
    public bool CustomContactUsField { get; set; }
    public bool AllowRegistration { get; set; }
    public bool EnableCustomerQuestion { get; set; }
    public bool EnableProductLedger { get; set; }
    public bool EnableHotJarAnalytics { get; set; }


    public string? SearchableFields { get; set; }


    public string? HotjarTrackingCodeID { get; set; }


    public string? HotjarSnippetVersion { get; set; }


    public string? BackOrderTextColour { get; set; }


    public string? ShowDescription { get; set; }
    public bool EnablePrintBasket { get; set; }
    public bool? EnableAttributeTab { get; set; }


    public string? VideoTabText { get; set; }
    public int? Gridpagesize { get; set; }

    public string? GridLayoutColour1 { get; set; }

    public string? GridLayoutColour2 { get; set; }
    public bool PaymentMethodPrices { get; set; }
    public bool EnableCommaSeperatedNumbers { get; set; }
    public bool? InvoicesManageAvailableBalance { get; set; }


    public string? SoftCreditLimitMessages { get; set; }


    public string? hardCreditLimitMessages { get; set; }
    public bool EnableTermlyCookie { get; set; }


    public string? TermlyCookieEmbedId { get; set; }


    public string? TermlyManageCookiePreferencesLocation { get; set; }
    public bool? ShowAvailableBlanceChckout { get; set; }
    public int? GridViewAttributeDisplay { get; set; }
    public bool EnablePAFIntegration { get; set; }
    public int PAFIntegrationService { get; set; }
    public bool CreateCustomerRecord { get; set; }
    public bool EnableQtyChangeAtCheckout { get; set; }
    public int InvoiceType { get; set; }

    public string? InvoiceAdditionalInfo { get; set; }


    public string? InvoiceDocName { get; set; }


    public string? InvoiceCompanyName { get; set; }


    public string? InvoiceAdd1 { get; set; }


    public string? InvoiceAdd2 { get; set; }


    public string? InvoiceCity { get; set; }


    public string? InvoiceCounty { get; set; }


    public string? InvoicePostCode { get; set; }


    public string? InvoiceVatNo { get; set; }


    public string? InvoiceTel { get; set; }


    public string? InvoiceFax { get; set; }


    public bool EnableFeefoReview { get; set; }


    public string? MerchantIdentifier { get; set; }


    public string? PricingColour { get; set; }
    public bool EnableDonations { get; set; }


    public string? DonationsSKU { get; set; }


    public string? DonationsItemDescription { get; set; }


    public string? DonationsSectionText { get; set; }
    public int CategoryLayoutOption { get; set; }
    public bool RestrictCategoryListview { get; set; }
    public bool EnableRelatedWhenOutOfStock { get; set; }
    public bool ChannableImport { get; set; }

    public string? ChannableURL { get; set; }
    public string? ChannableToken { get; set; }
    public int ChannableFrequency { get; set; }
    public byte CheckoutPageType { get; set; }


    public string? SelectCreditBalance { get; set; }
    public byte? ImagesLayout { get; set; }
    public bool? ShowSKUCodeOnDetail { get; set; }


    public string? ShowCategoryDescription { get; set; }
    public bool EnableSelfVATExemption { get; set; }


    public string? SelfVATExemptionComment { get; set; }
    public bool GridAddToBasket { get; set; }
    public int GridImage { get; set; }


    public string? DonationGiftAidText { get; set; }


    public string? DonationAccountType { get; set; }
    public bool? EnableFreeDeliveryCalculation { get; set; }
    public bool EnablePersonalisationMultipleQty { get; set; }


    public string? reCaptchaSiteKey { get; set; }


    public string? reCaptchaSecretKey { get; set; }
    public bool? DisplayCategoryAltImages { get; set; }
    public bool? EnableCategoryStockQty { get; set; }
    public bool DeliverToBillAddress { get; set; }

    public string? CheckoutMessage2 { get; set; }
    public bool IsPinchToZoom { get; set; }
    public bool IsRegistrationActive { get; set; }
    public bool? EnableDescriptionsPhoneOrders { get; set; }


    public string? PhoneOrderDescriptionOptions { get; set; }
    public bool CustomerAmendCreditLimit { get; set; }
    public bool IsAltTextBlank { get; set; }
    public int? AddToBasketPosition { get; set; }
    public bool IsMultiLocationWarning { get; set; }


    public string? MultiLocationWarningMsg { get; set; }
    public bool EnableMenuDefaultExpanded { get; set; }
    public bool EnableGridViewSetting { get; set; }
    public bool EnableTradeViewSetting { get; set; }
    public bool Ishoverbasket { get; set; }
    public bool IsEnableShipperHQ { get; set; }
    public bool? EnableYourPrice { get; set; }


    public string? HeaderBannerAltText { get; set; }


    public string? reCaptchaSiteKeyV2 { get; set; }
    public bool EnablePartFinder { get; set; }
    public bool ShowCollectionAddress { get; set; }
    public decimal V2FallbackScoreLimit { get; set; }


    public string? reCaptchaSecretKeyV2 { get; set; }


    public string? SiteNoImageAltText { get; set; }
    public bool AnchorLayout { get; set; }
    public long DefaultAutoCategorySortingOrder { get; set; }
    public bool OverrideDefaultChecksonBasket { get; set; }
    public int GridViewAttributeDisplay1 { get; set; }
    public int ShowFromPrice1 { get; set; }
    public bool GridAddToBasket1 { get; set; }
    public int GridImage1 { get; set; }
    public bool ExportTradeView { get; set; }
    public bool EnableViewBasketButton { get; set; }
    public int PAFIntegrationResult { get; set; }
    public bool EnableExtendedUOS { get; set; }
    public bool BasketPersonalisationDisplay { get; set; }
    public bool EnableSyrenisCookie { get; set; }


    public string? SyrenisCookieLicenseID { get; set; }


    public string? SyrenisCookieAccessKey { get; set; }


    public string? SyrenisCookieStyleSheet { get; set; }
    public string? DeliveryAddressZoneDefault { get; set; }
    public bool EnableCreditHoldMsgBanner { get; set; }
    public bool EnablePreLoad { get; set; }
    public int BackOrderSetting { get; set; }


    public string? HideOrderButtons { get; set; }


    public string? CatDescTextColor { get; set; }

    public bool EnableCirrusCallRecording { get; set; }


    public string? CirrusUsername { get; set; }


    public string? CirrusPassword { get; set; }
    public bool DeliveryBreakdownLevel { get; set; }
    public bool TopRowIsDefault { get; set; }



    public string? ProductTitleColour { get; set; }
    public int TitleTextSize { get; set; }


    public string? SelectedTabColour { get; set; }


    public string? TableHeaderBackgroundColour { get; set; }


    public string? TableHeaderTextColour { get; set; }
    public int CreditHoldBannerMsg { get; set; }
    public int AttributeFilterView { get; set; }
    public bool SeenCheaperPrice { get; set; }
    public int TaxCalculationDecimalPlaces { get; set; }
    public bool EnableCustomerRegistration { get; set; }
    public bool SiteUnderMaintenance { get; set; }
    public int PredictiveSearchAttribute { get; set; }
    public bool EnableMyAccountSalesRep { get; set; }


    public string? beforeFromPriceColor { get; set; }


    public string? afterFromPriceColor { get; set; }
    public bool EnableCivicCookie { get; set; }


    public string? CivicCookieAPIKey { get; set; }


    public string? CivicCookieProduct { get; set; }
    public bool AllowPopularSearchesAndLastUserSearches { get; set; }
    public bool SuperClassURL { get; set; }
    public bool EnableDedicatedBrandsPage { get; set; }
    public bool AddtoBasketNotification { get; set; }
    public int StockMessageLocation { get; set; }


    public string? OrderReceiptPaymentType { get; set; }
    public bool FinalDestinationEmail { get; set; }
    public bool ShowEmail_CallUs { get; set; }


    public string? ProductDescription5Text { get; set; }


    public string? ProductDescription6Text { get; set; }
    public bool ShowInBasketQuantity { get; set; }
    public bool EnablePaidonResults { get; set; }


    public string? MerchantId_Paidon { get; set; }


    public string? FooterScript_PaidonResult { get; set; }
    public bool TransactionalEmail_DownloadableProduct { get; set; }
    public string? OrderMin_MaxErrorMessage { get; set; }
    public bool MultipleCollectionLocation { get; set; }
    public bool EnhancedErrorValidation { get; set; }
    public string? HeaderScript { get; set; }
    public string? FooterScript { get; set; }
    public bool IsUseStockStatusLabel { get; set; }


    public string BasketArchive { get; set; }
    public bool EnableBackOrderMessage { get; set; }


    public string? DeliveryDateAlertMessage { get; set; }
    public int SelectedBrandDirectory { get; set; }
    public bool IsEnableDeliveryByOrderPercentage { get; set; }
    public bool PercentageDeliveryCharge_Type { get; set; }
    public bool EnableInvoiceOrderComments { get; set; }
    public bool CurrencySymbol { get; set; }
    public bool MultiProductImagesOption { get; set; }
    public bool EnableAgedDebtTable { get; set; }
    public bool EnableAgedDebtBreakdown { get; set; }
    public string? AgedDebtBreakdownItems { get; set; }
    public bool IsCurrentPasswordRequired { get; set; }
    public bool EnableLoyaltyLedger { get; set; }
    public bool EnableRedeemPaymentMethod { get; set; }
    public int RedeemPaymentMethod { get; set; }
    public bool EnablePointsAwardInCloudfy { get; set; }

    public int PointsDefaultExpiryPeriod { get; set; }


    public string PointsDefaultExpiryPeriodType { get; set; }
    public string? FTPUrl { get; set; }
    public string? FTPHost { get; set; }
    public string? FTPLogin { get; set; }
    public string? FTPPassword { get; set; }
    public string? FTPBaseRoute { get; set; }
    public int StockReduction { get; set; }
    public int DropShipmentSplit { get; set; }


    public string? BrandPageTitle { get; set; }


    public string? BrandPageUrl { get; set; }


    public string? BrandPageDescription { get; set; }
    public int IsMobileAppLoginAccess { get; set; }
    public bool EnableSortingGrid { get; set; }
    public bool ExternalRefFieldforOrderNumber { get; set; }


    public string? LoginToSeePriceText { get; set; }
    public bool Calculateshowoftoplevelmenu { get; set; }
    public bool EnableLoyaltyPointsToVoucher { get; set; }
    public bool StaticPageSearch { get; set; }
    public bool ProductLayouts_ProductType { get; set; }

}
public class CreateTblSiteSettingsRequestValidator : CustomValidator<CreateSiteSettingsRequest>
{
    public CreateTblSiteSettingsRequestValidator(IReadRepository<SiteSettingsModel> repository, IStringLocalizer<CreateTblSiteSettingsRequestValidator> localizer) { }
}
public class CreateSiteSettingsRequestHandler : IRequestHandler<CreateSiteSettingsRequest, SiteSettingsModel>
{
    readonly IRepositoryWithEvents<SiteSettingsModel> _repository;

    public CreateSiteSettingsRequestHandler(IRepositoryWithEvents<SiteSettingsModel> repository) => _repository = repository;
    public async Task<SiteSettingsModel> Handle(CreateSiteSettingsRequest request, CancellationToken cancellationToken)
    {
        var SiteSettings = new SiteSettingsModel(

     request.Id,
     request.settingsID,
     request. SiteId,

     request. SitePhoneNumber,

     request. SiteCompanyAddress,

     request. ContactUsEmailAddress,

     request. OrdersEmailAddress,

     request. TwitterURL,

     request. FacebookURL,

     request. InstagramURL,

     request. MinimumOrderValue,

     request. FreeDeliveryLevel,

     request. GoogleAnalyticsTrackingID,

     request. EmailBCC,

     request. RegistrationNo,
     request. EmailFooter,

     request. SiteLogo,

     request. SiteFavicon,

     request. HeaderBanner,


     request. RetailPriceLabel,


     request. TradePriceLabel,


     request. SKU,
     request. STOCK,
     request. QTYADD,
     request. REVIEWS,
     request. CASEQTY,
     request. QTYBREAK,


     request. RetailPriceLabel1,


     request. TradePriceLabel1,
     request. SKU1,
     request. STOCK1,
     request. QTYADD1,
     request. REVIEWS1,
     request. CASEQTY1,
     request. QTYBREAK1,
     request. EnableDemoStoreMessage,
     request. CreateTradeAccountLogin,
     request. EnableLiveChat,
     request. ZoopimScript,
     request. EnableReviews,
     request. EnableGuestCheckout,
     request. CurencyConversion,
     request. MageMenuPromotionalMessage,
     request. ShowHomeLink,
     request. CategoryMenuCount,
     request. EnablePredictiveSearch,
     request. EnableSuperClass,
     request. AllowOrder,
     request. selectedtab,
     request. ShowBarcode,


     request. UnitForSize,


     request. UnitForWeight,
     request. ShowRRPWithoutLogin,
     request. ShowRRPWithStrike,
     request. ShowPriceWithoutLogin,
     request. EnableOnCollection,
     request. IsVatApplicable,
     request. DeiveryRestrictedBy,
     request. EnableBestSellers,
     request. EnableLatestProducts,
     request. EnableSpecialOffers,
     request. EnableDeliveryDate,


     request. DeliveryDateLabel,
     request. ShowOutOfStockItem,
     request. Ordertype,
     request. ShowStockDueDate,
     request. ShowCatBannerHeading,
     request. EnableGoogleTranslater,


     request. LinkedInURL,


     request. YoutubeURL,


     request. PrinterestURL,
     request. EmableMultipleCurrency,
     request. EnableMinimumOrderByCountry,
     request. EnableMultipleSKU,


     request. ReportLogo,
     request. EnableExistingCustomer,
     request. EnablePaymentLimit,
     request. DefaultSortingField,
     request. IsBestSellersFromAdmin,
     request. IsLatestProductsFromAdmin,
     request. IsSpecialOffersFromAdmin,
     request. IsImageCompressed,


     request. Mailchimp_listid,


     request. Mailchimp_apiKey,
     request. SubscribeMailchimp,
     request. EnableRoundleOnDetails,
     request. IsNewLayout,
     request. IsUpdated,
     request. ChekoutEditableAddr,
     request. EnablePendingBasketMail,
     request. setDurationAfterAddedbasket,
     request. LastSendingMail,
     request. DeliveryAddressAtLogin,

     request. DemoStoreMessage,


     request. DemoStoreMessageLink,
     request. EnablepriceFilter,
     request. EnableRightClick,
     request. WelcomeMessageAfterLogin,
     request. EnableFooterSiteMapLink,
     request. EnableFooterNewsLink,
     request. EnableStockQty,
     request. EnableNewsforInactiveCus,
     request. DeliveryOptionMethod,
     request. DeliveryOption,
     request. EnableCustomerAlsoBoughtFeature,
     request. EnableAbandonedMailfeature,


     request. CopyrightText,
     request. EnableProductSocialShring,
     request. IsNextDayDelivery,
     request.EnableEmailBackInStock,


     request.TagManagerTrackingId,
     request. IsSavedBasket,
     request. MinOrderExvat,

     request. CalculateVatFrom,


     request. Brand,
     request. EnableCallForPrice,
     request. EnableDownloadTab,


     request. DownloadTabOption,
     request. HideCategoryImage,
     request. GoogleLangSwitchPosition,
     request. EnableReserveStock,
     request. ReserveStockLevel,
     request. EnableFooterEventsLink,
     request. EnableStockManagement,


     request. Vat,
     request. GoogleCustomerReviews,
     request. ShowProductInMenu,


     request. VimeoLink,
     request. CurrencyConversion_BeforeLogin,
     request. CurrencyConversion_AfterLogin,
     request. ShowTwoProductInCategoryView,


     request. ProductZoom,
     request. isShowFooterPaymentLogo,
     request. IsEnableProductReviewsEmailReminder,


     request. ProductDetail,


     request. Delivery,


     request. Materials,
     request.EnableBuyOutOfStock,
     request. HeaderMenuType,
     request.EnableWareHouse,
     request. EnableSalesRepCode,
     request. EnableCustomerSpecificeCatalogue,
     request. IsCustomerEncrypted,
     request. HideDeliveryChangeFromCheckout,
     request. HideVoucherCode,
     request. showmSellerOrder,
     request. EnableMultiLanguage,
     request. EnablePunchout,
     request. EnableLocalTax,
     request.EnableYotpoReviews,
     request.EnableVatverification,
     request. BaseCountry,
     request. EnableQuickOrder,
     request. IsOfferPriceFromProduct,
     request. EnableDownloadOrdersProductImages,
     request. IsEnableCapitalisationOnSite,
     request.ShowStockStatusFilter,
     request.EnableComments,


     request. GooglePlusLink,
     request.IsEnableNewExtendingDelivery,
     request.ShowDeliveryBreakdown,
     request. PrioritySetting,
     request. BasketCheckoutAlert,


     request. BasketCheckoutAlertText,


     request. NonSaleableMessage,
     request.EnableUserType,
     request.EnableSpendLimits,
     request.EnableAuthorisationOnly,
     request. LimitingPredictiveSearch,
     request. ShowThumbnailWithPredictiveSearch,


     request. FacebookTrackingID,
     request.IsBespokeMenuEnabled,
     request.SortCategoryByAlphabetically,
     request.EnableCustomerRef,
     request. PriceDecimalPlace,
     request. EnableCheckoutBillAddress,
     request. ShowPriceIncVat,
     request. ShowPriceIncVat1,
     request. ShowDualPrices,

     request. PageBuilderFontsFiles,


     request. PageBuilderCSSFiles,


     request. PageBuilderJSFiles,
     request.DisableLineLevelPO,
     request. Site404Page,


     request. GoogleMapApiKey,


     request. IndexRankLabel,
     request. DefaultSearchSortingOrder,
     request.EnableCustomerSpecificeProducts,
     request. LayoutSelection,
     request.CalculatedUnitsGridRestricted,
     request.EnableRMARequests,
     request.CustomerCatalogueMode,
     request.EnableBundleQty,
     request.EnableDualPrice,
     request.CategoryViewDropdownVarients,
     request.EnableProductSKUBasket,

     request.LiveChatVisibility,


     request. CalculatedUnits,
     request.EnableGridView,
     request.EnableListView,
     request.EnableTradeView,
     request.ApplyVATtoDelivery,
     request.EnableAnotherAddress,
     request.DeliveryNoteDispatchCutOff,
     request. DeliveryNoteDispatchCutOffTime,
     request.DeliveryNoteFutureDeliveryDate,
     request.ShowSaveAmount,
     request. DetailpageLayout,
     request.AllowEditingDeliveryAddressONCheckout,

     request.EnableTotalUnit,


     request. NoDeliveryChoiceMessage,
     request. EnableOrderSplit,

     request. DeliveryNoteComment,


     request. BingWebmasterTrackingId,
     request. EnableCheckoutEmailAddress,
     request. ShowQtyAsQuantityStock,
     request.CalculateDefaultPrice,
     request. Productlistlayout,
     request.EnableMultiWarehouse,
     request.EnableEmailInvoice,
     request.InvoiceTemplate,
     request.ShowDeliveryAddressonQuote,


     request. LoginPageURL,
     request.EnableCustomerDueStock,
     request.DueStockQty,


     request. InStockColour,


     request. OutofStockColour,


     request. DueStockColour,
     request.ShowFromPrice,
     request.Favourites_BeforLogin,
     request.Favourites_AfterLogin,
     request.ShowCategoryImagesOnLandingPage,
     request. ShipingTax,
     request.DisableSubTotal,
     request.ProductVatMethod,


     request. SupCatBgColorCode,


     request. RRPcurrency,
     request.ShowRRP,
     request.ShowRRP1,
     request.ProductIframeZoom,


     request. Detailpagetextcolor1,


     request. Detailpagetextcolor2,



     request. Detailpagetextcolor3,


     request. Tabbottombordercolour,
     request.DisablePriceUpdateOnBasket,
     request.EnableBranchName,


     request. QuoteEmailAddress,
     request.MiniBasket,
     request.TransparentHeader,


     request. InvoicePaymentType,
     request.EnablePaymentOfInvoices,
     request.PartialPaymentOrder,
     request.EnableAccountAgedDebt,


     request. BusinessDays,
     request.DisableLineLevelDeliveryDate,
     request.EnableLinkMultiAccount,


     request. BackOrderText,
     request.EnableTrustedShops,


     request. TrustedShops,
     request.ShowMaxOrderQtyOnProductDetailPage,
     request.PersonalisedLandingPages,
     request.DefaultCustomRegistrationForm,
     request.EnablePersonalisation,
     request. IsQuickorderAutocomplete,


     request. CustomiseSearchText,
     request. EnableCompanyMandatory,
     request.EnableDeliveryAddressEmails,
     request. EnableFinalDestination,
     request. Trade_View_Attribute_ID,
     request. IsQuotesOnly,
     request.EnableNewInvoice,
     request. EnableCheckoutquestion,


     request. Checkoutmessage,
     request.EnableProductSKU,
     request.EnableProductName,


     request. AttributeTabText,


     request. Documentation,
     request. EnableDropShipemailsforQuotes,


     request. DateFormat,
     request.ContactUsPopUp,
     request.CustomContactUsField,
     request.AllowRegistration,
     request.EnableCustomerQuestion,
     request.EnableProductLedger,
     request.EnableHotJarAnalytics,

     request. SearchableFields,


     request. HotjarTrackingCodeID,


     request. HotjarSnippetVersion,


     request. BackOrderTextColour,


     request. ShowDescription,
     request.EnablePrintBasket,
     request. EnableAttributeTab,


     request. VideoTabText,
     request. Gridpagesize,

     request. GridLayoutColour1,

     request. GridLayoutColour2,
     request.PaymentMethodPrices,
     request.EnableCommaSeperatedNumbers,
     request. InvoicesManageAvailableBalance,


     request. SoftCreditLimitMessages,


     request. hardCreditLimitMessages,
     request.EnableTermlyCookie,


     request. TermlyCookieEmbedId,


     request. TermlyManageCookiePreferencesLocation,
     request. ShowAvailableBlanceChckout,
     request. GridViewAttributeDisplay,
     request.EnablePAFIntegration,
     request.PAFIntegrationService,
     request.CreateCustomerRecord,
     request.EnableQtyChangeAtCheckout,
     request.InvoiceType,

     request. InvoiceAdditionalInfo,


     request. InvoiceDocName,


     request. InvoiceCompanyName,


     request. InvoiceAdd1,


     request. InvoiceAdd2,


     request. InvoiceCity,


     request. InvoiceCounty,


     request. InvoicePostCode,


     request. InvoiceVatNo,


     request. InvoiceTel,


     request. InvoiceFax,


     request.EnableFeefoReview,


     request. MerchantIdentifier,


     request. PricingColour,
     request.EnableDonations,


     request. DonationsSKU,


     request. DonationsItemDescription,


     request. DonationsSectionText,
     request.CategoryLayoutOption,
     request.RestrictCategoryListview,
     request.EnableRelatedWhenOutOfStock,
     request.ChannableImport,

     request. ChannableURL,
     request. ChannableToken,
     request.ChannableFrequency,
     request. CheckoutPageType,


     request. SelectCreditBalance,
     request. ImagesLayout,
     request. ShowSKUCodeOnDetail,


     request. ShowCategoryDescription,
     request.EnableSelfVATExemption,


     request. SelfVATExemptionComment,
     request.GridAddToBasket,
     request.GridImage,


     request. DonationGiftAidText,


     request. DonationAccountType,
     request. EnableFreeDeliveryCalculation,
     request.EnablePersonalisationMultipleQty,


     request. reCaptchaSiteKey,


     request. reCaptchaSecretKey,
     request. DisplayCategoryAltImages,
     request. EnableCategoryStockQty,
     request.DeliverToBillAddress,

     request. CheckoutMessage2,
     request.IsPinchToZoom,
     request.IsRegistrationActive,
     request. EnableDescriptionsPhoneOrders,


     request. PhoneOrderDescriptionOptions,
     request.CustomerAmendCreditLimit,
     request.IsAltTextBlank,
     request. AddToBasketPosition,
     request.IsMultiLocationWarning,


     request. MultiLocationWarningMsg,
     request.EnableMenuDefaultExpanded,
     request.EnableGridViewSetting,
     request.EnableTradeViewSetting,
     request.Ishoverbasket,
     request.IsEnableShipperHQ,
     request. EnableYourPrice,


     request. HeaderBannerAltText,


     request. reCaptchaSiteKeyV2,
     request.EnablePartFinder,
     request.ShowCollectionAddress,
     request.V2FallbackScoreLimit,


     request. reCaptchaSecretKeyV2,


     request. SiteNoImageAltText,
     request.AnchorLayout,
     request.DefaultAutoCategorySortingOrder,
     request.OverrideDefaultChecksonBasket,
     request.GridViewAttributeDisplay1,
     request.ShowFromPrice1,
     request.GridAddToBasket1,
     request.GridImage1,
     request.ExportTradeView,
     request.EnableViewBasketButton,
     request.PAFIntegrationResult,
     request.EnableExtendedUOS,
     request.BasketPersonalisationDisplay,
     request.EnableSyrenisCookie,


     request. SyrenisCookieLicenseID,


     request. SyrenisCookieAccessKey,


     request. SyrenisCookieStyleSheet,
     request. DeliveryAddressZoneDefault,
     request.EnableCreditHoldMsgBanner,
     request.EnablePreLoad,
     request.BackOrderSetting,


     request. HideOrderButtons,


     request. CatDescTextColor,

     request.EnableCirrusCallRecording,


     request. CirrusUsername,


     request. CirrusPassword,
     request.DeliveryBreakdownLevel,
     request.TopRowIsDefault,



     request. ProductTitleColour,
     request.TitleTextSize,


     request. SelectedTabColour,


     request. TableHeaderBackgroundColour,


     request. TableHeaderTextColour,
     request.CreditHoldBannerMsg,
     request.AttributeFilterView,
     request.SeenCheaperPrice,
     request.TaxCalculationDecimalPlaces,
     request.EnableCustomerRegistration,
     request.SiteUnderMaintenance,
     request.PredictiveSearchAttribute,
     request.EnableMyAccountSalesRep,


     request. beforeFromPriceColor,


     request. afterFromPriceColor,
     request.EnableCivicCookie,


     request. CivicCookieAPIKey,


     request. CivicCookieProduct,
     request.AllowPopularSearchesAndLastUserSearches,
     request.SuperClassURL,
     request.EnableDedicatedBrandsPage,
     request.AddtoBasketNotification,
     request.StockMessageLocation,


     request. OrderReceiptPaymentType,
     request.FinalDestinationEmail,
     request.ShowEmail_CallUs,


     request. ProductDescription5Text,


     request. ProductDescription6Text,
     request.ShowInBasketQuantity,
     request.EnablePaidonResults,


     request. MerchantId_Paidon,

     request. FooterScript_PaidonResult,
     request.TransactionalEmail_DownloadableProduct,
     request. OrderMin_MaxErrorMessage,
     request.MultipleCollectionLocation,
     request.EnhancedErrorValidation,
     request. HeaderScript,
     request. FooterScript,
     request.IsUseStockStatusLabel,


     request.BasketArchive,
     request.EnableBackOrderMessage,


     request. DeliveryDateAlertMessage,
     request.SelectedBrandDirectory,
     request.IsEnableDeliveryByOrderPercentage,
     request.PercentageDeliveryCharge_Type,
     request.EnableInvoiceOrderComments,
     request.CurrencySymbol,
     request.MultiProductImagesOption,
     request.EnableAgedDebtTable,
     request.EnableAgedDebtBreakdown,
     request. AgedDebtBreakdownItems,
     request.IsCurrentPasswordRequired,
     request.EnableLoyaltyLedger,
     request.EnableRedeemPaymentMethod,
     request.RedeemPaymentMethod,
     request.EnablePointsAwardInCloudfy,

     request.PointsDefaultExpiryPeriod,
     request.PointsDefaultExpiryPeriodType,
     request. FTPUrl,
     request. FTPHost,
     request. FTPLogin,
     request. FTPPassword,
     request. FTPBaseRoute,
     request.StockReduction,
     request.DropShipmentSplit,


     request. BrandPageTitle,


     request. BrandPageUrl,


     request. BrandPageDescription,
     request.IsMobileAppLoginAccess,
     request.EnableSortingGrid,
     request.ExternalRefFieldforOrderNumber,


     request. LoginToSeePriceText,
     request.Calculateshowoftoplevelmenu,
     request.EnableLoyaltyPointsToVoucher,
     request.StaticPageSearch,
     request.ProductLayouts_ProductType
        );
        var ouptput = await _repository.AddAsync(SiteSettings, cancellationToken);
        return ouptput;

    }
}

