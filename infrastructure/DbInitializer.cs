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

      
       public static void DataSeed( this ApplicationDbContext _db, UserManager<AppUser> usermanager,
                                                               RoleManager<IdentityRole> roleManager){
           if(!_db.Roles.Any()){
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
               roleManager.CreateAsync(role1).GetAwaiter(); 
               roleManager.CreateAsync(role2).GetAwaiter();
               roleManager.CreateAsync(role3).GetAwaiter();


           }

           if(!_db.Users.Any()){
               var user1=new AppUser(){
                   UserName="NaibTahmazli",
                   Email="naibrt@code.edu.az"
               };

              var result= usermanager.CreateAsync(user1,"1596321@TNaib").GetAwaiter().GetResult();
              if(result.Succeeded)
                   usermanager.AddToRoleAsync(user1,"Admin").GetAwaiter();

           }
          
        }
    }
}