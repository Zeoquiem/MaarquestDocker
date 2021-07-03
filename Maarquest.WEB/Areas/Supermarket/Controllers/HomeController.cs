using Maarquest.WEB.Logic.Models;
using Maarquest.WEB.Logic.Services;
using Maarquest.WEB.Areas.Supermarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.WEB.Areas.Supermarket.Controllers
{
    [Area("Supermarket")]
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult SupermarketIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
