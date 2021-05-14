using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Controllers
{
    public class CategoriesController: Controller
    {
        private readonly ICategories _categories;
        private readonly AppDBContext db;
        public CategoriesController(ICategories iCategories, AppDBContext db)
        {
            _categories = iCategories;
            this.db=db;
        }
        public ActionResult CreateCategory()
        {
           
            ViewBag.Categories = new SelectList(_categories.ListofCategories, "Id", "CategoryName");
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory( Category category)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
               
                db.Category.Add(category);
                db.SaveChanges();
                return RedirectToAction();

            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View();
        }

        public ViewResult ListOfCategories()
        {
            var categories = _categories.ListofCategories;
            return View(categories);
        }
    }
}
