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
    public class MapProductImagesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapProductImagesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapProductImages
        [HttpGet]
        public IEnumerable<MapProductImages> GetMapProductImages()
        {
            return _context.MapProductImages;
        }

        // GET: api/MapProductImages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapProductImages([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapProductImages = await _context.MapProductImages.FindAsync(id);

            if (mapProductImages == null)
            {
                return NotFound();
            }

            return Ok(mapProductImages);
        }

        // PUT: api/MapProductImages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapProductImages([FromRoute] int id, [FromBody] MapProductImages mapProductImages)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapProductImages.ImageId)
            {
                return BadRequest();
            }

            _context.Entry(mapProductImages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapProductImagesExists(id))
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

        // POST: api/MapProductImages
        [HttpPost]
        public async Task<IActionResult> PostMapProductImages([FromBody] MapProductImages mapProductImages)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapProductImages.Add(mapProductImages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapProductImages", new { id = mapProductImages.ImageId }, mapProductImages);
        }

        // DELETE: api/MapProductImages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapProductImages([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapProductImages = await _context.MapProductImages.FindAsync(id);
            if (mapProductImages == null)
            {
                return NotFound();
            }

            _context.MapProductImages.Remove(mapProductImages);
            await _context.SaveChangesAsync();

            return Ok(mapProductImages);
        }

        private bool MapProductImagesExists(int id)
        {
            return _context.MapProductImages.Any(e => e.ImageId == id);
        }
    }
}