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
    public class MstCrmQuotesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCrmQuotesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCrmQuotes
        [HttpGet]
        public IEnumerable<MstCrmQuote> GetMstCrmQuote()
        {
            return _context.MstCrmQuote;
        }

        // GET: api/MstCrmQuotes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCrmQuote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmQuote = await _context.MstCrmQuote.FindAsync(id);

            if (mstCrmQuote == null)
            {
                return NotFound();
            }

            return Ok(mstCrmQuote);
        }

        // PUT: api/MstCrmQuotes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCrmQuote([FromRoute] int id, [FromBody] MstCrmQuote mstCrmQuote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCrmQuote.QuoteId)
            {
                return BadRequest();
            }

            _context.Entry(mstCrmQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCrmQuoteExists(id))
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

        // POST: api/MstCrmQuotes
        [HttpPost]
        public async Task<IActionResult> PostMstCrmQuote([FromBody] MstCrmQuote mstCrmQuote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCrmQuote.Add(mstCrmQuote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCrmQuote", new { id = mstCrmQuote.QuoteId }, mstCrmQuote);
        }

        // DELETE: api/MstCrmQuotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCrmQuote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmQuote = await _context.MstCrmQuote.FindAsync(id);
            if (mstCrmQuote == null)
            {
                return NotFound();
            }

            _context.MstCrmQuote.Remove(mstCrmQuote);
            await _context.SaveChangesAsync();

            return Ok(mstCrmQuote);
        }

        private bool MstCrmQuoteExists(int id)
        {
            return _context.MstCrmQuote.Any(e => e.QuoteId == id);
        }
    }
}