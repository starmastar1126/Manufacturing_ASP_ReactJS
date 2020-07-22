using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstFavourites
    {
        public int MstFavouriteId { get; set; }
        public int? CompanyId { get; set; }
        public int? SpecialId { get; set; }
        public int? EflyerId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstEFlyers Eflyer { get; set; }
        public MstSpecials Special { get; set; }
        public MstUsers User { get; set; }
    }
}
