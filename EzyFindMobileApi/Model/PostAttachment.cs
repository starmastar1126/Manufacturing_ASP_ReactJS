using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PostAttachment
    {
        public int PostAttachmentId { get; set; }
        public int? PostId { get; set; }
        public string FilePath { get; set; }
        public string DocumentName { get; set; }
        public string ThumbNailImagePath { get; set; }
        public int? DocumentType { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public Post Post { get; set; }
    }
}
