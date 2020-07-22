using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCompanyTaskList
    {
        public MstCompanyTaskList()
        {
            MapCompanyTask = new HashSet<MapCompanyTask>();
        }

        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public decimal? Percentage { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MapCompanyTask> MapCompanyTask { get; set; }
    }
}
