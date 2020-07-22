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
    public class MapItemRequestCategoriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapItemRequestCategoriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapItemRequestCategories
        [HttpGet]
        public IEnumerable<MapItemRequestCategory> GetMapItemRequestCategory()
        {
            return _context.MapItemRequestCategory;
        }

        // GET: api/MapItemRequestCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapItemRequestCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestCategory = await _context.MapItemRequestCategory.FindAsync(id);

            if (mapItemRequestCategory == null)
            {
                return NotFound();
            }

            return Ok(mapItemRequestCategory);
        }

        // PUT: api/MapItemRequestCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapItemRequestCategory([FromRoute] int id, [FromBody] MapItemRequestCategory mapItemRequestCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapItemRequestCategory.IrCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(mapItemRequestCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapItemRequestCategoryExists(id))
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

        // POST: api/MapItemRequestCategories
        [HttpPost]
        public async Task<IActionResult> PostMapItemRequestCategory([FromBody] MapItemRequestCategory mapItemRequestCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapItemRequestCategory.Add(mapItemRequestCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapItemRequestCategory", new { id = mapItemRequestCategory.IrCategoryId }, mapItemRequestCategory);
        }

        // DELETE: api/MapItemRequestCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapItemRequestCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestCategory = await _context.MapItemRequestCategory.FindAsync(id);
            if (mapItemRequestCategory == null)
            {
                return NotFound();
            }

            _context.MapItemRequestCategory.Remove(mapItemRequestCategory);
            await _context.SaveChangesAsync();

            return Ok(mapItemRequestCategory);
        }

        private bool MapItemRequestCategoryExists(int id)
        {
            return _context.MapItemRequestCategory.Any(e => e.IrCategoryId == id);
        }
    }
}