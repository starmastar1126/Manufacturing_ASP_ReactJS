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
    public class MapCompanyTasksController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MapCompanyTasksController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MapCompanyTasks
        [HttpGet]
        public IEnumerable<MapCompanyTask> GetMapCompanyTask()
        {
            return _context.MapCompanyTask;
        }

        // GET: api/MapCompanyTasks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapCompanyTask([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyTask = await _context.MapCompanyTask.FindAsync(id);

            if (mapCompanyTask == null)
            {
                return NotFound();
            }

            return Ok(mapCompanyTask);
        }

        // PUT: api/MapCompanyTasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMapCompanyTask([FromRoute] int id, [FromBody] MapCompanyTask mapCompanyTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mapCompanyTask.CompTaskId)
            {
                return BadRequest();
            }

            _context.Entry(mapCompanyTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapCompanyTaskExists(id))
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

        // POST: api/MapCompanyTasks
        [HttpPost]
        public async Task<IActionResult> PostMapCompanyTask([FromBody] MapCompanyTask mapCompanyTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MapCompanyTask.Add(mapCompanyTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMapCompanyTask", new { id = mapCompanyTask.CompTaskId }, mapCompanyTask);
        }

        // DELETE: api/MapCompanyTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMapCompanyTask([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapCompanyTask = await _context.MapCompanyTask.FindAsync(id);
            if (mapCompanyTask == null)
            {
                return NotFound();
            }

            _context.MapCompanyTask.Remove(mapCompanyTask);
            await _context.SaveChangesAsync();

            return Ok(mapCompanyTask);
        }

        private bool MapCompanyTaskExists(int id)
        {
            return _context.MapCompanyTask.Any(e => e.CompTaskId == id);
        }
    }
}