using Maarquest.Logic.Interfaces;
using Maarquest.Logic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maarquest.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private IRecommendationService _recommandationService;
        private ILogger<RecommendationController> _logger;

        public RecommendationController(IRecommendationService RecommendationService, ILogger<RecommendationController> logger)
        {
           _recommandationService = RecommendationService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de recommandations
        ///	</summary>
        /// <returns>Liste de recommandations</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<Recommendation>> GetAll()
        {
            List<Recommendation> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _recommandationService.GetAll();
            watch.Stop();

            _logger.LogInformation("Recommendation/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une recommandation en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant de la recommandation</param>
        /// <returns>La recommandation</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<Recommendation> Get(int id)
        {
            Recommendation result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _recommandationService.Get(id);
            watch.Stop();

            _logger.LogInformation("Recommendation/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'une recommandation
        ///	</summary>
        ///	<param name="recommendation">recommandation</param>
        /// <returns>La recommandation a été créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<Recommendation> Add(Recommendation recommendation)
        {
            Recommendation result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _recommandationService.Add(recommendation);
            watch.Stop();

            _logger.LogInformation("Recommendation/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une recommandation
        ///	</summary>
        ///	<param name="recommendation">recommandation</param>
        /// <returns>La recommandation a été modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<Recommendation> Update(Recommendation recommendation)
        {
            Recommendation result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _recommandationService.Update(recommendation);
            watch.Stop();

            _logger.LogInformation("Recommendation/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de recommandations
        ///	</summary>
        ///	<param name="id">Identifiant de la recommandation</param>
        /// <returns>1 si la recommandation est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _recommandationService.Delete(id);
            watch.Stop();

            _logger.LogInformation("Recommendation/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
