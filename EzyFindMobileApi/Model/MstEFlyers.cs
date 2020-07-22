using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstEFlyers
    {
        public MstEFlyers()
        {
            MapEflyersUpload = new HashSet<MapEflyersUpload>();
            MstFavourites = new HashSet<MstFavourites>();
        }

        public int Efmid { get; set; }
        public int? CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? StatusId { get; set; }
        public bool? IsMenu { get; set; }
        public int? CategoryId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MstCategory Category { get; set; }
        public MstCompany Company { get; set; }
        public MstStatus Status { get; set; }
        public ICollection<MapEflyersUpload> MapEflyersUpload { get; set; }
        public ICollection<MstFavourites> MstFavourites { get; set; }
    }
}
