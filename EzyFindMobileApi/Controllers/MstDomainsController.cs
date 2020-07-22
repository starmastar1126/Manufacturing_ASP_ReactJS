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
    public class MstDomainsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstDomainsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstDomains
        [HttpGet]
        public IEnumerable<MstDomain> GetMstDomain()
        {
            return _context.MstDomain;
        }

        // GET: api/MstDomains/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstDomain([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstDomain = await _context.MstDomain.FindAsync(id);

            if (mstDomain == null)
            {
                return NotFound();
            }

            return Ok(mstDomain);
        }

        // PUT: api/MstDomains/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstDomain([FromRoute] int id, [FromBody] MstDomain mstDomain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstDomain.DomainId)
            {
                return BadRequest();
            }

            _context.Entry(mstDomain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstDomainExists(id))
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

        // POST: api/MstDomains
        [HttpPost]
        public async Task<IActionResult> PostMstDomain([FromBody] MstDomain mstDomain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstDomain.Add(mstDomain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstDomain", new { id = mstDomain.DomainId }, mstDomain);
        }

        // DELETE: api/MstDomains/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstDomain([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstDomain = await _context.MstDomain.FindAsync(id);
            if (mstDomain == null)
            {
                return NotFound();
            }

            _context.MstDomain.Remove(mstDomain);
            await _context.SaveChangesAsync();

            return Ok(mstDomain);
        }

        private bool MstDomainExists(int id)
        {
            return _context.MstDomain.Any(e => e.DomainId == id);
        }
    }
}