using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstContactForm
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
