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
    public class CategoryController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();

        // GET: api/Category/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoriesByParentId(int id)
        {
            try
            {
                //await GetUserById(id);
                var mMstCategory = await db.MstCategory.Where(c => c.ParentCategoryId == id).ToListAsync();

                response.Status = true;                // Operation Status Indicator
                response.Message = "Category successful";   // Exception Message
                response.Result = mMstCategory;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting Categories";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            try
            {
                //await GetUserById(id);
                var mMstCategory = await db.MstCategory.ToListAsync();
                response.Status = true;                // Operation Status Indicator
                response.Message = "Category successful";   // Exception Message
                response.Result = mMstCategory;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting Categories";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

    }
}
