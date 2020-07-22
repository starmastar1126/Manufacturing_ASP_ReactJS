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
    public class FavouritesController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Favourites  
        [HttpGet("{Id}/{page}/{size}", Name = "GetFavouritesByUserId")]
        public async Task<IActionResult> GetFavouritesByUserId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstFavourites;
                var mstFavourites = await query.Where(q => q.UserId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Favourites returned";   // Exception Message
                response.Result = mstFavourites;
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
                response.Message = "Error : unable to get  Favourites";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{Id}/{page}/{size}", Name = "GetFavouritesByBusinessId")]
        public async Task<IActionResult> GetFavouritesByBusinessId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstFavourites;
                var mstFavourites = await query.Where(q => q.CompanyId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Favourites returned";   // Exception Message
                response.Result = mstFavourites;
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
                response.Message = "Error : unable to get  Favourites";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{Id}/{page}/{size}", Name = "GetFavouritesBySpecialId")]
        public async Task<IActionResult> GetFavouritesBySpecialId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstFavourites;
                var mstFavourites = await query.Where(q => q.SpecialId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Favourites returned";   // Exception Message
                response.Result = mstFavourites;
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
                response.Message = "Error : unable to get  Favourites";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        [HttpGet("{Id}/{page}/{size}", Name = "GetFavouritesByFlyerId")]
        public async Task<IActionResult> GetFavouritesByFlyerId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstFavourites;
                var mstFavourites = await query.Where(q => q.EflyerId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Favourites returned";   // Exception Message
                response.Result = mstFavourites;
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
                response.Message = "Error : unable to get  Favourites";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }



        // POST: api/Add Favourites
        [HttpPost]
        public async Task<IActionResult> AddFavourite([FromBody] MstFavourites mstFavourites)
        {
            try
            {

                if (mstFavourites != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstFavourites.Add(mstFavourites);
                        await db.SaveChangesAsync();
                        id = mstFavourites.MstFavouriteId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Favourite added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Favourite provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Favourite";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/UpdateFavourite/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFavourite(int id, [FromBody] MstFavourites mstFavourites)
        {
            try
            {

                if (mstFavourites != null && id != 0)
                {

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstFavourites.Update(mstFavourites);
                        await db.SaveChangesAsync();
                        id = mstFavourites.MstFavouriteId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Favourite updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Favourite provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Favourite";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/DeleteFavourites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavourites(int? id)
        {
            try
            {

                if (id != 0)
                {
                    var mstFavourites = await db.MstFavourites.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.MstFavourites.Remove(mstFavourites);
                        await db.SaveChangesAsync();
                        id = mstFavourites.MstFavouriteId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: favourite deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No favourite provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete favourite";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
