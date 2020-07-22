using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyDocument
    {
        public int CompDocId { get; set; }
        public int? CompanyId { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentName { get; set; }
        public int? DocumentStatusId { get; set; }
        public string RejectReason { get; set; }
        public int? DocumentTypeId { get; set; }
        public string AboutDocument { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstDocumentStatus DocumentStatus { get; set; }
        public MstCompanyDocumentType DocumentType { get; set; }
    }
}
