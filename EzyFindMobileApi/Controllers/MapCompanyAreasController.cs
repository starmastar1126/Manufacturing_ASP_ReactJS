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
    public class MapCompanyAreasController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyAreasController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyAreas
        [HttpGet]
        public IEnumerable<MapCompanyArea> GetMapCompanyArea()
        {
            return _context.MapCompanyArea;
        }

        // GET: api/MapCompanyAreas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyArea([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyArea = await _context.MapCompanyArea.FindAsync(id);

            if (mapCompanyArea == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyArea);
        }

        // PUT: api/MapCompanyAreas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyArea([FromRoute] int id, [FromBody] MapCompanyArea mapCompanyArea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyArea.CompanyAreaId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyArea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyAreaExists(id))
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

        // POST: api/MapCompanyAreas
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyArea([FromBody] MapCompanyArea mapCompanyArea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyArea.Add(mapCompanyArea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyArea", new { id = mapCompanyArea.CompanyAreaId }, mapCompanyArea);
        }

        // DELETE: api/MapCompanyAreas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyArea([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyArea = await _context.MapCompanyArea.FindAsync(id);
            if (mapCompanyArea == null)
            {
                return NotFound();
            }

            _context.MapCompanyArea.Remove(mapCompanyArea);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyArea);
        }

        private bool MapCompanyAreaExists(int id)
        {
            return _context.MapCompanyArea.Any(e => e.CompanyAreaId == id);
        }
    }
}