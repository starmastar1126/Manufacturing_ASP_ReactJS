using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapPackageAttributes
    {
        public int PackageDetailId { get; set; }
        public int? PackageId { get; set; }
        public int? PattributeId { get; set; }
        public string Value { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstPackage Package { get; set; }
        public MstPackageAttribute Pattribute { get; set; }
    }
}
