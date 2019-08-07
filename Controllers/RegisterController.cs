using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using skyshopCore.Models;
using skyshopCore.ViewModels;
using skyshopCore.Data;
using skyshopCore.infrastructure;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;

namespace Namespace.Controllers
{
    public class RegisterController : Controller
    {
    private readonly ApplicationDbContext _db;
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IHttpContextAccessor  _accessor;
    private readonly IEmailSender  _mailsender ;
        public RegisterController(ApplicationDbContext db,UserManager<AppUser> usermanager,
                                                          RoleManager<IdentityRole> roleManager,
                                                          SignInManager<AppUser> signInManager,
                                                          IEmailSender mailSender,
                                                          IHttpContextAccessor accessor )
        {
            _db=db;
            _userManager=usermanager;
            _roleManager=roleManager;
            _signInManager=signInManager;
            _mailsender=mailSender;
            _accessor=accessor;
        }



        [HttpGet]
        public IActionResult User()
        {
            
            return View(new UserRegisterModel());
        }

        [HttpPost]
        public async Task<IActionResult> User(UserRegisterModel model)
        {
            AppUser newUser=new AppUser();
            if(ModelState.IsValid){
                   newUser.UserName=model.Name+model.Surname;
                   newUser.Email=model.Email;
                

               var result = await _userManager.CreateAsync(newUser, model.Password);

               if(result.Succeeded){
                  var token=await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                   await _userManager.AddToRoleAsync(newUser,"Customer");
                   var callbackUrl = Url.Action(
                       "ConfirmEmail","Register",
                values: new { userId = newUser.Id, token = token },
                protocol: Request.Scheme);
                await _signInManager.SignInAsync(newUser, false); 
                   

                await _mailsender.SendEmailAsync(newUser.Email,"Confirm your email",$"Please confirm your account by <a btn-btn-primary href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                return RedirectToAction("Index", "Home"); 
               }

            }


            return View(newUser);
        }

        [HttpGet]
        public IActionResult Supplier()
        {
            return View(new SupplierRegisterModel());
        }
        [HttpPost]
        public async Task<IActionResult> Supplier(SupplierRegisterModel model)
        {

            AppUser newUser=new AppUser();
            var imgName=model.Image.AddOneImage();
            if(ModelState.IsValid){
                
                   newUser.UserName=model.Name;
                   newUser.Email=model.Email;
                   newUser.About=model.About;

                   
                    if(!String.IsNullOrEmpty(imgName))
                      newUser.Image=imgName;
               var result = await _userManager.CreateAsync(newUser, model.Password);
                  await _userManager.AddToRoleAsync(newUser,"Supplier");
               if(result.Succeeded){
                  var token=await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                  //var remoteIpAddress = _accessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
                  //var ip=remoteIpAddress.ToString();
                   var callbackUrl = Url.Action(
                       "ConfirmEmail","Register",
                values: new { userId = newUser.Id, token = token },
                protocol: Request.Scheme);
                await _signInManager.SignInAsync(newUser, false); 
                   

                await _mailsender.SendEmailAsync(newUser.Email,"Confirm your email",$"Please confirm your account by <a class='btn-btn-primary' href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                return RedirectToAction("Index", "Home"); 

               }
               return View(model);
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if(String.IsNullOrEmpty(userId)&&String.IsNullOrEmpty(token)){
                return View($"/Views/Shared/Error.cshtml");
            }
            var user=await _userManager.FindByIdAsync(userId);
            if(user==null){
                return View($"/Views/Shared/Error.cshtml");
            }

            var result=await _userManager.ConfirmEmailAsync(user,token);
            if(result.Succeeded){
                return RedirectToAction("Index","Login");
            }
            return RedirectToAction("Index","Home");
        }
    }
}