// Controllers/PaypalController.cs

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
    public class PaypalController
    {
        private readonly MaarquestContext _db;

        public PaypalController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PAYPAL.ToListAsync();

            List<Paypal> result = PaypalMapper.ConvertToPaypalList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PAYPAL.FirstOrDefaultAsync(n => n.PAYPAL_ID == id);

            Paypal result = PaypalMapper.ConvertToPaypal(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Paypal paypal)
        {
            PAYPAL data = PaypalMapper.ConvertToPAYPAL(paypal);

            var res = _db.PAYPAL.Add(data);
            await _db.SaveChangesAsync();

            Paypal result = PaypalMapper.ConvertToPaypal(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Paypal paypal)
        {
            var existingPaypal = await _db.PAYPAL.FirstOrDefaultAsync(n => n.PAYPAL_ID == id);
            existingPaypal.IS_CONNECTED = (paypal.IsConnected != null) ? paypal.IsConnected : existingPaypal.IS_CONNECTED;
            existingPaypal.IDENTIFIANT_PAYPAL = (paypal.IdentifiantPaypal != null) ? paypal.IdentifiantPaypal : existingPaypal.IDENTIFIANT_PAYPAL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var paypal = await _db.PAYPAL.FirstOrDefaultAsync(n => n.PAYPAL_ID == id);
            _db.Remove(paypal);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
