using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skyshopCore.Models
{
    public class WishList
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}