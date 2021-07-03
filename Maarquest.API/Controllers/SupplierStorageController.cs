// Controllers/SupplierStorageController.cs

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
    public class SupplierStorageController
    {
        private readonly MaarquestContext _db;

        public SupplierStorageController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPPLIER_STORAGE.ToListAsync();

            List<SupplierStorage> result = SupplierStorageMapper.ConvertToSupplierStorageList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPPLIER_STORAGE.FirstOrDefaultAsync(n => n.SUPPLIER_STORAGE_ID == id);

            SupplierStorage result = SupplierStorageMapper.ConvertToSupplierStorage(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupplierStorage supplierStorage)
        {
            SUPPLIER_STORAGE data = SupplierStorageMapper.ConvertToSUPPLIER_STORAGE(supplierStorage);

            var res = _db.SUPPLIER_STORAGE.Add(data);
            await _db.SaveChangesAsync();

            SupplierStorage result = SupplierStorageMapper.ConvertToSupplierStorage(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupplierStorage supplierStorage)
        {
            var existingSupplierStorage = await _db.SUPPLIER_STORAGE.FirstOrDefaultAsync(n => n.SUPPLIER_STORAGE_ID == id);
            existingSupplierStorage.SUPPLIER_STORAGE_ID = (supplierStorage.SupplierStorageId != null) ? supplierStorage.SupplierStorageId : existingSupplierStorage.SUPPLIER_STORAGE_ID;
            existingSupplierStorage.SUPLLIER_ID = (supplierStorage.SupplierId > 0) ? supplierStorage.SupplierId : existingSupplierStorage.SUPPLIER_ID;
            existingSupplierStorage.ADDRESS_ID = (supplierStorage.AddressId != null) ? supplierStorage.AddressId : existingSupplierStorage.ADDRESS_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supplierStorage = await _db.SUPPLIER_STORAGE.FirstOrDefaultAsync(n => n.SUPPLIER_STORAGE_ID == id);
            _db.Remove(supplierStorage);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
