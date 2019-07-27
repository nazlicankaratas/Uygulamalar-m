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
        NorthwindEntities db = new NorthwindEntities();

        public List<CategoryModel> GetAllCategories()
        {
            List<CategoryModel> catList = db.Categories.Select(x => new CategoryModel()
            {
                KategoriAdi=x.CategoryName,
                Aciklamasi=x.Description
            }).ToList();
            return catList;
        }
        [HttpGet]
        public CategoryModel CategoryByID(int id)
        {
            Categories cat = db.Categories.Find(id);
            CategoryModel catModel = new CategoryModel();
            catModel.Aciklamasi = cat.Description;
            catModel.KategoriAdi = cat.CategoryName;

            return catModel;
        }
    }
}
