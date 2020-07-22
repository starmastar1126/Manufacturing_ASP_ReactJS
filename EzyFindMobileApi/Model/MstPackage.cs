using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstPackage
    {
        public MstPackage()
        {
            MapCompanyPackage = new HashSet<MapCompanyPackage>();
            MapPackageAttributes = new HashSet<MapPackageAttributes>();
        }

        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsRecommended { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyPackage> MapCompanyPackage { get; set; }
        public ICollection<MapPackageAttributes> MapPackageAttributes { get; set; }
    }
}
