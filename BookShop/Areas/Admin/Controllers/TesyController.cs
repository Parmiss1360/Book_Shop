﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Admin.Controllers
{
    public class TesyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}