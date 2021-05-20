using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviews _allReviews;
        private readonly AppDBContext db;
        public ReviewsController(IReviews IReviews, AppDBContext db)
        {
            _allReviews = IReviews;
            this.db = db;
        }
        public ActionResult Create(int Id)
        {
            var ThisBook = (from book in db.Book
                            where book.Id == Id
                            select book).First();
            return View(ThisBook);
        }
        [HttpPost]
        public ActionResult Create(Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                db.Reviews.Add(reviews);
                db.SaveChanges();
                return RedirectToRoute(new { controller = "Books", action = "Book" });

            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View(reviews);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
