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
    public class MstItemResponsesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstItemResponsesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstItemResponses
        [HttpGet]
        public IEnumerable<MstItemResponse> GetMstItemResponse()
        {
            return _context.MstItemResponse;
        }

        // GET: api/MstItemResponses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstItemResponse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstItemResponse = await _context.MstItemResponse.FindAsync(id);

            if (mstItemResponse == null)
            {
                return NotFound();
            }

            return Ok(mstItemResponse);
        }

        // PUT: api/MstItemResponses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstItemResponse([FromRoute] int id, [FromBody] MstItemResponse mstItemResponse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstItemResponse.ItemResponseId)
            {
                return BadRequest();
            }

            _context.Entry(mstItemResponse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstItemResponseExists(id))
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

        // POST: api/MstItemResponses
        [HttpPost]
        public async Task<IActionResult> PostMstItemResponse([FromBody] MstItemResponse mstItemResponse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstItemResponse.Add(mstItemResponse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstItemResponse", new { id = mstItemResponse.ItemResponseId }, mstItemResponse);
        }

        // DELETE: api/MstItemResponses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstItemResponse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstItemResponse = await _context.MstItemResponse.FindAsync(id);
            if (mstItemResponse == null)
            {
                return NotFound();
            }

            _context.MstItemResponse.Remove(mstItemResponse);
            await _context.SaveChangesAsync();

            return Ok(mstItemResponse);
        }

        private bool MstItemResponseExists(int id)
        {
            return _context.MstItemResponse.Any(e => e.ItemResponseId == id);
        }
    }
}