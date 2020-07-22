using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstFranchisee
    {
        public int FranchiseId { get; set; }
        public string FranchiseName { get; set; }
        public string StreetAddress { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string EmailId { get; set; }
        public bool? IsActive { get; set; }
        public int? FranchiseUserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCountry Country { get; set; }
        public MstUsers FranchiseUser { get; set; }
    }
}
