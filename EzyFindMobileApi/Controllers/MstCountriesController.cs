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
    public class MstCountriesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCountriesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCountries
        [HttpGet]
        public IEnumerable<MstCountry> GetMstCountry()
        {
            return _context.MstCountry;
        }

        // GET: api/MstCountries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCountry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCountry = await _context.MstCountry.FindAsync(id);

            if (mstCountry == null)
            {
                return NotFound();
            }

            return Ok(mstCountry);
        }

        // PUT: api/MstCountries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCountry([FromRoute] int id, [FromBody] MstCountry mstCountry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCountry.CountryId)
            {
                return BadRequest();
            }

            _context.Entry(mstCountry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCountryExists(id))
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

        // POST: api/MstCountries
        [HttpPost]
        public async Task<IActionResult> PostMstCountry([FromBody] MstCountry mstCountry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCountry.Add(mstCountry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCountry", new { id = mstCountry.CountryId }, mstCountry);
        }

        // DELETE: api/MstCountries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCountry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCountry = await _context.MstCountry.FindAsync(id);
            if (mstCountry == null)
            {
                return NotFound();
            }

            _context.MstCountry.Remove(mstCountry);
            await _context.SaveChangesAsync();

            return Ok(mstCountry);
        }

        private bool MstCountryExists(int id)
        {
            return _context.MstCountry.Any(e => e.CountryId == id);
        }
    }
}