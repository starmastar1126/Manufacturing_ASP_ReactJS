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
    public class MapEflyersUploadsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapEflyersUploadsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapEflyersUploads
        [HttpGet]
        public IEnumerable<MapEflyersUpload> GetMapEflyersUpload()
        {
            return _context.MapEflyersUpload;
        }

        // GET: api/MapEflyersUploads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapEflyersUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapEflyersUpload = await _context.MapEflyersUpload.FindAsync(id);

            if (mapEflyersUpload == null)
            {
                return NotFound();
            }

            return Ok(mapEflyersUpload);
        }

        // PUT: api/MapEflyersUploads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapEflyersUpload([FromRoute] int id, [FromBody] MapEflyersUpload mapEflyersUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapEflyersUpload.EflyerUploadId)
            {
                return BadRequest();
            }

            _context.Entry(mapEflyersUpload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapEflyersUploadExists(id))
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

        // POST: api/MapEflyersUploads
        [HttpPost]
        public async Task<IActionResult> PostMapEflyersUpload([FromBody] MapEflyersUpload mapEflyersUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapEflyersUpload.Add(mapEflyersUpload);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapEflyersUpload", new { id = mapEflyersUpload.EflyerUploadId }, mapEflyersUpload);
        }

        // DELETE: api/MapEflyersUploads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapEflyersUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapEflyersUpload = await _context.MapEflyersUpload.FindAsync(id);
            if (mapEflyersUpload == null)
            {
                return NotFound();
            }

            _context.MapEflyersUpload.Remove(mapEflyersUpload);
            await _context.SaveChangesAsync();

            return Ok(mapEflyersUpload);
        }

        private bool MapEflyersUploadExists(int id)
        {
            return _context.MapEflyersUpload.Any(e => e.EflyerUploadId == id);
        }
    }
}