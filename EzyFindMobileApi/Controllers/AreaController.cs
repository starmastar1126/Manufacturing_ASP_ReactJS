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
    public class AreaController : ControllerBase
    {

        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();

        [HttpGet]
        public async Task<IActionResult> GetCountry()
        {
            try
            {
                
                var mMstCountry = await db.MstCountry.ToListAsync();
                response.Status = true;                // Operation Status Indicator
                response.Message = "Country successful";   // Exception Message
                response.Result = mMstCountry;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting Country";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProvince()
        {
            try
            {
                
                var mMstProvince = await db.MstProvince.ToListAsync();
                response.Status = true;                // Operation Status Indicator
                response.Message = "Province successful";   // Exception Message
                response.Result = mMstProvince;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting Province";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetCity()
        {
            try
            {
                
                var mMstCity = await db.MstCity.ToListAsync();
                response.Status = true;                // Operation Status Indicator
                response.Message = "City successful";   // Exception Message
                response.Result = mMstCity;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting City";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSuburb()
        {
            try
            {
                
                var mMstSuburb = await db.MstSuburb.ToListAsync();
                response.Status = true;                // Operation Status Indicator
                response.Message = "Suburb successful";   // Exception Message
                response.Result = mMstSuburb;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : getting Suburb";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
