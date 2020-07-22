using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdOrderPayment
    {
        public int OrderPaymentId { get; set; }
        public int? OrderId { get; set; }
        public int? PaymentModeId { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentRefNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public MstPaymentMode PaymentMode { get; set; }
    }
}
