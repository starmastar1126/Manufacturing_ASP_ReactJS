using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstPaymentMode
    {
        public MstPaymentMode()
        {
            MapCompanyPayment = new HashSet<MapCompanyPayment>();
            PrdOrderPayment = new HashSet<PrdOrderPayment>();
        }

        public int PaymentModeId { get; set; }
        public string PaymentMode { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyPayment> MapCompanyPayment { get; set; }
        public ICollection<PrdOrderPayment> PrdOrderPayment { get; set; }
    }
}
