using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace skyshopCore.Models
{
    public class AppUser:IdentityUser
    {
     public string Image { get; set; }
     public string Location { get; set; }

     public string About { get; set; }

     public ICollection<Product> Products { get; set; }

    }
}