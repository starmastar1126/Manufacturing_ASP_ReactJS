using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapItemRequestCategoryAttribute
    {
        public int IrCategoryAttributeId { get; set; }
        public int? ItemRequestId { get; set; }
        public int? CategoryAttributeId { get; set; }
        public string CategoryValue { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MapCategoryAttributes CategoryAttribute { get; set; }
        public MstItemRequest ItemRequest { get; set; }
    }
}
