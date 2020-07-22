using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class DevForms
    {
        public DevForms()
        {
            InverseParentFormNavigation = new HashSet<DevForms>();
            MapUserRoleRights = new HashSet<MapUserRoleRights>();
        }

        public int FormId { get; set; }
        public int? ParentForm { get; set; }
        public string FormName { get; set; }
        public string FormUrl { get; set; }
        public decimal? SortOrder { get; set; }
        public bool? IsForm { get; set; }
        public string ImagePath { get; set; }
        public int? MenuLevel { get; set; }
        public bool? IsDeleted { get; set; }
        public int? MenuType { get; set; }

        public DevForms ParentFormNavigation { get; set; }
        public ICollection<DevForms> InverseParentFormNavigation { get; set; }
        public ICollection<MapUserRoleRights> MapUserRoleRights { get; set; }
    }
}
