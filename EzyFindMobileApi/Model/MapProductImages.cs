using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapProductImages
    {
        public int ImageId { get; set; }
        public int? ProductId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public PrdProducts Product { get; set; }
    }
}
