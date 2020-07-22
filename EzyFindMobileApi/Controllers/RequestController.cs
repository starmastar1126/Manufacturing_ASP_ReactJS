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
    public class RequestController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Request
        [HttpGet("{userId}/{page}/{size}", Name = "GetRequestForUser")]
        public async Task<IActionResult> GetRequestForUser(int userId, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemRequest;
                var mstItemRequest = await query.Where(q => q.UserId == userId).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Request returned";   // Exception Message
                response.Result = mstItemRequest;
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
                response.Message = "Error : unable to get Request";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // GET: api/Request/5 
        //Match business CategoryID to request CategoryID to match business incoming requests
        [HttpGet("{id}/{page}/{size}", Name = "GetRequestByCatId")]
        public async Task<IActionResult> GetIncomingRequestByCatId(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemRequest;
                var mstItemRequest = await query.Where(q => q.CategoryId == id && q.ItemRequestStatusId == 2).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Request returned";   // Exception Message
                response.Result = mstItemRequest;
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
                response.Message = "Error : unable to get Request";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{id}", Name = "GetRequestDetails")]
        public async Task<IActionResult> GetRequestDetails(int id)
        {
            try
            {
                var mstItemRequest = await db.MstItemRequest.FindAsync(id);
               

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Request returned";   // Exception Message
                response.Result = mstItemRequest;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get Request";   // Exception Message
                response.Result = null;               
                return Ok(response);
            }
        }

        //Get all accepted quotes request by user
        [HttpGet("{id}/{page}/{size}", Name = "GetRequestBySelBusinessId")]
        public async Task<IActionResult> GetRequestBySelBusinessId(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemRequest;
                var mstItemRequest = await query.Where(q => q.ItemRequestStatusId == 2 && q.SelectedCompany == id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Request returned";   // Exception Message
                response.Result = mstItemRequest;
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
                response.Message = "Error : unable to get Request";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // POST: api/Request
        [HttpPost]
        public async Task<IActionResult> AddRequest([FromBody] MstItemRequest mstItemRequest)
        {
            try
            {

                if (mstItemRequest != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {

                        await db.SaveChangesAsync();
                        id = mstItemRequest.ItemRequestId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Request added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Request provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Request";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/Request/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRequest(int id, [FromBody] MstItemRequest mstItemRequest)
        {
            try
            {

                if (mstItemRequest != null && id != 0)
                {
                   
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstItemRequest.Update(mstItemRequest);
                        await db.SaveChangesAsync();
                        id = mstItemRequest.ItemRequestId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Request updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Request provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Request";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int? id)
        {
            try
            {

                if (id != 0)
                {
                    var mstItemResponse = await db.MstItemResponse.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstItemResponse.Remove(mstItemResponse);
                        await db.SaveChangesAsync();
                        id = mstItemResponse.ItemRequestId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Request deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Request provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete request";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}

