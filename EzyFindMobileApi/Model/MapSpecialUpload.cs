using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapSpecialUpload
    {
        public int SpecialUploadId { get; set; }
        public int? SpecialId { get; set; }
        public string UploadPath { get; set; }
        public string ThumbNailPath { get; set; }
        public string Label { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstSpecials Special { get; set; }
    }
}
