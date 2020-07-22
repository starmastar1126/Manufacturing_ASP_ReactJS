using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstSuburb
    {
        public MstSuburb()
        {
            MapCompanyArea = new HashSet<MapCompanyArea>();
            MstSpecials = new HashSet<MstSpecials>();
            MstUsers = new HashSet<MstUsers>();
        }

        public int SuburbId { get; set; }
        public string SuburbName { get; set; }
        public int? CityId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCity City { get; set; }
        public ICollection<MapCompanyArea> MapCompanyArea { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
