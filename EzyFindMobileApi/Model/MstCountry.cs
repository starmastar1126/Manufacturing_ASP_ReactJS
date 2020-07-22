using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCountry
    {
        public MstCountry()
        {
            MapCompanyArea = new HashSet<MapCompanyArea>();
            MstFranchisee = new HashSet<MstFranchisee>();
            MstProvince = new HashSet<MstProvince>();
            MstSpecials = new HashSet<MstSpecials>();
            MstUsers = new HashSet<MstUsers>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyArea> MapCompanyArea { get; set; }
        public ICollection<MstFranchisee> MstFranchisee { get; set; }
        public ICollection<MstProvince> MstProvince { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
