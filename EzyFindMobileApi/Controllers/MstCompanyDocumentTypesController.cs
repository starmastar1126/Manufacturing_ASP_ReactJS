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
    public class MstCompanyDocumentTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCompanyDocumentTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCompanyDocumentTypes
        [HttpGet]
        public IEnumerable<MstCompanyDocumentType> GetMstCompanyDocumentType()
        {
            return _context.MstCompanyDocumentType;
        }

        // GET: api/MstCompanyDocumentTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCompanyDocumentType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompanyDocumentType = await _context.MstCompanyDocumentType.FindAsync(id);

            if (mstCompanyDocumentType == null)
            {
                return NotFound();
            }

            return Ok(mstCompanyDocumentType);
        }

        // PUT: api/MstCompanyDocumentTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCompanyDocumentType([FromRoute] int id, [FromBody] MstCompanyDocumentType mstCompanyDocumentType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCompanyDocumentType.DocumentTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstCompanyDocumentType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCompanyDocumentTypeExists(id))
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

        // POST: api/MstCompanyDocumentTypes
        [HttpPost]
        public async Task<IActionResult> PostMstCompanyDocumentType([FromBody] MstCompanyDocumentType mstCompanyDocumentType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCompanyDocumentType.Add(mstCompanyDocumentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCompanyDocumentType", new { id = mstCompanyDocumentType.DocumentTypeId }, mstCompanyDocumentType);
        }

        // DELETE: api/MstCompanyDocumentTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCompanyDocumentType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompanyDocumentType = await _context.MstCompanyDocumentType.FindAsync(id);
            if (mstCompanyDocumentType == null)
            {
                return NotFound();
            }

            _context.MstCompanyDocumentType.Remove(mstCompanyDocumentType);
            await _context.SaveChangesAsync();

            return Ok(mstCompanyDocumentType);
        }

        private bool MstCompanyDocumentTypeExists(int id)
        {
            return _context.MstCompanyDocumentType.Any(e => e.DocumentTypeId == id);
        }
    }
}