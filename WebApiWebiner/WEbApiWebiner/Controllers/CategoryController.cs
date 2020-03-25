using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEbApiWebiner.Models.Dto;
using WEbApiWebiner.Models.Orm;

namespace WEbApiWebiner.Controllers
{
    public class CategoryController : ApiController
    {
    //Dependency Injection yapılmalı
        private NorthwindEntities _db = new NorthwindEntities();
        
        public IActionResult GetAllCategories()
        {
            var catList = _db.Categories.Select(x => new CategoryModel
            {
                KategoriAdi = x.CategoryName,
                Aciklamasi = x.Description
            }).ToList();
            
            //Api projelerinde Status code önemli o yüzden böyle dönmelisin.
            return Ok(catList);
        }
        [HttpGet]
        public IActionResult CategoryById(int id)
        {
            var cat = _db.Categories.Find(id);
            if(cat is null)
                return NotFound(id);
                
            var catModel = new CategoryModel
            {
                Aciklamasi = cat.Description;
                KategoriAdi = cat.CategoryName;
            };

            return Ok(catModel);
        }
    }
}
