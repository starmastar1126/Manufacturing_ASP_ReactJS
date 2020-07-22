using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzyFindMobileApi.General
{
    public class LoginUser
    {      

        private int userID;

        private int roleID;

        private String roleName;

        private String email;

        private String firstName;

        private String lastName;

        private String fullName;

        private String userName;

        private String dateofBirth;

        private Object gender;

        private String vGender;

        private String streetAddress;

        private Object countryId;

        private Object countryName;

        private int provinceID;

        private String provinceName;

        private int cityID;

        private String cityName;

        private int suburbID;

        private String suburbName;

        private String zipCode;

        private Object longitude;

        private Object latitude;

        private String contactNo;

        private int statusID;

        private String statusName;

        private String lastLogin;

        private int companyId;

        private int compPackageID;

        private Double compPercent;

        private int packageID;

        private Boolean getRequests;

        private Boolean isLoggedIn;

        private Object isMobileLoggedIn;

        private Object userProfileImage;

        private Object userProfileThumbNailImage;

        private int failedLoginCount;

        private String facebookUserID;

        private Boolean postOnFB;

        private String fBAccessCode;

        private String googleUserID;

        private Boolean postOnGP;

        private String twitterUserId;

        private Boolean postOnTwitter;

        private String instagramUserID;

        private Boolean postOnInstagram;

        private Boolean emailNotification;

        private Boolean sMSNotification;

        private String password;

        private Object forgetPasswordCode;

        private String joinDate;

        private String linkedInUserID;

        private Boolean postOnLI;

        private Object franchiseID;

        private int deviceType;

        private String deviceID;

        public int getUserID()
        {
            return userID;
        }

        public void setUserID(int userID)
        {
            this.userID = userID;
        }

        public int getRoleID()
        {
            return roleID;
        }

        public void setRoleID(int roleID)
        {
            this.roleID = roleID;
        }

        public String getRoleName()
        {
            return roleName;
        }

        public void setRoleName(String roleName)
        {
            this.roleName = roleName;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getFullName()
        {
            return fullName;
        }

        public void setFullName(String fullName)
        {
            this.fullName = fullName;
        }

        public String getUserName()
        {
            return userName;
        }

        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getDateofBirth()
        {
            return dateofBirth;
        }

        public void setDateofBirth(String dateofBirth)
        {
            this.dateofBirth = dateofBirth;
        }

        public Object getGender()
        {
            return gender;
        }

        public void setGender(Object gender)
        {
            this.gender = gender;
        }

        public String getVGender()
        {
            return vGender;
        }

        public void setVGender(String vGender)
        {
            this.vGender = vGender;
        }

        public String getStreetAddress()
        {
            return streetAddress;
        }

        public void setStreetAddress(String streetAddress)
        {
            this.streetAddress = streetAddress;
        }

        public Object getCountryId()
        {
            return countryId;
        }

        public void setCountryId(Object countryId)
        {
            this.countryId = countryId;
        }

        public Object getCountryName()
        {
            return countryName;
        }

        public void setCountryName(Object countryName)
        {
            this.countryName = countryName;
        }

        public int getProvinceID()
        {
            return provinceID;
        }

        public void setProvinceID(int provinceID)
        {
            this.provinceID = provinceID;
        }

        public String getProvinceName()
        {
            return provinceName;
        }

        public void setProvinceName(String provinceName)
        {
            this.provinceName = provinceName;
        }

        public int getCityID()
        {
            return cityID;
        }

        public void setCityID(int cityID)
        {
            this.cityID = cityID;
        }

        public String getCityName()
        {
            return cityName;
        }

        public void setCityName(String cityName)
        {
            this.cityName = cityName;
        }

        public int getSuburbID()
        {
            return suburbID;
        }

        public void setSuburbID(int suburbID)
        {
            this.suburbID = suburbID;
        }

        public String getSuburbName()
        {
            return suburbName;
        }

        public void setSuburbName(String suburbName)
        {
            this.suburbName = suburbName;
        }

        public String getZipCode()
        {
            return zipCode;
        }

        public void setZipCode(String zipCode)
        {
            this.zipCode = zipCode;
        }

        public Object getLongitude()
        {
            return longitude;
        }

        public void setLongitude(Object longitude)
        {
            this.longitude = longitude;
        }

        public Object getLatitude()
        {
            return latitude;
        }

        public void setLatitude(Object latitude)
        {
            this.latitude = latitude;
        }

        public String getContactNo()
        {
            return contactNo;
        }

        public void setContactNo(String contactNo)
        {
            this.contactNo = contactNo;
        }

        public int getStatusID()
        {
            return statusID;
        }

        public void setStatusID(int statusID)
        {
            this.statusID = statusID;
        }

        public String getStatusName()
        {
            return statusName;
        }

        public void setStatusName(String statusName)
        {
            this.statusName = statusName;
        }

        public String getLastLogin()
        {
            return lastLogin;
        }

        public void setLastLogin(String lastLogin)
        {
            this.lastLogin = lastLogin;
        }

        public int getCompanyId()
        {
            return companyId;
        }

        public void setCompanyId(int companyId)
        {
            this.companyId = companyId;
        }

        public int getCompPackageID()
        {
            return compPackageID;
        }

        public void setCompPackageID(int compPackageID)
        {
            this.compPackageID = compPackageID;
        }

        public Double getCompPercent()
        {
            return compPercent;
        }

        public void setCompPercent(Double compPercent)
        {
            this.compPercent = compPercent;
        }

        public int getPackageID()
        {
            return packageID;
        }

        public void setPackageID(int packageID)
        {
            this.packageID = packageID;
        }

        public Boolean getGetRequests()
        {
            return getRequests;
        }

        public void setGetRequests(Boolean getRequests)
        {
            this.getRequests = getRequests;
        }

        public Boolean getIsLoggedIn()
        {
            return isLoggedIn;
        }

        public void setIsLoggedIn(Boolean isLoggedIn)
        {
            this.isLoggedIn = isLoggedIn;
        }

        public Object getIsMobileLoggedIn()
        {
            return isMobileLoggedIn;
        }

        public void setIsMobileLoggedIn(Object isMobileLoggedIn)
        {
            this.isMobileLoggedIn = isMobileLoggedIn;
        }

        public Object getUserProfileImage()
        {
            return userProfileImage;
        }

        public void setUserProfileImage(Object userProfileImage)
        {
            this.userProfileImage = userProfileImage;
        }

        public Object getUserProfileThumbNailImage()
        {
            return userProfileThumbNailImage;
        }

        public void setUserProfileThumbNailImage(Object userProfileThumbNailImage)
        {
            this.userProfileThumbNailImage = userProfileThumbNailImage;
        }

        public int getFailedLoginCount()
        {
            return failedLoginCount;
        }

        public void setFailedLoginCount(int failedLoginCount)
        {
            this.failedLoginCount = failedLoginCount;
        }

        public String getFacebookUserID()
        {
            return facebookUserID;
        }

        public void setFacebookUserID(String facebookUserID)
        {
            this.facebookUserID = facebookUserID;
        }

        public Boolean getPostOnFB()
        {
            return postOnFB;
        }

        public void setPostOnFB(Boolean postOnFB)
        {
            this.postOnFB = postOnFB;
        }

        public String getFBAccessCode()
        {
            return fBAccessCode;
        }

        public void setFBAccessCode(String fBAccessCode)
        {
            this.fBAccessCode = fBAccessCode;
        }

        public String getGoogleUserID()
        {
            return googleUserID;
        }

        public void setGoogleUserID(String googleUserID)
        {
            this.googleUserID = googleUserID;
        }

        public Boolean getPostOnGP()
        {
            return postOnGP;
        }

        public void setPostOnGP(Boolean postOnGP)
        {
            this.postOnGP = postOnGP;
        }

        public String getTwitterUserId()
        {
            return twitterUserId;
        }

        public void setTwitterUserId(String twitterUserId)
        {
            this.twitterUserId = twitterUserId;
        }

        public Boolean getPostOnTwitter()
        {
            return postOnTwitter;
        }

        public void setPostOnTwitter(Boolean postOnTwitter)
        {
            this.postOnTwitter = postOnTwitter;
        }

        public String getInstagramUserID()
        {
            return instagramUserID;
        }

        public void setInstagramUserID(String instagramUserID)
        {
            this.instagramUserID = instagramUserID;
        }

        public Boolean getPostOnInstagram()
        {
            return postOnInstagram;
        }

        public void setPostOnInstagram(Boolean postOnInstagram)
        {
            this.postOnInstagram = postOnInstagram;
        }

        public Boolean getEmailNotification()
        {
            return emailNotification;
        }

        public void setEmailNotification(Boolean emailNotification)
        {
            this.emailNotification = emailNotification;
        }

        public Boolean getSMSNotification()
        {
            return sMSNotification;
        }

        public void setSMSNotification(Boolean sMSNotification)
        {
            this.sMSNotification = sMSNotification;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public Object getForgetPasswordCode()
        {
            return forgetPasswordCode;
        }

        public void setForgetPasswordCode(Object forgetPasswordCode)
        {
            this.forgetPasswordCode = forgetPasswordCode;
        }

        public String getJoinDate()
        {
            return joinDate;
        }

        public void setJoinDate(String joinDate)
        {
            this.joinDate = joinDate;
        }

        public String getLinkedInUserID()
        {
            return linkedInUserID;
        }

        public void setLinkedInUserID(String linkedInUserID)
        {
            this.linkedInUserID = linkedInUserID;
        }

        public Boolean getPostOnLI()
        {
            return postOnLI;
        }

        public void setPostOnLI(Boolean postOnLI)
        {
            this.postOnLI = postOnLI;
        }

        public Object getFranchiseID()
        {
            return franchiseID;
        }

        public void setFranchiseID(Object franchiseID)
        {
            this.franchiseID = franchiseID;
        }

        public int getDeviceType()
        {
            return deviceType;
        }

        public void setDeviceType(int deviceType)
        {
            this.deviceType = deviceType;
        }

        public String getDeviceID()
        {
            return deviceID;
        }

        public void setDeviceID(String deviceID)
        {
            this.deviceID = deviceID;
        }

    }
}

