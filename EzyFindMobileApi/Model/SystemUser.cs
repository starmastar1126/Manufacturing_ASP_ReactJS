using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class SystemUser
    {
        public int SystemUserId { get; set; }
        public string SystemUserName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? FailedLoginCount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public SystemRole Role { get; set; }
    }
}
