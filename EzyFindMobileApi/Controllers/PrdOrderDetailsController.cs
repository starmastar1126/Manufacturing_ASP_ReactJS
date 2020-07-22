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
    public class PrdOrderDetailsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdOrderDetailsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdOrderDetails
        [HttpGet]
        public IEnumerable<PrdOrderDetails> GetPrdOrderDetails()
        {
            return _context.PrdOrderDetails;
        }

        // GET: api/PrdOrderDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdOrderDetails([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrderDetails = await _context.PrdOrderDetails.FindAsync(id);

            if (prdOrderDetails == null)
            {
                return NotFound();
            }

            return Ok(prdOrderDetails);
        }

        // PUT: api/PrdOrderDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdOrderDetails([FromRoute] int id, [FromBody] PrdOrderDetails prdOrderDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdOrderDetails.OrderDetailsId)
            {
                return BadRequest();
            }

            _context.Entry(prdOrderDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdOrderDetailsExists(id))
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

        // POST: api/PrdOrderDetails
        [HttpPost]
        public async Task<IActionResult> PostPrdOrderDetails([FromBody] PrdOrderDetails prdOrderDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdOrderDetails.Add(prdOrderDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdOrderDetails", new { id = prdOrderDetails.OrderDetailsId }, prdOrderDetails);
        }

        // DELETE: api/PrdOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdOrderDetails([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrderDetails = await _context.PrdOrderDetails.FindAsync(id);
            if (prdOrderDetails == null)
            {
                return NotFound();
            }

            _context.PrdOrderDetails.Remove(prdOrderDetails);
            await _context.SaveChangesAsync();

            return Ok(prdOrderDetails);
        }

        private bool PrdOrderDetailsExists(int id)
        {
            return _context.PrdOrderDetails.Any(e => e.OrderDetailsId == id);
        }
    }
}