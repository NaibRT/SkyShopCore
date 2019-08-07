using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using skyshopCore.Models;
using skyshopCore.ViewModels;

namespace skyshopCore.Areas.Supplier.ViewModel
{
    public class VMSupplier
    {
        public SupplierRegisterModel AppUser { get; set; }
        public List<Product> Products { get; set; }
         public List<Order> Orders { get; set; }

            [EnumDataType(typeof(Color))]
         public Color Color { get; set; }
    }
}