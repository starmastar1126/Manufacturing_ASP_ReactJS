using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyEmail
    {
        public int CompMailId { get; set; }
        public int? CompPackageId { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MapCompanyPackage CompPackage { get; set; }
    }
}
