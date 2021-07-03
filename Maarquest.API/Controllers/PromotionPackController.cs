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
    public class PromotionPackController : ControllerBase
    {
        private IPromotionPackService _adressService;
        private ILogger<PromotionPackController> _logger;

        public PromotionPackController(IPromotionPackService promotionPackService, ILogger<PromotionPackController> logger)
        {
            _adressService = promotionPackService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de packs de promotion
        ///	</summary>
        /// <returns>Liste de packs de promotion</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<PromotionPack>> GetAll()
        {
            List<PromotionPack> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.GetAll();
            watch.Stop();

            _logger.LogInformation("PromotionPack/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un pack de promotion en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du pack de promotion</param>
        /// <returns>Le pack de promotion</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<PromotionPack> Get(int id)
        {
            PromotionPack result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Get(id);
            watch.Stop();

            _logger.LogInformation("PromotionPack/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création du pack de promotion
        ///	</summary>
        ///	<param name="promotionPack">Pack de promotion</param>
        /// <returns>Le pack de promotion créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<PromotionPack> Add(PromotionPack promotionPack)
        {
            PromotionPack result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Add(promotionPack);
            watch.Stop();

            _logger.LogInformation("PromotionPack/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un pack de promotion
        ///	</summary>
        ///	<param name="promotionPack">Pack de promotion</param>
        /// <returns>Le pack de promotion modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<PromotionPack> Update(PromotionPack promotionPack)
        {
            PromotionPack result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Update(promotionPack);
            watch.Stop();

            _logger.LogInformation("PromotionPack/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime un pack de promotion
        ///	</summary>
        ///	<param name="id">Identifiant du pack de promotion</param>
        /// <returns>1 si le pack de promotion est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Delete(id);
            watch.Stop();

            _logger.LogInformation("PromotionPack/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
