using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstMagazineAdType
    {
        public MstMagazineAdType()
        {
            MstMagazineAd = new HashSet<MstMagazineAd>();
        }

        public int MagazineAdTypeId { get; set; }
        public string MagazineAdTypeName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstMagazineAd> MstMagazineAd { get; set; }
    }
}
