using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skyshopCore.Models;
using skyshopCore.Data;

namespace skyshopCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db ;
        public HomeController(ApplicationDbContext _db)
        {
            db=_db;
        }
        public IActionResult Index()
        {
           var list= db.mainCategories.Include(x=>x.categories).ThenInclude(y=>y.subcategories).ToList();
            return View(list);
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
