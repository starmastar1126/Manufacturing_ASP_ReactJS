using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstDomain
    {
        public MstDomain()
        {
            PrdCategory = new HashSet<PrdCategory>();
            PrdProducts = new HashSet<PrdProducts>();
        }

        public int DomainId { get; set; }
        public string DomainName { get; set; }
        public bool? Active { get; set; }

        public ICollection<PrdCategory> PrdCategory { get; set; }
        public ICollection<PrdProducts> PrdProducts { get; set; }
    }
}
