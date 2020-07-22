using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCity
    {
        public MstCity()
        {
            MapCompanyArea = new HashSet<MapCompanyArea>();
            MstSpecials = new HashSet<MstSpecials>();
            MstSuburb = new HashSet<MstSuburb>();
            MstUsers = new HashSet<MstUsers>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? ProvinceId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstProvince Province { get; set; }
        public ICollection<MapCompanyArea> MapCompanyArea { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
        public ICollection<MstSuburb> MstSuburb { get; set; }
        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
