// Controllers/CustomerKitchenController.cs

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
    public class CustomerKitchenController
    {
        private readonly MaarquestContext _db;

        public CustomerKitchenController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.CUSTOMER_KITCHEN.ToListAsync();

            List<CustomerKitchen> result = CustomerKitchenMapper.ConvertToCustomerKitchenList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.CUSTOMER_KITCHEN.FirstOrDefaultAsync(n => n.CUSTOMER_KITCHEN_ID == id);

            CustomerKitchen result = CustomerKitchenMapper.ConvertToCustomerKitchen(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerKitchen customerKitchen)
        {
            CUSTOMER_KITCHEN data = CustomerKitchenMapper.ConvertToCUSTOMER_KITCHEN(customerKitchen);

            var res = _db.CUSTOMER_KITCHEN.Add(data);
            await _db.SaveChangesAsync();

            CustomerKitchen result = CustomerKitchenMapper.ConvertToCustomerKitchen(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, CustomerKitchen customerKitchen)
        {
            var existingCustomerKitchen = await _db.CUSTOMER_KITCHEN.FirstOrDefaultAsync(n => n.CUSTOMER_KITCHEN_ID == id);
            existingCustomerKitchen.CUSTOMER_KITCHEN_PACK_ID = (customerKitchen.CustomerKitchenPackId > 0) ? customerKitchen.CustomerKitchenPackId : existingCustomerKitchen.CUSTOMER_KITCHEN_PACK_ID;
            existingCustomerKitchen.CUSTOMER_KITCHEN_TYPE_ID = (customerKitchen.CustomerKitchenTypeId > 0) ? customerKitchen.CustomerKitchenTypeId : existingCustomerKitchen.CUSTOMER_KITCHEN_TYPE_ID;
            existingCustomerKitchen.PRODUCT_TYPE_ID = (customerKitchen.ProductTypeId > 0) ? customerKitchen.ProductTypeId : existingCustomerKitchen.PRODUCT_TYPE_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var customerKitchen = await _db.CUSTOMER_KITCHEN.FirstOrDefaultAsync(n => n.CUSTOMER_KITCHEN_ID == id);
            _db.Remove(customerKitchen);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
