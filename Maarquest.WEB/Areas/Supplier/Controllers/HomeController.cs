using Maarquest.WEB.Logic.Models;
using Maarquest.WEB.Logic.Services;
using Maarquest.WEB.Areas.Supplier.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.WEB.Areas.Supplier.Controllers
{
    [Area("Supplier")]
    public class HomeController : Controller
    {
        private AddressService _addressService;

        public HomeController(AddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //if (User.Identity.IsAuthenticated)
            //{
                return View();
            //}
            //return View("../User/Login");
        }

        [HttpPost]
        public async Task<IActionResult> PushAdress()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
