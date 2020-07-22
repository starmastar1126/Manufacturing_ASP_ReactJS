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
    public class MstCrmInventoriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCrmInventoriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCrmInventories
        [HttpGet]
        public IEnumerable<MstCrmInventory> GetMstCrmInventory()
        {
            return _context.MstCrmInventory;
        }

        // GET: api/MstCrmInventories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCrmInventory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmInventory = await _context.MstCrmInventory.FindAsync(id);

            if (mstCrmInventory == null)
            {
                return NotFound();
            }

            return Ok(mstCrmInventory);
        }

        // PUT: api/MstCrmInventories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCrmInventory([FromRoute] int id, [FromBody] MstCrmInventory mstCrmInventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCrmInventory.InventoryId)
            {
                return BadRequest();
            }

            _context.Entry(mstCrmInventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCrmInventoryExists(id))
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

        // POST: api/MstCrmInventories
        [HttpPost]
        public async Task<IActionResult> PostMstCrmInventory([FromBody] MstCrmInventory mstCrmInventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCrmInventory.Add(mstCrmInventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCrmInventory", new { id = mstCrmInventory.InventoryId }, mstCrmInventory);
        }

        // DELETE: api/MstCrmInventories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCrmInventory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmInventory = await _context.MstCrmInventory.FindAsync(id);
            if (mstCrmInventory == null)
            {
                return NotFound();
            }

            _context.MstCrmInventory.Remove(mstCrmInventory);
            await _context.SaveChangesAsync();

            return Ok(mstCrmInventory);
        }

        private bool MstCrmInventoryExists(int id)
        {
            return _context.MstCrmInventory.Any(e => e.InventoryId == id);
        }
    }
}