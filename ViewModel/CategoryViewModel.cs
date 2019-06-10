using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using skyshopCore.Models;


namespace skyshopCore.ViewModels{

   
   public class CategoryViewModel{

public List<mainCategory> mainCategories { get; set; }
public Category Category { get; set; }
    
   }

}