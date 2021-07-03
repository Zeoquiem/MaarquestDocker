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
    public class ReceiptController : ControllerBase
    {
        private IReceiptService _receiptService;
        private ILogger<ReceiptController> _logger;

        public ReceiptController(IReceiptService ReceiptService, ILogger<ReceiptController> logger)
        {
            _receiptService = ReceiptService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de reçus
        ///	</summary>
        /// <returns>Liste de reçus</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<Receipt>> GetAll()
        {
            List<Receipt> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptService.GetAll();
            watch.Stop();

            _logger.LogInformation("Receipt/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un reçu en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du reçu</param>
        /// <returns>Le reçu</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<Receipt> Get(int id)
        {
            Receipt result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptService.Get(id);
            watch.Stop();

            _logger.LogInformation("Receipt/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'un reçu
        ///	</summary>
        ///	<param name="receipt">reçu</param>
        /// <returns>Le reçu créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<Receipt> Add(Receipt receipt)
        {
            Receipt result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptService.Add(receipt);
            watch.Stop();

            _logger.LogInformation("Receipt/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un reçu
        ///	</summary>
        ///	<param name="receipt">reçu</param>
        /// <returns>Le reçu modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<Receipt> Update(Receipt receipt)
        {
            Receipt result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptService.Update(receipt);
            watch.Stop();

            _logger.LogInformation("Receipt/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de reçus
        ///	</summary>
        ///	<param name="id">Identifiant du reçu</param>
        /// <returns>1 si le reçu est supprimée</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _receiptService.Delete(id);
            watch.Stop();

            _logger.LogInformation("Receipt/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
