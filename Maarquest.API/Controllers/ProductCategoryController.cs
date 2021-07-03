// Controllers/ProductCategoryController.cs

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
    public class ProductCategoryController
    {
        private readonly MaarquestContext _db;

        public ProductCategoryController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PRODUCT_CATEGORY.ToListAsync();

            List<ProductCategory> result = ProductCategoryMapper.ConvertToProductCategoryList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PRODUCT_CATEGORY.FirstOrDefaultAsync(n => n.PRODUCT_CATEGORY_ID == id);

            ProductCategory result = ProductCategoryMapper.ConvertToProductCategory(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductCategory productCategory)
        {
            PRODUCT_CATEGORY data = ProductCategoryMapper.ConvertToPRODUCT_CATEGORY(productCategory);

            var res = _db.PRODUCT_CATEGORY.Add(data);
            await _db.SaveChangesAsync();

            ProductCategory result = ProductCategoryMapper.ConvertToProductCategory(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, ProductCategory productCategory)
        {
            var existingProductCategory = await _db.PRODUCT_CATEGORY.FirstOrDefaultAsync(n => n.PRODUCT_CATEGORY_ID == id);
            existingProductCategory.LABEL = (productCategory.Label != null) ? productCategory.Label : existingProductCategory.LABEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var productCategory = await _db.PRODUCT_CATEGORY.FirstOrDefaultAsync(n => n.PRODUCT_CATEGORY_ID == id);
            _db.Remove(productCategory);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
