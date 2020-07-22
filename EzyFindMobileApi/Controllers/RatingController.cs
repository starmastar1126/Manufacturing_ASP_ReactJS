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
    public class RatingController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Rating
        [HttpGet("{Id}/{page}/{size}", Name = "GetRatingByUserId")]
        public async Task<IActionResult> GetRatingByUserId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstRating;
                var mstRating = await query.Where(q => q.UserId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Rating returned";   // Exception Message
                response.Result = mstRating;
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
                response.Message = "Error : unable to get  Rating";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{Id}/{page}/{size}", Name = "GetRatingByBusinessId")]
        public async Task<IActionResult> GetRatingByBusinessId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstRating;
                var mstRating = await query.Where(q => q.CompanyId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Rating returned";   // Exception Message
                response.Result = mstRating;
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
                response.Message = "Error : unable to get  Rating";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{Id}/{page}/{size}", Name = "GetRatingBySpecialId")]
        public async Task<IActionResult> GetRatingBySpecialId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstRating;
                var mstRating = await query.Where(q => q.SpecialId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Rating returned";   // Exception Message
                response.Result = mstRating;
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
                response.Message = "Error : unable to get  Rating";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{Id}/{page}/{size}", Name = "GetRatingByEFlyerId")]
        public async Task<IActionResult> GetRatingByEFlyerId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstRating;
                var mstRating = await query.Where(q => q.EflyerId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Rating returned";   // Exception Message
                response.Result = mstRating;
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
                response.Message = "Error : unable to get Rating";   // Exception Message
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
        public async Task<IActionResult> AddRating([FromBody] MstRating mstRating)
        {
            try
            {

                if (mstRating != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstRating.Add(mstRating);
                        await db.SaveChangesAsync();
                        id = mstRating.MstRatingId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Rating added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Rating provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Rating";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/CusotmerEnquiry/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRating(int id, [FromBody] MstRating mstRating)
        {
            try
            {

                if (mstRating != null && id != 0)
                {

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstRating.Update(mstRating);
                        await db.SaveChangesAsync();
                        id = mstRating.MstRatingId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Rating updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Rating provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Rating";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/CusotmerEnquiry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int? id)
        {
            try
            {

                if (id != 0)
                {
                    var mstRating = await db.MstRating.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstRating.Remove(mstRating);
                        await db.SaveChangesAsync();
                        id = mstRating.MstRatingId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Rating deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No rating provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete rating";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}

