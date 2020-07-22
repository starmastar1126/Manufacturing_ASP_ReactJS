using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanyPackage
    {
        public MapCompanyPackage()
        {
            MapCompanyArea = new HashSet<MapCompanyArea>();
            MapCompanyCategory = new HashSet<MapCompanyCategory>();
            MapCompanyEmail = new HashSet<MapCompanyEmail>();
            MapCompanyPayment = new HashSet<MapCompanyPayment>();
            MapCompanyProvide = new HashSet<MapCompanyProvide>();
            MapCompanySeek = new HashSet<MapCompanySeek>();
            MapCompanyUsers = new HashSet<MapCompanyUsers>();
        }

        public int CompPackageId { get; set; }
        public int? CompanyId { get; set; }
        public int? PackageId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int TimeDelay { get; set; }
        public bool? CategoryNotExist { get; set; }
        public bool? AddCategory { get; set; }
        public bool? IsActive { get; set; }
        public int? CategoryAllowedCount { get; set; }
        public int? CategoryUsedCount { get; set; }
        public int? UsersAllowedCount { get; set; }
        public int? UsersUsedCount { get; set; }
        public int? EmailAllowedCount { get; set; }
        public int? EmailUsedCount { get; set; }
        public int? RequestAllowedCount { get; set; }
        public int? RequestUsedCount { get; set; }
        public int? SpecialAllowedCount { get; set; }
        public int? SpecialUsedCount { get; set; }
        public int? CatalogueAllowedCount { get; set; }
        public int? CatalogueUsedCount { get; set; }
        public int? SalesLeadAllowedCount { get; set; }
        public int? SalesLeadUsedCount { get; set; }
        public int? KeywordAllowedCount { get; set; }
        public int? KeywordUsedCount { get; set; }
        public int? FollowBusinessAllowedCount { get; set; }
        public int? FollowBusinessUsedCount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstPackage Package { get; set; }
        public ICollection<MapCompanyArea> MapCompanyArea { get; set; }
        public ICollection<MapCompanyCategory> MapCompanyCategory { get; set; }
        public ICollection<MapCompanyEmail> MapCompanyEmail { get; set; }
        public ICollection<MapCompanyPayment> MapCompanyPayment { get; set; }
        public ICollection<MapCompanyProvide> MapCompanyProvide { get; set; }
        public ICollection<MapCompanySeek> MapCompanySeek { get; set; }
        public ICollection<MapCompanyUsers> MapCompanyUsers { get; set; }
    }
}
