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
    public class MapCompanyDocumentsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyDocumentsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyDocuments
        [HttpGet]
        public IEnumerable<MapCompanyDocument> GetMapCompanyDocument()
        {
            return _context.MapCompanyDocument;
        }

        // GET: api/MapCompanyDocuments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyDocument([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyDocument = await _context.MapCompanyDocument.FindAsync(id);

            if (mapCompanyDocument == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyDocument);
        }

        // PUT: api/MapCompanyDocuments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyDocument([FromRoute] int id, [FromBody] MapCompanyDocument mapCompanyDocument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyDocument.CompDocId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyDocumentExists(id))
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

        // POST: api/MapCompanyDocuments
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyDocument([FromBody] MapCompanyDocument mapCompanyDocument)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyDocument.Add(mapCompanyDocument);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyDocument", new { id = mapCompanyDocument.CompDocId }, mapCompanyDocument);
        }

        // DELETE: api/MapCompanyDocuments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyDocument([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyDocument = await _context.MapCompanyDocument.FindAsync(id);
            if (mapCompanyDocument == null)
            {
                return NotFound();
            }

            _context.MapCompanyDocument.Remove(mapCompanyDocument);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyDocument);
        }

        private bool MapCompanyDocumentExists(int id)
        {
            return _context.MapCompanyDocument.Any(e => e.CompDocId == id);
        }
    }
}