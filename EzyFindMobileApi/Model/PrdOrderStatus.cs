using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdOrderStatus
    {
        public int OrderStatusId { get; set; }
        public int? OrderId { get; set; }
        public int? OrderStatusTypeId { get; set; }
        public DateTime? OrderStatusDate { get; set; }
        public bool? IsCurrentStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public PrdOrders Order { get; set; }
    }
}
