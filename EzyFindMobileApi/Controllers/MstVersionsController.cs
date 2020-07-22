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
    public class MstVersionsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstVersionsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstVersions
        [HttpGet]
        public IEnumerable<MstVersion> GetMstVersion()
        {
            return _context.MstVersion;
        }

        // GET: api/MstVersions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstVersion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstVersion = await _context.MstVersion.FindAsync(id);

            if (mstVersion == null)
            {
                return NotFound();
            }

            return Ok(mstVersion);
        }

        // PUT: api/MstVersions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstVersion([FromRoute] int id, [FromBody] MstVersion mstVersion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstVersion.VersionId)
            {
                return BadRequest();
            }

            _context.Entry(mstVersion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstVersionExists(id))
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

        // POST: api/MstVersions
        [HttpPost]
        public async Task<IActionResult> PostMstVersion([FromBody] MstVersion mstVersion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstVersion.Add(mstVersion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MstVersionExists(mstVersion.VersionId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMstVersion", new { id = mstVersion.VersionId }, mstVersion);
        }

        // DELETE: api/MstVersions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstVersion([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstVersion = await _context.MstVersion.FindAsync(id);
            if (mstVersion == null)
            {
                return NotFound();
            }

            _context.MstVersion.Remove(mstVersion);
            await _context.SaveChangesAsync();

            return Ok(mstVersion);
        }

        private bool MstVersionExists(int id)
        {
            return _context.MstVersion.Any(e => e.VersionId == id);
        }
    }
}