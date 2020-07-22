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
    public class CustomerEnquiryResponseController : ControllerBase
    {        
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/CusotmerEnquiry
        [HttpGet("{Id}/{page}/{size}", Name = "GetEnquiryResponseById")]
        public async Task<IActionResult> GetEnquiryResponseById(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstCustomerEnquiryResponse;
                var mstCustomerEnquiryResponses = await query.Where(q => q.CustomerEnquiryId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Customer Enquiry response returned";   // Exception Message
                response.Result = mstCustomerEnquiryResponses;
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
                response.Message = "Error : unable to get  Customer Enquiry response";   // Exception Message
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
        public async Task<IActionResult> AddCustomerEnquiryResponse([FromBody] MstCustomerEnquiryResponse mstCustomerEnquiryResponse)
        {
            try
            {

                if (mstCustomerEnquiryResponse != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstCustomerEnquiryResponse.Add(mstCustomerEnquiryResponse);
                        await db.SaveChangesAsync();
                        id = mstCustomerEnquiryResponse.CeresponseId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Customer Enquiry response added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Customer Enquiry response provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Customer Enquiry response";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/CusotmerEnquiry/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerEnquiryResponse(int id, [FromBody] MstCustomerEnquiryResponse mstCustomerEnquiryResponse)
        {
            try
            {

                if (mstCustomerEnquiryResponse != null && id != 0)
                {

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstCustomerEnquiryResponse.Update(mstCustomerEnquiryResponse);
                        await db.SaveChangesAsync();
                        id = mstCustomerEnquiryResponse.CeresponseId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Customer Enquiry Response updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Customer Enquiry Response provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Customer Response Enquiry";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/CusotmerEnquiry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnquieryResponse(int? id)
        {
            try
            {

                if (id != 0)
                {
                    var mstCustomerEnquiryResponse = await db.MstCustomerEnquiryResponse.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstCustomerEnquiryResponse.Remove(mstCustomerEnquiryResponse);
                        await db.SaveChangesAsync();
                        id = mstCustomerEnquiryResponse.CeresponseId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Customer Enquiry response deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Customer Enquiry response provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete Customer Enquiry response";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
