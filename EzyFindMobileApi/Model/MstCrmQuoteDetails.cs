using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmQuoteDetails
    {
        public int QuoteLineItemId { get; set; }
        public int? QuoteId { get; set; }
        public int? InventoryId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public MstCrmInventory Inventory { get; set; }
        public MstCrmQuote Quote { get; set; }
    }
}
