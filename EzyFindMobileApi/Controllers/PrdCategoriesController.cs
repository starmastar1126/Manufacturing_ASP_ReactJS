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
    public class PrdCategoriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdCategoriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdCategories
        [HttpGet]
        public IEnumerable<PrdCategory> GetPrdCategory()
        {
            return _context.PrdCategory;
        }

        // GET: api/PrdCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdCategory = await _context.PrdCategory.FindAsync(id);

            if (prdCategory == null)
            {
                return NotFound();
            }

            return Ok(prdCategory);
        }

        // PUT: api/PrdCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdCategory([FromRoute] int id, [FromBody] PrdCategory prdCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdCategory.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(prdCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdCategoryExists(id))
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

        // POST: api/PrdCategories
        [HttpPost]
        public async Task<IActionResult> PostPrdCategory([FromBody] PrdCategory prdCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdCategory.Add(prdCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdCategory", new { id = prdCategory.CategoryId }, prdCategory);
        }

        // DELETE: api/PrdCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdCategory = await _context.PrdCategory.FindAsync(id);
            if (prdCategory == null)
            {
                return NotFound();
            }

            _context.PrdCategory.Remove(prdCategory);
            await _context.SaveChangesAsync();

            return Ok(prdCategory);
        }

        private bool PrdCategoryExists(int id)
        {
            return _context.PrdCategory.Any(e => e.CategoryId == id);
        }
    }
}