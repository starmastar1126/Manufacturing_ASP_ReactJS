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
    public class MapCompanyAuditLogsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyAuditLogsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyAuditLogs
        [HttpGet]
        public IEnumerable<MapCompanyAuditLog> GetMapCompanyAuditLog()
        {
            return _context.MapCompanyAuditLog;
        }

        // GET: api/MapCompanyAuditLogs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyAuditLog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyAuditLog = await _context.MapCompanyAuditLog.FindAsync(id);

            if (mapCompanyAuditLog == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyAuditLog);
        }

        // PUT: api/MapCompanyAuditLogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyAuditLog([FromRoute] int id, [FromBody] MapCompanyAuditLog mapCompanyAuditLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyAuditLog.AuditLogId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyAuditLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyAuditLogExists(id))
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

        // POST: api/MapCompanyAuditLogs
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyAuditLog([FromBody] MapCompanyAuditLog mapCompanyAuditLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyAuditLog.Add(mapCompanyAuditLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyAuditLog", new { id = mapCompanyAuditLog.AuditLogId }, mapCompanyAuditLog);
        }

        // DELETE: api/MapCompanyAuditLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyAuditLog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyAuditLog = await _context.MapCompanyAuditLog.FindAsync(id);
            if (mapCompanyAuditLog == null)
            {
                return NotFound();
            }

            _context.MapCompanyAuditLog.Remove(mapCompanyAuditLog);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyAuditLog);
        }

        private bool MapCompanyAuditLogExists(int id)
        {
            return _context.MapCompanyAuditLog.Any(e => e.AuditLogId == id);
        }
    }
}