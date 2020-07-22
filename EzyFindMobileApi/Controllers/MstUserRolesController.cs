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
    public class MstUserRolesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstUserRolesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstUserRoles
        [HttpGet]
        public IEnumerable<MstUserRole> GetMstUserRole()
        {
            return _context.MstUserRole;
        }

        // GET: api/MstUserRoles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstUserRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstUserRole = await _context.MstUserRole.FindAsync(id);

            if (mstUserRole == null)
            {
                return NotFound();
            }

            return Ok(mstUserRole);
        }

        // PUT: api/MstUserRoles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstUserRole([FromRoute] int id, [FromBody] MstUserRole mstUserRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstUserRole.RoleId)
            {
                return BadRequest();
            }

            _context.Entry(mstUserRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstUserRoleExists(id))
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

        // POST: api/MstUserRoles
        [HttpPost]
        public async Task<IActionResult> PostMstUserRole([FromBody] MstUserRole mstUserRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstUserRole.Add(mstUserRole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstUserRole", new { id = mstUserRole.RoleId }, mstUserRole);
        }

        // DELETE: api/MstUserRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstUserRole([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstUserRole = await _context.MstUserRole.FindAsync(id);
            if (mstUserRole == null)
            {
                return NotFound();
            }

            _context.MstUserRole.Remove(mstUserRole);
            await _context.SaveChangesAsync();

            return Ok(mstUserRole);
        }

        private bool MstUserRoleExists(int id)
        {
            return _context.MstUserRole.Any(e => e.RoleId == id);
        }
    }
}