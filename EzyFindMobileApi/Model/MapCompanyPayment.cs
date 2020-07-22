using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyPayment
    {
        public int CompPaymentId { get; set; }
        public int? CompPackageId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? TotalAmountUsd { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? PaymentModeId { get; set; }
        public int? PaymentStatusId { get; set; }
        public string TransactionId { get; set; }
        public string InvoicePath { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MapCompanyPackage CompPackage { get; set; }
        public MstPaymentMode PaymentMode { get; set; }
        public MstPaymentStatus PaymentStatus { get; set; }
    }
}
