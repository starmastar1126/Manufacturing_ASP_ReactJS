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
    public class MstStatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstStatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstStatus
        [HttpGet]
        public IEnumerable<MstStatus> GetMstStatus()
        {
            return _context.MstStatus;
        }

        // GET: api/MstStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstStatus = await _context.MstStatus.FindAsync(id);

            if (mstStatus == null)
            {
                return NotFound();
            }

            return Ok(mstStatus);
        }

        // PUT: api/MstStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstStatus([FromRoute] int id, [FromBody] MstStatus mstStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstStatus.StatusId)
            {
                return BadRequest();
            }

            _context.Entry(mstStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstStatusExists(id))
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

        // POST: api/MstStatus
        [HttpPost]
        public async Task<IActionResult> PostMstStatus([FromBody] MstStatus mstStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstStatus.Add(mstStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstStatus", new { id = mstStatus.StatusId }, mstStatus);
        }

        // DELETE: api/MstStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstStatus = await _context.MstStatus.FindAsync(id);
            if (mstStatus == null)
            {
                return NotFound();
            }

            _context.MstStatus.Remove(mstStatus);
            await _context.SaveChangesAsync();

            return Ok(mstStatus);
        }

        private bool MstStatusExists(int id)
        {
            return _context.MstStatus.Any(e => e.StatusId == id);
        }
    }
}