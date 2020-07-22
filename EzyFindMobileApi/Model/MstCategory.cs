using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCategory
    {
        public MstCategory()
        {
            InverseParentCategory = new HashSet<MstCategory>();
            MapCategoryAttributes = new HashSet<MapCategoryAttributes>();
            MstEFlyers = new HashSet<MstEFlyers>();
            MstItemRequest = new HashSet<MstItemRequest>();
            MstKeywords = new HashSet<MstKeywords>();
            MstSpecials = new HashSet<MstSpecials>();
        }

        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public bool? IsMainCategory { get; set; }
        public bool? IsCategory { get; set; }
        public string CategoryName { get; set; }
        public string CategoryIcon { get; set; }
        public string CategoryThumbNailIcon { get; set; }
        public bool? TimeDelayException { get; set; }
        public bool? IsMenuAllowed { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCategory ParentCategory { get; set; }
        public ICollection<MstCategory> InverseParentCategory { get; set; }
        public ICollection<MapCategoryAttributes> MapCategoryAttributes { get; set; }
        public ICollection<MstEFlyers> MstEFlyers { get; set; }
        public ICollection<MstItemRequest> MstItemRequest { get; set; }
        public ICollection<MstKeywords> MstKeywords { get; set; }
        public ICollection<MstSpecials> MstSpecials { get; set; }
    }
}
