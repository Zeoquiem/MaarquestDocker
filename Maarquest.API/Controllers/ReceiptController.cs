// Controllers/ReceiptController.cs

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
    public class ReceiptController
    {
        private readonly MaarquestContext _db;

        public ReceiptController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.RECEIPT.ToListAsync();

            List<Receipt> result = ReceiptMapper.ConvertToReceiptList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.RECEIPT.FirstOrDefaultAsync(n => n.RECEIPT_ID == id);

            Receipt result = ReceiptMapper.ConvertToReceipt(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Receipt receipt)
        {
            RECEIPT data = ReceiptMapper.ConvertToRECEIPT(receipt);

            var res = _db.RECEIPT.Add(data);
            await _db.SaveChangesAsync();

            Receipt result = ReceiptMapper.ConvertToReceipt(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Receipt receipt)
        {
            var existingReceipt = await _db.RECEIPT.FirstOrDefaultAsync(n => n.RECEIPT_ID == id);
            existingReceipt.CUSTOMER_ID = (receipt.CustomerId != null) ? receipt.CustomerId : existingReceipt.CUSTOMER_ID;
            existingReceipt.UNIT_PRICE = (receipt.UnitPrice > 0) ? receipt.UnitPrice : existingReceipt.UNIT_PRICE;
             existingReceipt.TAX = (receipt.Tax > 0) ? receipt.Tax : existingReceipt.TAX;
             existingReceipt.TOTAL_PRICE = (receipt.TotalPrice > 0) ? receipt.TotalPrice : existingReceipt.TOTAL_PRICE;
             existingReceipt.DATE = (receipt.Date != null) ? receipt.Date : existingReceipt.DATE;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var receipt = await _db.RECEIPT.FirstOrDefaultAsync(n => n.RECEIPT_ID == id);
            _db.Remove(receipt);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
