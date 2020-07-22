using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmQuote
    {
        public MstCrmQuote()
        {
            MstCrmQuoteDetails = new HashSet<MstCrmQuoteDetails>();
        }

        public int QuoteId { get; set; }
        public string QuoteNo { get; set; }
        public string QuoteDescription { get; set; }
        public string QuoteFooter { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? QuoteDate { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public MstCompany Company { get; set; }
        public MstCrmCustomer Customer { get; set; }
        public ICollection<MstCrmQuoteDetails> MstCrmQuoteDetails { get; set; }
    }
}
