using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class PrdProducts
    {
        public PrdProducts()
        {
            MapProductDocument = new HashSet<MapProductDocument>();
            MapProductImages = new HashSet<MapProductImages>();
            PrdBid = new HashSet<PrdBid>();
            PrdShoppingCart = new HashSet<PrdShoppingCart>();
        }

        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal? UnitCost { get; set; }
        public string Description { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DomainId { get; set; }
        public int? SubCategoryId { get; set; }
        public bool? Special { get; set; }
        public bool? Featured { get; set; }
        public bool? Auction { get; set; }
        public bool? Hire { get; set; }

        public PrdCategory Category { get; set; }
        public MstDomain Domain { get; set; }
        public ICollection<MapProductDocument> MapProductDocument { get; set; }
        public ICollection<MapProductImages> MapProductImages { get; set; }
        public ICollection<PrdBid> PrdBid { get; set; }
        public ICollection<PrdShoppingCart> PrdShoppingCart { get; set; }
    }
}
