using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using skyshopCore.Models;

namespace skyshopCore.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Identity")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
