using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IAuthors _allAuthors;
        private readonly IPublisher _allPublishers;
        private readonly ICompilations _allCompilations;
        private AppDBContext db = new AppDBContext(); 



        public BooksController(IAllBooks IAllBooks, ICategories IBooksCategories, IAuthors IAllAuthors, IPublisher IAllPublishers,ICompilations IAllCompilations)
        {
            _allBooks = IAllBooks;
            _allCategories = IBooksCategories;
            _allAuthors = IAllAuthors;
            _allPublishers = IAllPublishers;
            _allCompilations = IAllCompilations;
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
            ViewBag.Authors = new SelectList(_allAuthors.ListofAuthors,"Id", "Surname");
            ViewBag.Categories = new SelectList(_allCategories.ListofCategories, "Id", "CategoryName");
            ViewBag.Publisher = new SelectList(_allPublishers.ListofPublishers,"Id","Name");
            ViewBag.Compilations = new SelectList(_allCompilations.ListofCompilations,"Id","Name");
            return View(book);
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (string.IsNullOrEmpty(book.Name))
            {
                ModelState.AddModelError("Name", "Некорректное название книги");
            }
            else if (book.Name.Length > 5)
            {
                ModelState.AddModelError("Name", "Недопустимая длина строки");
            }

            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                
                db.Book.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Запрос не прошел валидацию";
            return View(book);
            
        }


        }



}

