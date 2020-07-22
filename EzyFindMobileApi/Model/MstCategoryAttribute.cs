using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCategoryAttribute
    {
        public MstCategoryAttribute()
        {
            MapCategoryAttributes = new HashSet<MapCategoryAttributes>();
        }

        public int CatAttributeId { get; set; }
        public string CatAttribute { get; set; }
        public int? CatAttributeDataTypeId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCategoryAttributeDataType CatAttributeDataType { get; set; }
        public ICollection<MapCategoryAttributes> MapCategoryAttributes { get; set; }
    }
}
