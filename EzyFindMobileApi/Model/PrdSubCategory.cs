using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdSubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int? CategoryId { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DomainId { get; set; }

        public PrdCategory Category { get; set; }
    }
}
