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
    public class MstCrmInventoryTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCrmInventoryTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCrmInventoryTypes
        [HttpGet]
        public IEnumerable<MstCrmInventoryType> GetMstCrmInventoryType()
        {
            return _context.MstCrmInventoryType;
        }

        // GET: api/MstCrmInventoryTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCrmInventoryType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmInventoryType = await _context.MstCrmInventoryType.FindAsync(id);

            if (mstCrmInventoryType == null)
            {
                return NotFound();
            }

            return Ok(mstCrmInventoryType);
        }

        // PUT: api/MstCrmInventoryTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCrmInventoryType([FromRoute] int id, [FromBody] MstCrmInventoryType mstCrmInventoryType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCrmInventoryType.InventoryTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstCrmInventoryType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCrmInventoryTypeExists(id))
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

        // POST: api/MstCrmInventoryTypes
        [HttpPost]
        public async Task<IActionResult> PostMstCrmInventoryType([FromBody] MstCrmInventoryType mstCrmInventoryType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCrmInventoryType.Add(mstCrmInventoryType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCrmInventoryType", new { id = mstCrmInventoryType.InventoryTypeId }, mstCrmInventoryType);
        }

        // DELETE: api/MstCrmInventoryTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCrmInventoryType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmInventoryType = await _context.MstCrmInventoryType.FindAsync(id);
            if (mstCrmInventoryType == null)
            {
                return NotFound();
            }

            _context.MstCrmInventoryType.Remove(mstCrmInventoryType);
            await _context.SaveChangesAsync();

            return Ok(mstCrmInventoryType);
        }

        private bool MstCrmInventoryTypeExists(int id)
        {
            return _context.MstCrmInventoryType.Any(e => e.InventoryTypeId == id);
        }
    }
}