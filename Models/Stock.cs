using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace skyshopCore.Models
{
    public class Stock
    {
        public int Id { get; set; }

       public int ProductColorId { get; set; }
       public ProductColor ProductColor { get; set; }
        public int ProductSizeId { get; set; }
       public ProductSize ProductSize { get; set; }
        public int Quantity { get; set; }
    }
}