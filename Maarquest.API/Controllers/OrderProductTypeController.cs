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
    public class OrderProductTypeController : ControllerBase
    {
        private IOrderProductTypeService _orderProductTypeService;
        private ILogger<OrderProductTypeController> _logger;

        public OrderProductTypeController(IOrderProductTypeService orderProductTypeService, ILogger<OrderProductTypeController> logger)
        {
            _orderProductTypeService = orderProductTypeService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de commandes de produits types
        ///	</summary>
        /// <returns>Liste de commandes de produits types</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<OrderProductType>> GetAll()
        {
            List<OrderProductType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.GetAll();
            watch.Stop();

            _logger.LogInformation("OrderProductType/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de produits d'une commande
        ///	</summary>
        ///	<param name="id">Identifiant d'une commande</param>
        /// <returns>Liste de produits types d'une commande</returns>
        [Route("GetAllFromOrder/{id}")]
        [HttpGet]
        public async Task<List<OrderProductType>> GetAllFromOrder(int id)
        {
            List<OrderProductType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.GetAllFromOrder(id);
            watch.Stop();

            _logger.LogInformation("OrderProductType/GetAllFromOrder/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de commandes de produits types
        ///	</summary>
        ///	<param name="id">Identifiant du produit type</param>
        /// <returns>Liste de commandes de produits types</returns>
        [Route("GetAllFromProductType/{id}")]
        [HttpGet]
        public async Task<List<OrderProductType>> GetAllFromProductType(int id)
        {
            List<OrderProductType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.GetAllFromProductType(id);
            watch.Stop();

            _logger.LogInformation("OrderProductType/GetAllFromProductType/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une commande de produits types en fonction de son id
        ///	</summary>
        ///	<param name="orderId">Identifiant du commande</param>
        ///	<param name="productTypeId">Identifiant du produit type</param>
        /// <returns>La commande de produits types</returns>
        [Route("Get")]
        [HttpGet]
        public async Task<OrderProductType> Get(int orderId, int productTypeId)
        {
            OrderProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.Get(orderId, productTypeId);
            watch.Stop();

            _logger.LogInformation("OrderProductType/Get?orderId=" + orderId + "productTypeId=" + productTypeId + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'une commande de produits types
        ///	</summary>
        ///	<param name="orderProductType">Cuisine de commande</param>
        /// <returns>La commande de produits types créée</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<OrderProductType> Add(OrderProductType orderProductType)
        {
            OrderProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.Add(orderProductType);
            watch.Stop();

            _logger.LogInformation("OrderProductType/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une commande de produits types
        ///	</summary>
        ///	<param name="orderProductType">Livraison de produits types</param>
        ///	<param name="newOrderId">Nouvel id d'une commande</param>
        /// <returns>La commande de produits types modifiée</returns>
        [Route("UpdateOrder")]
        [HttpPut]
        public async Task<OrderProductType> UpdateOrder(OrderProductType orderProductType, int newOrderId)
        {
            OrderProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.UpdateOrder(orderProductType, newOrderId);
            watch.Stop();

            _logger.LogInformation("OrderProductType/UpdateOrder/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une commande de produits types
        ///	</summary>
        ///	<param name="orderProductType">Livraison de produits types</param>
        ///	<param name="newProductTypeId">Nouvel id du produit type</param>
        /// <returns>La commande de produits types modifiée</returns>
        [Route("UpdateProduct")]
        [HttpPut]
        public async Task<OrderProductType> UpdateProduct(OrderProductType orderProductType, int newProductTypeId)
        {
            OrderProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.UpdateProductType(orderProductType, newProductTypeId);
            watch.Stop();

            _logger.LogInformation("OrderProductType/UpdateProductType/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une commande de produits types
        ///	</summary>
        ///	<param name="orderId">Identifiant de la commande</param>
        ///	<param name="productTypeId">Identifiant du produit type</param>
        /// <returns>1 si la commande de produits types est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int orderId, int productTypeId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.Delete(orderId, productTypeId);
            watch.Stop();

            _logger.LogInformation("OrderProductType/Delete?orderId=" + orderId + "productTypeId=" + productTypeId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des commandes de produits types
        ///	</summary>
        ///	<param name="orderId">Identifiant de la commande</param>
        /// <returns>1 si les commandes de produits types sont supprimées</returns>
        [Route("DeleteAllFromOrder")]
        [HttpDelete]
        public async Task<int> DeleteAllFromOrder(int orderId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.DeleteAllFromOrder(orderId);
            watch.Stop();

            _logger.LogInformation("OrderProductType/DeleteAllFromOrder?orderId=" + orderId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des commandes de produits types
        ///	</summary>
        ///	<param name="productTypeId">Identifiant du produit type</param>
        /// <returns>1 si les commandes de produits types sont supprimées</returns>
        [Route("DeleteAllFromProductType")]
        [HttpDelete]
        public async Task<int> DeleteAllFromProduct(int productTypeId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _orderProductTypeService.DeleteAllFromProductType(productTypeId);
            watch.Stop();

            _logger.LogInformation("OrderProductType/DeleteAllFromProduct?productTypeId=" + productTypeId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
