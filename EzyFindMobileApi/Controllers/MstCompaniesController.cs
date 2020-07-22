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
    public class MstCompaniesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCompaniesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCompanies
        [HttpGet]
        public IEnumerable<MstCompany> GetMstCompany()
        {
            return _context.MstCompany;
        }

        // GET: api/MstCompanies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCompany([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompany = await _context.MstCompany.FindAsync(id);

            if (mstCompany == null)
            {
                return NotFound();
            }

            return Ok(mstCompany);
        }

        // PUT: api/MstCompanies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCompany([FromRoute] int id, [FromBody] MstCompany mstCompany)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCompany.CompanyId)
            {
                return BadRequest();
            }

            _context.Entry(mstCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCompanyExists(id))
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

        // POST: api/MstCompanies
        [HttpPost]
        public async Task<IActionResult> PostMstCompany([FromBody] MstCompany mstCompany)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCompany.Add(mstCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCompany", new { id = mstCompany.CompanyId }, mstCompany);
        }

        // DELETE: api/MstCompanies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCompany([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompany = await _context.MstCompany.FindAsync(id);
            if (mstCompany == null)
            {
                return NotFound();
            }

            _context.MstCompany.Remove(mstCompany);
            await _context.SaveChangesAsync();

            return Ok(mstCompany);
        }

        private bool MstCompanyExists(int id)
        {
            return _context.MstCompany.Any(e => e.CompanyId == id);
        }
    }
}