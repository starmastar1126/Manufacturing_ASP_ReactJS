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
    public class MstVolumeTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstVolumeTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstVolumeTypes
        [HttpGet]
        public IEnumerable<MstVolumeType> GetMstVolumeType()
        {
            return _context.MstVolumeType;
        }

        // GET: api/MstVolumeTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstVolumeType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstVolumeType = await _context.MstVolumeType.FindAsync(id);

            if (mstVolumeType == null)
            {
                return NotFound();
            }

            return Ok(mstVolumeType);
        }

        // PUT: api/MstVolumeTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstVolumeType([FromRoute] int id, [FromBody] MstVolumeType mstVolumeType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstVolumeType.VolumeTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstVolumeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstVolumeTypeExists(id))
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

        // POST: api/MstVolumeTypes
        [HttpPost]
        public async Task<IActionResult> PostMstVolumeType([FromBody] MstVolumeType mstVolumeType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstVolumeType.Add(mstVolumeType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstVolumeType", new { id = mstVolumeType.VolumeTypeId }, mstVolumeType);
        }

        // DELETE: api/MstVolumeTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstVolumeType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstVolumeType = await _context.MstVolumeType.FindAsync(id);
            if (mstVolumeType == null)
            {
                return NotFound();
            }

            _context.MstVolumeType.Remove(mstVolumeType);
            await _context.SaveChangesAsync();

            return Ok(mstVolumeType);
        }

        private bool MstVolumeTypeExists(int id)
        {
            return _context.MstVolumeType.Any(e => e.VolumeTypeId == id);
        }
    }
}