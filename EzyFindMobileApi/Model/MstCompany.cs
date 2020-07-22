using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCompany
    {
        public MstCompany()
        {
            MapCompanyAuditLog = new HashSet<MapCompanyAuditLog>();
            MapCompanyDocument = new HashSet<MapCompanyDocument>();
            MapCompanyTask = new HashSet<MapCompanyTask>();
            MstCrmInventory = new HashSet<MstCrmInventory>();
            MstCrmInvoice = new HashSet<MstCrmInvoice>();
            MstCrmQuote = new HashSet<MstCrmQuote>();
            MstCustomerEnquiry = new HashSet<MstCustomerEnquiry>();
            MstCustomerEnquiryResponse = new HashSet<MstCustomerEnquiryResponse>();
            MstEFlyers = new HashSet<MstEFlyers>();
            MstFavourites = new HashSet<MstFavourites>();
            MstItemResponse = new HashSet<MstItemResponse>();
            MstRating = new HashSet<MstRating>();
            MstSpecials = new HashSet<MstSpecials>();
            MstUsers = new HashSet<MstUsers>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string LogoPath { get; set; }
        public string Description { get; set; }
        public decimal? ServiceTax { get; set; }
        public string Vatnumber { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string HelpDeskNumber { get; set; }
        public int? CompanyStatusId { get; set; }
        public int? BeestatusId { get; set; }
        public int? DirectorsCount { get; set; }
        public decimal? CompanyPercent { get; set; }
        public string PayFastMerchantId { get; set; }
        public string PayFastMerchantKey { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? FranchiseeId { get; set; }
        public string DomainUrl { get; set; }
        public int? MainBusinessUserId { get; set; }
        public string CrmcolorCode { get; set; }
        public string CrmQuoteHeader { get; set; }
        public string CrmQuoteFooter { get; set; }
        public string CrmInvoiceHeader { get; set; }
        public string CrmInvoiceFooter { get; set; }
        public bool? Featured { get; set; }
        public string PayGateMerchantId { get; set; }
        public string PayGateMerchantKey { get; set; }
        public string PayPalMerchantId { get; set; }
        public string PayPalMerchantKey { get; set; }

        public MstBeestatus Beestatus { get; set; }
        public MstCompanyStatus CompanyStatus { get; set; }
        public ICollection<MapCompanyAuditLog> MapCompanyAuditLog { get; set; }
        public ICollection<MapCompanyDocument> MapCompanyDocument { get; set; }
        public ICollection<MapCompanyTask> MapCompanyTask { get; set; }
        public ICollection<MstCrmInventory> MstCrmInventory { get; set; }
        public ICollection<MstCrmInvoice> MstCrmInvoice { get; set; }
        public ICollection<MstCrmQuote> MstCrmQuote { get; set; }
        public ICollection<MstCustomerEnquiry> MstCustomerEnquiry { get; set; }
        public ICollection<MstCustomerEnquiryResponse> MstCustomerEnquiryResponse { get; set; }
        public ICollection<MstEFlyers> MstEFlyers { get; set; }
        public ICollection<MstFavourites> MstFavourites { get; set; }
        public ICollection<MstItemResponse> MstItemResponse { get; set; }
        public ICollection<MstRating> MstRating { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
