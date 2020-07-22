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
    public class MstPeriodTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstPeriodTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstPeriodTypes
        [HttpGet]
        public IEnumerable<MstPeriodType> GetMstPeriodType()
        {
            return _context.MstPeriodType;
        }

        // GET: api/MstPeriodTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstPeriodType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPeriodType = await _context.MstPeriodType.FindAsync(id);

            if (mstPeriodType == null)
            {
                return NotFound();
            }

            return Ok(mstPeriodType);
        }

        // PUT: api/MstPeriodTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstPeriodType([FromRoute] int id, [FromBody] MstPeriodType mstPeriodType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstPeriodType.PeriodTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstPeriodType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstPeriodTypeExists(id))
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

        // POST: api/MstPeriodTypes
        [HttpPost]
        public async Task<IActionResult> PostMstPeriodType([FromBody] MstPeriodType mstPeriodType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstPeriodType.Add(mstPeriodType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstPeriodType", new { id = mstPeriodType.PeriodTypeId }, mstPeriodType);
        }

        // DELETE: api/MstPeriodTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstPeriodType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPeriodType = await _context.MstPeriodType.FindAsync(id);
            if (mstPeriodType == null)
            {
                return NotFound();
            }

            _context.MstPeriodType.Remove(mstPeriodType);
            await _context.SaveChangesAsync();

            return Ok(mstPeriodType);
        }

        private bool MstPeriodTypeExists(int id)
        {
            return _context.MstPeriodType.Any(e => e.PeriodTypeId == id);
        }
    }
}