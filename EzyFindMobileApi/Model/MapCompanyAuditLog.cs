using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyAuditLog
    {
        public int AuditLogId { get; set; }
        public int? CompanyId { get; set; }
        public string AuditLog { get; set; }
        public DateTime? AuditDate { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public MstCompany Company { get; set; }
    }
}
