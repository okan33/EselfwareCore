﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EselfwareCore.Controllers
{
    public class EselfERPController : Controller
    {
        public IActionResult EselfERP()
        {
            return View();
        }
    }
}