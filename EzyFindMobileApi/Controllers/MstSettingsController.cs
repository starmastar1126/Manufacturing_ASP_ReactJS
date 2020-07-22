using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EzyFindMobileApi.Model;

namespace EzyFindMobileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MstSettingsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstSettingsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstSettings
        [HttpGet]
        public IEnumerable<MstSettings> GetMstSettings()
        {
            return _context.MstSettings;
        }

        // GET: api/MstSettings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstSettings([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSettings = await _context.MstSettings.FindAsync(id);

            if (mstSettings == null)
            {
                return NotFound();
            }

            return Ok(mstSettings);
        }

        // PUT: api/MstSettings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstSettings([FromRoute] int id, [FromBody] MstSettings mstSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstSettings.SettingId)
            {
                return BadRequest();
            }

            _context.Entry(mstSettings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstSettingsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MstSettings
        [HttpPost]
        public async Task<IActionResult> PostMstSettings([FromBody] MstSettings mstSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstSettings.Add(mstSettings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstSettings", new { id = mstSettings.SettingId }, mstSettings);
        }

        // DELETE: api/MstSettings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstSettings([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSettings = await _context.MstSettings.FindAsync(id);
            if (mstSettings == null)
            {
                return NotFound();
            }

            _context.MstSettings.Remove(mstSettings);
            await _context.SaveChangesAsync();

            return Ok(mstSettings);
        }

        private bool MstSettingsExists(int id)
        {
            return _context.MstSettings.Any(e => e.SettingId == id);
        }
    }
}