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
    public class MstCrmCustomerCommentsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCrmCustomerCommentsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCrmCustomerComments
        [HttpGet]
        public IEnumerable<MstCrmCustomerComment> GetMstCrmCustomerComment()
        {
            return _context.MstCrmCustomerComment;
        }

        // GET: api/MstCrmCustomerComments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCrmCustomerComment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmCustomerComment = await _context.MstCrmCustomerComment.FindAsync(id);

            if (mstCrmCustomerComment == null)
            {
                return NotFound();
            }

            return Ok(mstCrmCustomerComment);
        }

        // PUT: api/MstCrmCustomerComments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCrmCustomerComment([FromRoute] int id, [FromBody] MstCrmCustomerComment mstCrmCustomerComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCrmCustomerComment.CustomerCommentId)
            {
                return BadRequest();
            }

            _context.Entry(mstCrmCustomerComment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCrmCustomerCommentExists(id))
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

        // POST: api/MstCrmCustomerComments
        [HttpPost]
        public async Task<IActionResult> PostMstCrmCustomerComment([FromBody] MstCrmCustomerComment mstCrmCustomerComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCrmCustomerComment.Add(mstCrmCustomerComment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCrmCustomerComment", new { id = mstCrmCustomerComment.CustomerCommentId }, mstCrmCustomerComment);
        }

        // DELETE: api/MstCrmCustomerComments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCrmCustomerComment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCrmCustomerComment = await _context.MstCrmCustomerComment.FindAsync(id);
            if (mstCrmCustomerComment == null)
            {
                return NotFound();
            }

            _context.MstCrmCustomerComment.Remove(mstCrmCustomerComment);
            await _context.SaveChangesAsync();

            return Ok(mstCrmCustomerComment);
        }

        private bool MstCrmCustomerCommentExists(int id)
        {
            return _context.MstCrmCustomerComment.Any(e => e.CustomerCommentId == id);
        }
    }
}