using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCustomerEnquiryResponse
    {
        public int CeresponseId { get; set; }
        public int? CustomerEnquiryId { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public string Comment { get; set; }
        public DateTime? ResponseDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstCustomerEnquiry CustomerEnquiry { get; set; }
        public MstUsers User { get; set; }
    }
}
