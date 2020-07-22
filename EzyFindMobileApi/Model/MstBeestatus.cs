using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstBeestatus
    {
        public MstBeestatus()
        {
            MstCompany = new HashSet<MstCompany>();
        }

        public int BeestatusId { get; set; }
        public string BeestatusName { get; set; }
        public string ScorePoint { get; set; }
        public decimal? ProcurementRecognition { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstBeestatus Beestatus { get; set; }
        public MstBeestatus InverseBeestatus { get; set; }
        public ICollection<MstCompany> MstCompany { get; set; }
    }
}
