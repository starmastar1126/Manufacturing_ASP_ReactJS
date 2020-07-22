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
    public class MstFranchiseesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstFranchiseesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstFranchisees
        [HttpGet]
        public IEnumerable<MstFranchisee> GetMstFranchisee()
        {
            return _context.MstFranchisee;
        }

        // GET: api/MstFranchisees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstFranchisee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstFranchisee = await _context.MstFranchisee.FindAsync(id);

            if (mstFranchisee == null)
            {
                return NotFound();
            }

            return Ok(mstFranchisee);
        }

        // PUT: api/MstFranchisees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstFranchisee([FromRoute] int id, [FromBody] MstFranchisee mstFranchisee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstFranchisee.FranchiseId)
            {
                return BadRequest();
            }

            _context.Entry(mstFranchisee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstFranchiseeExists(id))
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

        // POST: api/MstFranchisees
        [HttpPost]
        public async Task<IActionResult> PostMstFranchisee([FromBody] MstFranchisee mstFranchisee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstFranchisee.Add(mstFranchisee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstFranchisee", new { id = mstFranchisee.FranchiseId }, mstFranchisee);
        }

        // DELETE: api/MstFranchisees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstFranchisee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstFranchisee = await _context.MstFranchisee.FindAsync(id);
            if (mstFranchisee == null)
            {
                return NotFound();
            }

            _context.MstFranchisee.Remove(mstFranchisee);
            await _context.SaveChangesAsync();

            return Ok(mstFranchisee);
        }

        private bool MstFranchiseeExists(int id)
        {
            return _context.MstFranchisee.Any(e => e.FranchiseId == id);
        }
    }
}