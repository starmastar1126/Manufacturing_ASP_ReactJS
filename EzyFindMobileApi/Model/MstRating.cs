using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstRating
    {
        public int MstRatingId { get; set; }
        public int? CompanyId { get; set; }
        public int? SpecialId { get; set; }
        public int? EflyerId { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string EmaiId { get; set; }
        public string Review { get; set; }
        public int? RatingScore { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstSpecials Special { get; set; }
        public MstStatus Status { get; set; }
        public MstUsers User { get; set; }
    }
}
