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
    public class MapItemRequestCategoryAttributesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapItemRequestCategoryAttributesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapItemRequestCategoryAttributes
        [HttpGet]
        public IEnumerable<MapItemRequestCategoryAttribute> GetMapItemRequestCategoryAttribute()
        {
            return _context.MapItemRequestCategoryAttribute;
        }

        // GET: api/MapItemRequestCategoryAttributes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapItemRequestCategoryAttribute([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestCategoryAttribute = await _context.MapItemRequestCategoryAttribute.FindAsync(id);

            if (mapItemRequestCategoryAttribute == null)
            {
                return NotFound();
            }

            return Ok(mapItemRequestCategoryAttribute);
        }

        // PUT: api/MapItemRequestCategoryAttributes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapItemRequestCategoryAttribute([FromRoute] int id, [FromBody] MapItemRequestCategoryAttribute mapItemRequestCategoryAttribute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapItemRequestCategoryAttribute.IrCategoryAttributeId)
            {
                return BadRequest();
            }

            _context.Entry(mapItemRequestCategoryAttribute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapItemRequestCategoryAttributeExists(id))
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

        // POST: api/MapItemRequestCategoryAttributes
        [HttpPost]
        public async Task<IActionResult> PostMapItemRequestCategoryAttribute([FromBody] MapItemRequestCategoryAttribute mapItemRequestCategoryAttribute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapItemRequestCategoryAttribute.Add(mapItemRequestCategoryAttribute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapItemRequestCategoryAttribute", new { id = mapItemRequestCategoryAttribute.IrCategoryAttributeId }, mapItemRequestCategoryAttribute);
        }

        // DELETE: api/MapItemRequestCategoryAttributes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapItemRequestCategoryAttribute([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestCategoryAttribute = await _context.MapItemRequestCategoryAttribute.FindAsync(id);
            if (mapItemRequestCategoryAttribute == null)
            {
                return NotFound();
            }

            _context.MapItemRequestCategoryAttribute.Remove(mapItemRequestCategoryAttribute);
            await _context.SaveChangesAsync();

            return Ok(mapItemRequestCategoryAttribute);
        }

        private bool MapItemRequestCategoryAttributeExists(int id)
        {
            return _context.MapItemRequestCategoryAttribute.Any(e => e.IrCategoryAttributeId == id);
        }
    }
}