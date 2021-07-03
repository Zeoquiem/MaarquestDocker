using Maarquest.WEB.Logic.Models;
using Maarquest.WEB.Logic.Services;
using Maarquest.WEB.Areas.Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.WEB.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult CustomerIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
