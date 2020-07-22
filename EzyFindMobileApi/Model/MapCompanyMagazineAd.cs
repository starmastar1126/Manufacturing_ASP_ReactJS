using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyMagazineAd
    {
        public int CompMagId { get; set; }
        public int? CompanyId { get; set; }
        public int? MagazineAdId { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstMagazineAd MagazineAd { get; set; }
    }
}
