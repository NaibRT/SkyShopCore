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
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext db ;
        public AjaxController(ApplicationDbContext _db)
        {
            db=_db;
        }
        [HttpGet]
        public IActionResult GetMainMenu()
        {
             var list= db.mainCategories.Include(x=>x.categories).ThenInclude(y=>y.subcategories).ToList();
            return PartialView("_main-menuPartial",list);
        }
    }
}
