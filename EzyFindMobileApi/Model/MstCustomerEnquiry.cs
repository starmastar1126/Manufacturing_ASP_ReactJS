using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCustomerEnquiry
    {
        public MstCustomerEnquiry()
        {
            MapCustomerEnquiryUpload = new HashSet<MapCustomerEnquiryUpload>();
            MstCustomerEnquiryResponse = new HashSet<MstCustomerEnquiryResponse>();
        }

        public int CustomerEnquiryId { get; set; }
        public int? UserId { get; set; }
        public string EnquiryTitle { get; set; }
        public string EnquiryDescription { get; set; }
        public DateTime? EnquiryDate { get; set; }
        public int? EnquiryStatusId { get; set; }
        public int? CompanyId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstStatus EnquiryStatus { get; set; }
        public MstUsers User { get; set; }
        public ICollection<MapCustomerEnquiryUpload> MapCustomerEnquiryUpload { get; set; }
        public ICollection<MstCustomerEnquiryResponse> MstCustomerEnquiryResponse { get; set; }
    }
}
