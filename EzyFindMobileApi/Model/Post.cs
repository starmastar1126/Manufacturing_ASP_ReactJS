using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class Post
    {
        public Post()
        {
            PostAttachment = new HashSet<PostAttachment>();
        }

        public int PostId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? TitleCategoryId { get; set; }
        public int? DomainId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<PostAttachment> PostAttachment { get; set; }
    }
}
