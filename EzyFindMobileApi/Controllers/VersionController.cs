using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzyFindMobileApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EzyFindMobileApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/Version
        [HttpGet]
        [Authorize]//(Roles = "Main Business User, Indvidual User (Seeker)")]
        public async Task<IActionResult> GetVersion()
        {
            try
            {
                //await GetUserById(id);
                var mMstVersion = await db.MstVersion.ToListAsync();
                response.Status = true;                // Operation Status Indicator
                response.Message = "Version successful";   // Exception Message
                response.Result = mMstVersion;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting Versions";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }


    }
}
