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
    public class PostAttachmentsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public PostAttachmentsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/PostAttachments
        [HttpGet]
        public IEnumerable<PostAttachment> GetPostAttachment()
        {
            return _context.PostAttachment;
        }

        // GET: api/PostAttachments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostAttachment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postAttachment = await _context.PostAttachment.FindAsync(id);

            if (postAttachment == null)
            {
                return NotFound();
            }

            return Ok(postAttachment);
        }

        // PUT: api/PostAttachments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostAttachment([FromRoute] int id, [FromBody] PostAttachment postAttachment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != postAttachment.PostAttachmentId)
            {
                return BadRequest();
            }

            _context.Entry(postAttachment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostAttachmentExists(id))
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

        // POST: api/PostAttachments
        [HttpPost]
        public async Task<IActionResult> PostPostAttachment([FromBody] PostAttachment postAttachment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PostAttachment.Add(postAttachment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostAttachment", new { id = postAttachment.PostAttachmentId }, postAttachment);
        }

        // DELETE: api/PostAttachments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostAttachment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postAttachment = await _context.PostAttachment.FindAsync(id);
            if (postAttachment == null)
            {
                return NotFound();
            }

            _context.PostAttachment.Remove(postAttachment);
            await _context.SaveChangesAsync();

            return Ok(postAttachment);
        }

        private bool PostAttachmentExists(int id)
        {
            return _context.PostAttachment.Any(e => e.PostAttachmentId == id);
        }
    }
}