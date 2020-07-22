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
    public class MstPackagesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstPackagesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstPackages
        [HttpGet]
        public IEnumerable<MstPackage> GetMstPackage()
        {
            return _context.MstPackage;
        }

        // GET: api/MstPackages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstPackage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPackage = await _context.MstPackage.FindAsync(id);

            if (mstPackage == null)
            {
                return NotFound();
            }

            return Ok(mstPackage);
        }

        // PUT: api/MstPackages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstPackage([FromRoute] int id, [FromBody] MstPackage mstPackage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstPackage.PackageId)
            {
                return BadRequest();
            }

            _context.Entry(mstPackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstPackageExists(id))
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

        // POST: api/MstPackages
        [HttpPost]
        public async Task<IActionResult> PostMstPackage([FromBody] MstPackage mstPackage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstPackage.Add(mstPackage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstPackage", new { id = mstPackage.PackageId }, mstPackage);
        }

        // DELETE: api/MstPackages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstPackage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPackage = await _context.MstPackage.FindAsync(id);
            if (mstPackage == null)
            {
                return NotFound();
            }

            _context.MstPackage.Remove(mstPackage);
            await _context.SaveChangesAsync();

            return Ok(mstPackage);
        }

        private bool MstPackageExists(int id)
        {
            return _context.MstPackage.Any(e => e.PackageId == id);
        }
    }
}