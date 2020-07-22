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
    public class MstCrmInvoicesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCrmInvoicesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCrmInvoices
        [HttpGet]
        public IEnumerable<MstCrmInvoice> GetMstCrmInvoice()
        {
            return _context.MstCrmInvoice;
        }

        // GET: api/MstCrmInvoices/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCrmInvoice([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmInvoice = await _context.MstCrmInvoice.FindAsync(id);

            if (mstCrmInvoice == null)
            {
                return NotFound();
            }

            return Ok(mstCrmInvoice);
        }

        // PUT: api/MstCrmInvoices/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCrmInvoice([FromRoute] int id, [FromBody] MstCrmInvoice mstCrmInvoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCrmInvoice.InvoiceId)
            {
                return BadRequest();
            }

            _context.Entry(mstCrmInvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCrmInvoiceExists(id))
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

        // POST: api/MstCrmInvoices
        [HttpPost]
        public async Task<IActionResult> PostMstCrmInvoice([FromBody] MstCrmInvoice mstCrmInvoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCrmInvoice.Add(mstCrmInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCrmInvoice", new { id = mstCrmInvoice.InvoiceId }, mstCrmInvoice);
        }

        // DELETE: api/MstCrmInvoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCrmInvoice([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmInvoice = await _context.MstCrmInvoice.FindAsync(id);
            if (mstCrmInvoice == null)
            {
                return NotFound();
            }

            _context.MstCrmInvoice.Remove(mstCrmInvoice);
            await _context.SaveChangesAsync();

            return Ok(mstCrmInvoice);
        }

        private bool MstCrmInvoiceExists(int id)
        {
            return _context.MstCrmInvoice.Any(e => e.InvoiceId == id);
        }
    }
}