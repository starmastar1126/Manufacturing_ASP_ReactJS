using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstPeriodType
    {
        public MstPeriodType()
        {
            MapCompanyProvide = new HashSet<MapCompanyProvide>();
            MapCompanySeek = new HashSet<MapCompanySeek>();
        }

        public int PeriodTypeId { get; set; }
        public string PeriodType { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyProvide> MapCompanyProvide { get; set; }
        public ICollection<MapCompanySeek> MapCompanySeek { get; set; }
    }
}
