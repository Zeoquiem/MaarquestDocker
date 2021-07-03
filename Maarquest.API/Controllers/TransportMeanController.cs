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
    public class TransportMeanController : ControllerBase
    {
        private ITransportMeanService _transportMeanService;
        private ILogger<TransportMeanController> _logger;

        public TransportMeanController(ITransportMeanService TransportMeanService, ILogger<TransportMeanController> logger)
        {
            _transportMeanService = TransportMeanService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de moyens de transport
        ///	</summary>
        /// <returns>Liste de moyens de transport</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<TransportMean>> GetAll()
        {
            List<TransportMean> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _transportMeanService.GetAll();
            watch.Stop();

            _logger.LogInformation("TransportMean/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un moyen de transport en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du moyen de transport</param>
        /// <returns>Le moyen de transport</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<TransportMean> Get(int id)
        {
            TransportMean result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _transportMeanService.Get(id);
            watch.Stop();

            _logger.LogInformation("TransportMean/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'un moyen de transport
        ///	</summary>
        ///	<param name="transportMean">moyen de transport</param>
        /// <returns>Le moyen de transport a été créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<TransportMean> Add(TransportMean transportMean)
        {
            TransportMean result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _transportMeanService.Add(transportMean);
            watch.Stop();

            _logger.LogInformation("TransportMean/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un moyen de transport
        ///	</summary>
        ///	<param name="transportMean">moyen de transport</param>
        /// <returns>Le moyen de transport a été modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<TransportMean> Update(TransportMean transportMean)
        {
            TransportMean result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _transportMeanService.Update(transportMean);
            watch.Stop();

            _logger.LogInformation("TransportMean/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de moyens de transport
        ///	</summary>
        ///	<param name="id">Identifiant du moyen de transport</param>
        /// <returns>1 si le moyen de transport est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _transportMeanService.Delete(id);
            watch.Stop();

            _logger.LogInformation("TransportMean/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
