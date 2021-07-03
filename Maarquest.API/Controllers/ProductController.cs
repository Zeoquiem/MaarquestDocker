// Controllers/ProductController.cs

using Maarquest.API.Data;
using Maarquest.API.Mappers;
using Maarquest.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DockerSqlServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly MaarquestContext _db;

        public ProductController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PRODUCT.ToListAsync();

            List<Product> result = ProductMapper.ConvertToProductList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PRODUCT.FirstOrDefaultAsync(n => n.PRODUCT_ID == id);

            Product result = ProductMapper.ConvertToProduct(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            PRODUCT data = ProductMapper.ConvertToPRODUCT(product);

            var res = _db.PRODUCT.Add(data);
            await _db.SaveChangesAsync();

            Product result = ProductMapper.ConvertToProduct(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Product product)
        {
            var existingProduct = await _db.PRODUCT.FirstOrDefaultAsync(n => n.PRODUCT_ID == id);
            existingProduct.PRODUCT_TYPE_ID = (product.ProductTypeId > 0) ? product.ProductTypeId : existingProduct.PRODUCT_TYPE_ID;
            existingProduct.EXPIRY_DATE = (product.ExpiryDate != null) ? product.ExpiryDate : existingProduct.EXPIRY_DATE;
            existingProduct.POSITION_ID = (product.PositionId > 0) ? product.PositionId : existingProduct.POSITION_ID;
            existingProduct.POSITION_TYPE_ID = (product.PositionTypeId > 0) ? product.PositionTypeId : existingProduct.POSITION_TYPE_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _db.PRODUCT.FirstOrDefaultAsync(n => n.PRODUCT_ID == id);
            _db.Remove(product);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
