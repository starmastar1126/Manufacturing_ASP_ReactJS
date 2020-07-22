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
    public class SpecialController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Special
        [HttpGet]
        public async Task<IActionResult> GetSpecial(int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstSpecials;
                var mstSpecials = await query.Where(q => q.StatusId == 2).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Specials returned";   // Exception Message
                response.Result = mstSpecials;
                response.TotalPages = totalPages;
                response.CurrentPage = page;
                response.PrevPage = prevPage;
                response.NextPage = nextPage;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get Specials";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // GET: api/Special/5
        [HttpGet("{id}", Name = "GetSpecialById")]
        public async Task<IActionResult> GetSpecialByID(int id)
        {
            try
            {
                //await GetUserById(id);
                var mstSpecials = await db.MstSpecials.FindAsync(id);
                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Specails details";   // Exception Message
                response.Result = mstSpecials;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to get Specail details";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        [HttpGet("{id}", Name = "GetSpecialByBusinessId")]
        public async Task<IActionResult> GetSpecialByBusinessId(int id, int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstSpecials;
                var mstSpecials = await query.Where(q => q.StatusId == 2 && q.CompanyId == id).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Specials returned";   // Exception Message
                response.Result = mstSpecials;
                response.TotalPages = totalPages;
                response.CurrentPage = page;
                response.PrevPage = prevPage;
                response.NextPage = nextPage;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get Specials";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // POST: api/Special
        [HttpPost]
        public async Task<IActionResult> AddSpecial([FromBody] MstSpecials mstSpecials)
        {
            try
            {

                if (mstSpecials != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        await db.SaveChangesAsync();
                        id = mstSpecials.SpecialId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Special added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No special provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add special";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/Special/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSpecial (int id, [FromBody] MstSpecials mstSpecials)
        {
            try
            {

                if (mstSpecials != null && id != 0)
                {
                    var mMstSpecials = await db.MstSpecials.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstSpecials.Update(mstSpecials);
                        await db.SaveChangesAsync();
                        id = mstSpecials.SpecialId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Specail updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);  
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No special provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update special";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecial (int id)
        {
            try
            {

                if (id != 0)
                {
                    var mMstSpecials = await db.MstSpecials.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstSpecials.Remove(mMstSpecials);
                        await db.SaveChangesAsync();
                        id = mMstSpecials.SpecialId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Special deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No special provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete special";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
