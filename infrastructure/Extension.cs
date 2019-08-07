using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace skyshopCore.infrastructure
{
    public static class Extension
    {
        public static string AddOneImage(this IFormFile file){

          if(file==null){
             return null;
          }
          if(file.Length<=(2*(1024*1024))&&file.ContentType=="image/jpg"
                                         ||file.ContentType=="image/jpeg"
                                         ||file.ContentType=="image/png"
                                         ||file.ContentType=="image/gif")
            {
                var typeName=file.ContentType.Split('/');
                var filename=Guid.NewGuid().ToString()+"."+typeName[1];
                var path=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img",filename);
                using (var stream=new FileStream(path,FileMode.Create))
                {
                    file.CopyToAsync(stream);
                    return filename;
                }

                
            }
            else{
              return  null;
            }
            
         
        }

    }

}