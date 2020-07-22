using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzyFindMobileApi.General
{
    public class SendSMSMessage
    {
        public string Content { get; set; }
        public string Destination { get; set; }

        public static implicit operator List<object>(SendSMSMessage v)
        {
            throw new NotImplementedException();
        }
    }
}
