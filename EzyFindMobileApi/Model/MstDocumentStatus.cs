using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstDocumentStatus
    {
        public MstDocumentStatus()
        {
            MapCompanyDocument = new HashSet<MapCompanyDocument>();
        }

        public int DocumentStatusId { get; set; }
        public string DocumentStatus { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyDocument> MapCompanyDocument { get; set; }
    }
}
