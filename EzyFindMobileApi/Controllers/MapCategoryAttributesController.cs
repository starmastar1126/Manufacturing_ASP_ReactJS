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
    public class MapCategoryAttributesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCategoryAttributesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCategoryAttributes
        [HttpGet]
        public IEnumerable<MapCategoryAttributes> GetMapCategoryAttributes()
        {
            return _context.MapCategoryAttributes;
        }

        // GET: api/MapCategoryAttributes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCategoryAttributes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCategoryAttributes = await _context.MapCategoryAttributes.FindAsync(id);

            if (mapCategoryAttributes == null)
            {
                return NotFound();
            }

            return Ok(mapCategoryAttributes);
        }

        // PUT: api/MapCategoryAttributes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCategoryAttributes([FromRoute] int id, [FromBody] MapCategoryAttributes mapCategoryAttributes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCategoryAttributes.CategoryAttributeId)
            {
                return BadRequest();
            }

            _context.Entry(mapCategoryAttributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCategoryAttributesExists(id))
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

        // POST: api/MapCategoryAttributes
        [HttpPost]
        public async Task<IActionResult> PostMapCategoryAttributes([FromBody] MapCategoryAttributes mapCategoryAttributes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCategoryAttributes.Add(mapCategoryAttributes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCategoryAttributes", new { id = mapCategoryAttributes.CategoryAttributeId }, mapCategoryAttributes);
        }

        // DELETE: api/MapCategoryAttributes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCategoryAttributes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCategoryAttributes = await _context.MapCategoryAttributes.FindAsync(id);
            if (mapCategoryAttributes == null)
            {
                return NotFound();
            }

            _context.MapCategoryAttributes.Remove(mapCategoryAttributes);
            await _context.SaveChangesAsync();

            return Ok(mapCategoryAttributes);
        }

        private bool MapCategoryAttributesExists(int id)
        {
            return _context.MapCategoryAttributes.Any(e => e.CategoryAttributeId == id);
        }
    }
}