// Controllers/PromotionTypeController.cs

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
    public class PromotionTypeController
    {
        private readonly MaarquestContext _db;

        public PromotionTypeController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.PROMOTION_TYPE.ToListAsync();

            List<PromotionType> result = PromotionTypeMapper.ConvertToPromotionTypeList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.PROMOTION_TYPE.FirstOrDefaultAsync(n => n.PROMOTION_TYPE_ID == id);

            PromotionType result = PromotionTypeMapper.ConvertToPromotionType(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PromotionType promotionType)
        {
            PROMOTION_TYPE data = PromotionTypeMapper.ConvertToPROMOTION_TYPE(promotionType);

            var res = _db.PROMOTION_TYPE.Add(data);
            await _db.SaveChangesAsync();

            PromotionType result = PromotionTypeMapper.ConvertToPromotionType(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PromotionType promotionType)
        {
            var existingPromotionType = await _db.PROMOTION_TYPE.FirstOrDefaultAsync(n => n.PROMOTION_TYPE_ID == id);
            existingPromotionType.OPERATION = (promotionType.Operation != null) ? promotionType.Operation : existingPromotionType.OPERATION;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var promotionType = await _db.PROMOTION_TYPE.FirstOrDefaultAsync(n => n.PROMOTION_TYPE_ID == id);
            _db.Remove(promotionType);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
