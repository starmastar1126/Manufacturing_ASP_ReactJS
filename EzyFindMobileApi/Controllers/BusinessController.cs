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
    public class BusinessController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Business
        [HttpGet]
        public async Task<IActionResult> GetBusiness(int page, int size)
        {
            try
            {
                if (size == 0)
                    size = 10;

                var query = db.MstCompany;
                var companies = await query.Where(q => q.CompanyStatusId == 1 || q.CompanyStatusId == 2).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Businesses returned";   // Exception Message
                response.Result = companies;
                response.TotalPages = totalPages;
                response.CurrentPage = page;
                response.PrevPage = prevPage;
                response.NextPage = nextPage;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get Businesses";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }

        // GET: api/Business/5
        [HttpGet("{id}", Name = "GetBusinessByID")]
        public async Task<IActionResult> GetBusinessByID(int id)
        {
            try
            {
                //await GetUserById(id);
                var mSTUsers = await db.MstCompany.FindAsync(id);
                response.Status = true;                // Operation Status Indicator
                response.Message = "Business details";   // Exception Message
                response.Result = mSTUsers;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to get business details";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // POST: api/Business
        [HttpPost]
        public void Post([FromBody] MstCompany mstCompany)
        {

        }

        // PUT: api/Business/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
