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
    public class PrdOrderStatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdOrderStatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdOrderStatus
        [HttpGet]
        public IEnumerable<PrdOrderStatus> GetPrdOrderStatus()
        {
            return _context.PrdOrderStatus;
        }

        // GET: api/PrdOrderStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdOrderStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrderStatus = await _context.PrdOrderStatus.FindAsync(id);

            if (prdOrderStatus == null)
            {
                return NotFound();
            }

            return Ok(prdOrderStatus);
        }

        // PUT: api/PrdOrderStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdOrderStatus([FromRoute] int id, [FromBody] PrdOrderStatus prdOrderStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdOrderStatus.OrderStatusId)
            {
                return BadRequest();
            }

            _context.Entry(prdOrderStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdOrderStatusExists(id))
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

        // POST: api/PrdOrderStatus
        [HttpPost]
        public async Task<IActionResult> PostPrdOrderStatus([FromBody] PrdOrderStatus prdOrderStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdOrderStatus.Add(prdOrderStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdOrderStatus", new { id = prdOrderStatus.OrderStatusId }, prdOrderStatus);
        }

        // DELETE: api/PrdOrderStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdOrderStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrderStatus = await _context.PrdOrderStatus.FindAsync(id);
            if (prdOrderStatus == null)
            {
                return NotFound();
            }

            _context.PrdOrderStatus.Remove(prdOrderStatus);
            await _context.SaveChangesAsync();

            return Ok(prdOrderStatus);
        }

        private bool PrdOrderStatusExists(int id)
        {
            return _context.PrdOrderStatus.Any(e => e.OrderStatusId == id);
        }
    }
}