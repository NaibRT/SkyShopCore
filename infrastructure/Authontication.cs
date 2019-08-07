using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using skyshopCore.Models;

namespace skyshopCore.infrastructure
{
public class AuthorizeUser : ActionFilterAttribute
{


  public override void OnActionExecuting(ActionExecutingContext context){
      var id = context.HttpContext.Session.GetString("UserId");
      if(!String.IsNullOrEmpty(id)){
         //var user=_userManager.FindByIdAsync(id);
      }

   }
  public override void OnActionExecuted(ActionExecutedContext context){
       
       
   }
 }
}