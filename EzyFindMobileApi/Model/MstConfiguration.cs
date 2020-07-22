using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstConfiguration
    {
        public int ConfigurationId { get; set; }
        public string SmtpHostServer { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
        public bool? SmtpEnableSsl { get; set; }
        public string SmtpFromEmail { get; set; }
        public string SmtpFromName { get; set; }
        public string SmsUserName { get; set; }
        public string SmsPassword { get; set; }
        public bool? SmsIsEnabled { get; set; }
        public string FbFanPageLink { get; set; }
        public string FbApiclientId { get; set; }
        public string FbApisecretKey { get; set; }
        public string GpFanPageLink { get; set; }
        public string GpApiclientId { get; set; }
        public string GpApisecretKey { get; set; }
        public string TwFanPageLink { get; set; }
        public string TwApiclientId { get; set; }
        public string TwApisecretKey { get; set; }
        public string IgFanPageLink { get; set; }
        public string IgApiclientId { get; set; }
        public string IgApisecretKey { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
