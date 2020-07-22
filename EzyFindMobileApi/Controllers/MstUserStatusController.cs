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
    public class MstUserStatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstUserStatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstUserStatus
        [HttpGet]
        public IEnumerable<MstUserStatus> GetMstUserStatus()
        {
            return _context.MstUserStatus;
        }

        // GET: api/MstUserStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstUserStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstUserStatus = await _context.MstUserStatus.FindAsync(id);

            if (mstUserStatus == null)
            {
                return NotFound();
            }

            return Ok(mstUserStatus);
        }

        // PUT: api/MstUserStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstUserStatus([FromRoute] int id, [FromBody] MstUserStatus mstUserStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstUserStatus.StatusId)
            {
                return BadRequest();
            }

            _context.Entry(mstUserStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstUserStatusExists(id))
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

        // POST: api/MstUserStatus
        [HttpPost]
        public async Task<IActionResult> PostMstUserStatus([FromBody] MstUserStatus mstUserStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstUserStatus.Add(mstUserStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstUserStatus", new { id = mstUserStatus.StatusId }, mstUserStatus);
        }

        // DELETE: api/MstUserStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstUserStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstUserStatus = await _context.MstUserStatus.FindAsync(id);
            if (mstUserStatus == null)
            {
                return NotFound();
            }

            _context.MstUserStatus.Remove(mstUserStatus);
            await _context.SaveChangesAsync();

            return Ok(mstUserStatus);
        }

        private bool MstUserStatusExists(int id)
        {
            return _context.MstUserStatus.Any(e => e.StatusId == id);
        }
    }
}