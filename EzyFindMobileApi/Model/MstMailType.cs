using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstMailType
    {
        public int MailTypeId { get; set; }
        public string MailType { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
