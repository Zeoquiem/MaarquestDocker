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
    public class ReceiptProductTypeController : ControllerBase
    {
        private IReceiptProductTypeService _receiptProductTypeService;
        private ILogger<ReceiptProductTypeController> _logger;

        public ReceiptProductTypeController(IReceiptProductTypeService receiptProductTypeService, ILogger<ReceiptProductTypeController> logger)
        {
            _receiptProductTypeService = receiptProductTypeService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de receipts de consommateurs
        ///	</summary>
        /// <returns>Liste de receipts de consommateurs</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<ReceiptProductType>> GetAll()
        {
            List<ReceiptProductType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.GetAll();
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de receipt de consommateurs
        ///	</summary>
        ///	<param name="id">Identifiant d'une receipt</param>
        /// <returns>Liste de receipt de consommateurs</returns>
        [Route("GetAllFromReceipt/{id}")]
        [HttpGet]
        public async Task<List<ReceiptProductType>> GetAllFromReceipt(int id)
        {
            List<ReceiptProductType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.GetAllFromReceipt(id);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/GetAllFromReceipt/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de receipts de consommateurs
        ///	</summary>
        ///	<param name="id">Identifiant du consommateur</param>
        /// <returns>Liste de receipts de consommateurs</returns>
        [Route("GetAllFromProductType/{id}")]
        [HttpGet]
        public async Task<List<ReceiptProductType>> GetAllFromProductType(int id)
        {
            List<ReceiptProductType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.GetAllFromProductType(id);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/GetAllFromProductType/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une receipt de consommateurs en fonction de son id
        ///	</summary>
        ///	<param name="receiptId">Identifiant du receipt</param>
        ///	<param name="productTypeId">Identifiant du consommateur</param>
        /// <returns>La receipt de consommateurs</returns>
        [Route("Get")]
        [HttpGet]
        public async Task<ReceiptProductType> Get(int receiptId, int productTypeId)
        {
            ReceiptProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.Get(receiptId, productTypeId);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/Get?receiptId=" + receiptId + "productTypeId=" + productTypeId + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'une receipt de consommateurs
        ///	</summary>
        ///	<param name="receiptProductType">Cuisine de receipt</param>
        /// <returns>La receipt de consommateurs créée</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<ReceiptProductType> Add(ReceiptProductType receiptProductType)
        {
            ReceiptProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.Add(receiptProductType);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une receipt de consommateurs
        ///	</summary>
        ///	<param name="receiptProductType">Livraison de consommateurs</param>
        ///	<param name="newReceiptId">Nouvel id d'une receipt</param>
        /// <returns>La receipt de consommateurs modifiée</returns>
        [Route("UpdateReceipt")]
        [HttpPut]
        public async Task<ReceiptProductType> UpdateReceipt(ReceiptProductType receiptProductType, int newReceiptId)
        {
            ReceiptProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.UpdateReceipt(receiptProductType, newReceiptId);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/UpdateReceipt/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'une receipt de consommateurs
        ///	</summary>
        ///	<param name="receiptProductType">Livraison de consommateurs</param>
        ///	<param name="newProductTypeId">Nouvel id du consommateur</param>
        /// <returns>La receipt de consommateurs modifiée</returns>
        [Route("UpdateProductType")]
        [HttpPut]
        public async Task<ReceiptProductType> UpdateProductType(ReceiptProductType receiptProductType, int newProductTypeId)
        {
            ReceiptProductType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.UpdateProductType(receiptProductType, newProductTypeId);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/UpdateProductType/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime une receipt de consommateurs
        ///	</summary>
        ///	<param name="receiptId">Identifiant de la receipt</param>
        ///	<param name="productTypeId">Identifiant du consommateur</param>
        /// <returns>1 si la receipt de consommateurs est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int receiptId, int productTypeId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.Delete(receiptId, productTypeId);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/Delete?receiptId=" + receiptId + "productTypeId=" + productTypeId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des receipts de consommateurs
        ///	</summary>
        ///	<param name="receiptId">Identifiant de la receipt</param>
        /// <returns>1 si les receipts de consommateurs sont supprimées</returns>
        [Route("DeleteAllFromReceipt")]
        [HttpDelete]
        public async Task<int> DeleteAllFromReceipt(int receiptId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.DeleteAllFromReceipt(receiptId);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/DeleteAllFromReceipt?receiptId=" + receiptId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime des receipts de consommateurs
        ///	</summary>
        ///	<param name="productTypeId">Identifiant du consommateur</param>
        /// <returns>1 si les receipts de consommateurs sont supprimées</returns>
        [Route("DeleteAllFromProductType")]
        [HttpDelete]
        public async Task<int> DeleteAllFromProduct(int productTypeId)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptProductTypeService.DeleteAllFromProductType(productTypeId);
            watch.Stop();

            _logger.LogInformation("ReceiptProductType/DeleteAllFromProduct?productTypeId=" + productTypeId + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
