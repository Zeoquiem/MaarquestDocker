// Controllers/OrderController.cs

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
    public class OrderController
    {
        private readonly MaarquestContext _db;

        public OrderController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.ORDER.ToListAsync();

            List<Order> result = OrderMapper.ConvertToOrderList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.ORDER.FirstOrDefaultAsync(n => n.ORDER_ID == id);

            Order result = OrderMapper.ConvertToOrder(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Order order)
        {
            ORDER data = OrderMapper.ConvertToORDER(order);

            var res = _db.ORDER.Add(data);
            await _db.SaveChangesAsync();

            Order result = OrderMapper.ConvertToOrder(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Order order)
        {
            var existingOrder = await _db.ORDER.FirstOrDefaultAsync(n => n.ORDER_ID == id);
            existingOrder.SUPPLIER_ID = (order.SupplierId < 0) ? order.SupplierId : existingOrder.SUPPLIER_ID;
            existingOrder.SUPERMARKET_ID = (order.SupermarketId < 0) ? order.SupermarketId : existingOrder.SUPERMARKET_ID;
            existingOrder.DATE = (order.Date != null) ? order.Date : existingOrder.DATE;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var order = await _db.ORDER.FirstOrDefaultAsync(n => n.ORDER_ID == id);
            _db.Remove(order);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
