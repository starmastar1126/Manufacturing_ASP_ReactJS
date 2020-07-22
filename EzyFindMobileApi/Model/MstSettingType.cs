using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstSettingType
    {
        public MstSettingType()
        {
            MstSettings = new HashSet<MstSettings>();
        }

        public int SettingTypeId { get; set; }
        public string SettingTypeName { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstSettings> MstSettings { get; set; }
    }
}
