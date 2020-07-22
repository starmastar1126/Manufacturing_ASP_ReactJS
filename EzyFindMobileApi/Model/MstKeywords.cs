using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstKeywords
    {
        public MstKeywords()
        {
            MapCompanyProvide = new HashSet<MapCompanyProvide>();
            MapCompanySeek = new HashSet<MapCompanySeek>();
        }

        public int KeywordId { get; set; }
        public string Keyword { get; set; }
        public int? CategoryId { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCategory Category { get; set; }
        public MstStatus Status { get; set; }
        public ICollection<MapCompanyProvide> MapCompanyProvide { get; set; }
        public ICollection<MapCompanySeek> MapCompanySeek { get; set; }
    }
}
