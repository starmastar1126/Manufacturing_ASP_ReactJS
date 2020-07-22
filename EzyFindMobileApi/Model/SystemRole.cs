using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class SystemRole
    {
        public SystemRole()
        {
            SystemUser = new HashSet<SystemUser>();
        }

        public int SystemRoleId { get; set; }
        public string SystemRoleName { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<SystemUser> SystemUser { get; set; }
    }
}
