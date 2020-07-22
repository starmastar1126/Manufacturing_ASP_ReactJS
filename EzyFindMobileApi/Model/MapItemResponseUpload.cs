using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MapItemResponseUpload
    {
        public int IrUploadId { get; set; }
        public int? ItemResponseId { get; set; }
        public string DocumentName { get; set; }
        public string UploadPath { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstItemResponse ItemResponse { get; set; }
    }
}
