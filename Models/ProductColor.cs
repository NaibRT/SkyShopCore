using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace skyshopCore.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        [Required]
        public string Color { get; set; }


        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}