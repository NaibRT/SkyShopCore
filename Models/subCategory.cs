using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace skyshopCore.Models{

   
   public class SubCategory{
       
       
        [Required]
        public int Id{ get; set; }
 
       [Required]
       [DataType(DataType.Text)]
       public string name { get; set; }
[      Required]
       public bool status { get; set; }

       public int categoryId { get; set; }
       public Category category { get; set; }
    
   }

}