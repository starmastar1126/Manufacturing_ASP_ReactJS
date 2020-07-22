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
    public class PrdShoppingCartsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PrdShoppingCartsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PrdShoppingCarts
        [HttpGet]
        public IEnumerable<PrdShoppingCart> GetPrdShoppingCart()
        {
            return _context.PrdShoppingCart;
        }

        // GET: api/PrdShoppingCarts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrdShoppingCart([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdShoppingCart = await _context.PrdShoppingCart.FindAsync(id);

            if (prdShoppingCart == null)
            {
                return NotFound();
            }

            return Ok(prdShoppingCart);
        }

        // PUT: api/PrdShoppingCarts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrdShoppingCart([FromRoute] int id, [FromBody] PrdShoppingCart prdShoppingCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prdShoppingCart.RecordId)
            {
                return BadRequest();
            }

            _context.Entry(prdShoppingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrdShoppingCartExists(id))
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

        // POST: api/PrdShoppingCarts
        [HttpPost]
        public async Task<IActionResult> PostPrdShoppingCart([FromBody] PrdShoppingCart prdShoppingCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PrdShoppingCart.Add(prdShoppingCart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdShoppingCart", new { id = prdShoppingCart.RecordId }, prdShoppingCart);
        }

        // DELETE: api/PrdShoppingCarts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrdShoppingCart([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prdShoppingCart = await _context.PrdShoppingCart.FindAsync(id);
            if (prdShoppingCart == null)
            {
                return NotFound();
            }

            _context.PrdShoppingCart.Remove(prdShoppingCart);
            await _context.SaveChangesAsync();

            return Ok(prdShoppingCart);
        }

        private bool PrdShoppingCartExists(int id)
        {
            return _context.PrdShoppingCart.Any(e => e.RecordId == id);
        }
    }
}