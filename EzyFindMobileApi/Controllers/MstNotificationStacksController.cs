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
    public class MstNotificationStacksController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstNotificationStacksController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstNotificationStacks
        [HttpGet]
        public IEnumerable<MstNotificationStack> GetMstNotificationStack()
        {
            return _context.MstNotificationStack;
        }

        // GET: api/MstNotificationStacks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstNotificationStack([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstNotificationStack = await _context.MstNotificationStack.FindAsync(id);

            if (mstNotificationStack == null)
            {
                return NotFound();
            }

            return Ok(mstNotificationStack);
        }

        // PUT: api/MstNotificationStacks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstNotificationStack([FromRoute] long id, [FromBody] MstNotificationStack mstNotificationStack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstNotificationStack.NotificationId)
            {
                return BadRequest();
            }

            _context.Entry(mstNotificationStack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstNotificationStackExists(id))
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

        // POST: api/MstNotificationStacks
        [HttpPost]
        public async Task<IActionResult> PostMstNotificationStack([FromBody] MstNotificationStack mstNotificationStack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstNotificationStack.Add(mstNotificationStack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstNotificationStack", new { id = mstNotificationStack.NotificationId }, mstNotificationStack);
        }

        // DELETE: api/MstNotificationStacks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstNotificationStack([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstNotificationStack = await _context.MstNotificationStack.FindAsync(id);
            if (mstNotificationStack == null)
            {
                return NotFound();
            }

            _context.MstNotificationStack.Remove(mstNotificationStack);
            await _context.SaveChangesAsync();

            return Ok(mstNotificationStack);
        }

        private bool MstNotificationStackExists(long id)
        {
            return _context.MstNotificationStack.Any(e => e.NotificationId == id);
        }
    }
}