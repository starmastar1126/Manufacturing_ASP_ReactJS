using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapItemRequestUpload
    {
        public int IrUploadId { get; set; }
        public int? ItemRequestId { get; set; }
        public string UploadPath { get; set; }
        public string ThumbNailPath { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
