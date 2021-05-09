using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;
using Syte.ViewModels;

namespace Syte.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly ICategories _allCategories;
        private AppDBContext db;

        public BooksController(IAllBooks IAllBooks, ICategories IBooksCategories)
        {
            _allBooks = IAllBooks;
            _allCategories = IBooksCategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Наши книги";
            BooksListViewModel obj = new BooksListViewModel();
            obj.AllBooks = _allBooks.Books;
            obj.CurrentCategory = "Тут должно быть название жанра";
            return View(obj);
        }
        public ActionResult Create()
        {
            Book book = new Book();
            return View(book);
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Book.Add(book);
                    db.SaveChanges();
                    return RedirectToAction("List");
                }
            
            }
            catch(Exception ex)
            {
                //ModelState.AddModelError(String.Empty, ex);
            }
            return View(book);
        }


        }



}

