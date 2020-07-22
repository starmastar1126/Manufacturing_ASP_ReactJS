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
    public class MapCompanyCategoriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyCategoriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyCategories
        [HttpGet]
        public IEnumerable<MapCompanyCategory> GetMapCompanyCategory()
        {
            return _context.MapCompanyCategory;
        }

        // GET: api/MapCompanyCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyCategory = await _context.MapCompanyCategory.FindAsync(id);

            if (mapCompanyCategory == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyCategory);
        }

        // PUT: api/MapCompanyCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyCategory([FromRoute] int id, [FromBody] MapCompanyCategory mapCompanyCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyCategory.CompanyCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyCategoryExists(id))
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

        // POST: api/MapCompanyCategories
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyCategory([FromBody] MapCompanyCategory mapCompanyCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyCategory.Add(mapCompanyCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyCategory", new { id = mapCompanyCategory.CompanyCategoryId }, mapCompanyCategory);
        }

        // DELETE: api/MapCompanyCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyCategory = await _context.MapCompanyCategory.FindAsync(id);
            if (mapCompanyCategory == null)
            {
                return NotFound();
            }

            _context.MapCompanyCategory.Remove(mapCompanyCategory);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyCategory);
        }

        private bool MapCompanyCategoryExists(int id)
        {
            return _context.MapCompanyCategory.Any(e => e.CompanyCategoryId == id);
        }
    }
}