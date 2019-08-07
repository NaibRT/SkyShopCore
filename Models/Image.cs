using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace skyshopCore.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        
    }
}