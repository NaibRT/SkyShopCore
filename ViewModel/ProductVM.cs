using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using skyshopCore.Models;

namespace skyshopCore.ViewModels
{
    public class ProductVM
    {

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public IFormFile[] Images { get; set; }

       public string AppUserId { get; set; }
       public string gender { get; set; }
       public int branId { get; set; }
    }
}