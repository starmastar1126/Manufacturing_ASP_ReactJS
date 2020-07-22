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
    public class MstCategoryAttributesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCategoryAttributesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCategoryAttributes
        [HttpGet]
        public IEnumerable<MstCategoryAttribute> GetMstCategoryAttribute()
        {
            return _context.MstCategoryAttribute;
        }

        // GET: api/MstCategoryAttributes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCategoryAttribute([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCategoryAttribute = await _context.MstCategoryAttribute.FindAsync(id);

            if (mstCategoryAttribute == null)
            {
                return NotFound();
            }

            return Ok(mstCategoryAttribute);
        }

        // PUT: api/MstCategoryAttributes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCategoryAttribute([FromRoute] int id, [FromBody] MstCategoryAttribute mstCategoryAttribute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCategoryAttribute.CatAttributeId)
            {
                return BadRequest();
            }

            _context.Entry(mstCategoryAttribute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCategoryAttributeExists(id))
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

        // POST: api/MstCategoryAttributes
        [HttpPost]
        public async Task<IActionResult> PostMstCategoryAttribute([FromBody] MstCategoryAttribute mstCategoryAttribute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCategoryAttribute.Add(mstCategoryAttribute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCategoryAttribute", new { id = mstCategoryAttribute.CatAttributeId }, mstCategoryAttribute);
        }

        // DELETE: api/MstCategoryAttributes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCategoryAttribute([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCategoryAttribute = await _context.MstCategoryAttribute.FindAsync(id);
            if (mstCategoryAttribute == null)
            {
                return NotFound();
            }

            _context.MstCategoryAttribute.Remove(mstCategoryAttribute);
            await _context.SaveChangesAsync();

            return Ok(mstCategoryAttribute);
        }

        private bool MstCategoryAttributeExists(int id)
        {
            return _context.MstCategoryAttribute.Any(e => e.CatAttributeId == id);
        }
    }
}