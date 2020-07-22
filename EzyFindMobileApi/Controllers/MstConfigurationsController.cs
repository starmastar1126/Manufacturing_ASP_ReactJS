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
    public class MstConfigurationsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstConfigurationsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstConfigurations
        [HttpGet]
        public IEnumerable<MstConfiguration> GetMstConfiguration()
        {
            return _context.MstConfiguration;
        }

        // GET: api/MstConfigurations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstConfiguration([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstConfiguration = await _context.MstConfiguration.FindAsync(id);

            if (mstConfiguration == null)
            {
                return NotFound();
            }

            return Ok(mstConfiguration);
        }

        // PUT: api/MstConfigurations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstConfiguration([FromRoute] int id, [FromBody] MstConfiguration mstConfiguration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstConfiguration.ConfigurationId)
            {
                return BadRequest();
            }

            _context.Entry(mstConfiguration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstConfigurationExists(id))
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

        // POST: api/MstConfigurations
        [HttpPost]
        public async Task<IActionResult> PostMstConfiguration([FromBody] MstConfiguration mstConfiguration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstConfiguration.Add(mstConfiguration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstConfiguration", new { id = mstConfiguration.ConfigurationId }, mstConfiguration);
        }

        // DELETE: api/MstConfigurations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstConfiguration([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstConfiguration = await _context.MstConfiguration.FindAsync(id);
            if (mstConfiguration == null)
            {
                return NotFound();
            }

            _context.MstConfiguration.Remove(mstConfiguration);
            await _context.SaveChangesAsync();

            return Ok(mstConfiguration);
        }

        private bool MstConfigurationExists(int id)
        {
            return _context.MstConfiguration.Any(e => e.ConfigurationId == id);
        }
    }
}