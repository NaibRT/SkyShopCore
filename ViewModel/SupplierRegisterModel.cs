using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using skyshopCore.Models;
using Microsoft.AspNetCore.Http;

namespace skyshopCore.ViewModels
{
    public class SupplierRegisterModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
         [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(1000)]
        public string About { get; set; }


        [Required]
        [DataType(DataType.ImageUrl)]
        public IFormFile  Image { get; set; }
    }
}