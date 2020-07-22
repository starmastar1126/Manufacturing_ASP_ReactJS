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
    public class MstCategoryAttributeDataTypesController : ControllerBase
    {
        private readonly EzyFind_DevContext _context;

        public MstCategoryAttributeDataTypesController(EzyFind_DevContext context)
        {
            _context = context;
        }

        // GET: api/MstCategoryAttributeDataTypes
        [HttpGet]
        public IEnumerable<MstCategoryAttributeDataType> GetMstCategoryAttributeDataType()
        {
            return _context.MstCategoryAttributeDataType;
        }

        // GET: api/MstCategoryAttributeDataTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMstCategoryAttributeDataType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCategoryAttributeDataType = await _context.MstCategoryAttributeDataType.FindAsync(id);

            if (mstCategoryAttributeDataType == null)
            {
                return NotFound();
            }

            return Ok(mstCategoryAttributeDataType);
        }

        // PUT: api/MstCategoryAttributeDataTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMstCategoryAttributeDataType([FromRoute] int id, [FromBody] MstCategoryAttributeDataType mstCategoryAttributeDataType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mstCategoryAttributeDataType.CatAttributeDataTypeId)
            {
                return BadRequest();
            }

            _context.Entry(mstCategoryAttributeDataType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MstCategoryAttributeDataTypeExists(id))
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

        // POST: api/MstCategoryAttributeDataTypes
        [HttpPost]
        public async Task<IActionResult> PostMstCategoryAttributeDataType([FromBody] MstCategoryAttributeDataType mstCategoryAttributeDataType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MstCategoryAttributeDataType.Add(mstCategoryAttributeDataType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMstCategoryAttributeDataType", new { id = mstCategoryAttributeDataType.CatAttributeDataTypeId }, mstCategoryAttributeDataType);
        }

        // DELETE: api/MstCategoryAttributeDataTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMstCategoryAttributeDataType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstCategoryAttributeDataType = await _context.MstCategoryAttributeDataType.FindAsync(id);
            if (mstCategoryAttributeDataType == null)
            {
                return NotFound();
            }

            _context.MstCategoryAttributeDataType.Remove(mstCategoryAttributeDataType);
            await _context.SaveChangesAsync();

            return Ok(mstCategoryAttributeDataType);
        }

        private bool MstCategoryAttributeDataTypeExists(int id)
        {
            return _context.MstCategoryAttributeDataType.Any(e => e.CatAttributeDataTypeId == id);
        }
    }
}