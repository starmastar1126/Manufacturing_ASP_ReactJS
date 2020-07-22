using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdOrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? OrderQuantity { get; set; }
        public decimal? OrderAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? DownloadCount { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public PrdOrders Order { get; set; }
    }
}
