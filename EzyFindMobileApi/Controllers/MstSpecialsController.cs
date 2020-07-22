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
    public class MstSpecialsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstSpecialsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstSpecials
        [HttpGet]
        public IEnumerable<MstSpecials> GetMstSpecials()
        {
            return _context.MstSpecials;
        }

        // GET: api/MstSpecials/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstSpecials([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSpecials = await _context.MstSpecials.FindAsync(id);

            if (mstSpecials == null)
            {
                return NotFound();
            }

            return Ok(mstSpecials);
        }

        // PUT: api/MstSpecials/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstSpecials([FromRoute] int id, [FromBody] MstSpecials mstSpecials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstSpecials.SpecialId)
            {
                return BadRequest();
            }

            _context.Entry(mstSpecials).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstSpecialsExists(id))
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

        // POST: api/MstSpecials
        [HttpPost]
        public async Task<IActionResult> PostMstSpecials([FromBody] MstSpecials mstSpecials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstSpecials.Add(mstSpecials);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstSpecials", new { id = mstSpecials.SpecialId }, mstSpecials);
        }

        // DELETE: api/MstSpecials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstSpecials([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSpecials = await _context.MstSpecials.FindAsync(id);
            if (mstSpecials == null)
            {
                return NotFound();
            }

            _context.MstSpecials.Remove(mstSpecials);
            await _context.SaveChangesAsync();

            return Ok(mstSpecials);
        }

        private bool MstSpecialsExists(int id)
        {
            return _context.MstSpecials.Any(e => e.SpecialId == id);
        }
    }
}