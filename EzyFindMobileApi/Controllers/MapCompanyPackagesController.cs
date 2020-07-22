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
    public class MapCompanyPackagesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyPackagesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyPackages
        [HttpGet]
        public IEnumerable<MapCompanyPackage> GetMapCompanyPackage()
        {
            return _context.MapCompanyPackage;
        }

        // GET: api/MapCompanyPackages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyPackage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyPackage = await _context.MapCompanyPackage.FindAsync(id);

            if (mapCompanyPackage == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyPackage);
        }

        // PUT: api/MapCompanyPackages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyPackage([FromRoute] int id, [FromBody] MapCompanyPackage mapCompanyPackage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyPackage.CompPackageId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyPackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyPackageExists(id))
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

        // POST: api/MapCompanyPackages
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyPackage([FromBody] MapCompanyPackage mapCompanyPackage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyPackage.Add(mapCompanyPackage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyPackage", new { id = mapCompanyPackage.CompPackageId }, mapCompanyPackage);
        }

        // DELETE: api/MapCompanyPackages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyPackage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyPackage = await _context.MapCompanyPackage.FindAsync(id);
            if (mapCompanyPackage == null)
            {
                return NotFound();
            }

            _context.MapCompanyPackage.Remove(mapCompanyPackage);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyPackage);
        }

        private bool MapCompanyPackageExists(int id)
        {
            return _context.MapCompanyPackage.Any(e => e.CompPackageId == id);
        }
    }
}