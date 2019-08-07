using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skyshopCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime OrderedDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderedCount { get; set; }

        public decimal TotalPrice { get; set; }
    }
}