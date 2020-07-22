using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzyFindMobileApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EzyFindMobileApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();
        // GET: api/GetProductByUserId
        [HttpGet("{Id}/{page}/{size}", Name = "GetProductByUserId")]
        public async Task<IActionResult> GetProductByUserId(int Id, int page, int size)
        {

            try
            {
                if (size == 0)
                    size = 10;

                var query = db.PrdProducts;
                var PrdProduct = await query.Where(q => q.ProductId == Id).OrderByDescending(q => q.CreatedDate).Skip((page - 1) * size).Take(size).ToListAsync();
                var count = await query.CountAsync();

                var totalPages = (int)Math.Ceiling(count / (float)size);

                var firstPage = 1; // obviously
                var lastPage = totalPages;
                var prevPage = page > firstPage ? page - 1 : firstPage;
                var nextPage = page < lastPage ? page + 1 : lastPage;

                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : Product returned";   // Exception Message
                response.Result = PrdProduct;
                response.Count = count;
                response.TotalPages = totalPages;
                response.CurrentPage = page;
                response.PrevPage = prevPage;
                response.NextPage = nextPage;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : unable to get  Product";   // Exception Message
                response.Result = null;
                response.TotalPages = 0;
                response.CurrentPage = page;
                response.PrevPage = 0;
                response.NextPage = 0;
                return Ok(response);
            }
        }



        // POST: api/AddProduct
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] PrdProducts PrdProduct)
        {
            try
            {

                if (PrdProduct != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.PrdProducts.Add(PrdProduct);
                        await db.SaveChangesAsync();
                        id = PrdProduct.ProductId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : Product added";   // Exception Message
                    response.Result = id;
                    return Ok(response);

                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Product provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to add Product";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // PUT: api/UpdateProduct/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] PrdProducts PrdProduct)
        {
            try
            {

                if (PrdProduct != null && id != 0)
                {

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.PrdProducts.Update(PrdProduct);
                        await db.SaveChangesAsync();
                        id = PrdProduct.ProductId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Product updated";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Product provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update Product";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        // DELETE: api/DeleteProduct/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            try
            {

                if (id != 0)
                {
                    var PrdProduct = await db.PrdProducts.FindAsync(id);

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        db.PrdProducts.Remove(PrdProduct);
                        await db.SaveChangesAsync();
                        id = PrdProduct.ProductId;
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful: Product deleted";   // Exception Message
                    response.Result = id;
                    return Ok(response);
                }
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Warning : No Product provided";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete Product";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
