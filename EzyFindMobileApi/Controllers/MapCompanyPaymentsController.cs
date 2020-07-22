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
    public class MapCompanyPaymentsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyPaymentsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyPayments
        [HttpGet]
        public IEnumerable<MapCompanyPayment> GetMapCompanyPayment()
        {
            return _context.MapCompanyPayment;
        }

        // GET: api/MapCompanyPayments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyPayment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyPayment = await _context.MapCompanyPayment.FindAsync(id);

            if (mapCompanyPayment == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyPayment);
        }

        // PUT: api/MapCompanyPayments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyPayment([FromRoute] int id, [FromBody] MapCompanyPayment mapCompanyPayment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyPayment.CompPaymentId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyPaymentExists(id))
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

        // POST: api/MapCompanyPayments
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyPayment([FromBody] MapCompanyPayment mapCompanyPayment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyPayment.Add(mapCompanyPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyPayment", new { id = mapCompanyPayment.CompPaymentId }, mapCompanyPayment);
        }

        // DELETE: api/MapCompanyPayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyPayment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyPayment = await _context.MapCompanyPayment.FindAsync(id);
            if (mapCompanyPayment == null)
            {
                return NotFound();
            }

            _context.MapCompanyPayment.Remove(mapCompanyPayment);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyPayment);
        }

        private bool MapCompanyPaymentExists(int id)
        {
            return _context.MapCompanyPayment.Any(e => e.CompPaymentId == id);
        }
    }
}