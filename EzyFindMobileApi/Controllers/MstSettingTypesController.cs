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
    public class MstSettingTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstSettingTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstSettingTypes
        [HttpGet]
        public IEnumerable<MstSettingType> GetMstSettingType()
        {
            return _context.MstSettingType;
        }

        // GET: api/MstSettingTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstSettingType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSettingType = await _context.MstSettingType.FindAsync(id);

            if (mstSettingType == null)
            {
                return NotFound();
            }

            return Ok(mstSettingType);
        }

        // PUT: api/MstSettingTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstSettingType([FromRoute] int id, [FromBody] MstSettingType mstSettingType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstSettingType.SettingTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstSettingType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstSettingTypeExists(id))
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

        // POST: api/MstSettingTypes
        [HttpPost]
        public async Task<IActionResult> PostMstSettingType([FromBody] MstSettingType mstSettingType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstSettingType.Add(mstSettingType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstSettingType", new { id = mstSettingType.SettingTypeId }, mstSettingType);
        }

        // DELETE: api/MstSettingTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstSettingType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstSettingType = await _context.MstSettingType.FindAsync(id);
            if (mstSettingType == null)
            {
                return NotFound();
            }

            _context.MstSettingType.Remove(mstSettingType);
            await _context.SaveChangesAsync();

            return Ok(mstSettingType);
        }

        private bool MstSettingTypeExists(int id)
        {
            return _context.MstSettingType.Any(e => e.SettingTypeId == id);
        }
    }
}