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
    public class MstPaymentStatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstPaymentStatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstPaymentStatus
        [HttpGet]
        public IEnumerable<MstPaymentStatus> GetMstPaymentStatus()
        {
            return _context.MstPaymentStatus;
        }

        // GET: api/MstPaymentStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstPaymentStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPaymentStatus = await _context.MstPaymentStatus.FindAsync(id);

            if (mstPaymentStatus == null)
            {
                return NotFound();
            }

            return Ok(mstPaymentStatus);
        }

        // PUT: api/MstPaymentStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstPaymentStatus([FromRoute] int id, [FromBody] MstPaymentStatus mstPaymentStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstPaymentStatus.PaymentStatusId)
            {
                return BadRequest();
            }

            _context.Entry(mstPaymentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstPaymentStatusExists(id))
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

        // POST: api/MstPaymentStatus
        [HttpPost]
        public async Task<IActionResult> PostMstPaymentStatus([FromBody] MstPaymentStatus mstPaymentStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstPaymentStatus.Add(mstPaymentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstPaymentStatus", new { id = mstPaymentStatus.PaymentStatusId }, mstPaymentStatus);
        }

        // DELETE: api/MstPaymentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstPaymentStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPaymentStatus = await _context.MstPaymentStatus.FindAsync(id);
            if (mstPaymentStatus == null)
            {
                return NotFound();
            }

            _context.MstPaymentStatus.Remove(mstPaymentStatus);
            await _context.SaveChangesAsync();

            return Ok(mstPaymentStatus);
        }

        private bool MstPaymentStatusExists(int id)
        {
            return _context.MstPaymentStatus.Any(e => e.PaymentStatusId == id);
        }
    }
}