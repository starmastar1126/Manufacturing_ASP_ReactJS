using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapUsersSettings
    {
        public int UserSettingId { get; set; }
        public int? SettingId { get; set; }
        public int? UserId { get; set; }
        public string SUserId { get; set; }
        public bool? SPost { get; set; }
        public string AccessToken { get; set; }
        public bool? Email { get; set; }
        public bool? Sms { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstSettings Setting { get; set; }
    }
}
