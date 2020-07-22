using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapProductDocument
    {
        public int DocumentId { get; set; }
        public int? ProductId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public PrdProducts Product { get; set; }
    }
}
