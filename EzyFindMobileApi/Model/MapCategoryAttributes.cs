using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCategoryAttributes
    {
        public MapCategoryAttributes()
        {
            MapItemRequestCategoryAttribute = new HashSet<MapItemRequestCategoryAttribute>();
        }

        public int CategoryAttributeId { get; set; }
        public int? CategoryId { get; set; }
        public int? CatAttributeId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCategoryAttribute CatAttribute { get; set; }
        public MstCategory Category { get; set; }
        public ICollection<MapItemRequestCategoryAttribute> MapItemRequestCategoryAttribute { get; set; }
    }
}
