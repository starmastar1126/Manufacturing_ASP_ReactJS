using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstSpecials
    {
        public MstSpecials()
        {
            MapSpecialUpload = new HashSet<MapSpecialUpload>();
            MstFavourites = new HashSet<MstFavourites>();
            MstRating = new HashSet<MstRating>();
        }

        public int SpecialId { get; set; }
        public string SpecialName { get; set; }
        public int? CompanyId { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Amount { get; set; }
        public int? StatusId { get; set; }
        public string StreetAddress { get; set; }
        public int? CategoryId { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string ImagePath { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Featured { get; set; }

        public MstCategory Category { get; set; }
        public MstCity City { get; set; }
        public MstCompany Company { get; set; }
        public MstCountry Country { get; set; }
        public MstProvince Province { get; set; }
        public MstStatus Status { get; set; }
        public MstSuburb StatusNavigation { get; set; }
        public ICollection<MapSpecialUpload> MapSpecialUpload { get; set; }
        public ICollection<MstFavourites> MstFavourites { get; set; }
        public ICollection<MstRating> MstRating { get; set; }
    }
}
