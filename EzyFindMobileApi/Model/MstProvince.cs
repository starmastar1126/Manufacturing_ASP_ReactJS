using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstProvince
    {
        public MstProvince()
        {
            MapCompanyArea = new HashSet<MapCompanyArea>();
            MstCity = new HashSet<MstCity>();
            MstSpecials = new HashSet<MstSpecials>();
            MstUsers = new HashSet<MstUsers>();
        }

        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int? CountryId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCountry Country { get; set; }
        public ICollection<MapCompanyArea> MapCompanyArea { get; set; }
        public ICollection<MstCity> MstCity { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
