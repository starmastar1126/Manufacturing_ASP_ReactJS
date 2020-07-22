using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyArea
    {
        public int CompanyAreaId { get; set; }
        public int? CompPackageId { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCity City { get; set; }
        public MapCompanyPackage CompPackage { get; set; }
        public MstCountry Country { get; set; }
        public MstProvince Province { get; set; }
        public MstSuburb Suburb { get; set; }
    }
}
