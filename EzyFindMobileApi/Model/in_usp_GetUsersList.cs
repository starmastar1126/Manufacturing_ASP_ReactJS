using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzyFindMobileApi.Model
{
    public class in_usp_GetUsersList
    {
        public int? userID { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string UserName { get; set; }
        public string FacebookUserID { get; set; }
        public string GoogleUserID { get; set; }
        public string LinkedInUserID { get; set; }
        public string ForgetPasswordCode { get; set; }
        public int? RoleID { get; set; }
        public int? StatusID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int intTrack { get; set; } // --1 - Login , 2 - Search , 3 - FacebookCheck, 4 - GoogleCheck, 5 - Business User List, 12 - UserName , 13 - Email Exists , 14 - Contact No
        public int? DeviceType { get; set; }
        public string DeviceID { get; set; }
       

    }
}
