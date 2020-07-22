using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCompanyStatus
    {
        public MstCompanyStatus()
        {
            MstCompany = new HashSet<MstCompany>();
        }

        public int CompanyStatusId { get; set; }
        public string StatusName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstCompany> MstCompany { get; set; }
    }
}
