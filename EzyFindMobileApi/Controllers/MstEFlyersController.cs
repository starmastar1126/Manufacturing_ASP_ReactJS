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
    public class MstEFlyersController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstEFlyersController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstEFlyers
        [HttpGet]
        public IEnumerable<MstEFlyers> GetMstEFlyers()
        {
            return _context.MstEFlyers;
        }

        // GET: api/MstEFlyers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstEFlyers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstEFlyers = await _context.MstEFlyers.FindAsync(id);

            if (mstEFlyers == null)
            {
                return NotFound();
            }

            return Ok(mstEFlyers);
        }

        // PUT: api/MstEFlyers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstEFlyers([FromRoute] int id, [FromBody] MstEFlyers mstEFlyers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstEFlyers.Efmid)
            {
                return BadRequest();
            }

            _context.Entry(mstEFlyers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstEFlyersExists(id))
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

        // POST: api/MstEFlyers
        [HttpPost]
        public async Task<IActionResult> PostMstEFlyers([FromBody] MstEFlyers mstEFlyers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstEFlyers.Add(mstEFlyers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstEFlyers", new { id = mstEFlyers.Efmid }, mstEFlyers);
        }

        // DELETE: api/MstEFlyers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstEFlyers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstEFlyers = await _context.MstEFlyers.FindAsync(id);
            if (mstEFlyers == null)
            {
                return NotFound();
            }

            _context.MstEFlyers.Remove(mstEFlyers);
            await _context.SaveChangesAsync();

            return Ok(mstEFlyers);
        }

        private bool MstEFlyersExists(int id)
        {
            return _context.MstEFlyers.Any(e => e.Efmid == id);
        }
    }
}