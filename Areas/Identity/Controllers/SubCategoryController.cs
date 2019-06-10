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


using Microsoft.EntityFrameworkCore;

namespace skyshopCore.Areas.Identity.Controllers
{
    
    [Area("Identity")]
    public class SubCategoryController : Controller
    {
       private ApplicationDbContext db;
       public SubCategoryController(ApplicationDbContext _db)
       {
          db=_db;
       }
        public  IActionResult Index()
        {
          var SubCategories=db.SubCategories.Include(x=>x.category).ToList();

           return View(SubCategories);
        }
          
          [HttpGet]
        public IActionResult Create()
        {
            var SubCategoryViewModel=new SubCategoryViewModel(){
                Categories=db.Categories.ToList(),
                SubCategory=new SubCategory()
            };
            return View(SubCategoryViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name,int categoryId)
        {
            SubCategory newSubCategory=new SubCategory();
           if(!String.IsNullOrEmpty(name)&& categoryId!=0){
             newSubCategory=new SubCategory(){
              name=name,
              status=true,
              categoryId=categoryId
            };

             if(ModelState.IsValid){
              try
              {
                await  db.SubCategories.AddAsync(newSubCategory);
               await db.SaveChangesAsync();
              }
              catch (Exception ex)
              {
                  ViewBag.SubCategoryErrorMessage=ex.Message;


                  return RedirectToAction(nameof(Create));
              }       
            }else{

                var SubCategoryViewModel=new SubCategoryViewModel(){
                Categories=db.Categories.ToList(),
                SubCategory=newSubCategory
                };

                return View(nameof(Create),SubCategoryViewModel);
            }
            }
            else{
            ViewBag.SubCategoryErrorMessage="name or category must be selected";
            return RedirectToAction(nameof(Create));
            }

            return RedirectToAction(nameof(Create));
        }

        
                public IActionResult Update()
        {
            return View();
        }
        public async Task<IActionResult> Delete(int id)
        {
            if(id!=0){
                try
                {
                    var currentSubCategory=await db.SubCategories.FindAsync(id);
                    db.SubCategories.Remove(currentSubCategory);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    
                  ViewBag.SubCategoryErrorMessage=ex.Message;
                  
                }
                
                    return RedirectToAction(nameof(Index));
                
            }
            else{
                ViewBag.SubCategoryErrorMessage="selected item is not correct";
                    return RedirectToAction(nameof(Index));
            }

        }

    }
}
