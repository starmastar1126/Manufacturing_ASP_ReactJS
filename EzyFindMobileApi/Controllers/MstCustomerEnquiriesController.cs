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
    public class MstCustomerEnquiriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCustomerEnquiriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCustomerEnquiries
        [HttpGet]
        public IEnumerable<MstCustomerEnquiry> GetMstCustomerEnquiry()
        {
            return _context.MstCustomerEnquiry;
        }

        // GET: api/MstCustomerEnquiries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCustomerEnquiry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCustomerEnquiry = await _context.MstCustomerEnquiry.FindAsync(id);

            if (mstCustomerEnquiry == null)
            {
                return NotFound();
            }

            return Ok(mstCustomerEnquiry);
        }

        // PUT: api/MstCustomerEnquiries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCustomerEnquiry([FromRoute] int id, [FromBody] MstCustomerEnquiry mstCustomerEnquiry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCustomerEnquiry.CustomerEnquiryId)
            {
                return BadRequest();
            }

            _context.Entry(mstCustomerEnquiry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCustomerEnquiryExists(id))
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

        // POST: api/MstCustomerEnquiries
        [HttpPost]
        public async Task<IActionResult> PostMstCustomerEnquiry([FromBody] MstCustomerEnquiry mstCustomerEnquiry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCustomerEnquiry.Add(mstCustomerEnquiry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCustomerEnquiry", new { id = mstCustomerEnquiry.CustomerEnquiryId }, mstCustomerEnquiry);
        }

        // DELETE: api/MstCustomerEnquiries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCustomerEnquiry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCustomerEnquiry = await _context.MstCustomerEnquiry.FindAsync(id);
            if (mstCustomerEnquiry == null)
            {
                return NotFound();
            }

            _context.MstCustomerEnquiry.Remove(mstCustomerEnquiry);
            await _context.SaveChangesAsync();

            return Ok(mstCustomerEnquiry);
        }

        private bool MstCustomerEnquiryExists(int id)
        {
            return _context.MstCustomerEnquiry.Any(e => e.CustomerEnquiryId == id);
        }
    }
}