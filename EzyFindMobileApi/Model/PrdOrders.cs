using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdOrders
    {
        public PrdOrders()
        {
            PrdOrderDetails = new HashSet<PrdOrderDetails>();
            PrdOrderStatus = new HashSet<PrdOrderStatus>();
        }

        public int OrderId { get; set; }
        public string OrderIdstring { get; set; }
        public int? UserId { get; set; }
        public string OrderSessionId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderIpaddress { get; set; }
        public decimal? OrderAmount { get; set; }
        public decimal? OrderTotal { get; set; }
        public string TransactionId { get; set; }
        public int? OrderStatusId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? ProductId { get; set; }
        public int? DownloadCount { get; set; }

        public MstUsers User { get; set; }
        public ICollection<PrdOrderDetails> PrdOrderDetails { get; set; }
        public ICollection<PrdOrderStatus> PrdOrderStatus { get; set; }
    }
}
