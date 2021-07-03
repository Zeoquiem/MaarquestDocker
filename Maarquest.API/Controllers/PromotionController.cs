// Controllers/ProductTypeController.cs

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
    public class ProductTypeController
    {
        private readonly MaarquestContext _db;

        public ProductTypeController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PRODUCT_TYPE.ToListAsync();

            List<ProductType> result = ProductTypeMapper.ConvertToProductTypeList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PRODUCT_TYPE.FirstOrDefaultAsync(n => n.PRODUCT_TYPE_ID == id);

            ProductType result = ProductTypeMapper.ConvertToProductType(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductType productType)
        {
            PRODUCT_TYPE data = ProductTypeMapper.ConvertToPRODUCT_TYPE(productType);

            var res = _db.PRODUCT_TYPE.Add(data);
            await _db.SaveChangesAsync();

            ProductType result = ProductTypeMapper.ConvertToProductType(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, ProductType productType)
        {
            var existingProductType = await _db.PRODUCT_TYPE.FirstOrDefaultAsync(n => n.PRODUCT_TYPE_ID == id);
            existingProductType.SUPPLIER_ID = (productType.SupplierId > 0) ? productType.SupplierId : existingProductType.SUPPLIER_ID;
            existingProductType.NAME = (productType.Name != null) ? productType.Name : existingProductType.NAME;
            existingProductType.PRODUCT_CATEGORY_ID = (productType.ProductCategoryId > 0) ? productType.ProductCategoryId : existingProductType.PRODUCT_CATEGORY_ID;
            existingProductType.DETAILS = (productType.Details != null) ? productType.Details : existingProductType.DETAILS;
            existingProductType.QUANTITY = (productType.Quantity > 0) ? productType.Quantity : existingProductType.QUANTITY;
            existingProductType.UNIT_PRICE = (productType.UnitPrice > 0) ? productType.UnitPrice : existingProductType.UNIT_PRICE;
            existingProductType.TAX = (productType.Tax > 0) ? productType.Tax : existingProductType.TAX;
            existingProductType.TOTAL_PRICE = (productType.TotalPrice > 0) ? productType.TotalPrice : existingProductType.TOTAL_PRICE;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var productType = await _db.PRODUCT_TYPE.FirstOrDefaultAsync(n => n.PRODUCT_TYPE_ID == id);
            _db.Remove(productType);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
