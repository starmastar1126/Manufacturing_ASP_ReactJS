using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstSettings
    {
        public MstSettings()
        {
            MapSettingsRole = new HashSet<MapSettingsRole>();
            MapUsersSettings = new HashSet<MapUsersSettings>();
        }

        public int SettingId { get; set; }
        public string SettingName { get; set; }
        public int? SettingTypeId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstSettingType SettingType { get; set; }
        public ICollection<MapSettingsRole> MapSettingsRole { get; set; }
        public ICollection<MapUsersSettings> MapUsersSettings { get; set; }
    }
}
