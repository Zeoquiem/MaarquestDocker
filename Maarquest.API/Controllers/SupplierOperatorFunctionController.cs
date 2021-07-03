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
    public class SupplierOperatorFunctionController : ControllerBase
    {
        private ISupplierOperatorFunctionService _adressService;
        private ILogger<SupplierOperatorFunctionController> _logger;

        public SupplierOperatorFunctionController(ISupplierOperatorFunctionService supplierOperatorFunctionService, ILogger<SupplierOperatorFunctionController> logger)
        {
            _adressService = supplierOperatorFunctionService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de fonctions d'opérateur d'un supermarché
        ///	</summary>
        /// <returns>Liste de fonctions d'opérateur d'un supermarché</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<SupplierOperatorFunction>> GetAll()
        {
            List<SupplierOperatorFunction> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.GetAll();
            watch.Stop();

            _logger.LogInformation("SupplierOperatorFunction/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un fonction d'opérateur d'un supermarché en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du fonction d'opérateur d'un supermarché</param>
        /// <returns>Le fonction d'opérateur d'un supermarché</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<SupplierOperatorFunction> Get(int id)
        {
            SupplierOperatorFunction result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Get(id);
            watch.Stop();

            _logger.LogInformation("SupplierOperatorFunction/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création du fonction d'opérateur d'un supermarché
        ///	</summary>
        ///	<param name="supplierOperatorFunction">Fonction d'opérateur d'un supermarché</param>
        /// <returns>Le fonction d'opérateur d'un supermarché créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<SupplierOperatorFunction> Add(SupplierOperatorFunction supplierOperatorFunction)
        {
            SupplierOperatorFunction result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Add(supplierOperatorFunction);
            watch.Stop();

            _logger.LogInformation("SupplierOperatorFunction/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un fonction d'opérateur d'un supermarché
        ///	</summary>
        ///	<param name="supplierOperatorFunction">Fonction d'opérateur d'un supermarché</param>
        /// <returns>Le fonction d'opérateur d'un supermarché modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<SupplierOperatorFunction> Update(SupplierOperatorFunction supplierOperatorFunction)
        {
            SupplierOperatorFunction result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _adressService.Update(supplierOperatorFunction);
            watch.Stop();

            _logger.LogInformation("SupplierOperatorFunction/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

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

            _logger.LogInformation("SupplierOperatorFunction/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
