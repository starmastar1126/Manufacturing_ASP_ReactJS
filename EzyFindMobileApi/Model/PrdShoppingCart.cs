using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdShoppingCart
    {
        public int RecordId { get; set; }
        public string SessionId { get; set; }
        public int? UserId { get; set; }
        public int? Quantity { get; set; }
        public int? ProductId { get; set; }
        public DateTime? DateCreated { get; set; }

        public PrdProducts Product { get; set; }
    }
}
