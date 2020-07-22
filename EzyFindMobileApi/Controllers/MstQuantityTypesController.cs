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
    public class MstQuantityTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstQuantityTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstQuantityTypes
        [HttpGet]
        public IEnumerable<MstQuantityType> GetMstQuantityType()
        {
            return _context.MstQuantityType;
        }

        // GET: api/MstQuantityTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstQuantityType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstQuantityType = await _context.MstQuantityType.FindAsync(id);

            if (mstQuantityType == null)
            {
                return NotFound();
            }

            return Ok(mstQuantityType);
        }

        // PUT: api/MstQuantityTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstQuantityType([FromRoute] int id, [FromBody] MstQuantityType mstQuantityType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstQuantityType.QuantityTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstQuantityType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstQuantityTypeExists(id))
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

        // POST: api/MstQuantityTypes
        [HttpPost]
        public async Task<IActionResult> PostMstQuantityType([FromBody] MstQuantityType mstQuantityType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstQuantityType.Add(mstQuantityType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstQuantityType", new { id = mstQuantityType.QuantityTypeId }, mstQuantityType);
        }

        // DELETE: api/MstQuantityTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstQuantityType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstQuantityType = await _context.MstQuantityType.FindAsync(id);
            if (mstQuantityType == null)
            {
                return NotFound();
            }

            _context.MstQuantityType.Remove(mstQuantityType);
            await _context.SaveChangesAsync();

            return Ok(mstQuantityType);
        }

        private bool MstQuantityTypeExists(int id)
        {
            return _context.MstQuantityType.Any(e => e.QuantityTypeId == id);
        }
    }
}