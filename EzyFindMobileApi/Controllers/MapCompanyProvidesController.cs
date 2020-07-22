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
    public class MapCompanyProvidesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyProvidesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyProvides
        [HttpGet]
        public IEnumerable<MapCompanyProvide> GetMapCompanyProvide()
        {
            return _context.MapCompanyProvide;
        }

        // GET: api/MapCompanyProvides/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyProvide([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyProvide = await _context.MapCompanyProvide.FindAsync(id);

            if (mapCompanyProvide == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyProvide);
        }

        // PUT: api/MapCompanyProvides/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyProvide([FromRoute] int id, [FromBody] MapCompanyProvide mapCompanyProvide)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyProvide.ProvideKeywordId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyProvide).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyProvideExists(id))
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

        // POST: api/MapCompanyProvides
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyProvide([FromBody] MapCompanyProvide mapCompanyProvide)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyProvide.Add(mapCompanyProvide);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyProvide", new { id = mapCompanyProvide.ProvideKeywordId }, mapCompanyProvide);
        }

        // DELETE: api/MapCompanyProvides/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyProvide([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyProvide = await _context.MapCompanyProvide.FindAsync(id);
            if (mapCompanyProvide == null)
            {
                return NotFound();
            }

            _context.MapCompanyProvide.Remove(mapCompanyProvide);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyProvide);
        }

        private bool MapCompanyProvideExists(int id)
        {
            return _context.MapCompanyProvide.Any(e => e.ProvideKeywordId == id);
        }
    }
}