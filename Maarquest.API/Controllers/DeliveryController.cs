// Controllers/DeliveryController.cs

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
    public class DeliveryController
    {
        private readonly MaarquestContext _db;

        public DeliveryController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.DELIVERY.ToListAsync();

            List<Delivery> result = DeliveryMapper.ConvertToDeliveryList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.DELIVERY.FirstOrDefaultAsync(n => n.DELIVERY_ID == id);

            Delivery result = DeliveryMapper.ConvertToDelivery(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Delivery delivery)
        {
            DELIVERY data = DeliveryMapper.ConvertToDELIVERY(delivery);

            var res = _db.DELIVERY.Add(data);
            await _db.SaveChangesAsync();

            Delivery result = DeliveryMapper.ConvertToDelivery(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Delivery delivery)
        {
            var existingDelivery = await _db.DELIVERY.FirstOrDefaultAsync(n => n.DELIVERY_ID == id);
            existingDelivery.SUPPLIER_ID = (delivery.SupplierId < 0) ? delivery.SupplierId : existingDelivery.SUPPLIER_ID;
            existingDelivery.SUPERMARKET_ID = (delivery.SupermarketId < 0) ? delivery.SupermarketId : existingDelivery.SUPERMARKET_ID;
            existingDelivery.ORDER_ID = (delivery.OrderId < 0) ? delivery.OrderId : existingDelivery.ORDER_ID;
            existingDelivery.TRANSPORT_MEAN_ID = (delivery.TransportMeanId < 0) ? delivery.TransportMeanId : existingDelivery.TRANSPORT_MEAN_ID;
            existingDelivery.DATE = (delivery.Date != null) ? delivery.Date : existingDelivery.DATE;
            existingDelivery.IS_LEFT = (delivery.IsLeft != null) ? delivery.IsLeft : existingDelivery.IS_LEFT;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var delivery = await _db.DELIVERY.FirstOrDefaultAsync(n => n.DELIVERY_ID == id);
            _db.Remove(delivery);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
