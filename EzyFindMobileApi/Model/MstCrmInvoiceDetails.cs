using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmInvoiceDetails
    {
        public int InvoiceLineItemId { get; set; }
        public int? InvoiceId { get; set; }
        public int? InventoryId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public MstCrmInventory Inventory { get; set; }
        public MstCrmInvoice Invoice { get; set; }
    }
}
