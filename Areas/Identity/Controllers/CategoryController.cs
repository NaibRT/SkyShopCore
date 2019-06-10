using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skyshopCore.Models;
using System.ComponentModel.DataAnnotations;
using skyshopCore.Data;
using Microsoft.EntityFrameworkCore;
using skyshopCore.ViewModels;

namespace skyshopCore.Areas.Identity.Controllers
{
    
    [Area("Identity")]
    public class CategoryController : Controller
    {
       private ApplicationDbContext db;
       public CategoryController(ApplicationDbContext _db)
       {
          db=_db;
       }
        public  IActionResult Index()
        {
          var categories=db.Categories.Include(x=>x.MainCategory).ToList();
           return View(categories);
        }
          
          [HttpGet]
        public IActionResult Create()
        {
            CategoryViewModel newviewModel=new CategoryViewModel(){
              Category=new Category(),
              mainCategories=db.mainCategories.ToList()
            };
            return View(newviewModel);
        }

                  [HttpPost]
        public async Task<IActionResult> Create(string name,int MainCategoryId)
        {
                  
                Category newCategory=new Category(){
                  name=name,
                  status=true,
                  MainCategoryId=MainCategoryId
                };

                if(ModelState.IsValid){
                  try
                  {
                  await  db.Categories.AddAsync(newCategory);
                 await db.SaveChangesAsync();
                  }
                  catch (Exception ex)
                  {
                      ViewBag.createMessage=ex.Message;
                      
                  }                
                     return RedirectToAction(nameof(Create));         
                }
                else{
                  CategoryViewModel categoryViewModel=new CategoryViewModel(){
                    Category=newCategory,
                    mainCategories=db.mainCategories.ToList()
                   
                  };
                   return RedirectToAction(nameof(Create),categoryViewModel);
                }
               
        }

        
         public IActionResult Update()
        {
            return View();
        }
         public async Task<IActionResult> Delete(int id)
        {
          if(id!=0){

                var obj=await db.Categories.FindAsync(id);
                if(obj!=null){
                  try
                  {
                     db.Categories.Remove(obj);
                     await db.SaveChangesAsync();
                     ViewBag.deleteMessage="Object is deleted successfully";
                  }
                  catch (System.Exception ex){
                  
                     ViewBag.deleteMessage=ex.Message;
                      
                  }

                    return RedirectToAction(nameof(Index));


                }
                else{
                  ViewBag.deleteMessage="Object not found";
                  return RedirectToAction(nameof(Index));
                }
            
          }
            return View();
        }

    }
}
