// Controllers/SupplierController.cs

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
    public class SupplierController
    {
        private readonly MaarquestContext _db;

        public SupplierController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPPLIER.ToListAsync();

            List<Supplier> result = SupplierMapper.ConvertToSupplierList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPPLIER.FirstOrDefaultAsync(n => n.SUPPLIER_ID == id);

            Supplier result = SupplierMapper.ConvertToSupplier(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Supplier supplier)
        {
            SUPPLIER data = SupplierMapper.ConvertToSUPPLIER(supplier);

            var res = _db.SUPPLIER.Add(data);
            await _db.SaveChangesAsync();

            Supplier result = SupplierMapper.ConvertToSupplier(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Supplier Supplier)
        {
            var existingSupplier = await _db.SUPPLIER.FirstOrDefaultAsync(n => n.SUPPLIER_ID == id);
            existingSupplier.ADDRESS_ID = (Supplier.AddressId != null) ? Supplier.AddressId : existingSupplier.ADDRESS_ID;
            existingSupplier.COMPANY_NAME = (Supplier.CompanyName > 0) ? Supplier.CompanyName : existingSupplier.COMPANY_NAME;
            existingSupplier.COMPANY_SIGN = (Supplier.CompanySign != null) ? Supplier.CompanySign : existingSupplier.COMPANY_SIGN;
            existingSupplier.SIRET = (Supplier.Siret != null) ? Supplier.Siret : existingSupplier.SIRET;
            existingSupplier.TEL = (Supplier.Tel != null) ? Supplier.Tel : existingSupplier.TEL;
            existingSupplier.FAX = (Supplier.Fax != null) ? Supplier.Fax : existingSupplier.FAX;
            existingSupplier.IS_READY = (Supplier.IsReady != null) ? Supplier.IsReady : existingSupplier.IS_READY;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supplier = await _db.SUPPLIER.FirstOrDefaultAsync(n => n.SUPPLIER_ID == id);
            _db.Remove(supplier);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
