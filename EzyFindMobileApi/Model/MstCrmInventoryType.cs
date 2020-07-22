using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmInventoryType
    {
        public MstCrmInventoryType()
        {
            MstCrmInventory = new HashSet<MstCrmInventory>();
        }

        public int InventoryTypeId { get; set; }
        public string InventoryTypeName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public ICollection<MstCrmInventory> MstCrmInventory { get; set; }
    }
}
