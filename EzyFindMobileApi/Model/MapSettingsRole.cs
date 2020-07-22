using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapSettingsRole
    {
        public int Srid { get; set; }
        public int? RoleId { get; set; }
        public int? SettingId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstUserRole Role { get; set; }
        public MstSettings Setting { get; set; }
    }
}
