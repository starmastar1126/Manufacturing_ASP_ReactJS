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
    public class MstKeywordsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstKeywordsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstKeywords
        [HttpGet]
        public IEnumerable<MstKeywords> GetMstKeywords()
        {
            return _context.MstKeywords;
        }

        // GET: api/MstKeywords/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstKeywords([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstKeywords = await _context.MstKeywords.FindAsync(id);

            if (mstKeywords == null)
            {
                return NotFound();
            }

            return Ok(mstKeywords);
        }

        // PUT: api/MstKeywords/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstKeywords([FromRoute] int id, [FromBody] MstKeywords mstKeywords)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstKeywords.KeywordId)
            {
                return BadRequest();
            }

            _context.Entry(mstKeywords).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstKeywordsExists(id))
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

        // POST: api/MstKeywords
        [HttpPost]
        public async Task<IActionResult> PostMstKeywords([FromBody] MstKeywords mstKeywords)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstKeywords.Add(mstKeywords);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstKeywords", new { id = mstKeywords.KeywordId }, mstKeywords);
        }

        // DELETE: api/MstKeywords/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstKeywords([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstKeywords = await _context.MstKeywords.FindAsync(id);
            if (mstKeywords == null)
            {
                return NotFound();
            }

            _context.MstKeywords.Remove(mstKeywords);
            await _context.SaveChangesAsync();

            return Ok(mstKeywords);
        }

        private bool MstKeywordsExists(int id)
        {
            return _context.MstKeywords.Any(e => e.KeywordId == id);
        }
    }
}