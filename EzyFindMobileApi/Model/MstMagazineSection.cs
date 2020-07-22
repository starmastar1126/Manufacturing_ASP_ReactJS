using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstMagazineSection
    {
        public MstMagazineSection()
        {
            MstMagazineAd = new HashSet<MstMagazineAd>();
        }

        public int MagazineSectionId { get; set; }
        public string MagazineSectionName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstMagazineAd> MstMagazineAd { get; set; }
    }
}
