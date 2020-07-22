using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapUserRoleRights
    {
        public int RightsId { get; set; }
        public int? RoleId { get; set; }
        public int? FormId { get; set; }
        public bool? AddRights { get; set; }
        public bool? ModifyRights { get; set; }
        public bool? DeleteRights { get; set; }
        public bool? ViewRights { get; set; }

        public DevForms Form { get; set; }
        public MstUserRole Role { get; set; }
    }
}
