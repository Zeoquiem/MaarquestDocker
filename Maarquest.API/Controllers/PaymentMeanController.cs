// Controllers/PaymentMeanController.cs

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
    public class PaymentMeanController
    {
        private readonly MaarquestContext _db;

        public PaymentMeanController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PAYMENT_MEAN.ToListAsync();

            List<PaymentMean> result = PaymentMeanMapper.ConvertToPaymentMeanList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PAYMENT_MEAN.FirstOrDefaultAsync(n => n.PAYMENT_MEAN_ID == id);

            PaymentMean result = PaymentMeanMapper.ConvertToPaymentMean(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PaymentMean paymentMean)
        {
            PAYMENT_MEAN data = PaymentMeanMapper.ConvertToPAYMENT_MEAN(paymentMean);

            var res = _db.PAYMENT_MEAN.Add(data);
            await _db.SaveChangesAsync();

            PaymentMean result = PaymentMeanMapper.ConvertToPaymentMean(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PaymentMean paymentMean)
        {
            var existingPaymentMean = await _db.PAYMENT_MEAN.FirstOrDefaultAsync(n => n.PAYMENT_MEAN_ID == id);
            existingPaymentMean.USER_ID = (paymentMean.UserId < 0) ? paymentMean.UserId : existingPaymentMean.USER_ID;
            existingPaymentMean.USER_TYPE_ID = (paymentMean.UserTypeId < 0) ? paymentMean.UserTypeId : existingPaymentMean.USER_TYPE_ID;
            existingPaymentMean.ADDRESS_ID = (paymentMean.AddressId < 0) ? paymentMean.AddressId : existingPaymentMean.ADDRESS_ID;
            existingPaymentMean.PAYMENT_ID = (paymentMean.PaymentId < 0) ? paymentMean.PaymentId : existingPaymentMean.PAYMENT_ID;
            existingPaymentMean.PAYMENT_TYPE_ID = (paymentMean.PaymentTypeId < 0) ? paymentMean.PaymentTypeId : existingPaymentMean.PAYMENT_TYPE_ID;
            existingPaymentMean.IS_DEFAULT = (paymentMean.IsDefault != null) ? paymentMean.IsDefault : existingPaymentMean.IS_DEFAULT;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var paymentMean = await _db.PAYMENT_MEAN.FirstOrDefaultAsync(n => n.PAYMENT_MEAN_ID == id);
            _db.Remove(paymentMean);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
