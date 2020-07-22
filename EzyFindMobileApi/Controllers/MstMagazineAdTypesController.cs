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
    public class MstMagazineAdTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstMagazineAdTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstMagazineAdTypes
        [HttpGet]
        public IEnumerable<MstMagazineAdType> GetMstMagazineAdType()
        {
            return _context.MstMagazineAdType;
        }

        // GET: api/MstMagazineAdTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstMagazineAdType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMagazineAdType = await _context.MstMagazineAdType.FindAsync(id);

            if (mstMagazineAdType == null)
            {
                return NotFound();
            }

            return Ok(mstMagazineAdType);
        }

        // PUT: api/MstMagazineAdTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstMagazineAdType([FromRoute] int id, [FromBody] MstMagazineAdType mstMagazineAdType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstMagazineAdType.MagazineAdTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstMagazineAdType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstMagazineAdTypeExists(id))
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

        // POST: api/MstMagazineAdTypes
        [HttpPost]
        public async Task<IActionResult> PostMstMagazineAdType([FromBody] MstMagazineAdType mstMagazineAdType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstMagazineAdType.Add(mstMagazineAdType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstMagazineAdType", new { id = mstMagazineAdType.MagazineAdTypeId }, mstMagazineAdType);
        }

        // DELETE: api/MstMagazineAdTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstMagazineAdType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstMagazineAdType = await _context.MstMagazineAdType.FindAsync(id);
            if (mstMagazineAdType == null)
            {
                return NotFound();
            }

            _context.MstMagazineAdType.Remove(mstMagazineAdType);
            await _context.SaveChangesAsync();

            return Ok(mstMagazineAdType);
        }

        private bool MstMagazineAdTypeExists(int id)
        {
            return _context.MstMagazineAdType.Any(e => e.MagazineAdTypeId == id);
        }
    }
}