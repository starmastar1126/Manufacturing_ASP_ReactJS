using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstUserStatus
    {
        public MstUserStatus()
        {
            MstUsers = new HashSet<MstUsers>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
