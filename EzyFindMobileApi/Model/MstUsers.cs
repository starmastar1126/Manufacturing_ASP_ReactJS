using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstUsers
    {
        public MstUsers()
        {
            MstCrmCustomerComment = new HashSet<MstCrmCustomerComment>();
            MstCustomerEnquiry = new HashSet<MstCustomerEnquiry>();
            MstCustomerEnquiryResponse = new HashSet<MstCustomerEnquiryResponse>();
            MstFavourites = new HashSet<MstFavourites>();
            MstFranchisee = new HashSet<MstFranchisee>();
            MstItemResponse = new HashSet<MstItemResponse>();
            MstRating = new HashSet<MstRating>();
            PrdOrders = new HashSet<PrdOrders>();
        }

        public int UserId { get; set; }
        public int? RoleId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public int? Gender { get; set; }
        public string StreetAddress { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }
        public string ZipCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string ContactNo { get; set; }
        public string Password { get; set; }
        public int? StatusId { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? CompanyId { get; set; }
        public string EmailActivationCode { get; set; }
        public string MobileActivationCode { get; set; }
        public string ForgetPasswordCode { get; set; }
        public bool? IsLoggedIn { get; set; }
        public bool? IsMobileLoggedIn { get; set; }
        public string UserProfileImage { get; set; }
        public string UserProfileThumbNailImage { get; set; }
        public int? FailedLoginCount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string LogInCode { get; set; }
        public int? AdminPin { get; set; }
        public int? FranchiseId { get; set; }
        public int? DeviceType { get; set; }
        public string DeviceId { get; set; }
        public string Token { get; set; }

        public MstCity City { get; set; }
        public MstCompany Company { get; set; }
        public MstCountry Country { get; set; }
        public MstProvince Province { get; set; }
        public MstUserRole Role { get; set; }
        public MstUserStatus Status { get; set; }
        public MstSuburb Suburb { get; set; }
        public ICollection<MstCrmCustomerComment> MstCrmCustomerComment { get; set; }
        public ICollection<MstCustomerEnquiry> MstCustomerEnquiry { get; set; }
        public ICollection<MstCustomerEnquiryResponse> MstCustomerEnquiryResponse { get; set; }
        public ICollection<MstFavourites> MstFavourites { get; set; }
        public ICollection<MstFranchisee> MstFranchisee { get; set; }
        public ICollection<MstItemResponse> MstItemResponse { get; set; }
        public ICollection<MstRating> MstRating { get; set; }
        public ICollection<PrdOrders> PrdOrders { get; set; }
    }
}
