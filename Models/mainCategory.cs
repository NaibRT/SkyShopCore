using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace skyshopCore.Models{

   
   public class mainCategory{

      public mainCategory()
      {
          categories=new HashSet<Category>();
      }
       
        [Required]
        public int Id{ get; set; }
 
       [Required]
       [DataType(DataType.Text)]
       public string name { get; set; }
       [Required]
       public bool status { get; set; }

       public virtual ICollection<Category> categories { get; set; }
    
   }

}