using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdCategory
    {
        public PrdCategory()
        {
            PrdProducts = new HashSet<PrdProducts>();
            PrdSubCategory = new HashSet<PrdSubCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DomainId { get; set; }

        public PrdCategory Category { get; set; }
        public MstDomain Domain { get; set; }
        public PrdCategory InverseCategory { get; set; }
        public ICollection<PrdProducts> PrdProducts { get; set; }
        public ICollection<PrdSubCategory> PrdSubCategory { get; set; }
    }
}
