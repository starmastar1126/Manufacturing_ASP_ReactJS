using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzyFindMobileApi.Model
{
    public class out_usp_GetUsersList
    {
        public int userID { get; set; }

        public int? roleID { get; set; }

        public String roleName { get; set; }

        public String email { get; set; }

        public String firstName { get; set; }

        public String lastName { get; set; }

        public String fullName { get; set; }

        public String userName { get; set; }

        public DateTime? dateofBirth { get; set; }

        public int? gender { get; set; }

        public String vGender { get; set; }

        public String streetAddress { get; set; }

        public int? countryId { get; set; }

        public String countryName { get; set; }

        public int? provinceID { get; set; }

        public String provinceName { get; set; }

        public int? cityID { get; set; }

        public String cityName { get; set; }

        public int? suburbID { get; set; }

        public String suburbName { get; set; }

        public String zipCode { get; set; }

        public String longitude { get; set; }

        public String latitude { get; set; }

        public String contactNo { get; set; }

        public int? statusID { get; set; }

        public String statusName { get; set; }

        public DateTime? lastLogin { get; set; }

        public int? companyId { get; set; }

        public int? compPackageID { get; set; }

        public Decimal? compPercent { get; set; }

        public int? packageID { get; set; }

        public Boolean? getRequests { get; set; }

        public Boolean? isLoggedIn { get; set; }

        public Boolean? isMobileLoggedIn { get; set; }

        public String userProfileImage { get; set; }

        public String userProfileThumbNailImage { get; set; }

        public int? failedLoginCount { get; set; }

        public String facebookUserID { get; set; }

        public Boolean? postOnFB { get; set; }

        public String fBAccessCode { get; set; }

        public String googleUserID { get; set; }

        public Boolean? postOnGP { get; set; }

        public String twitterUserId { get; set; }

        public Boolean? postOnTwitter { get; set; }

        public String instagramUserID { get; set; }

        public Boolean? postOnInstagram { get; set; }

        public Boolean? emailNotification { get; set; }

        public Boolean? sMSNotification { get; set; }

        public String password { get; set; }

        public String forgetPasswordCode { get; set; }

        public DateTime? joinDate { get; set; }

        public String linkedInUserID { get; set; }

        public Boolean? postOnLI { get; set; }

        public int? franchiseID { get; set; }

        public int? deviceType { get; set; }

        public String deviceID { get; set; }

        public String token { get; set; }
    }
}
