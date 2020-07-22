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
    public class MapPackageAttributesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapPackageAttributesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapPackageAttributes
        [HttpGet]
        public IEnumerable<MapPackageAttributes> GetMapPackageAttributes()
        {
            return _context.MapPackageAttributes;
        }

        // GET: api/MapPackageAttributes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapPackageAttributes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapPackageAttributes = await _context.MapPackageAttributes.FindAsync(id);

            if (mapPackageAttributes == null)
            {
                return NotFound();
            }

            return Ok(mapPackageAttributes);
        }

        // PUT: api/MapPackageAttributes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapPackageAttributes([FromRoute] int id, [FromBody] MapPackageAttributes mapPackageAttributes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapPackageAttributes.PackageDetailId)
            {
                return BadRequest();
            }

            _context.Entry(mapPackageAttributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapPackageAttributesExists(id))
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

        // POST: api/MapPackageAttributes
        [HttpPost]
        public async Task<IActionResult> PostMapPackageAttributes([FromBody] MapPackageAttributes mapPackageAttributes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapPackageAttributes.Add(mapPackageAttributes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapPackageAttributes", new { id = mapPackageAttributes.PackageDetailId }, mapPackageAttributes);
        }

        // DELETE: api/MapPackageAttributes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapPackageAttributes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapPackageAttributes = await _context.MapPackageAttributes.FindAsync(id);
            if (mapPackageAttributes == null)
            {
                return NotFound();
            }

            _context.MapPackageAttributes.Remove(mapPackageAttributes);
            await _context.SaveChangesAsync();

            return Ok(mapPackageAttributes);
        }

        private bool MapPackageAttributesExists(int id)
        {
            return _context.MapPackageAttributes.Any(e => e.PackageDetailId == id);
        }
    }
}