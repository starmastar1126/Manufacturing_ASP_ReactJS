using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapCompanySeek
    {
        public int SeekKeywordId { get; set; }
        public int? CompPackageId { get; set; }
        public int KeywordId { get; set; }
        public int? PeriodValue { get; set; }
        public int? PeriodTypeId { get; set; }
        public int? QuantityTypeId { get; set; }
        public int? VolumeTypeId { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MapCompanyPackage CompPackage { get; set; }
        public MstKeywords Keyword { get; set; }
        public MstPeriodType PeriodType { get; set; }
        public MstQuantityType QuantityType { get; set; }
        public MstVolumeType VolumeType { get; set; }
    }
}
