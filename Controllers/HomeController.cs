using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skyshopCore.Models;
using skyshopCore.Data;
using skyshopCore.infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace skyshopCore.Controllers
{
 
    // [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
         private readonly SignInManager<AppUser> _signinManager;

        private readonly ApplicationDbContext _db ;
        public HomeController(ApplicationDbContext db,UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            _db=db;
            _userManager=userManager;
            _signinManager=signInManager;
        }
       
        public IActionResult Index()
        {
            var y=HttpContext.User;
         var id = HttpContext.Session.GetString("UserId");
         AppUser user=  _userManager.FindByIdAsync(id).GetAwaiter().GetResult();
         var res=_signinManager.IsSignedIn(y);
            return View();
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
