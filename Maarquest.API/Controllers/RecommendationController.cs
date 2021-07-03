// Controllers/RecommendationController.cs

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
    public class RecommendationController
    {
        private readonly MaarquestContext _db;

        public RecommendationController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.RECOMMENDATION.ToListAsync();

            List<Recommendation> result = RecommendationMapper.ConvertToRecommendationList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.RECOMMENDATION.FirstOrDefaultAsync(n => n.RECOMMENDATION_ID == id);

            Recommendation result = RecommendationMapper.ConvertToRecommendation(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Recommendation recommendation)
        {
            RECOMMENDATION data = RecommendationMapper.ConvertToRECOMMENDATION(recommendation);

            var res = _db.RECOMMENDATION.Add(data);
            await _db.SaveChangesAsync();

            Recommendation result = RecommendationMapper.ConvertToRecommendation(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Recommendation recommendation)
        {
            var existingRecommendation = await _db.RECOMMENDATION.FirstOrDefaultAsync(n => n.RECOMMENDATION_ID == id);
             existingRecommendation.CUSTOMER_ID = (recommendation.CustomerId != null) ? recommendation.CustomerId : existingRecommendation.CUSTOMER_ID;
            existingRecommendation.PRODUCT_CATEGORY_ID = (recommendation.ProductCategoryId > 0) ? recommendation.ProductCategoryId : existingRecommendation.PRODUCT_CATEGORY_ID;
            existingRecommendation.LABEL = (recommendation.Label != null) ? recommendation.Label : existingRecommendation.LABEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var recommendation = await _db.RECOMMENDATION.FirstOrDefaultAsync(n => n.RECOMMENDATION_ID == id);
            _db.Remove(recommendation);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
