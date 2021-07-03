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
    public class DeliveryProductController : ControllerBase
    {
        private IDeliveryProductService _deliveryProductService;
        private ILogger<DeliveryProductController> _logger;

        public DeliveryProductController(IDeliveryProductService deliveryProductService, ILogger<DeliveryProductController> logger)
        {
            _deliveryProductService = deliveryProductService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de livraisons de produits
        ///	</summary>
        /// <returns>Liste de livraisons de produits</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<DeliveryProduct>> GetAll()
        {
            List<DeliveryProduct> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.GetAll();
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de produits d'une livraison
        ///	</summary>
        ///	<param name="id">Identifiant d'une livraison</param>
        /// <returns>Liste de produits d'une livraison</returns>
        [Route("GetAllFromDelivery/{id}")]
        [HttpGet]
        public async Task<List<DeliveryProduct>> GetAllFromDelivery(int id)
        {
            List<DeliveryProduct> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.GetAllFromDelivery(id);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/GetAllFromDelivery/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de livraisons d'un produit
        ///	</summary>
        ///	<param name="id">Identifiant du produit</param>
        /// <returns>Liste de livraisons d'un produit</returns>
        [Route("GetAllFromProduct/{id}")]
        [HttpGet]
        public async Task<List<DeliveryProduct>> GetAllFromProduct(int id)
        {
            List<DeliveryProduct> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.GetAllFromProduct(id);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/GetAllFromProduct/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une livraison de produits en fonction de son id
        ///	</summary>
        ///	<param name="deliveryId">Identifiant du livraison</param>
        ///	<param name="productId">Identifiant du produit</param>
        /// <returns>La livraison de produits</returns>
        [Route("Get")]
        [HttpGet]
        public async Task<DeliveryProduct> Get(int deliveryId, int productId)
        {
            DeliveryProduct result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.Get(deliveryId, productId);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/Get?deliveryId=" + deliveryId + "productId=" + productId + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'une livraison de produits
        ///	</summary>
        ///	<param name="deliveryProduct">Cuisine de livraison</param>
        /// <returns>La livraison de produits créée</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<DeliveryProduct> Add(DeliveryProduct deliveryProduct)
        {
            DeliveryProduct result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.Add(deliveryProduct);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une livraison de produits
        ///	</summary>
        ///	<param name="deliveryProduct">Livraison de produits</param>
        ///	<param name="newDeliveryId">Nouvel id d'une livraison</param>
        /// <returns>La livraison de produits modifiée</returns>
        [Route("UpdateDelivery")]
        [HttpPut]
        public async Task<DeliveryProduct> UpdateDelivery(DeliveryProduct deliveryProduct, int newDeliveryId)
        {
            DeliveryProduct result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.UpdateDelivery(deliveryProduct, newDeliveryId);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/UpdateDelivery/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une livraison de produits
        ///	</summary>
        ///	<param name="deliveryProduct">Livraison de produits</param>
        ///	<param name="newProductId">Nouvel id du produit</param>
        /// <returns>La livraison de produits modifiée</returns>
        [Route("UpdateProduct")]
        [HttpPut]
        public async Task<DeliveryProduct> UpdateProduct(DeliveryProduct deliveryProduct, int newProductId)
        {
            DeliveryProduct result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.UpdateProduct(deliveryProduct, newProductId);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/UpdateProduct/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une livraison de produits
        ///	</summary>
        ///	<param name="deliveryId">Identifiant de la livraison</param>
        ///	<param name="productId">Identifiant du produit</param>
        /// <returns>1 si la livraison de produits est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int deliveryId, int productId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.Delete(deliveryId, productId);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/Delete?deliveryId=" + deliveryId + "productId=" + productId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des livraisons de produits
        ///	</summary>
        ///	<param name="deliveryId">Identifiant de la livraison</param>
        /// <returns>1 si les livraisons de produits sont supprimées</returns>
        [Route("DeleteAllFromDelivery")]
        [HttpDelete]
        public async Task<int> DeleteAllFromDelivery(int deliveryId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.DeleteAllFromDelivery(deliveryId);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/DeleteAllFromDelivery?deliveryId=" + deliveryId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des livraisons de produits
        ///	</summary>
        ///	<param name="productId">Identifiant du produit</param>
        /// <returns>1 si les livraisons de produits sont supprimées</returns>
        [Route("DeleteAllFromProduct")]
        [HttpDelete]
        public async Task<int> DeleteAllFromProduct(int productId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _deliveryProductService.DeleteAllFromProduct(productId);
            watch.Stop();

            _logger.LogInformation("DeliveryProduct/DeleteAllFromProduct?productId=" + productId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
