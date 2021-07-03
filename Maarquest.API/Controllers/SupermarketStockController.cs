// Controllers/SupermarketStockController.cs

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
    public class SupermarketStockController
    {
        private readonly MaarquestContext _db;

        public SupermarketStockController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPERMARKET_STOCK.ToListAsync();

            List<SupermarketStock> result = SupermarketStockMapper.ConvertToSupermarketStockList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPERMARKET_STOCK.FirstOrDefaultAsync(n => n.SUPERMARKET_STOCK_ID == id);

            SupermarketStock result = SupermarketStockMapper.ConvertToSupermarketStock(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupermarketStock supermarketStock)
        {
            SUPERMARKET_STOCK data = SupermarketStockMapper.ConvertToSUPERMARKET_STOCK(supermarketStock);

            var res = _db.SUPERMARKET_STOCK.Add(data);
            await _db.SaveChangesAsync();

            SupermarketStock result = SupermarketStockMapper.ConvertToSupermarketStock(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupermarketStock supermarketStock)
        {
            var existingSupermarketStock = await _db.SUPERMARKET_STOCK.FirstOrDefaultAsync(n => n.SUPERMARKET_STOCK_ID == id);
            existingSupermarketStock.SUPERMARKET_ID = (supermarketStock.SupermarketId > 0) ? supermarketStock.SupermarketId : existingSupermarketStock.SUPERMARKET_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supermarketStock = await _db.SUPERMARKET_STOCK.FirstOrDefaultAsync(n => n.SUPERMARKET_STOCK_ID == id);
            _db.Remove(supermarketStock);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
