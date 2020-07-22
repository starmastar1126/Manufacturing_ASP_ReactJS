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
    public class MstPaymentTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstPaymentTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstPaymentTypes
        [HttpGet]
        public IEnumerable<MstPaymentType> GetMstPaymentType()
        {
            return _context.MstPaymentType;
        }

        // GET: api/MstPaymentTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstPaymentType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPaymentType = await _context.MstPaymentType.FindAsync(id);

            if (mstPaymentType == null)
            {
                return NotFound();
            }

            return Ok(mstPaymentType);
        }

        // PUT: api/MstPaymentTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstPaymentType([FromRoute] int id, [FromBody] MstPaymentType mstPaymentType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstPaymentType.PaymentTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstPaymentType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstPaymentTypeExists(id))
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

        // POST: api/MstPaymentTypes
        [HttpPost]
        public async Task<IActionResult> PostMstPaymentType([FromBody] MstPaymentType mstPaymentType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstPaymentType.Add(mstPaymentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstPaymentType", new { id = mstPaymentType.PaymentTypeId }, mstPaymentType);
        }

        // DELETE: api/MstPaymentTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstPaymentType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPaymentType = await _context.MstPaymentType.FindAsync(id);
            if (mstPaymentType == null)
            {
                return NotFound();
            }

            _context.MstPaymentType.Remove(mstPaymentType);
            await _context.SaveChangesAsync();

            return Ok(mstPaymentType);
        }

        private bool MstPaymentTypeExists(int id)
        {
            return _context.MstPaymentType.Any(e => e.PaymentTypeId == id);
        }
    }
}