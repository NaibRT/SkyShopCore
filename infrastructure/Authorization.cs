using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using skyshopCore.Models;

namespace skyshopCore.infrastructure
{

 [System.AttributeUsage(System.AttributeTargets.All, Inherited = true, AllowMultiple = true)]
 sealed class AuthorizationAttribute :Attribute, IAuthorizationFilter
 {
    private string _name { get; set; }
    public AuthorizationAttribute(string name)
    {
        _name=name;
    }
    public AuthorizationAttribute()
    {
        
    }

  public void OnAuthorization(AuthorizationFilterContext context)
  {
      IsAuthorized(context);
      IsRoleAuthorized(_name,context);
  }

 private void IsAuthorized(AuthorizationFilterContext context){
   var user=context.HttpContext.User;
    if (!user.Identity.IsAuthenticated)
    {
        context.Result=new RedirectToRouteResult(
                                   new RouteValueDictionary
                                   {    { "action", "Index" },
                                       { "controller", "Login" }
                                   });
    }
 }
  private void IsRoleAuthorized(string name,AuthorizationFilterContext context){
     
   var user=context.HttpContext.User;
   var res=user.IsInRole(name);
    if (!user.IsInRole(name))
    {
        context.Result=new RedirectToRouteResult(
                                   new RouteValueDictionary
                                   {
                                       { "action", "Index" },
                                       { "controller", "Login" }
                                   });
    }
  }
 }

}