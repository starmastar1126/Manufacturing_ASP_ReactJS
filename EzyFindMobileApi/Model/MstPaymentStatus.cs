using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstPaymentStatus
    {
        public MstPaymentStatus()
        {
            MapCompanyPayment = new HashSet<MapCompanyPayment>();
        }

        public int PaymentStatusId { get; set; }
        public string PaymentStatus { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyPayment> MapCompanyPayment { get; set; }
    }
}
