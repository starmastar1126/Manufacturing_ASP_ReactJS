using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstUserRole
    {
        public MstUserRole()
        {
            MapSettingsRole = new HashSet<MapSettingsRole>();
            MapUserRoleRights = new HashSet<MapUserRoleRights>();
            MstUsers = new HashSet<MstUsers>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public ICollection<MapSettingsRole> MapSettingsRole { get; set; }
        public ICollection<MapUserRoleRights> MapUserRoleRights { get; set; }
        public ICollection<MstUsers> MstUsers { get; set; }
    }
}
