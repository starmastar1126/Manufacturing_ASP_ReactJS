using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmCustomerComment
    {
        public int CustomerCommentId { get; set; }
        public int? CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCrmCustomer Customer { get; set; }
        public MstUsers User { get; set; }
    }
}
