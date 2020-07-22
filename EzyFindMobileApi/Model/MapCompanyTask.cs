using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyTask
    {
        public int CompTaskId { get; set; }
        public int? TaskId { get; set; }
        public int? CompanyId { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCompany Company { get; set; }
        public MstCompanyTaskList Task { get; set; }
    }
}
