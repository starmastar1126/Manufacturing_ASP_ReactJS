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
    public class MapCompanyMagazineAdsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyMagazineAdsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyMagazineAds
        [HttpGet]
        public IEnumerable<MapCompanyMagazineAd> GetMapCompanyMagazineAd()
        {
            return _context.MapCompanyMagazineAd;
        }

        // GET: api/MapCompanyMagazineAds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyMagazineAd([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyMagazineAd = await _context.MapCompanyMagazineAd.FindAsync(id);

            if (mapCompanyMagazineAd == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyMagazineAd);
        }

        // PUT: api/MapCompanyMagazineAds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyMagazineAd([FromRoute] int id, [FromBody] MapCompanyMagazineAd mapCompanyMagazineAd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyMagazineAd.CompMagId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyMagazineAd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyMagazineAdExists(id))
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

        // POST: api/MapCompanyMagazineAds
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyMagazineAd([FromBody] MapCompanyMagazineAd mapCompanyMagazineAd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyMagazineAd.Add(mapCompanyMagazineAd);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyMagazineAd", new { id = mapCompanyMagazineAd.CompMagId }, mapCompanyMagazineAd);
        }

        // DELETE: api/MapCompanyMagazineAds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyMagazineAd([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyMagazineAd = await _context.MapCompanyMagazineAd.FindAsync(id);
            if (mapCompanyMagazineAd == null)
            {
                return NotFound();
            }

            _context.MapCompanyMagazineAd.Remove(mapCompanyMagazineAd);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyMagazineAd);
        }

        private bool MapCompanyMagazineAdExists(int id)
        {
            return _context.MapCompanyMagazineAd.Any(e => e.CompMagId == id);
        }
    }
}