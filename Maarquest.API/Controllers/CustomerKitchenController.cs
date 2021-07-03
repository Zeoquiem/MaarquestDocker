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
    public class CustomerKitchenController : ControllerBase
    {
        private ICustomerKitchenService _customerKitchenService;
        private ILogger<CustomerKitchenController> _logger;

        public CustomerKitchenController(ICustomerKitchenService customerKitchenService, ILogger<CustomerKitchenController> logger)
        {
            _customerKitchenService = customerKitchenService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de cuisines de consommateur
        ///	</summary>
        /// <returns>Liste de cuisines de consommateur</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<CustomerKitchen>> GetAll()
        {
            List<CustomerKitchen> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.GetAll();
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de cuisines d'un consommateur
        ///	</summary>
        ///	<param name="id">Identifiant du consommateur</param>
        /// <returns>Liste de cuisines d'un consommateur</returns>
        [Route("GetAllFromCustomer/{id}")]
        [HttpGet]
        public async Task<List<CustomerKitchen>> GetAllFromCustomer(int id)
        {
            List<CustomerKitchen> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.GetAllFromCustomer(id);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/GetAllFromCustomer/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de cuisines d'un produit
        ///	</summary>
        ///	<param name="id">Identifiant du produit</param>
        /// <returns>Liste de cuisines d'un produit</returns>
        [Route("GetAllFromProduct/{id}")]
        [HttpGet]
        public async Task<List<CustomerKitchen>> GetAllFromProduct(int id)
        {
            List<CustomerKitchen> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.GetAllFromProduct(id);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/GetAllFromProduct/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une cuisine de consommateur en fonction de son id
        ///	</summary>
        ///	<param name="customerId">Identifiant du consommateur</param>
        ///	<param name="productId">Identifiant du produit</param>
        /// <returns>La cuisine de consommateur</returns>
        [Route("Get")]
        [HttpGet]
        public async Task<CustomerKitchen> Get(int customerId, int productId)
        {
            CustomerKitchen result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.Get(customerId, productId);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/Get?customerId=" + customerId + "productId=" + productId + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'une cuisine de consommateur
        ///	</summary>
        ///	<param name="customerKitchen">Cuisine de consommateur</param>
        /// <returns>La cuisine de consommateur créée</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<CustomerKitchen> Add(CustomerKitchen customerKitchen)
        {
            CustomerKitchen result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.Add(customerKitchen);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une cuisine de consommateur
        ///	</summary>
        ///	<param name="customerKitchen">Cuisine de consommateur</param>
        ///	<param name="newCustomerId">Nouvel id du consommatteur</param>
        /// <returns>La cuisine de consommateur modifiée</returns>
        [Route("UpdateCustomer")]
        [HttpPut]
        public async Task<CustomerKitchen> UpdateCustomer(CustomerKitchen customerKitchen, int newCustomerId)
        {
            CustomerKitchen result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.UpdateCustomer(customerKitchen, newCustomerId);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/UpdateCustomer/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une cuisine de consommateur
        ///	</summary>
        ///	<param name="customerKitchen">Cuisine de consommateur</param>
        ///	<param name="newProductId">Nouvel id du produit</param>
        /// <returns>La cuisine de consommateur modifiée</returns>
        [Route("UpdateProduct")]
        [HttpPut]
        public async Task<CustomerKitchen> UpdateProduct(CustomerKitchen customerKitchen, int newProductId)
        {
            CustomerKitchen result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.UpdateProduct(customerKitchen, newProductId);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/UpdateProduct/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une cuisine de consommateur
        ///	</summary>
        ///	<param name="customerId">Identifiant du consommateur</param>
        ///	<param name="productId">Identifiant du produit</param>
        /// <returns>1 si la cuisine de consommateur est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int customerId, int productId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.Delete(customerId, productId);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/Delete?customerId=" + customerId + "productId=" + productId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une cuisine de consommateur
        ///	</summary>
        ///	<param name="customerId">Identifiant du consommateur</param>
        /// <returns>1 si la cuisine de consommateur est supprimée</returns>
        [Route("DeleteAllFromCustomer")]
        [HttpDelete]
        public async Task<int> DeleteAllFromCustomer(int customerId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.DeleteAllFromCustomer(customerId);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/DeleteAllFromCustomer?customerId=" + customerId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une cuisine de consommateur
        ///	</summary>
        ///	<param name="productId">Identifiant du produit</param>
        /// <returns>1 si la cuisine de consommateur est supprimée</returns>
        [Route("DeleteAllFromProduct")]
        [HttpDelete]
        public async Task<int> DeleteAllFromProduct(int productId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _customerKitchenService.DeleteAllFromProduct(productId);
            watch.Stop();

            _logger.LogInformation("CustomerKitchen/DeleteAllFromProduct?productId=" + productId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
