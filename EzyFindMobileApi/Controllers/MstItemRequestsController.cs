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
    public class MstItemRequestsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstItemRequestsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstItemRequests
        [HttpGet]
        public IEnumerable<MstItemRequest> GetMstItemRequest()
        {
            return _context.MstItemRequest;
        }

        // GET: api/MstItemRequests/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstItemRequest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstItemRequest = await _context.MstItemRequest.FindAsync(id);

            if (mstItemRequest == null)
            {
                return NotFound();
            }

            return Ok(mstItemRequest);
        }

        // PUT: api/MstItemRequests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstItemRequest([FromRoute] int id, [FromBody] MstItemRequest mstItemRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstItemRequest.ItemRequestId)
            {
                return BadRequest();
            }

            _context.Entry(mstItemRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstItemRequestExists(id))
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

        // POST: api/MstItemRequests
        [HttpPost]
        public async Task<IActionResult> PostMstItemRequest([FromBody] MstItemRequest mstItemRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstItemRequest.Add(mstItemRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstItemRequest", new { id = mstItemRequest.ItemRequestId }, mstItemRequest);
        }

        // DELETE: api/MstItemRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstItemRequest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstItemRequest = await _context.MstItemRequest.FindAsync(id);
            if (mstItemRequest == null)
            {
                return NotFound();
            }

            _context.MstItemRequest.Remove(mstItemRequest);
            await _context.SaveChangesAsync();

            return Ok(mstItemRequest);
        }

        private bool MstItemRequestExists(int id)
        {
            return _context.MstItemRequest.Any(e => e.ItemRequestId == id);
        }
    }
}