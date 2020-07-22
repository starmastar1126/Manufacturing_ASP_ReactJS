using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstNotificationStack
    {
        public long NotificationId { get; set; }
        public string PostData { get; set; }
        public int? DeviceType { get; set; }
        public string DeviceId { get; set; }
        public DateTime? NotificationDate { get; set; }
    }
}
