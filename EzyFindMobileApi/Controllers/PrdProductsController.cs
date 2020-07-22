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
    public class PrdProductsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdProductsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdProducts
        [HttpGet]
        public IEnumerable<PrdProducts> GetPrdProducts()
        {
            return _context.PrdProducts;
        }

        // GET: api/PrdProducts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdProducts([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdProducts = await _context.PrdProducts.FindAsync(id);

            if (prdProducts == null)
            {
                return NotFound();
            }

            return Ok(prdProducts);
        }

        // PUT: api/PrdProducts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdProducts([FromRoute] int id, [FromBody] PrdProducts prdProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdProducts.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(prdProducts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdProductsExists(id))
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

        // POST: api/PrdProducts
        [HttpPost]
        public async Task<IActionResult> PostPrdProducts([FromBody] PrdProducts prdProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdProducts.Add(prdProducts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdProducts", new { id = prdProducts.ProductId }, prdProducts);
        }

        // DELETE: api/PrdProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdProducts([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdProducts = await _context.PrdProducts.FindAsync(id);
            if (prdProducts == null)
            {
                return NotFound();
            }

            _context.PrdProducts.Remove(prdProducts);
            await _context.SaveChangesAsync();

            return Ok(prdProducts);
        }

        private bool PrdProductsExists(int id)
        {
            return _context.PrdProducts.Any(e => e.ProductId == id);
        }
    }
}