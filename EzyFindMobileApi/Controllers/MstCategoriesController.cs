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
    public class MstCategoriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCategoriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCategories
        [HttpGet]
        public IEnumerable<MstCategory> GetMstCategory()
        {
            return _context.MstCategory;
        }

        // GET: api/MstCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCategory = await _context.MstCategory.FindAsync(id);

            if (mstCategory == null)
            {
                return NotFound();
            }

            return Ok(mstCategory);
        }

        // PUT: api/MstCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCategory([FromRoute] int id, [FromBody] MstCategory mstCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCategory.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(mstCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCategoryExists(id))
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

        // POST: api/MstCategories
        [HttpPost]
        public async Task<IActionResult> PostMstCategory([FromBody] MstCategory mstCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCategory.Add(mstCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCategory", new { id = mstCategory.CategoryId }, mstCategory);
        }

        // DELETE: api/MstCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCategory = await _context.MstCategory.FindAsync(id);
            if (mstCategory == null)
            {
                return NotFound();
            }

            _context.MstCategory.Remove(mstCategory);
            await _context.SaveChangesAsync();

            return Ok(mstCategory);
        }

        private bool MstCategoryExists(int id)
        {
            return _context.MstCategory.Any(e => e.CategoryId == id);
        }
    }
}