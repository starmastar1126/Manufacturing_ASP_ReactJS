using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstVersion
    {
        public int VersionId { get; set; }
        public string VersionType { get; set; }
        public decimal? VersionNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
