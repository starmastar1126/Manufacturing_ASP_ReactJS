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
    public class MapItemRequestAreasController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapItemRequestAreasController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapItemRequestAreas
        [HttpGet]
        public IEnumerable<MapItemRequestArea> GetMapItemRequestArea()
        {
            return _context.MapItemRequestArea;
        }

        // GET: api/MapItemRequestAreas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapItemRequestArea([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestArea = await _context.MapItemRequestArea.FindAsync(id);

            if (mapItemRequestArea == null)
            {
                return NotFound();
            }

            return Ok(mapItemRequestArea);
        }

        // PUT: api/MapItemRequestAreas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapItemRequestArea([FromRoute] int id, [FromBody] MapItemRequestArea mapItemRequestArea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapItemRequestArea.IrAreaId)
            {
                return BadRequest();
            }

            _context.Entry(mapItemRequestArea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapItemRequestAreaExists(id))
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

        // POST: api/MapItemRequestAreas
        [HttpPost]
        public async Task<IActionResult> PostMapItemRequestArea([FromBody] MapItemRequestArea mapItemRequestArea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapItemRequestArea.Add(mapItemRequestArea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapItemRequestArea", new { id = mapItemRequestArea.IrAreaId }, mapItemRequestArea);
        }

        // DELETE: api/MapItemRequestAreas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapItemRequestArea([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestArea = await _context.MapItemRequestArea.FindAsync(id);
            if (mapItemRequestArea == null)
            {
                return NotFound();
            }

            _context.MapItemRequestArea.Remove(mapItemRequestArea);
            await _context.SaveChangesAsync();

            return Ok(mapItemRequestArea);
        }

        private bool MapItemRequestAreaExists(int id)
        {
            return _context.MapItemRequestArea.Any(e => e.IrAreaId == id);
        }
    }
}