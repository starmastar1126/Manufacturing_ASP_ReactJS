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
    public class MstMagazineAdsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstMagazineAdsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstMagazineAds
        [HttpGet]
        public IEnumerable<MstMagazineAd> GetMstMagazineAd()
        {
            return _context.MstMagazineAd;
        }

        // GET: api/MstMagazineAds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstMagazineAd([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMagazineAd = await _context.MstMagazineAd.FindAsync(id);

            if (mstMagazineAd == null)
            {
                return NotFound();
            }

            return Ok(mstMagazineAd);
        }

        // PUT: api/MstMagazineAds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstMagazineAd([FromRoute] int id, [FromBody] MstMagazineAd mstMagazineAd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstMagazineAd.MagazineAdId)
            {
                return BadRequest();
            }

            _context.Entry(mstMagazineAd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstMagazineAdExists(id))
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

        // POST: api/MstMagazineAds
        [HttpPost]
        public async Task<IActionResult> PostMstMagazineAd([FromBody] MstMagazineAd mstMagazineAd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstMagazineAd.Add(mstMagazineAd);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstMagazineAd", new { id = mstMagazineAd.MagazineAdId }, mstMagazineAd);
        }

        // DELETE: api/MstMagazineAds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstMagazineAd([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMagazineAd = await _context.MstMagazineAd.FindAsync(id);
            if (mstMagazineAd == null)
            {
                return NotFound();
            }

            _context.MstMagazineAd.Remove(mstMagazineAd);
            await _context.SaveChangesAsync();

            return Ok(mstMagazineAd);
        }

        private bool MstMagazineAdExists(int id)
        {
            return _context.MstMagazineAd.Any(e => e.MagazineAdId == id);
        }
    }
}