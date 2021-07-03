// Controllers/AddressController.cs

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
    public class AddressController
    {
        private readonly MaarquestContext _db;

        public AddressController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.ADDRESS.ToListAsync();

            List<Address> result = AddressMapper.ConvertToAddressList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.ADDRESS.FirstOrDefaultAsync(n => n.ADDRESS_ID == id);

            Address result = AddressMapper.ConvertToAddress(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Address address)
        {
            ADDRESS data = AddressMapper.ConvertToADDRESS(address);

            var res = _db.ADDRESS.Add(data);
            await _db.SaveChangesAsync();

            Address result = AddressMapper.ConvertToAddress(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Address address)
        {
            var existingAddress = await _db.ADDRESS.FirstOrDefaultAsync(n => n.ADDRESS_ID == id);
            existingAddress.RECEIVER = (address.Receiver != null) ? address.Receiver : existingAddress.RECEIVER;
            existingAddress.LIGN_ONE = (address.LignOne != null) ? address.LignOne : existingAddress.LIGN_ONE;
            existingAddress.LIGN_TWO = (address.LignTwo != null) ? address.LignTwo : existingAddress.LIGN_TWO;
            existingAddress.POSTCODE = (address.PostCode != null) ? address.PostCode : existingAddress.POSTCODE;
            existingAddress.CITY = (address.City != null) ? address.City : existingAddress.CITY;
            existingAddress.REGION = (address.Region != null) ? address.Region : existingAddress.REGION;
            existingAddress.COUNTRY = (address.Country != null) ? address.Country : existingAddress.COUNTRY;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var address = await _db.ADDRESS.FirstOrDefaultAsync(n => n.ADDRESS_ID == id);
            _db.Remove(address);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
