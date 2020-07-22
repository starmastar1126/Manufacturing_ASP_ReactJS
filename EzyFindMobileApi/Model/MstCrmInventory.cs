using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmInventory
    {
        public MstCrmInventory()
        {
            MstCrmInvoiceDetails = new HashSet<MstCrmInvoiceDetails>();
            MstCrmQuoteDetails = new HashSet<MstCrmQuoteDetails>();
        }

        public int InventoryId { get; set; }
        public int? CompanyId { get; set; }
        public int? InventoryTypeId { get; set; }
        public string InventoryName { get; set; }
        public string InventoryDescription { get; set; }
        public string OfficeDescription { get; set; }
        public string QunatityTypeName { get; set; }
        public int? Quantity { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public MstCompany Company { get; set; }
        public MstCrmInventoryType InventoryType { get; set; }
        public ICollection<MstCrmInvoiceDetails> MstCrmInvoiceDetails { get; set; }
        public ICollection<MstCrmQuoteDetails> MstCrmQuoteDetails { get; set; }
    }
}
