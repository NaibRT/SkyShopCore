using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace skyshopCore.Models{

   
   public class Category{

      public Category()
      {
          subcategories=new HashSet<SubCategory>();
      }
       
        [Required]
        public int Id{ get; set; }
 
       [Required]
       [DataType(DataType.Text)]
       public string name { get; set; }
[      Required]
       public bool status { get; set; }

       public int MainCategoryId { get; set; }
       public mainCategory MainCategory { get; set; }

       public virtual ICollection<SubCategory> subcategories { get; set; }
    
   }

}