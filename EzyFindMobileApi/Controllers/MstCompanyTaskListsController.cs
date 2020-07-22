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
    public class MstCompanyTaskListsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCompanyTaskListsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCompanyTaskLists
        [HttpGet]
        public IEnumerable<MstCompanyTaskList> GetMstCompanyTaskList()
        {
            return _context.MstCompanyTaskList;
        }

        // GET: api/MstCompanyTaskLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCompanyTaskList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompanyTaskList = await _context.MstCompanyTaskList.FindAsync(id);

            if (mstCompanyTaskList == null)
            {
                return NotFound();
            }

            return Ok(mstCompanyTaskList);
        }

        // PUT: api/MstCompanyTaskLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCompanyTaskList([FromRoute] int id, [FromBody] MstCompanyTaskList mstCompanyTaskList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCompanyTaskList.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(mstCompanyTaskList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCompanyTaskListExists(id))
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

        // POST: api/MstCompanyTaskLists
        [HttpPost]
        public async Task<IActionResult> PostMstCompanyTaskList([FromBody] MstCompanyTaskList mstCompanyTaskList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCompanyTaskList.Add(mstCompanyTaskList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCompanyTaskList", new { id = mstCompanyTaskList.TaskId }, mstCompanyTaskList);
        }

        // DELETE: api/MstCompanyTaskLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCompanyTaskList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCompanyTaskList = await _context.MstCompanyTaskList.FindAsync(id);
            if (mstCompanyTaskList == null)
            {
                return NotFound();
            }

            _context.MstCompanyTaskList.Remove(mstCompanyTaskList);
            await _context.SaveChangesAsync();

            return Ok(mstCompanyTaskList);
        }

        private bool MstCompanyTaskListExists(int id)
        {
            return _context.MstCompanyTaskList.Any(e => e.TaskId == id);
        }
    }
}