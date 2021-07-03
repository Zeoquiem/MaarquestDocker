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
    public class PromotionCustomerController : ControllerBase
    {
        private IPromotionCustomerService _promotionCustomerService;
        private ILogger<PromotionCustomerController> _logger;

        public PromotionCustomerController(IPromotionCustomerService promotionCustomerService, ILogger<PromotionCustomerController> logger)
        {
            _promotionCustomerService = promotionCustomerService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de promotions de consommateurs
        ///	</summary>
        /// <returns>Liste de promotions de consommateurs</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<PromotionCustomer>> GetAll()
        {
            List<PromotionCustomer> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.GetAll();
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de promotion de consommateurs
        ///	</summary>
        ///	<param name="id">Identifiant d'une promotion</param>
        /// <returns>Liste de promotion de consommateurs</returns>
        [Route("GetAllFromPromotion/{id}")]
        [HttpGet]
        public async Task<List<PromotionCustomer>> GetAllFromPromotion(int id)
        {
            List<PromotionCustomer> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.GetAllFromPromotion(id);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/GetAllFromPromotion/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de promotions de consommateurs
        ///	</summary>
        ///	<param name="id">Identifiant du consommateur</param>
        /// <returns>Liste de promotions de consommateurs</returns>
        [Route("GetAllFromCustomer/{id}")]
        [HttpGet]
        public async Task<List<PromotionCustomer>> GetAllFromCustomer(int id)
        {
            List<PromotionCustomer> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.GetAllFromCustomer(id);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/GetAllFromCustomer/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une promotion de consommateurs en fonction de son id
        ///	</summary>
        ///	<param name="promotionId">Identifiant du promotion</param>
        ///	<param name="customerId">Identifiant du consommateur</param>
        /// <returns>La promotion de consommateurs</returns>
        [Route("Get")]
        [HttpGet]
        public async Task<PromotionCustomer> Get(int promotionId, int customerId)
        {
            PromotionCustomer result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.Get(promotionId, customerId);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/Get?promotionId=" + promotionId + "customerId=" + customerId + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'une promotion de consommateurs
        ///	</summary>
        ///	<param name="promotionCustomer">Cuisine de promotion</param>
        /// <returns>La promotion de consommateurs créée</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<PromotionCustomer> Add(PromotionCustomer promotionCustomer)
        {
            PromotionCustomer result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.Add(promotionCustomer);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une promotion de consommateurs
        ///	</summary>
        ///	<param name="promotionCustomer">Livraison de consommateurs</param>
        ///	<param name="newPromotionId">Nouvel id d'une promotion</param>
        /// <returns>La promotion de consommateurs modifiée</returns>
        [Route("UpdatePromotion")]
        [HttpPut]
        public async Task<PromotionCustomer> UpdatePromotion(PromotionCustomer promotionCustomer, int newPromotionId)
        {
            PromotionCustomer result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.UpdatePromotion(promotionCustomer, newPromotionId);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/UpdatePromotion/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une promotion de consommateurs
        ///	</summary>
        ///	<param name="promotionCustomer">Livraison de consommateurs</param>
        ///	<param name="newCustomerId">Nouvel id du consommateur</param>
        /// <returns>La promotion de consommateurs modifiée</returns>
        [Route("UpdateCustomer")]
        [HttpPut]
        public async Task<PromotionCustomer> UpdateCustomer(PromotionCustomer promotionCustomer, int newCustomerId)
        {
            PromotionCustomer result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.UpdateCustomer(promotionCustomer, newCustomerId);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/UpdateCustomer/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une promotion de consommateurs
        ///	</summary>
        ///	<param name="promotionId">Identifiant de la promotion</param>
        ///	<param name="customerId">Identifiant du consommateur</param>
        /// <returns>1 si la promotion de consommateurs est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int promotionId, int customerId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.Delete(promotionId, customerId);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/Delete?promotionId=" + promotionId + "customerId=" + customerId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des promotions de consommateurs
        ///	</summary>
        ///	<param name="promotionId">Identifiant de la promotion</param>
        /// <returns>1 si les promotions de consommateurs sont supprimées</returns>
        [Route("DeleteAllFromPromotion")]
        [HttpDelete]
        public async Task<int> DeleteAllFromPromotion(int promotionId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.DeleteAllFromPromotion(promotionId);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/DeleteAllFromPromotion?promotionId=" + promotionId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des promotions de consommateurs
        ///	</summary>
        ///	<param name="customerId">Identifiant du consommateur</param>
        /// <returns>1 si les promotions de consommateurs sont supprimées</returns>
        [Route("DeleteAllFromCustomer")]
        [HttpDelete]
        public async Task<int> DeleteAllFromCustomer(int customerId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _promotionCustomerService.DeleteAllFromCustomer(customerId);
            watch.Stop();

            _logger.LogInformation("PromotionCustomer/DeleteAllFromProduct?customerId=" + customerId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
