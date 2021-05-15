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
    public class AuthorsController : Controller
    {
        private readonly IAuthors _author;
        private readonly AppDBContext db;
        public AuthorsController(IAuthors iAuthors, AppDBContext db)
        {
            _author = iAuthors;
            this.db = db;
        }

        public ActionResult Create()
        {
            Authors obj = new Authors();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Create(Authors author)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                db.Authors.Add(author);
                db.SaveChanges();
                return RedirectToRoute(new { controller = "Books", action = "List" });
            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View(author);
        }


        //public ViewResult ListOfCategories()
        //{
        //    var authors = _author.ListofAuthors;
        //    return View(authors);
        //}
    }
}

