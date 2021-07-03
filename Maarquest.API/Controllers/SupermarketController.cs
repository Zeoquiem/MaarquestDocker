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
    public class SupermarketController : ControllerBase
    {
        private ISupermarketService  _supermarketService;
        private ILogger<SupermarketController> _logger;

        public SupermarketController(ISupermarketService SupermarketService, ILogger<SupermarketController> logger)
        {
            _supermarketService = SupermarketService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de supermarchés
        ///	</summary>
        /// <returns>Liste de supermarchés</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<Supermarket>> GetAll()
        {
            List<Supermarket> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await  _supermarketService.GetAll();
            watch.Stop();

            _logger.LogInformation("Supermarket/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un supermarché en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du supermarché</param>
        /// <returns>Le supermarché</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<Supermarket> Get(int id)
        {
            Supermarket result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await  _supermarketService.Get(id);
            watch.Stop();

            _logger.LogInformation("Supermarket/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'un supermarché
        ///	</summary>
        ///	<param name="supermarket">supermarché</param>
        /// <returns>Le supermarché créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<Supermarket> Add(Supermarket supermarket)
        {
            Supermarket result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await  _supermarketService.Add(supermarket);
            watch.Stop();

            _logger.LogInformation("Supermarket/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un supermarché
        ///	</summary>
        ///	<param name="supermarket">supermarché</param>
        /// <returns>Le supermarché modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<Supermarket> Update(Supermarket supermarket)
        {
            Supermarket result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await  _supermarketService.Update(supermarket);
            watch.Stop();

            _logger.LogInformation("Supermarket/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de supermarchés
        ///	</summary>
        ///	<param name="id">Identifiant du supermarché</param>
        /// <returns>1 si le supermarché est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await  _supermarketService.Delete(id);
            watch.Stop();

            _logger.LogInformation("Supermarket/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
