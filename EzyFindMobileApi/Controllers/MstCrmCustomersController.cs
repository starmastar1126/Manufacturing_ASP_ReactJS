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
    public class MstCrmCustomersController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCrmCustomersController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCrmCustomers
        [HttpGet]
        public IEnumerable<MstCrmCustomer> GetMstCrmCustomer()
        {
            return _context.MstCrmCustomer;
        }

        // GET: api/MstCrmCustomers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCrmCustomer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmCustomer = await _context.MstCrmCustomer.FindAsync(id);

            if (mstCrmCustomer == null)
            {
                return NotFound();
            }

            return Ok(mstCrmCustomer);
        }

        // PUT: api/MstCrmCustomers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCrmCustomer([FromRoute] int id, [FromBody] MstCrmCustomer mstCrmCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCrmCustomer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(mstCrmCustomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCrmCustomerExists(id))
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

        // POST: api/MstCrmCustomers
        [HttpPost]
        public async Task<IActionResult> PostMstCrmCustomer([FromBody] MstCrmCustomer mstCrmCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCrmCustomer.Add(mstCrmCustomer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCrmCustomer", new { id = mstCrmCustomer.CustomerId }, mstCrmCustomer);
        }

        // DELETE: api/MstCrmCustomers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCrmCustomer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmCustomer = await _context.MstCrmCustomer.FindAsync(id);
            if (mstCrmCustomer == null)
            {
                return NotFound();
            }

            _context.MstCrmCustomer.Remove(mstCrmCustomer);
            await _context.SaveChangesAsync();

            return Ok(mstCrmCustomer);
        }

        private bool MstCrmCustomerExists(int id)
        {
            return _context.MstCrmCustomer.Any(e => e.CustomerId == id);
        }
    }
}