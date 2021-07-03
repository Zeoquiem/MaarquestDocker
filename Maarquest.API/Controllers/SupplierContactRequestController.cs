// Controllers/SupplierContactRequestController.cs

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
    public class SupplierContactRequestController
    {
        private readonly MaarquestContext _db;

        public SupplierContactRequestController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPPLIER_CONTACT_REQUEST.ToListAsync();

            List<SupplierContactRequest> result = SupplierContactRequestMapper.ConvertToSupplierContactRequestList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPPLIER_CONTACT_REQUEST.FirstOrDefaultAsync(n => n.SUPPLIER_CONTACT_REQUEST_ID == id);

            SupplierContactRequest result = SupplierContactRequestMapper.ConvertToSupplierContactRequest(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupplierContactRequest supplierContactRequest)
        {
            SUPPLIER_CONTACT_REQUEST data = SupplierContactRequestMapper.ConvertToSUPPLIER_CONTACT_REQUEST(supplierContactRequest);

            var res = _db.SUPPLIER_CONTACT_REQUEST.Add(data);
            await _db.SaveChangesAsync();

            SupplierContactRequest result = SupplierContactRequestMapper.ConvertToSupplierContactRequest(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupplierContactRequest supplierContactRequest)
        {
            var existingSupplierContactRequest = await _db.SUPPLIER_CONTACT_REQUEST.FirstOrDefaultAsync(n => n.SUPPLIER_CONTACT_REQUEST_ID == id);
            existingSupplierContactRequest.SUPPLIER_ID = (supplierContactRequest.SupplierId != null) ? supplierContactRequest.SupplierId : existingSupplierContactRequest.SUPPLIER_ID;
            existingSupplierContactRequest.IS_TREATED = (supplierContactRequest.IsTreated > 0) ? supplierContactRequest.IsTreated : existingSupplierContactRequest.IS_TREATED;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supplierContactRequest = await _db.SUPPLIER_CONTACT_REQUEST.FirstOrDefaultAsync(n => n.SUPPLIER_CONTACT_REQUEST_ID == id);
            _db.Remove(supplierContactRequest);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
