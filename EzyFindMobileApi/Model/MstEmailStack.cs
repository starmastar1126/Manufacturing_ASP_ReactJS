using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstEmailStack
    {
        public int EmailStackId { get; set; }
        public string FromAddress { get; set; }
        public string ToName { get; set; }
        public string ToAddress { get; set; }
        public string ToCcname { get; set; }
        public string ToCc { get; set; }
        public string ToBcc { get; set; }
        public string ToBccname { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? EmailSentOn { get; set; }
        public string EmailSentFrom { get; set; }
        public bool? EmailSentSuccess { get; set; }
        public string AttachmentPath { get; set; }
        public string AttachmentName { get; set; }
        public int? EmailSendCount { get; set; }
        public DateTime? EmailCreatedOn { get; set; }
    }
}
