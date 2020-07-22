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
    public class PrdSubCategoriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdSubCategoriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdSubCategories
        [HttpGet]
        public IEnumerable<PrdSubCategory> GetPrdSubCategory()
        {
            return _context.PrdSubCategory;
        }

        // GET: api/PrdSubCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdSubCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdSubCategory = await _context.PrdSubCategory.FindAsync(id);

            if (prdSubCategory == null)
            {
                return NotFound();
            }

            return Ok(prdSubCategory);
        }

        // PUT: api/PrdSubCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdSubCategory([FromRoute] int id, [FromBody] PrdSubCategory prdSubCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdSubCategory.SubCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(prdSubCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdSubCategoryExists(id))
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

        // POST: api/PrdSubCategories
        [HttpPost]
        public async Task<IActionResult> PostPrdSubCategory([FromBody] PrdSubCategory prdSubCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdSubCategory.Add(prdSubCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdSubCategory", new { id = prdSubCategory.SubCategoryId }, prdSubCategory);
        }

        // DELETE: api/PrdSubCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdSubCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdSubCategory = await _context.PrdSubCategory.FindAsync(id);
            if (prdSubCategory == null)
            {
                return NotFound();
            }

            _context.PrdSubCategory.Remove(prdSubCategory);
            await _context.SaveChangesAsync();

            return Ok(prdSubCategory);
        }

        private bool PrdSubCategoryExists(int id)
        {
            return _context.PrdSubCategory.Any(e => e.SubCategoryId == id);
        }
    }
}