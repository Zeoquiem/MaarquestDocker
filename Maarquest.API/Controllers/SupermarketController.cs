// Controllers/SupermarketController.cs

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
    public class SupermarketController
    {
        private readonly MaarquestContext _db;

        public SupermarketController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPERMARKET.ToListAsync();

            List<Supermarket> result = SupermarketMapper.ConvertToSupermarketList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPERMARKET.FirstOrDefaultAsync(n => n.SUPERMARKET_ID == id);

            Supermarket result = SupermarketMapper.ConvertToSupermarket(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Supermarket Supermarket)
        {
            SUPERMARKET data = SupermarketMapper.ConvertToSUPERMARKET(Supermarket);

            var res = _db.SUPERMARKET.Add(data);
            await _db.SaveChangesAsync();

            Supermarket result = SupermarketMapper.ConvertToSupermarket(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Supermarket supermarket)
        {
            var existingSupermarket = await _db.SUPERMARKET.FirstOrDefaultAsync(n => n.SUPERMARKET_ID == id);
            existingSupermarket.ADDRESS_ID = (supermarket.AddressId != null) ? supermarket.AddressId : existingSupermarket.ADDRESS_ID;
            existingSupermarket.TEL = (supermarket.Tel > 0) ? supermarket.Tel : existingSupermarket.TEL;
            existingSupermarket.FAX = (supermarket.Fax > 0) ? supermarket.Fax : existingSupermarket.FAX;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supermarket = await _db.SUPERMARKET.FirstOrDefaultAsync(n => n.SUPERMARKET_ID == id);
            _db.Remove(supermarket);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
