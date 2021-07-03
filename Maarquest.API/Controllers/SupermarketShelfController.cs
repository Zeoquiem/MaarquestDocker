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
    public class SupermarketShelfController : ControllerBase
    {
        private ISupermarketShelfService _adressService;
        private ILogger<SupermarketShelfController> _logger;

        public SupermarketShelfController(ISupermarketShelfService supermarketShelfService, ILogger<SupermarketShelfController> logger)
        {
            _adressService = supermarketShelfService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de fonctions d'opérateur d'un supermarché
        ///	</summary>
        /// <returns>Liste de fonctions d'opérateur d'un supermarché</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<SupermarketShelf>> GetAll()
        {
            List<SupermarketShelf> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.GetAll();
            watch.Stop();

            _logger.LogInformation("SupermarketShelf/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un fonction d'opérateur d'un supermarché en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du fonction d'opérateur d'un supermarché</param>
        /// <returns>Le fonction d'opérateur d'un supermarché</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<SupermarketShelf> Get(int id)
        {
            SupermarketShelf result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Get(id);
            watch.Stop();

            _logger.LogInformation("SupermarketShelf/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création du fonction d'opérateur d'un supermarché
        ///	</summary>
        ///	<param name="supermarketShelf">Fonction d'opérateur d'un supermarché</param>
        /// <returns>Le fonction d'opérateur d'un supermarché créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<SupermarketShelf> Add(SupermarketShelf supermarketShelf)
        {
            SupermarketShelf result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Add(supermarketShelf);
            watch.Stop();

            _logger.LogInformation("SupermarketShelf/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un fonction d'opérateur d'un supermarché
        ///	</summary>
        ///	<param name="supermarketShelf">Fonction d'opérateur d'un supermarché</param>
        /// <returns>Le fonction d'opérateur d'un supermarché modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<SupermarketShelf> Update(SupermarketShelf supermarketShelf)
        {
            SupermarketShelf result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Update(supermarketShelf);
            watch.Stop();

            _logger.LogInformation("SupermarketShelf/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Supprime un fonction d'opérateur d'un supermarché
        ///	</summary>
        ///	<param name="id">Identifiant du fonction d'opérateur d'un supermarché</param>
        /// <returns>1 si le fonction d'opérateur d'un supermarché est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Delete(id);
            watch.Stop();

            _logger.LogInformation("SupermarketShelf/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
