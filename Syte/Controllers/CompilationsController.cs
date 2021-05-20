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
    public class CompilationsController : Controller
    {
        private readonly ICompilations _compilation;
        private readonly AppDBContext db;
        public CompilationsController(ICompilations iCompilation, AppDBContext db)
        {
            _compilation = iCompilation;
            this.db = db;
        }
        public ActionResult Create()
        {

            ViewBag.Compilations = new SelectList(_compilation.ListofCompilations, "Id", "Name");

            return View();
        }
        [HttpPost]
        public ActionResult Create(Compilations compilation)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";

                db.Compilation.Add(compilation);
                db.SaveChanges();
                return RedirectToAction();

            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View();
        }

        public ViewResult ListOfCategories()
        {
            var compilations = _compilation.ListofCompilations;
            return View(compilations);
        }
    }
}

