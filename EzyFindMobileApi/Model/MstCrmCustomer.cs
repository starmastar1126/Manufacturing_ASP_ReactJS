using System;
using System.Collections.Generic;

namespace EzyFindMobileApi.Model
{
    public partial class MstCrmCustomer
    {
        public MstCrmCustomer()
        {
            MstCrmCustomerComment = new HashSet<MstCrmCustomerComment>();
            MstCrmInvoice = new HashSet<MstCrmInvoice>();
            MstCrmQuote = new HashSet<MstCrmQuote>();
        }

        public int CustomerId { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Gender { get; set; }
        public string StreetAddress { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }
        public string ZipCode { get; set; }
        public string ContactNo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MstCrmCustomerComment> MstCrmCustomerComment { get; set; }
        public ICollection<MstCrmInvoice> MstCrmInvoice { get; set; }
        public ICollection<MstCrmQuote> MstCrmQuote { get; set; }
    }
}
