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
    public class MapCustomerEnquiryUploadsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCustomerEnquiryUploadsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCustomerEnquiryUploads
        [HttpGet]
        public IEnumerable<MapCustomerEnquiryUpload> GetMapCustomerEnquiryUpload()
        {
            return _context.MapCustomerEnquiryUpload;
        }

        // GET: api/MapCustomerEnquiryUploads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCustomerEnquiryUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCustomerEnquiryUpload = await _context.MapCustomerEnquiryUpload.FindAsync(id);

            if (mapCustomerEnquiryUpload == null)
            {
                return NotFound();
            }

            return Ok(mapCustomerEnquiryUpload);
        }

        // PUT: api/MapCustomerEnquiryUploads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCustomerEnquiryUpload([FromRoute] int id, [FromBody] MapCustomerEnquiryUpload mapCustomerEnquiryUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCustomerEnquiryUpload.CeUploadId)
            {
                return BadRequest();
            }

            _context.Entry(mapCustomerEnquiryUpload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCustomerEnquiryUploadExists(id))
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

        // POST: api/MapCustomerEnquiryUploads
        [HttpPost]
        public async Task<IActionResult> PostMapCustomerEnquiryUpload([FromBody] MapCustomerEnquiryUpload mapCustomerEnquiryUpload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCustomerEnquiryUpload.Add(mapCustomerEnquiryUpload);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCustomerEnquiryUpload", new { id = mapCustomerEnquiryUpload.CeUploadId }, mapCustomerEnquiryUpload);
        }

        // DELETE: api/MapCustomerEnquiryUploads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCustomerEnquiryUpload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCustomerEnquiryUpload = await _context.MapCustomerEnquiryUpload.FindAsync(id);
            if (mapCustomerEnquiryUpload == null)
            {
                return NotFound();
            }

            _context.MapCustomerEnquiryUpload.Remove(mapCustomerEnquiryUpload);
            await _context.SaveChangesAsync();

            return Ok(mapCustomerEnquiryUpload);
        }

        private bool MapCustomerEnquiryUploadExists(int id)
        {
            return _context.MapCustomerEnquiryUpload.Any(e => e.CeUploadId == id);
        }
    }
}