using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skyshopCore.Models;

namespace skyshopCore.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
