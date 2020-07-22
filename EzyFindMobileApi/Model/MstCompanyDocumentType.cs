using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCompanyDocumentType
    {
        public MstCompanyDocumentType()
        {
            MapCompanyDocument = new HashSet<MapCompanyDocument>();
        }

        public int DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyDocument> MapCompanyDocument { get; set; }
    }
}
