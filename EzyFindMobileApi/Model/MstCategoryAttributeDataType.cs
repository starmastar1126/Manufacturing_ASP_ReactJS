using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCategoryAttributeDataType
    {
        public MstCategoryAttributeDataType()
        {
            MstCategoryAttribute = new HashSet<MstCategoryAttribute>();
        }

        public int CatAttributeDataTypeId { get; set; }
        public string CatAttributeDataType { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstCategoryAttribute> MstCategoryAttribute { get; set; }
    }
}
