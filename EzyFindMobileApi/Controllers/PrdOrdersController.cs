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
    public class PrdOrdersController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdOrdersController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdOrders
        [HttpGet]
        public IEnumerable<PrdOrders> GetPrdOrders()
        {
            return _context.PrdOrders;
        }

        // GET: api/PrdOrders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdOrders([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrders = await _context.PrdOrders.FindAsync(id);

            if (prdOrders == null)
            {
                return NotFound();
            }

            return Ok(prdOrders);
        }

        // PUT: api/PrdOrders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdOrders([FromRoute] int id, [FromBody] PrdOrders prdOrders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdOrders.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(prdOrders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdOrdersExists(id))
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

        // POST: api/PrdOrders
        [HttpPost]
        public async Task<IActionResult> PostPrdOrders([FromBody] PrdOrders prdOrders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdOrders.Add(prdOrders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdOrders", new { id = prdOrders.OrderId }, prdOrders);
        }

        // DELETE: api/PrdOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdOrders([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrders = await _context.PrdOrders.FindAsync(id);
            if (prdOrders == null)
            {
                return NotFound();
            }

            _context.PrdOrders.Remove(prdOrders);
            await _context.SaveChangesAsync();

            return Ok(prdOrders);
        }

        private bool PrdOrdersExists(int id)
        {
            return _context.PrdOrders.Any(e => e.OrderId == id);
        }
    }
}