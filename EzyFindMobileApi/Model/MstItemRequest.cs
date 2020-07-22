using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstItemRequest
    {
        public MstItemRequest()
        {
            MapItemRequestCategoryAttribute = new HashSet<MapItemRequestCategoryAttribute>();
        }

        public int ItemRequestId { get; set; }
        public int? UserId { get; set; }
        public string ItemRequestTitle { get; set; }
        public string ItemRequestDescription { get; set; }
        public DateTime? ItemRequestDate { get; set; }
        public int? ItemRequestStatusId { get; set; }
        public int? SelectedCompany { get; set; }
        public int? CategoryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }
        public bool? RequestApprovedMail { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCategory Category { get; set; }
        public MstStatus ItemRequestStatus { get; set; }
        public ICollection<MapItemRequestCategoryAttribute> MapItemRequestCategoryAttribute { get; set; }
    }
}
