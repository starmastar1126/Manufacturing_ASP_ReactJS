using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzyFindMobileApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EzyFindMobileApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerEnquiryController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/CusotmerEnquiry
        [HttpGet("{userId}/{page}/{size}", Name = "GetCusotmerEnquiryByUserId")]
        public async Task<IActionResult> GetCusotmerEnquiryByUserId(int userId, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstCustomerEnquiry;
                var mstCustomerEnquiries = await query.Where(q => q.UserId == userId).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Customer Enquiry returned";   // Exception Message
                response.Result = mstCustomerEnquiries;
                response.Count = count;
                response.TotalPages = totalPages;
                response.CurrentPage = page;
                response.PrevPage = prevPage;
                response.NextPage = nextPage;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get  Customer Enquiry";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // GET: api/CusotmerEnquiry/5 
        
        [HttpGet("{BusinessId}/{page}/{size}", Name = "GetCusotmerEnquiryByBusinessId")]
        public async Task<IActionResult> GetRequestByBusinessID(int BusinessId, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstCustomerEnquiry;
                var mstCustomerEnquiries = await query.Where(q => q.CompanyId == BusinessId).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Customer Enquiry returned";   // Exception Message
                response.Result = mstCustomerEnquiries;
                response.Count = count;
                response.TotalPages = totalPages;
                response.CurrentPage = page;
                response.PrevPage = prevPage;
                response.NextPage = nextPage;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get  Customer Enquiry";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }



        // POST: api/AddCustomerEnquiry
        [HttpPost]
        public async Task<IActionResult> AddCustomerEnquiry([FromBody] MstCustomerEnquiry mstCustomerEnquiry)
        {
            try
            {

                if (mstCustomerEnquiry != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstCustomerEnquiry.Add(mstCustomerEnquiry);
                        await db.SaveChangesAsync();
                        id = mstCustomerEnquiry.CustomerEnquiryId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Customer Enquiry added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Customer Enquiry provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Customer Enquiry";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/CusotmerEnquiry/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerEnquiry(int id, [FromBody] MstCustomerEnquiry mstCustomerEnquiry)
        {
            try
            {

                if (mstCustomerEnquiry != null && id != 0)
                {

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstCustomerEnquiry.Update(mstCustomerEnquiry);
                        await db.SaveChangesAsync();
                        id = mstCustomerEnquiry.CustomerEnquiryId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Customer Enquiry updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Customer Enquiry provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Customer Enquiry";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/CusotmerEnquiry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int? id)
        {
            try
            {

                if (id != 0)
                {
                    var mstCustomerEnquiry = await db.MstCustomerEnquiry.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstCustomerEnquiry.Remove(mstCustomerEnquiry);
                        await db.SaveChangesAsync();
                        id = mstCustomerEnquiry.CustomerEnquiryId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Customer Enquiry deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Customer Enquiry provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete Customer Enquiry";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
