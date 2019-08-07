using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using skyshopCore.Data;
using skyshopCore.Areas.Supplier.ViewModel;
using skyshopCore.Models;
using Microsoft.AspNetCore.Authorization;
using skyshopCore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using skyshopCore.infrastructure;

namespace skyshopCore.Areas.Supplier.Controllers
{
     [Authorize(Roles = "Supplier")]
    [Area("Supplier")]
    public class SupplierController:Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signManager;

        public SupplierController(ApplicationDbContext db,
                                  UserManager<AppUser> userManager,
                                  SignInManager<AppUser> signManager)
        {
            _db=db;
            _userManager=userManager;
            _signManager=signManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var id=HttpContext.Session.GetString("UserId");
            var user= _userManager.FindByIdAsync(id);


            var VMSupplier=new VMSupplier{
            };
            return View();
        }

         [HttpPost]
         [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(ProductVM product)
        {
            AppUser user=new AppUser();
                    var id = HttpContext.Session.GetString("UserId");
                    if(!String.IsNullOrEmpty(id)){
                        user=await _userManager.FindByIdAsync(id);
                    }
                    else{ return RedirectToAction("Index","login"); }
                   
            if(ModelState.IsValid){

                  Discount newDiscount=new Discount();
                if(product.Discount!=0){
                  newDiscount=new Discount{
                  Value=product.Discount
                  };
                await  _db.Discounts.AddAsync(newDiscount);
              }

               var newProduct=new Product{
                Name=product.Name,
                Description=product.Description,
                Price=product.Price,
                AppUserId=user.Id,
                DiscountId=newDiscount.Id,
                gender=product.gender,
                BrandId=product.branId
               };

              await _db.Products.AddAsync(newProduct);



              if(product.Images.Length>0){

                  foreach (IFormFile item in product.Images.ToList())
                  {
                    var iName= item.AddOneImage();

                    var newImage=new Image{
                    Name=iName,
                    ProductId=newProduct.Id
                    };
                  }

              }
              await _db.SaveChangesAsync();
              return Json(newProduct);
            }else{
                return View(product);
            }
            
        }
                       [HttpPost]
                       [ValidateAntiForgeryToken]
                   public async Task<int> AddStock(StockVM stock){

                    if(ModelState.IsValid){
                        try
                        {
                           ProductColor  newPColor=new ProductColor();
                           ProductSize  newPSize=new ProductSize();

                            newPColor.Color=stock.color;
                            newPColor.ProductId=stock.Id;

                            await _db.ProductColors.AddAsync(newPColor);
                        

                                newPSize.Size=stock.size;
                                newPSize.ProductId=stock.Id;
                   
                                await _db.ProductSizes.AddAsync(newPSize);
                    

                    
                        var Stock=new Stock{
                            ProductColorId=newPColor.Id,
                            ProductSizeId=newPSize.Id,
                            Quantity=stock.count,
                         };
                            await _db.Stocks.AddAsync(Stock);
                            await _db.SaveChangesAsync();
                             return Response.StatusCode=StatusCodes.Status200OK;
                        }
                        catch (System.Exception)
                        {
                            
                           return Response.StatusCode=StatusCodes.Status200OK;
                        }
                    }
                    else{
                        return Response.StatusCode=StatusCodes.Status400BadRequest;
                    };

                 }
    }
}