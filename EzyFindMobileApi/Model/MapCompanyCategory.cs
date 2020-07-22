using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyCategory
    {
        public int CompanyCategoryId { get; set; }
        public int? CompPackageId { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MapCompanyPackage CompPackage { get; set; }
    }
}
