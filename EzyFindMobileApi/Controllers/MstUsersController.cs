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
    public class MstUsersController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstUsersController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstUsers
        [HttpGet]
        public IEnumerable<MstUsers> GetMstUsers()
        {
            return _context.MstUsers;
        }

        // GET: api/MstUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstUsers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstUsers = await _context.MstUsers.FindAsync(id);

            if (mstUsers == null)
            {
                return NotFound();
            }

            return Ok(mstUsers);
        }

        // PUT: api/MstUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstUsers([FromRoute] int id, [FromBody] MstUsers mstUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstUsers.UserId)
            {
                return BadRequest();
            }

            _context.Entry(mstUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstUsersExists(id))
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

        // POST: api/MstUsers
        [HttpPost]
        public async Task<IActionResult> PostMstUsers([FromBody] MstUsers mstUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstUsers.Add(mstUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstUsers", new { id = mstUsers.UserId }, mstUsers);
        }

        // DELETE: api/MstUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstUsers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstUsers = await _context.MstUsers.FindAsync(id);
            if (mstUsers == null)
            {
                return NotFound();
            }

            _context.MstUsers.Remove(mstUsers);
            await _context.SaveChangesAsync();

            return Ok(mstUsers);
        }

        private bool MstUsersExists(int id)
        {
            return _context.MstUsers.Any(e => e.UserId == id);
        }
    }
}