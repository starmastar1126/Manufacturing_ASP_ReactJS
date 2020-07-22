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
    public class MapSpecialUploadsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapSpecialUploadsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapSpecialUploads
        [HttpGet]
        public IEnumerable<MapSpecialUpload> GetMapSpecialUpload()
        {
            return _context.MapSpecialUpload;
        }

        // GET: api/MapSpecialUploads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapSpecialUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapSpecialUpload = await _context.MapSpecialUpload.FindAsync(id);

            if (mapSpecialUpload == null)
            {
                return NotFound();
            }

            return Ok(mapSpecialUpload);
        }

        // PUT: api/MapSpecialUploads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapSpecialUpload([FromRoute] int id, [FromBody] MapSpecialUpload mapSpecialUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapSpecialUpload.SpecialUploadId)
            {
                return BadRequest();
            }

            _context.Entry(mapSpecialUpload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapSpecialUploadExists(id))
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

        // POST: api/MapSpecialUploads
        [HttpPost]
        public async Task<IActionResult> PostMapSpecialUpload([FromBody] MapSpecialUpload mapSpecialUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapSpecialUpload.Add(mapSpecialUpload);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapSpecialUpload", new { id = mapSpecialUpload.SpecialUploadId }, mapSpecialUpload);
        }

        // DELETE: api/MapSpecialUploads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapSpecialUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapSpecialUpload = await _context.MapSpecialUpload.FindAsync(id);
            if (mapSpecialUpload == null)
            {
                return NotFound();
            }

            _context.MapSpecialUpload.Remove(mapSpecialUpload);
            await _context.SaveChangesAsync();

            return Ok(mapSpecialUpload);
        }

        private bool MapSpecialUploadExists(int id)
        {
            return _context.MapSpecialUpload.Any(e => e.SpecialUploadId == id);
        }
    }
}