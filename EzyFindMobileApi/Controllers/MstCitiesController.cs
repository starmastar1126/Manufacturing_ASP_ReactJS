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
    public class MstCitiesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCitiesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCities
        [HttpGet]
        public IEnumerable<MstCity> GetMstCity()
        {
            return _context.MstCity;
        }

        // GET: api/MstCities/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCity = await _context.MstCity.FindAsync(id);

            if (mstCity == null)
            {
                return NotFound();
            }

            return Ok(mstCity);
        }

        // PUT: api/MstCities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCity([FromRoute] int id, [FromBody] MstCity mstCity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCity.CityId)
            {
                return BadRequest();
            }

            _context.Entry(mstCity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCityExists(id))
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

        // POST: api/MstCities
        [HttpPost]
        public async Task<IActionResult> PostMstCity([FromBody] MstCity mstCity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCity.Add(mstCity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCity", new { id = mstCity.CityId }, mstCity);
        }

        // DELETE: api/MstCities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCity = await _context.MstCity.FindAsync(id);
            if (mstCity == null)
            {
                return NotFound();
            }

            _context.MstCity.Remove(mstCity);
            await _context.SaveChangesAsync();

            return Ok(mstCity);
        }

        private bool MstCityExists(int id)
        {
            return _context.MstCity.Any(e => e.CityId == id);
        }
    }
}