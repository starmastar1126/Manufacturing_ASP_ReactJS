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
    public class MapCompanyEmailsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyEmailsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyEmails
        [HttpGet]
        public IEnumerable<MapCompanyEmail> GetMapCompanyEmail()
        {
            return _context.MapCompanyEmail;
        }

        // GET: api/MapCompanyEmails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyEmail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyEmail = await _context.MapCompanyEmail.FindAsync(id);

            if (mapCompanyEmail == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyEmail);
        }

        // PUT: api/MapCompanyEmails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyEmail([FromRoute] int id, [FromBody] MapCompanyEmail mapCompanyEmail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyEmail.CompMailId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyEmail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyEmailExists(id))
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

        // POST: api/MapCompanyEmails
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyEmail([FromBody] MapCompanyEmail mapCompanyEmail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyEmail.Add(mapCompanyEmail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyEmail", new { id = mapCompanyEmail.CompMailId }, mapCompanyEmail);
        }

        // DELETE: api/MapCompanyEmails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyEmail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyEmail = await _context.MapCompanyEmail.FindAsync(id);
            if (mapCompanyEmail == null)
            {
                return NotFound();
            }

            _context.MapCompanyEmail.Remove(mapCompanyEmail);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyEmail);
        }

        private bool MapCompanyEmailExists(int id)
        {
            return _context.MapCompanyEmail.Any(e => e.CompMailId == id);
        }
    }
}