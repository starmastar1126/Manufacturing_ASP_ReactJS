using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapItemRequestCategory
    {
        public int IrCategoryId { get; set; }
        public int? ItemRequestId { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
