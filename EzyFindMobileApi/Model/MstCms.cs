using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCms
    {
        public int Cmsid { get; set; }
        public string Cmstitle { get; set; }
        public string Cmstext { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
