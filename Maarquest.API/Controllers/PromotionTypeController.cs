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
    public class PromotionTypeController : ControllerBase
    {
        private IPromotionTypeService _adressService;
        private ILogger<PromotionTypeController> _logger;

        public PromotionTypeController(IPromotionTypeService promotionTypeService, ILogger<PromotionTypeController> logger)
        {
            _adressService = promotionTypeService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de types de promotion
        ///	</summary>
        /// <returns>Liste de types de promotion</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<PromotionType>> GetAll()
        {
            List<PromotionType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.GetAll();
            watch.Stop();

            _logger.LogInformation("PromotionType/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un type de promotion en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du type de promotion</param>
        /// <returns>Le type de promotion</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<PromotionType> Get(int id)
        {
            PromotionType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Get(id);
            watch.Stop();

            _logger.LogInformation("PromotionType/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création du type de promotion
        ///	</summary>
        ///	<param name="promotionType">Type de promotion</param>
        /// <returns>Le type de promotion créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<PromotionType> Add(PromotionType promotionType)
        {
            PromotionType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Add(promotionType);
            watch.Stop();

            _logger.LogInformation("PromotionType/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un type de promotion
        ///	</summary>
        ///	<param name="promotionType">Type de promotion</param>
        /// <returns>Le type de promotion modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<PromotionType> Update(PromotionType promotionType)
        {
            PromotionType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Update(promotionType);
            watch.Stop();

            _logger.LogInformation("PromotionType/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime un type de promotion
        ///	</summary>
        ///	<param name="id">Identifiant du type de promotion</param>
        /// <returns>1 si le type de promotion est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Delete(id);
            watch.Stop();

            _logger.LogInformation("PromotionType/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
