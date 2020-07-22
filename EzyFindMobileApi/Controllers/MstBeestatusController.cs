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
    public class MstBeestatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstBeestatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstBeestatus
        [HttpGet]
        public IEnumerable<MstBeestatus> GetMstBeestatus()
        {
            return _context.MstBeestatus;
        }

        // GET: api/MstBeestatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstBeestatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstBeestatus = await _context.MstBeestatus.FindAsync(id);

            if (mstBeestatus == null)
            {
                return NotFound();
            }

            return Ok(mstBeestatus);
        }

        // PUT: api/MstBeestatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstBeestatus([FromRoute] int id, [FromBody] MstBeestatus mstBeestatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstBeestatus.BeestatusId)
            {
                return BadRequest();
            }

            _context.Entry(mstBeestatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstBeestatusExists(id))
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

        // POST: api/MstBeestatus
        [HttpPost]
        public async Task<IActionResult> PostMstBeestatus([FromBody] MstBeestatus mstBeestatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstBeestatus.Add(mstBeestatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstBeestatus", new { id = mstBeestatus.BeestatusId }, mstBeestatus);
        }

        // DELETE: api/MstBeestatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstBeestatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstBeestatus = await _context.MstBeestatus.FindAsync(id);
            if (mstBeestatus == null)
            {
                return NotFound();
            }

            _context.MstBeestatus.Remove(mstBeestatus);
            await _context.SaveChangesAsync();

            return Ok(mstBeestatus);
        }

        private bool MstBeestatusExists(int id)
        {
            return _context.MstBeestatus.Any(e => e.BeestatusId == id);
        }
    }
}