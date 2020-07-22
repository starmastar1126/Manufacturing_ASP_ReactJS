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
    public class MstCompanyStatusController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCompanyStatusController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCompanyStatus
        [HttpGet]
        public IEnumerable<MstCompanyStatus> GetMstCompanyStatus()
        {
            return _context.MstCompanyStatus;
        }

        // GET: api/MstCompanyStatus/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCompanyStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompanyStatus = await _context.MstCompanyStatus.FindAsync(id);

            if (mstCompanyStatus == null)
            {
                return NotFound();
            }

            return Ok(mstCompanyStatus);
        }

        // PUT: api/MstCompanyStatus/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCompanyStatus([FromRoute] int id, [FromBody] MstCompanyStatus mstCompanyStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCompanyStatus.CompanyStatusId)
            {
                return BadRequest();
            }

            _context.Entry(mstCompanyStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCompanyStatusExists(id))
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

        // POST: api/MstCompanyStatus
        [HttpPost]
        public async Task<IActionResult> PostMstCompanyStatus([FromBody] MstCompanyStatus mstCompanyStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCompanyStatus.Add(mstCompanyStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCompanyStatus", new { id = mstCompanyStatus.CompanyStatusId }, mstCompanyStatus);
        }

        // DELETE: api/MstCompanyStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCompanyStatus([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompanyStatus = await _context.MstCompanyStatus.FindAsync(id);
            if (mstCompanyStatus == null)
            {
                return NotFound();
            }

            _context.MstCompanyStatus.Remove(mstCompanyStatus);
            await _context.SaveChangesAsync();

            return Ok(mstCompanyStatus);
        }

        private bool MstCompanyStatusExists(int id)
        {
            return _context.MstCompanyStatus.Any(e => e.CompanyStatusId == id);
        }
    }
}