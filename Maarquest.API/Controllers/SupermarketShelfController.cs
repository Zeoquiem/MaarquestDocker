// Controllers/SupermarketShelfController.cs

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
    public class SupermarketShelfController
    {
        private readonly MaarquestContext _db;

        public SupermarketShelfController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPERMARKET_SHELF.ToListAsync();

            List<SupermarketShelf> result = SupermarketShelfMapper.ConvertToSupermarketShelfList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPERMARKET_SHELF.FirstOrDefaultAsync(n => n.SUPERMARKET_SHELF_ID == id);

            SupermarketShelf result = SupermarketShelfMapper.ConvertToSupermarketShelf(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupermarketShelf supermarketShelf)
        {
            SUPERMARKET_SHELF data = SupermarketShelfMapper.ConvertToSUPERMARKET_SHELF(supermarketShelf);

            var res = _db.SUPERMARKET_SHELF.Add(data);
            await _db.SaveChangesAsync();

            SupermarketShelf result = SupermarketShelfMapper.ConvertToSupermarketShelf(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupermarketShelf supermarketShelf)
        {
            var existingSupermarketShelf = await _db.SUPERMARKET_SHELF.FirstOrDefaultAsync(n => n.SUPERMARKET_SHELF_ID == id);
            existingSupermarketShelf.SUPERMARKET_ID = (supermarketShelf.SupermarketId > 0) ? supermarketShelf.SupermarketId : existingSupermarketShelf.SUPERMARKET_ID;
            existingSupermarketShelf.PRODUCT_CATEGORY_ID = (supermarketShelf.ProductCategoryId > 0) ? supermarketShelf.ProductCategoryId : existingSupermarketShelf.PRODUCT_CATEGORY_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supermarketShelf = await _db.SUPERMARKET_SHELF.FirstOrDefaultAsync(n => n.SUPERMARKET_SHELF_ID == id);
            _db.Remove(supermarketShelf);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
