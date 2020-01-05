using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EselfwareCore.Models;

namespace EselfwareCore.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
