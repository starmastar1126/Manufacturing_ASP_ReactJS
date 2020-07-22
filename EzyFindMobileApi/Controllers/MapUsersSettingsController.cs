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
    public class MapUsersSettingsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapUsersSettingsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapUsersSettings
        [HttpGet]
        public IEnumerable<MapUsersSettings> GetMapUsersSettings()
        {
            return _context.MapUsersSettings;
        }

        // GET: api/MapUsersSettings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapUsersSettings([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapUsersSettings = await _context.MapUsersSettings.FindAsync(id);

            if (mapUsersSettings == null)
            {
                return NotFound();
            }

            return Ok(mapUsersSettings);
        }

        // PUT: api/MapUsersSettings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapUsersSettings([FromRoute] int id, [FromBody] MapUsersSettings mapUsersSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapUsersSettings.UserSettingId)
            {
                return BadRequest();
            }

            _context.Entry(mapUsersSettings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapUsersSettingsExists(id))
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

        // POST: api/MapUsersSettings
        [HttpPost]
        public async Task<IActionResult> PostMapUsersSettings([FromBody] MapUsersSettings mapUsersSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapUsersSettings.Add(mapUsersSettings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapUsersSettings", new { id = mapUsersSettings.UserSettingId }, mapUsersSettings);
        }

        // DELETE: api/MapUsersSettings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapUsersSettings([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapUsersSettings = await _context.MapUsersSettings.FindAsync(id);
            if (mapUsersSettings == null)
            {
                return NotFound();
            }

            _context.MapUsersSettings.Remove(mapUsersSettings);
            await _context.SaveChangesAsync();

            return Ok(mapUsersSettings);
        }

        private bool MapUsersSettingsExists(int id)
        {
            return _context.MapUsersSettings.Any(e => e.UserSettingId == id);
        }
    }
}