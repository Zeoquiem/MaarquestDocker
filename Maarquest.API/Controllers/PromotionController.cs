// Controllers/PromotionController.cs

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
    public class PromotionController
    {
        private readonly MaarquestContext _db;

        public PromotionController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PROMOTION.ToListAsync();

            List<Promotion> result = PromotionMapper.ConvertToPromotionList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PROMOTION.FirstOrDefaultAsync(n => n.PROMOTION_ID == id);

            Promotion result = PromotionMapper.ConvertToPromotion(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Promotion promotion)
        {
            PROMOTION data = PromotionMapper.ConvertToPROMOTION(promotion);

            var res = _db.PROMOTION.Add(data);
            await _db.SaveChangesAsync();

            Promotion result = PromotionMapper.ConvertToPromotion(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Promotion promotion)
        {
            var existingPromotion = await _db.PROMOTION.FirstOrDefaultAsync(n => n.PROMOTION_ID == id);
            existingPromotion.PROMOTION_PACK_ID = (promotion.PromotionPackId > 0) ? promotion.PromotionPackId : existingPromotion.PROMOTION_PACK_ID;
            existingPromotion.PROMOTION_TYPE_ID = (promotion.PromotionTypeId > 0) ? promotion.PromotionTypeId : existingPromotion.PROMOTION_TYPE_ID;
            existingPromotion.PRODUCT_TYPE_ID = (promotion.ProductTypeId > 0) ? promotion.ProductTypeId : existingPromotion.PRODUCT_TYPE_ID;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var promotion = await _db.PROMOTION.FirstOrDefaultAsync(n => n.PROMOTION_ID == id);
            _db.Remove(promotion);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
