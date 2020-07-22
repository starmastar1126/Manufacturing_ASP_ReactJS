using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstItemResponse
    {
        public MstItemResponse()
        {
            InverseReplyTo = new HashSet<MstItemResponse>();
            MapItemResponseUpload = new HashSet<MapItemResponseUpload>();
        }

        public int ItemResponseId { get; set; }
        public int? ItemRequestId { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public string Comment { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int? ReplyToId { get; set; }
        public bool? IsAccepted { get; set; }
        public bool? IsRejected { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstItemResponse ReplyTo { get; set; }
        public MstUsers User { get; set; }
        public ICollection<MstItemResponse> InverseReplyTo { get; set; }
        public ICollection<MapItemResponseUpload> MapItemResponseUpload { get; set; }
    }
}
