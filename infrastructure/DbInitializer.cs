using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using skyshopCore.Data;
using skyshopCore.Models;

namespace skyshopCore.infrastructure
{
    public static  class DbInitializer
    {

      
       public static async Task DataSeed( this ApplicationDbContext _db, UserManager<AppUser> usermanager,
                                                               RoleManager<IdentityRole> roleManager){
           if(_db.Roles.Any()){
             var role1= new IdentityRole(){
                Name="Admin",
                NormalizedName="ADMIN"
              };
              var role2=  new IdentityRole(){
                Name="Customer",
                NormalizedName="CUSTOMER",

              };
              var role3=  new IdentityRole(){
                Name="Supplier",
                NormalizedName="SUPPLIER"
              };
             await  roleManager.CreateAsync(role1); 
              await roleManager.CreateAsync(role2);
             await  roleManager.CreateAsync(role3);


           }
           if(_db.Users.Any()){
               var user1=new AppUser(){
                   UserName="NaibTahmazli",
                   Email="naibrt@code.edu.az"
               };

              var result=await usermanager.CreateAsync(user1,"1596321Tn");
              if(result.Succeeded)
                 await  usermanager.AddToRoleAsync(user1,"Admin");

           }
          
        }
    }
}