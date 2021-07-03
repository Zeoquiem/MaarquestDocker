// Controllers/SupplierOperatorController.cs

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
    public class SupplierOperatorController
    {
        private readonly MaarquestContext _db;

        public SupplierOperatorController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPPLIER_OPERATOR.ToListAsync();

            List<SupplierOperator> result = SupplierOperatorMapper.ConvertToSupplierOperatorList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPPLIER_OPERATOR.FirstOrDefaultAsync(n => n.SUPPLIER_OPERATOR_ID == id);

            SupplierOperator result = SupplierOperatorMapper.ConvertToSupplierOperator(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupplierOperator supplierOperator)
        {
            SUPPLIER_OPERATOR data = SupplierOperatorMapper.ConvertToSUPPLIER_OPERATOR(supplierOperator);

            var res = _db.SUPPLIER_OPERATOR.Add(data);
            await _db.SaveChangesAsync();

            SupplierOperator result = SupplierOperatorMapper.ConvertToSupplierOperator(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupplierOperator supplierOperator)
        {
            var existingSupplierOperator = await _db.SUPPLIER_OPERATOR.FirstOrDefaultAsync(n => n.SUPPLIER_OPERATOR_ID == id);
           existingSupplierOperator.SUPPLIER_ID = (supplierOperator.SupplierId != null) ? supplierOperator.SupplierId : existingSupplierOperator.SUPPLIER_ID;
            existingSupplierOperator.SUPPLIER_OPERATOR_FUNCTION_ID = (supplierOperator.SupplierOperatorFunctionId > 0) ? supplierOperator.SupplierOperatorFunctionId : existingSupplierOperator.SUPPLIER_OPERATOR_FUNCTION_ID;
            existingSupplierOperator.FIRSTNAME= (supplierOperator.Firstname != null) ? supplierOperator.Firstname : existingSupplierOperator.FIRSTNAME;
            existingSupplierOperator.LASTNAME = (supplierOperator.Lastname != null) ? supplierOperator.Lastname : existingSupplierOperator.LASTNAME;
            existingSupplierOperator.USERNAME = (supplierOperator.Username != null) ? supplierOperator.Username : existingSupplierOperator.USERNAME;
            existingSupplierOperator.MAIL = (supplierOperator.Mail != null) ? supplierOperator.Mail : existingSupplierOperator.MAIL;
            existingSupplierOperator.PASSWORD = (supplierOperator.Password != null) ? supplierOperator.Password : existingSupplierOperator.PASSWORD;
            existingSupplierOperator.BIRTHDATE = (supplierOperator.Birthdate != null) ? supplierOperator.Birthdate : existingSupplierOperator.BIRTDATE;
            existingSupplierOperator.GENDER = (supplierOperator.Gender != null) ? supplierOperator.Gender : existingSupplierOperator.GENDER;
            existingSupplierOperator.TEL = (supplierOperator.Tel != null) ? supplierOperator.Tel : existingSupplierOperator.TEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supplierOperator = await _db.SUPPLIER_OPERATOR.FirstOrDefaultAsync(n => n.SUPPLIER_OPERATOR_ID == id);
            _db.Remove(supplierOperator);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
