// Controllers/SupplierProductRequestController.cs

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
    public class SupplierProductRequestController
    {
        private readonly MaarquestContext _db;

        public SupplierProductRequestController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPPLIER_PRODUCT_REQUEST.ToListAsync();

            List<SupplierProductRequest> result = SupplierProductRequestMapper.ConvertToSupplierProductRequestList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPPLIER_PRODUCT_REQUEST.FirstOrDefaultAsync(n => n.SUPPLIER_PRODUCT_REQUEST_ID == id);

            SupplierProductRequest result = SupplierProductRequestMapper.ConvertToSupplierProductRequest(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupplierProductRequest supplierProductRequest)
        {
            SUPPLIER_PRODUCT_REQUEST data = SupplierProductRequestMapper.ConvertToSUPPLIER_PRODUCT_REQUEST(supplierProductRequest);

            var res = _db.SUPPLIER_PRODUCT_REQUEST.Add(data);
            await _db.SaveChangesAsync();

            SupplierProductRequest result = SupplierProductRequestMapper.ConvertToSupplierProductRequest(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupplierProductRequest SupplierProductRequest)
        {
            var existingSupplierProductRequest = await _db.SUPPLIER_PRODUCT_REQUEST.FirstOrDefaultAsync(n => n.SUPPLIER_PRODUCT_REQUEST_ID == id);
            existingSupplierProductRequest.SUPPLIER_ID = (SupplierProductRequest.SupplierId != null) ? SupplierProductRequest.SupplierId : existingSupplierProductRequest.SUPPLIER_ID;
            existingSupplierProductRequest.PRODUCT_CATEGORY_ID = (SupplierProductRequest.ProductCategoryId > 0) ? SupplierProductRequest.ProductCategoryId : existingSupplierProductRequest.PRODUCT_CATEGORY_ID;
            existingSupplierProductRequest.IS_TREATED = (SupplierProductRequest.IsTreated != null) ? SupplierProductRequest.IsTreated : existingSupplierProductRequest.IS_TREATED;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supplierProductRequest = await _db.SUPPLIER_PRODUCT_REQUEST.FirstOrDefaultAsync(n => n.SUPPLIER_PRODUCT_REQUEST_ID == id);
            _db.Remove(supplierProductRequest);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
