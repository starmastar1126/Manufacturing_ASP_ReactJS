using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstStatus
    {
        public MstStatus()
        {
            MstCustomerEnquiry = new HashSet<MstCustomerEnquiry>();
            MstEFlyers = new HashSet<MstEFlyers>();
            MstItemRequest = new HashSet<MstItemRequest>();
            MstKeywords = new HashSet<MstKeywords>();
            MstRating = new HashSet<MstRating>();
            MstSpecials = new HashSet<MstSpecials>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstCustomerEnquiry> MstCustomerEnquiry { get; set; }
        public ICollection<MstEFlyers> MstEFlyers { get; set; }
        public ICollection<MstItemRequest> MstItemRequest { get; set; }
        public ICollection<MstKeywords> MstKeywords { get; set; }
        public ICollection<MstRating> MstRating { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
    }
}
