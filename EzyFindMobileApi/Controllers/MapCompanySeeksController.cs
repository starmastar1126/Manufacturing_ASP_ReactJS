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
    public class MapCompanySeeksController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanySeeksController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanySeeks
        [HttpGet]
        public IEnumerable<MapCompanySeek> GetMapCompanySeek()
        {
            return _context.MapCompanySeek;
        }

        // GET: api/MapCompanySeeks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanySeek([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanySeek = await _context.MapCompanySeek.FindAsync(id);

            if (mapCompanySeek == null)
            {
                return NotFound();
            }

            return Ok(mapCompanySeek);
        }

        // PUT: api/MapCompanySeeks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanySeek([FromRoute] int id, [FromBody] MapCompanySeek mapCompanySeek)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanySeek.SeekKeywordId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanySeek).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanySeekExists(id))
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

        // POST: api/MapCompanySeeks
        [HttpPost]
        public async Task<IActionResult> PostMapCompanySeek([FromBody] MapCompanySeek mapCompanySeek)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanySeek.Add(mapCompanySeek);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanySeek", new { id = mapCompanySeek.SeekKeywordId }, mapCompanySeek);
        }

        // DELETE: api/MapCompanySeeks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanySeek([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanySeek = await _context.MapCompanySeek.FindAsync(id);
            if (mapCompanySeek == null)
            {
                return NotFound();
            }

            _context.MapCompanySeek.Remove(mapCompanySeek);
            await _context.SaveChangesAsync();

            return Ok(mapCompanySeek);
        }

        private bool MapCompanySeekExists(int id)
        {
            return _context.MapCompanySeek.Any(e => e.SeekKeywordId == id);
        }
    }
}