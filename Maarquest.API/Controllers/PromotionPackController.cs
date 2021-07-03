// Controllers/PromotionPackController.cs

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
    public class PromotionPackController
    {
        private readonly MaarquestContext _db;

        public PromotionPackController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PROMOTION_PACK.ToListAsync();

            List<PromotionPack> result = PromotionPackMapper.ConvertToPromotionPackList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PROMOTION_PACK.FirstOrDefaultAsync(n => n.PROMOTION_PACK_ID == id);

            PromotionPack result = PromotionPackMapper.ConvertToPromotionPack(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PromotionPack promotionPack)
        {
            PROMOTION_PACK data = PromotionPackMapper.ConvertToPROMOTION_PACK(promotionPack);

            var res = _db.PROMOTION_PACK.Add(data);
            await _db.SaveChangesAsync();

            PromotionPack result = PromotionPackMapper.ConvertToPromotionPack(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PromotionPack promotionPack)
        {
            var existingPromotionPack = await _db.PROMOTION_PACK.FirstOrDefaultAsync(n => n.PROMOTION_PACK_ID == id);
            existingPromotionPack.LABEL = (promotionPack.Label != null) ? promotionPack.Label : existingPromotionPack.LABEL;
            existingPromotionPack.PRODUCT_CATEGORY_ID = (promotionPack.ProductCategoryId > 0) ? promotionPack.ProductCategoryId : existingPromotionPack.PRODUCT_CATEGORY_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var promotionPack = await _db.PROMOTION_PACK.FirstOrDefaultAsync(n => n.PROMOTION_PACK_ID == id);
            _db.Remove(promotionPack);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
