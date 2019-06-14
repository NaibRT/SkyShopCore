using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skyshopCore.Models;
using System.ComponentModel.DataAnnotations;
using skyshopCore.Data;
using skyshopCore.ViewModels;


namespace skyshopCore.Controllers
{
    public class AboutController : Controller
    {
private ApplicationDbContext db;
        public AboutController(ApplicationDbContext _db)
        {
            db=_db;
        }
        public IActionResult Index()
        {
            var allCategories=db.mainCategories.ToList();
            return View(allCategories);
        }

    }
}
