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
    public class MstDocumentStatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstDocumentStatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstDocumentStatus
        [HttpGet]
        public IEnumerable<MstDocumentStatus> GetMstDocumentStatus()
        {
            return _context.MstDocumentStatus;
        }

        // GET: api/MstDocumentStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstDocumentStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstDocumentStatus = await _context.MstDocumentStatus.FindAsync(id);

            if (mstDocumentStatus == null)
            {
                return NotFound();
            }

            return Ok(mstDocumentStatus);
        }

        // PUT: api/MstDocumentStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstDocumentStatus([FromRoute] int id, [FromBody] MstDocumentStatus mstDocumentStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstDocumentStatus.DocumentStatusId)
            {
                return BadRequest();
            }

            _context.Entry(mstDocumentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstDocumentStatusExists(id))
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

        // POST: api/MstDocumentStatus
        [HttpPost]
        public async Task<IActionResult> PostMstDocumentStatus([FromBody] MstDocumentStatus mstDocumentStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstDocumentStatus.Add(mstDocumentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstDocumentStatus", new { id = mstDocumentStatus.DocumentStatusId }, mstDocumentStatus);
        }

        // DELETE: api/MstDocumentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstDocumentStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstDocumentStatus = await _context.MstDocumentStatus.FindAsync(id);
            if (mstDocumentStatus == null)
            {
                return NotFound();
            }

            _context.MstDocumentStatus.Remove(mstDocumentStatus);
            await _context.SaveChangesAsync();

            return Ok(mstDocumentStatus);
        }

        private bool MstDocumentStatusExists(int id)
        {
            return _context.MstDocumentStatus.Any(e => e.DocumentStatusId == id);
        }
    }
}