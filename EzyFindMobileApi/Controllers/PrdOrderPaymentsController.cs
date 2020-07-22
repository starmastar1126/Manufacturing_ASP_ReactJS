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
    public class PrdOrderPaymentsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdOrderPaymentsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdOrderPayments
        [HttpGet]
        public IEnumerable<PrdOrderPayment> GetPrdOrderPayment()
        {
            return _context.PrdOrderPayment;
        }

        // GET: api/PrdOrderPayments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdOrderPayment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrderPayment = await _context.PrdOrderPayment.FindAsync(id);

            if (prdOrderPayment == null)
            {
                return NotFound();
            }

            return Ok(prdOrderPayment);
        }

        // PUT: api/PrdOrderPayments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdOrderPayment([FromRoute] int id, [FromBody] PrdOrderPayment prdOrderPayment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdOrderPayment.OrderPaymentId)
            {
                return BadRequest();
            }

            _context.Entry(prdOrderPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdOrderPaymentExists(id))
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

        // POST: api/PrdOrderPayments
        [HttpPost]
        public async Task<IActionResult> PostPrdOrderPayment([FromBody] PrdOrderPayment prdOrderPayment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdOrderPayment.Add(prdOrderPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdOrderPayment", new { id = prdOrderPayment.OrderPaymentId }, prdOrderPayment);
        }

        // DELETE: api/PrdOrderPayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdOrderPayment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdOrderPayment = await _context.PrdOrderPayment.FindAsync(id);
            if (prdOrderPayment == null)
            {
                return NotFound();
            }

            _context.PrdOrderPayment.Remove(prdOrderPayment);
            await _context.SaveChangesAsync();

            return Ok(prdOrderPayment);
        }

        private bool PrdOrderPaymentExists(int id)
        {
            return _context.PrdOrderPayment.Any(e => e.OrderPaymentId == id);
        }
    }
}