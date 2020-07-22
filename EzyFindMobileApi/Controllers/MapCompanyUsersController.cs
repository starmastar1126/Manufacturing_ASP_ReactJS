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
    public class MapCompanyUsersController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyUsersController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyUsers
        [HttpGet]
        public IEnumerable<MapCompanyUsers> GetMapCompanyUsers()
        {
            return _context.MapCompanyUsers;
        }

        // GET: api/MapCompanyUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyUsers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyUsers = await _context.MapCompanyUsers.FindAsync(id);

            if (mapCompanyUsers == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyUsers);
        }

        // PUT: api/MapCompanyUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyUsers([FromRoute] int id, [FromBody] MapCompanyUsers mapCompanyUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyUsers.CompanyUserId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyUsersExists(id))
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

        // POST: api/MapCompanyUsers
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyUsers([FromBody] MapCompanyUsers mapCompanyUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyUsers.Add(mapCompanyUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyUsers", new { id = mapCompanyUsers.CompanyUserId }, mapCompanyUsers);
        }

        // DELETE: api/MapCompanyUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyUsers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyUsers = await _context.MapCompanyUsers.FindAsync(id);
            if (mapCompanyUsers == null)
            {
                return NotFound();
            }

            _context.MapCompanyUsers.Remove(mapCompanyUsers);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyUsers);
        }

        private bool MapCompanyUsersExists(int id)
        {
            return _context.MapCompanyUsers.Any(e => e.CompanyUserId == id);
        }
    }
}