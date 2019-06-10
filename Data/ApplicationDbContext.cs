using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using skyshopCore.Models;

namespace skyshopCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<mainCategory> mainCategories {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<SubCategory> SubCategories {get;set;}
        

    }
}
