using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmInvoice
    {
        public MstCrmInvoice()
        {
            MstCrmInvoiceDetails = new HashSet<MstCrmInvoiceDetails>();
        }

        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceDescription { get; set; }
        public string InvoiceFooter { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? CustomerId { get; set; }
        public int? QuoteId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentModeId { get; set; }
        public int? PaymentStatusId { get; set; }
        public string TransactionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public MstCompany Company { get; set; }
        public MstCrmCustomer Customer { get; set; }
        public ICollection<MstCrmInvoiceDetails> MstCrmInvoiceDetails { get; set; }
    }
}
