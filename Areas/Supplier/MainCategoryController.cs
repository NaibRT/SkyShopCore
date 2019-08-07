using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skyshopCore.Models;
using System.ComponentModel.DataAnnotations;
using skyshopCore.Data;
using Microsoft.AspNetCore.Authorization;

namespace skyshopCore.Areas.Identity.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Identity")]
    public class MainCategoryController : Controller
    {
       private ApplicationDbContext db;
       public MainCategoryController(ApplicationDbContext _db)
       {
          db=_db;
       }
        public  IActionResult Index()
        {
          var mainCatList=db.mainCategories.ToList();

           return View(mainCatList);
        }
          
          [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

                  [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            if(!String.IsNullOrEmpty(name)){
                mainCategory newmainCategory=new mainCategory(){
                  name=name,
                  status=true
                };

                if(ModelState.IsValid){
                  await  db.mainCategories.AddAsync(newmainCategory);
                 await db.SaveChangesAsync();
                }
            }
            return View();
        }

        
                public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
          List<mainCategory> mainCatList=new List<mainCategory>();
            if(id!=0){
                try
                {
                    var currentMainCategory=await db.mainCategories.FindAsync(id);
                    db.mainCategories.Remove(currentMainCategory);
                  await  db.SaveChangesAsync();
                  mainCatList=db.mainCategories.ToList();
                }
                catch (Exception ex) 
                {
                    ViewBag.Error=new ArgumentNullException("Oject not found",ex);
            
                    return RedirectToAction(nameof(Index));
                }
             
            }
            return RedirectToAction(nameof(Index),mainCatList);
            
        }

    }
}
