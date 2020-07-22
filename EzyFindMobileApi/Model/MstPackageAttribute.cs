using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstPackageAttribute
    {
        public MstPackageAttribute()
        {
            MapPackageAttributes = new HashSet<MapPackageAttributes>();
        }

        public int PattributeId { get; set; }
        public string AttributeName { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapPackageAttributes> MapPackageAttributes { get; set; }
    }
}
