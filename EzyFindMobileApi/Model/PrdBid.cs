using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdBid
    {
        public int BidId { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public decimal? BidAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? BidApprovedMail { get; set; }
        public bool? IsAccepted { get; set; }

        public PrdProducts Product { get; set; }
    }
}
