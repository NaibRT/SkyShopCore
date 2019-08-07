using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using skyshopCore.Models;
using skyshopCore.Data;
using skyshopCore.ViewModels;
using Microsoft.AspNetCore.Http;
using skyshopCore.infrastructure;

namespace skyshopCore.Controllers
{
 public class LoginController:Controller
 {
     private readonly ApplicationDbContext _db;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
     public LoginController(ApplicationDbContext db,UserManager<AppUser> user,
                            SignInManager<AppUser> sign)
     {
         _db=db;
         _userManager=user;
         _signInManager=sign;
     }
     [HttpGet]
     public IActionResult Index()
     {
         var id = HttpContext.Session.GetString("UserId");
         var user=_userManager.FindByIdAsync(id);
        //  var res=_signInManager.;
         
         return View(new LoginModel());
     }

         [HttpPost]

    public async Task<IActionResult> Index(LoginModel model)
     {
         var email=model.Email;
          if(ModelState.IsValid){
            var user=await _userManager.FindByEmailAsync(email);
            if(user!=null){
                HttpContext.Session.SetString("UserId",user.Id);
               await _signInManager.SignInAsync(user, isPersistent: false);
               return RedirectToAction("Index","Home");
            }
              
          }

         return View();
     }
 }
}
