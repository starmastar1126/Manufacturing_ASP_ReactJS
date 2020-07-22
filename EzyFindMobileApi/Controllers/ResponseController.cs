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
    public class ResponseController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Response
        [HttpGet("{id}/{page}/{size}", Name = "GetResponse")]
        public async Task<IActionResult> GetResponseByReqId(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemResponse;
                var mstItemResponses = await query.Where(q => q.ItemRequestId == id).OrderByDescending(q => q.ResponseDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Response returned";   // Exception Message
                response.Result = mstItemResponses;
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
                response.Message = "Error : unable to get Response";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // GET: api/Response/5         
        [HttpGet("{id}/{page}/{size}", Name = "GetResponseByUserID")]
        public async Task<IActionResult> GetResponseByUserID(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemResponse;
                var mstItemResponses = await query.Where(q => q.UserId == id).OrderByDescending(q => q.ResponseDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Response returned";   // Exception Message
                response.Result = mstItemResponses;
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
                response.Message = "Error : unable to get Response";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }


        // GET: api/Response/5         
        [HttpGet("{id}/{page}/{size}", Name = "GetResponseByCompanyID")]
        public async Task<IActionResult> GetResponseByCompanyID(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemResponse;
                var mstItemResponses = await query.Where(q => q.CompanyId == id).OrderByDescending(q => q.ResponseDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Response returned";   // Exception Message
                response.Result = mstItemResponses;
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
                response.Message = "Error : unable to get Response";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // GET: api/Response/5         
        [HttpGet("{id}/{page}/{size}", Name = "GetResponseByReplyToID")]
        public async Task<IActionResult> GetResponseByReplyToID(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstItemResponse;
                var mstItemResponses = await query.Where(q => q.ReplyToId == id).OrderByDescending(q => q.ResponseDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Response returned";   // Exception Message
                response.Result = mstItemResponses;
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
                response.Message = "Error : unable to get Response";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }




        // POST: api/Response
        [HttpPost]
        public async Task<IActionResult> AddResponse([FromBody] MstItemResponse mstItemResponse)
        {
            try
            {

                if (mstItemResponse != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstItemResponse.Add(mstItemResponse);
                        await db.SaveChangesAsync();
                        id = mstItemResponse.ItemResponseId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Response added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Response provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Response";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/Response/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResponse(int id, [FromBody] MstItemResponse mstItemResponse)
        {
            try
            {

                if (mstItemResponse != null && id != 0)
                {

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstItemResponse.Update(mstItemResponse);
                        await db.SaveChangesAsync();
                        id = mstItemResponse.ItemResponseId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Response updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Response provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Response";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResponse(int id)
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
                        id = mstItemResponse.ItemResponseId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Response deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Response provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete Response";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}

