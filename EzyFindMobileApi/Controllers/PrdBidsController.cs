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
    public class PrdBidsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdBidsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdBids
        [HttpGet]
        public IEnumerable<PrdBid> GetPrdBid()
        {
            return _context.PrdBid;
        }

        // GET: api/PrdBids/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdBid([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdBid = await _context.PrdBid.FindAsync(id);

            if (prdBid == null)
            {
                return NotFound();
            }

            return Ok(prdBid);
        }

        // PUT: api/PrdBids/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdBid([FromRoute] int id, [FromBody] PrdBid prdBid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdBid.BidId)
            {
                return BadRequest();
            }

            _context.Entry(prdBid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdBidExists(id))
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

        // POST: api/PrdBids
        [HttpPost]
        public async Task<IActionResult> PostPrdBid([FromBody] PrdBid prdBid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdBid.Add(prdBid);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdBid", new { id = prdBid.BidId }, prdBid);
        }

        // DELETE: api/PrdBids/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdBid([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdBid = await _context.PrdBid.FindAsync(id);
            if (prdBid == null)
            {
                return NotFound();
            }

            _context.PrdBid.Remove(prdBid);
            await _context.SaveChangesAsync();

            return Ok(prdBid);
        }

        private bool PrdBidExists(int id)
        {
            return _context.PrdBid.Any(e => e.BidId == id);
        }
    }
}