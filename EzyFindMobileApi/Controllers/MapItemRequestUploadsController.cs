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
    public class MapItemRequestUploadsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapItemRequestUploadsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapItemRequestUploads
        [HttpGet]
        public IEnumerable<MapItemRequestUpload> GetMapItemRequestUpload()
        {
            return _context.MapItemRequestUpload;
        }

        // GET: api/MapItemRequestUploads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapItemRequestUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestUpload = await _context.MapItemRequestUpload.FindAsync(id);

            if (mapItemRequestUpload == null)
            {
                return NotFound();
            }

            return Ok(mapItemRequestUpload);
        }

        // PUT: api/MapItemRequestUploads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapItemRequestUpload([FromRoute] int id, [FromBody] MapItemRequestUpload mapItemRequestUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapItemRequestUpload.IrUploadId)
            {
                return BadRequest();
            }

            _context.Entry(mapItemRequestUpload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapItemRequestUploadExists(id))
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

        // POST: api/MapItemRequestUploads
        [HttpPost]
        public async Task<IActionResult> PostMapItemRequestUpload([FromBody] MapItemRequestUpload mapItemRequestUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapItemRequestUpload.Add(mapItemRequestUpload);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapItemRequestUpload", new { id = mapItemRequestUpload.IrUploadId }, mapItemRequestUpload);
        }

        // DELETE: api/MapItemRequestUploads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapItemRequestUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapItemRequestUpload = await _context.MapItemRequestUpload.FindAsync(id);
            if (mapItemRequestUpload == null)
            {
                return NotFound();
            }

            _context.MapItemRequestUpload.Remove(mapItemRequestUpload);
            await _context.SaveChangesAsync();

            return Ok(mapItemRequestUpload);
        }

        private bool MapItemRequestUploadExists(int id)
        {
            return _context.MapItemRequestUpload.Any(e => e.IrUploadId == id);
        }
    }
}