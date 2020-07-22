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
    public class MstFavouritesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstFavouritesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstFavourites
        [HttpGet]
        public IEnumerable<MstFavourites> GetMstFavourites()
        {
            return _context.MstFavourites;
        }

        // GET: api/MstFavourites/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstFavourites([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstFavourites = await _context.MstFavourites.FindAsync(id);

            if (mstFavourites == null)
            {
                return NotFound();
            }

            return Ok(mstFavourites);
        }

        // PUT: api/MstFavourites/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstFavourites([FromRoute] int id, [FromBody] MstFavourites mstFavourites)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstFavourites.MstFavouriteId)
            {
                return BadRequest();
            }

            _context.Entry(mstFavourites).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstFavouritesExists(id))
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

        // POST: api/MstFavourites
        [HttpPost]
        public async Task<IActionResult> PostMstFavourites([FromBody] MstFavourites mstFavourites)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstFavourites.Add(mstFavourites);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstFavourites", new { id = mstFavourites.MstFavouriteId }, mstFavourites);
        }

        // DELETE: api/MstFavourites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstFavourites([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstFavourites = await _context.MstFavourites.FindAsync(id);
            if (mstFavourites == null)
            {
                return NotFound();
            }

            _context.MstFavourites.Remove(mstFavourites);
            await _context.SaveChangesAsync();

            return Ok(mstFavourites);
        }

        private bool MstFavouritesExists(int id)
        {
            return _context.MstFavourites.Any(e => e.MstFavouriteId == id);
        }
    }
}