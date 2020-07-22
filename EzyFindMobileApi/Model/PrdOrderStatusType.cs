using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdOrderStatusType
    {
        public int OrderStatusTypeId { get; set; }
        public string StatusName { get; set; }
        public int? StatusSequence { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
