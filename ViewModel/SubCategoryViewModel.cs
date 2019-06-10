using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using skyshopCore.Models;

namespace skyshopCore.ViewModels{

   
   public class SubCategoryViewModel{

public List<Category> Categories { get; set; }
public SubCategory SubCategory { get; set; }
    
   }

}