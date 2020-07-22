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
    public class MstCustomerEnquiryResponsesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCustomerEnquiryResponsesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCustomerEnquiryResponses
        [HttpGet]
        public IEnumerable<MstCustomerEnquiryResponse> GetMstCustomerEnquiryResponse()
        {
            return _context.MstCustomerEnquiryResponse;
        }

        // GET: api/MstCustomerEnquiryResponses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCustomerEnquiryResponse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCustomerEnquiryResponse = await _context.MstCustomerEnquiryResponse.FindAsync(id);

            if (mstCustomerEnquiryResponse == null)
            {
                return NotFound();
            }

            return Ok(mstCustomerEnquiryResponse);
        }

        // PUT: api/MstCustomerEnquiryResponses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCustomerEnquiryResponse([FromRoute] int id, [FromBody] MstCustomerEnquiryResponse mstCustomerEnquiryResponse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCustomerEnquiryResponse.CeresponseId)
            {
                return BadRequest();
            }

            _context.Entry(mstCustomerEnquiryResponse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCustomerEnquiryResponseExists(id))
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

        // POST: api/MstCustomerEnquiryResponses
        [HttpPost]
        public async Task<IActionResult> PostMstCustomerEnquiryResponse([FromBody] MstCustomerEnquiryResponse mstCustomerEnquiryResponse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCustomerEnquiryResponse.Add(mstCustomerEnquiryResponse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCustomerEnquiryResponse", new { id = mstCustomerEnquiryResponse.CeresponseId }, mstCustomerEnquiryResponse);
        }

        // DELETE: api/MstCustomerEnquiryResponses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCustomerEnquiryResponse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCustomerEnquiryResponse = await _context.MstCustomerEnquiryResponse.FindAsync(id);
            if (mstCustomerEnquiryResponse == null)
            {
                return NotFound();
            }

            _context.MstCustomerEnquiryResponse.Remove(mstCustomerEnquiryResponse);
            await _context.SaveChangesAsync();

            return Ok(mstCustomerEnquiryResponse);
        }

        private bool MstCustomerEnquiryResponseExists(int id)
        {
            return _context.MstCustomerEnquiryResponse.Any(e => e.CeresponseId == id);
        }
    }
}