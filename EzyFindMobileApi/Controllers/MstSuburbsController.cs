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
    public class MstSuburbsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstSuburbsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstSuburbs
        [HttpGet]
        public IEnumerable<MstSuburb> GetMstSuburb()
        {
            return _context.MstSuburb;
        }

        // GET: api/MstSuburbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstSuburb([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSuburb = await _context.MstSuburb.FindAsync(id);

            if (mstSuburb == null)
            {
                return NotFound();
            }

            return Ok(mstSuburb);
        }

        // PUT: api/MstSuburbs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstSuburb([FromRoute] int id, [FromBody] MstSuburb mstSuburb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstSuburb.SuburbId)
            {
                return BadRequest();
            }

            _context.Entry(mstSuburb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstSuburbExists(id))
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

        // POST: api/MstSuburbs
        [HttpPost]
        public async Task<IActionResult> PostMstSuburb([FromBody] MstSuburb mstSuburb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstSuburb.Add(mstSuburb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstSuburb", new { id = mstSuburb.SuburbId }, mstSuburb);
        }

        // DELETE: api/MstSuburbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstSuburb([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSuburb = await _context.MstSuburb.FindAsync(id);
            if (mstSuburb == null)
            {
                return NotFound();
            }

            _context.MstSuburb.Remove(mstSuburb);
            await _context.SaveChangesAsync();

            return Ok(mstSuburb);
        }

        private bool MstSuburbExists(int id)
        {
            return _context.MstSuburb.Any(e => e.SuburbId == id);
        }
    }
}