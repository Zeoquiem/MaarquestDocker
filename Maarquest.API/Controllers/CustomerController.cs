// Controllers/CustomerController.cs

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
    public class CustomerController
    {
        private readonly MaarquestContext _db;

        public CustomerController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.CUSTOMER.ToListAsync();

            List<Customer> result = CustomerMapper.ConvertToCustomerList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.CUSTOMER.FirstOrDefaultAsync(n => n.CUSTOMER_ID == id);

            Customer result = CustomerMapper.ConvertToCustomer(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            CUSTOMER data = CustomerMapper.ConvertToCUSTOMER(customer);

            var res = _db.CUSTOMER.Add(data);
            await _db.SaveChangesAsync();

            Customer result = CustomerMapper.ConvertToCustomer(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Customer customer)
        {
            var existingCustomer = await _db.CUSTOMER.FirstOrDefaultAsync(n => n.CUSTOMER_ID == id);
            existingCustomer.ADDRESS_ID = (customer.AddressId != null) ? customer.AddressId : existingCustomer.ADDRESS_ID;
            existingCustomer.FIRSTNAME = (customer.FirstName != null) ? customer.FirstName : existingCustomer.FIRSTNAME;
            existingCustomer.LASTNAME = (customer.LastName != null) ? customer.LastName : existingCustomer.LASTNAME;
            existingCustomer.USERNAME = (customer.UserName != null) ? customer.UserName : existingCustomer.USERNAME;
            existingCustomer.MAIL = (customer.Mail != null) ? customer.Mail : existingCustomer.MAIL;
            existingCustomer.PASSWORD = (customer.Password != null) ? customer.Password : existingCustomer.PASSWORD;
            existingCustomer.BIRTHDATE = (customer.Birthdate != null) ? customer.Birthdate : existingCustomer.BIRTHDATE;
            existingCustomer.GENDER = (customer.Gender != null) ? customer.Gender : existingCustomer.GENDER;
            existingCustomer.TEL = (customer.Tel != null) ? customer.Tel : existingCustomer.TEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _db.CUSTOMER.FirstOrDefaultAsync(n => n.CUSTOMER_ID == id);
            _db.Remove(customer);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
