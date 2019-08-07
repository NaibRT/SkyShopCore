using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace skyshopCore.Models
{
    public class Product
    {
      public Product()
      {
          Images=new HashSet<Image>();
          Colors=new HashSet<ProductColor>();
          Sizes=new HashSet<ProductSize>();
      }


        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int? DiscountId { get; set; }
        public Discount Discount { get; set; }

        public int BrandId { get; set; }
            public Brand Brand { get; set; }
        

        public ICollection<Image> Images { get; set; }
        public ICollection<ProductColor> Colors { get; set; }
        public ICollection<ProductSize> Sizes { get; set; }

        public string gender { get; set; }
    }
}