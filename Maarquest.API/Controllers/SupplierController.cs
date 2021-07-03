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
    public class SupplierController : ControllerBase
    {
        private ISupplierService _supplierService;
        private ILogger<SupplierController> _logger;

        public SupplierController(ISupplierService SupplierService, ILogger<SupplierController> logger)
        {
            _supplierService = SupplierService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste de fournisseurs
        ///	</summary>
        /// <returns>Liste de fournisseurs</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<Supplier>> GetAll()
        {
            List<Supplier> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _supplierService.GetAll();
            watch.Stop();

            _logger.LogInformation("Supplier/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un fournisseur en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant du fournisseur</param>
        /// <returns>Le fournisseur</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<Supplier> Get(int id)
        {
            Supplier result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _supplierService.Get(id);
            watch.Stop();

            _logger.LogInformation("Supplier/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'un fournisseur
        ///	</summary>
        ///	<param name="supplier">fournisseur</param>
        /// <returns>Le fournisseur créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<Supplier> Add(Supplier supplier)
        {
            Supplier result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _supplierService.Add(supplier);
            watch.Stop();

            _logger.LogInformation("Supplier/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un fournisseur
        ///	</summary>
        ///	<param name="supplier">fournisseur</param>
        /// <returns>Le fournisseur modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<Supplier> Update(Supplier supplier)
        {
            Supplier result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _supplierService.Update(supplier);
            watch.Stop();

            _logger.LogInformation("Supplier/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste de fournisseurs
        ///	</summary>
        ///	<param name="id">Identifiant du fournisseur</param>
        /// <returns>1 si le fournisseur est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _supplierService.Delete(id);
            watch.Stop();

            _logger.LogInformation("Supplier/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
