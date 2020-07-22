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
    public class MstCmsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCmsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCms
        [HttpGet]
        public IEnumerable<MstCms> GetMstCms()
        {
            return _context.MstCms;
        }

        // GET: api/MstCms/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCms([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCms = await _context.MstCms.FindAsync(id);

            if (mstCms == null)
            {
                return NotFound();
            }

            return Ok(mstCms);
        }

        // PUT: api/MstCms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCms([FromRoute] int id, [FromBody] MstCms mstCms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCms.Cmsid)
            {
                return BadRequest();
            }

            _context.Entry(mstCms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCmsExists(id))
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

        // POST: api/MstCms
        [HttpPost]
        public async Task<IActionResult> PostMstCms([FromBody] MstCms mstCms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCms.Add(mstCms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCms", new { id = mstCms.Cmsid }, mstCms);
        }

        // DELETE: api/MstCms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCms([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCms = await _context.MstCms.FindAsync(id);
            if (mstCms == null)
            {
                return NotFound();
            }

            _context.MstCms.Remove(mstCms);
            await _context.SaveChangesAsync();

            return Ok(mstCms);
        }

        private bool MstCmsExists(int id)
        {
            return _context.MstCms.Any(e => e.Cmsid == id);
        }
    }
}