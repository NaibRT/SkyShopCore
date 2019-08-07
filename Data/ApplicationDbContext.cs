using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using skyshopCore.Models;

namespace skyshopCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<mainCategory> mainCategories {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<SubCategory> SubCategories {get;set;}
        public DbSet<Product> Products {get;set;}
       public DbSet<Brand> Brands {get;set;}
       public DbSet<Discount> Discounts {get;set;}
       public DbSet<Image> Images {get;set;}
       public DbSet<ProductColor> ProductColors {get;set;}
       public DbSet<ProductSize> ProductSizes {get;set;}
       public DbSet<Stock> Stocks {get;set;}
       public DbSet<Order> Orders {get;set;}
       public DbSet<WishList> WishLists {get;set;}

    }
}
