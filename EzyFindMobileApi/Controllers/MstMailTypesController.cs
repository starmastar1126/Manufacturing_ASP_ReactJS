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
    public class MstMailTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstMailTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstMailTypes
        [HttpGet]
        public IEnumerable<MstMailType> GetMstMailType()
        {
            return _context.MstMailType;
        }

        // GET: api/MstMailTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstMailType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMailType = await _context.MstMailType.FindAsync(id);

            if (mstMailType == null)
            {
                return NotFound();
            }

            return Ok(mstMailType);
        }

        // PUT: api/MstMailTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstMailType([FromRoute] int id, [FromBody] MstMailType mstMailType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstMailType.MailTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstMailType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstMailTypeExists(id))
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

        // POST: api/MstMailTypes
        [HttpPost]
        public async Task<IActionResult> PostMstMailType([FromBody] MstMailType mstMailType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstMailType.Add(mstMailType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MstMailTypeExists(mstMailType.MailTypeId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMstMailType", new { id = mstMailType.MailTypeId }, mstMailType);
        }

        // DELETE: api/MstMailTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstMailType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMailType = await _context.MstMailType.FindAsync(id);
            if (mstMailType == null)
            {
                return NotFound();
            }

            _context.MstMailType.Remove(mstMailType);
            await _context.SaveChangesAsync();

            return Ok(mstMailType);
        }

        private bool MstMailTypeExists(int id)
        {
            return _context.MstMailType.Any(e => e.MailTypeId == id);
        }
    }
}