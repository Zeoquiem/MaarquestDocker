// Controllers/AddressController.cs

using Maarquest.API;
using Maarquest.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DockerSqlServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController
    {
        private readonly AppDbContext _db;

        public AddressController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var addresses = await _db.Addresses.ToListAsync();

            return new JsonResult(addresses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var address = await _db.Addresses.FirstOrDefaultAsync(n => n.Id == id);

            return new JsonResult(address);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Address address)
        {
            _db.Addresses.Add(address);
            await _db.SaveChangesAsync();

            return new JsonResult(address.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Address address)
        {
            var existingAddress = await _db.Addresses.FirstOrDefaultAsync(n => n.Id == id);
            existingAddress.Receiver = address.Receiver;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var address = await _db.Addresses.FirstOrDefaultAsync(n => n.Id == id);
            _db.Remove(address);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
