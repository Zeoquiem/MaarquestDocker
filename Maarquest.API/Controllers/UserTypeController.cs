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
    public class UserTypeController : ControllerBase
    {
        private IUserTypeService _usertypeService;
        private ILogger<UserTypeController> _logger;

        public UserTypeController(IUserTypeService UserTypeService, ILogger<UserTypeController> logger)
        {
            _usertypeService = UserTypeService;
            _logger = logger;
        }

        /// <summary>
        ///		Retroune une liste d'utilisateurs
        ///	</summary>
        /// <returns>Liste d'utilisateurs</returns>
        [Route("GetAll")]
        [HttpGet]
        public async Task<List<UserType>> GetAll()
        {
            List<UserType> result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _usertypeService.GetAll();
            watch.Stop();

            _logger.LogInformation("UserType/GetAll/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune un utilisateur en fonction de son id
        ///	</summary>
        ///	<param name="id">Identifiant de l'utilisateur</param>
        /// <returns>L'utilisateur</returns>
        [Route("Get/{id}")]
        [HttpGet]
        public async Task<UserType> Get(int id)
        {
            UserType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _usertypeService.Get(id);
            watch.Stop();

            _logger.LogInformation("UserType/Get/" + id + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Création d'un utilisateur
        ///	</summary>
        ///	<param name="usertype">utilisateur</param>
        /// <returns>L'utilisateur a été créé</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<UserType> Add(UserType usertype)
        {
            UserType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _usertypeService.Add(usertype);
            watch.Stop();

            _logger.LogInformation("UserType/Add/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Modification d'un utilisateur
        ///	</summary>
        ///	<param name="UserType">utilisateur</param>
        /// <returns>L'utilisateur a été modifié</returns>
        [Route("Update")]
        [HttpPut]
        public async Task<UserType> Update(UserType UserType)
        {
            UserType result = null;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _usertypeService.Update(UserType);
            watch.Stop();

            _logger.LogInformation("UserType/Update/" + " |result : " + (result == null ? "null" : result.ToString()) + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }

        /// <summary>
        ///		Retroune une liste d'utilisateurs
        ///	</summary>
        ///	<param name="id">Identifiant de l'utilisateur</param>
        /// <returns>1 si l'utilisateur est supprimé</returns>
        [Route("Delete")]
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            int result = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            result = await _usertypeService.Delete(id);
            watch.Stop();

            _logger.LogInformation("UserType/Delete/" + id + " |result : " + result.ToString() + "|duree :" + watch.ElapsedMilliseconds);

            return result;
        }
    }
}
