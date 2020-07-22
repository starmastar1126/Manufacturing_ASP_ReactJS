using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstMagazineAd
    {
        public MstMagazineAd()
        {
            MapCompanyMagazineAd = new HashSet<MapCompanyMagazineAd>();
        }

        public int MagazineAdId { get; set; }
        public int? MagazineSectionId { get; set; }
        public int? MagazineAdTypeId { get; set; }
        public decimal? Discount { get; set; }
        public int? Duration { get; set; }
        public decimal? Price { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstMagazineAdType MagazineAdType { get; set; }
        public MstMagazineSection MagazineSection { get; set; }
        public ICollection<MapCompanyMagazineAd> MapCompanyMagazineAd { get; set; }
    }
}
