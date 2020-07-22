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
    public class MapUserRoleRightsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapUserRoleRightsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapUserRoleRights
        [HttpGet]
        public IEnumerable<MapUserRoleRights> GetMapUserRoleRights()
        {
            return _context.MapUserRoleRights;
        }

        // GET: api/MapUserRoleRights/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapUserRoleRights([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapUserRoleRights = await _context.MapUserRoleRights.FindAsync(id);

            if (mapUserRoleRights == null)
            {
                return NotFound();
            }

            return Ok(mapUserRoleRights);
        }

        // PUT: api/MapUserRoleRights/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapUserRoleRights([FromRoute] int id, [FromBody] MapUserRoleRights mapUserRoleRights)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapUserRoleRights.RightsId)
            {
                return BadRequest();
            }

            _context.Entry(mapUserRoleRights).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapUserRoleRightsExists(id))
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

        // POST: api/MapUserRoleRights
        [HttpPost]
        public async Task<IActionResult> PostMapUserRoleRights([FromBody] MapUserRoleRights mapUserRoleRights)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapUserRoleRights.Add(mapUserRoleRights);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapUserRoleRights", new { id = mapUserRoleRights.RightsId }, mapUserRoleRights);
        }

        // DELETE: api/MapUserRoleRights/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapUserRoleRights([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapUserRoleRights = await _context.MapUserRoleRights.FindAsync(id);
            if (mapUserRoleRights == null)
            {
                return NotFound();
            }

            _context.MapUserRoleRights.Remove(mapUserRoleRights);
            await _context.SaveChangesAsync();

            return Ok(mapUserRoleRights);
        }

        private bool MapUserRoleRightsExists(int id)
        {
            return _context.MapUserRoleRights.Any(e => e.RightsId == id);
        }
    }
}