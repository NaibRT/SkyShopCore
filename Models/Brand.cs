using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace skyshopCore.Models
{
    public class Brand
    {
       
        public int Id { get; set; }
         [Required]
        public string Name { get; set; }
        [Required]
        public string Logo { get; set; }
    }
}