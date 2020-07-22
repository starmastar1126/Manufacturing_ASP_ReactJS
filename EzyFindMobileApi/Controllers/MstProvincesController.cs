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
    public class MstProvincesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstProvincesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstProvinces
        [HttpGet]
        public IEnumerable<MstProvince> GetMstProvince()
        {
            return _context.MstProvince;
        }

        // GET: api/MstProvinces/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstProvince([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstProvince = await _context.MstProvince.FindAsync(id);

            if (mstProvince == null)
            {
                return NotFound();
            }

            return Ok(mstProvince);
        }

        // PUT: api/MstProvinces/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstProvince([FromRoute] int id, [FromBody] MstProvince mstProvince)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstProvince.ProvinceId)
            {
                return BadRequest();
            }

            _context.Entry(mstProvince).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstProvinceExists(id))
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

        // POST: api/MstProvinces
        [HttpPost]
        public async Task<IActionResult> PostMstProvince([FromBody] MstProvince mstProvince)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstProvince.Add(mstProvince);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstProvince", new { id = mstProvince.ProvinceId }, mstProvince);
        }

        // DELETE: api/MstProvinces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstProvince([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstProvince = await _context.MstProvince.FindAsync(id);
            if (mstProvince == null)
            {
                return NotFound();
            }

            _context.MstProvince.Remove(mstProvince);
            await _context.SaveChangesAsync();

            return Ok(mstProvince);
        }

        private bool MstProvinceExists(int id)
        {
            return _context.MstProvince.Any(e => e.ProvinceId == id);
        }
    }
}