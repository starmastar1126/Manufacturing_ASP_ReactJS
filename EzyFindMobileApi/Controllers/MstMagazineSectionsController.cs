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
    public class MstMagazineSectionsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstMagazineSectionsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstMagazineSections
        [HttpGet]
        public IEnumerable<MstMagazineSection> GetMstMagazineSection()
        {
            return _context.MstMagazineSection;
        }

        // GET: api/MstMagazineSections/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstMagazineSection([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMagazineSection = await _context.MstMagazineSection.FindAsync(id);

            if (mstMagazineSection == null)
            {
                return NotFound();
            }

            return Ok(mstMagazineSection);
        }

        // PUT: api/MstMagazineSections/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstMagazineSection([FromRoute] int id, [FromBody] MstMagazineSection mstMagazineSection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstMagazineSection.MagazineSectionId)
            {
                return BadRequest();
            }

            _context.Entry(mstMagazineSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstMagazineSectionExists(id))
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

        // POST: api/MstMagazineSections
        [HttpPost]
        public async Task<IActionResult> PostMstMagazineSection([FromBody] MstMagazineSection mstMagazineSection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstMagazineSection.Add(mstMagazineSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstMagazineSection", new { id = mstMagazineSection.MagazineSectionId }, mstMagazineSection);
        }

        // DELETE: api/MstMagazineSections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstMagazineSection([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMagazineSection = await _context.MstMagazineSection.FindAsync(id);
            if (mstMagazineSection == null)
            {
                return NotFound();
            }

            _context.MstMagazineSection.Remove(mstMagazineSection);
            await _context.SaveChangesAsync();

            return Ok(mstMagazineSection);
        }

        private bool MstMagazineSectionExists(int id)
        {
            return _context.MstMagazineSection.Any(e => e.MagazineSectionId == id);
        }
    }
}