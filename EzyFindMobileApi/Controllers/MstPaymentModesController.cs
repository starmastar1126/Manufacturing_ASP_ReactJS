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
    public class MstPaymentModesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstPaymentModesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstPaymentModes
        [HttpGet]
        public IEnumerable<MstPaymentMode> GetMstPaymentMode()
        {
            return _context.MstPaymentMode;
        }

        // GET: api/MstPaymentModes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstPaymentMode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPaymentMode = await _context.MstPaymentMode.FindAsync(id);

            if (mstPaymentMode == null)
            {
                return NotFound();
            }

            return Ok(mstPaymentMode);
        }

        // PUT: api/MstPaymentModes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstPaymentMode([FromRoute] int id, [FromBody] MstPaymentMode mstPaymentMode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstPaymentMode.PaymentModeId)
            {
                return BadRequest();
            }

            _context.Entry(mstPaymentMode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstPaymentModeExists(id))
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

        // POST: api/MstPaymentModes
        [HttpPost]
        public async Task<IActionResult> PostMstPaymentMode([FromBody] MstPaymentMode mstPaymentMode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstPaymentMode.Add(mstPaymentMode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstPaymentMode", new { id = mstPaymentMode.PaymentModeId }, mstPaymentMode);
        }

        // DELETE: api/MstPaymentModes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstPaymentMode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPaymentMode = await _context.MstPaymentMode.FindAsync(id);
            if (mstPaymentMode == null)
            {
                return NotFound();
            }

            _context.MstPaymentMode.Remove(mstPaymentMode);
            await _context.SaveChangesAsync();

            return Ok(mstPaymentMode);
        }

        private bool MstPaymentModeExists(int id)
        {
            return _context.MstPaymentMode.Any(e => e.PaymentModeId == id);
        }
    }
}