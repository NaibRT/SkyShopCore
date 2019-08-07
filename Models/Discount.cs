using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace skyshopCore.Models
{
    public class Discount
    {
        public int Id { get; set; }

        [Required]
        public decimal Value { get; set; }
        public string Description { get; set; }
        
    }
}