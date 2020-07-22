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
    public class MstRatingsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstRatingsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstRatings
        [HttpGet]
        public IEnumerable<MstRating> GetMstRating()
        {
            return _context.MstRating;
        }

        // GET: api/MstRatings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstRating([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstRating = await _context.MstRating.FindAsync(id);

            if (mstRating == null)
            {
                return NotFound();
            }

            return Ok(mstRating);
        }

        // PUT: api/MstRatings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstRating([FromRoute] int id, [FromBody] MstRating mstRating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstRating.MstRatingId)
            {
                return BadRequest();
            }

            _context.Entry(mstRating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstRatingExists(id))
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

        // POST: api/MstRatings
        [HttpPost]
        public async Task<IActionResult> PostMstRating([FromBody] MstRating mstRating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstRating.Add(mstRating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstRating", new { id = mstRating.MstRatingId }, mstRating);
        }

        // DELETE: api/MstRatings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstRating([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstRating = await _context.MstRating.FindAsync(id);
            if (mstRating == null)
            {
                return NotFound();
            }

            _context.MstRating.Remove(mstRating);
            await _context.SaveChangesAsync();

            return Ok(mstRating);
        }

        private bool MstRatingExists(int id)
        {
            return _context.MstRating.Any(e => e.MstRatingId == id);
        }
    }
}