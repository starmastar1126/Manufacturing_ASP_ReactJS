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
    public class MstContactFormsController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstContactFormsController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstContactForms
        [HttpGet]
        public IEnumerable<MstContactForm> GetMstContactForm()
        {
            return _context.MstContactForm;
        }

        // GET: api/MstContactForms/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstContactForm([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstContactForm = await _context.MstContactForm.FindAsync(id);

            if (mstContactForm == null)
            {
                return NotFound();
            }

            return Ok(mstContactForm);
        }

        // PUT: api/MstContactForms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstContactForm([FromRoute] int id, [FromBody] MstContactForm mstContactForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstContactForm.ContactId)
            {
                return BadRequest();
            }

            _context.Entry(mstContactForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstContactFormExists(id))
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

        // POST: api/MstContactForms
        [HttpPost]
        public async Task<IActionResult> PostMstContactForm([FromBody] MstContactForm mstContactForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstContactForm.Add(mstContactForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstContactForm", new { id = mstContactForm.ContactId }, mstContactForm);
        }

        // DELETE: api/MstContactForms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstContactForm([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstContactForm = await _context.MstContactForm.FindAsync(id);
            if (mstContactForm == null)
            {
                return NotFound();
            }

            _context.MstContactForm.Remove(mstContactForm);
            await _context.SaveChangesAsync();

            return Ok(mstContactForm);
        }

        private bool MstContactFormExists(int id)
        {
            return _context.MstContactForm.Any(e => e.ContactId == id);
        }
    }
}