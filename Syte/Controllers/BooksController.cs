using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        private readonly ITags _allTags;
        private readonly AppDBContext db;

        public BooksController(IAllBooks IAllBooks, ICategories IBooksCategories, IAuthors IAllAuthors, IPublisher IAllPublishers,ICompilations IAllCompilations, ITags IAllTags, AppDBContext db)
        {
            _allBooks = IAllBooks;
            _allCategories = IBooksCategories;
            _allAuthors = IAllAuthors;
            _allPublishers = IAllPublishers;
            _allCompilations = IAllCompilations;
            _allTags = IAllTags;
            this.db = db;
        }

        public ActionResult Index()
        {
            var books = (from book in db.Book select book).ToList();
            var authors = (from author in db.Authors select author).ToList();
            var categories = (from category in db.Category select category).ToList();
            var publishers = (from publisher in db.Publisher select publisher).ToList();
            var compilations = (from compilation in db.Compilation select compilation).ToList();
            return View(books);
        }
        public ViewResult List()
        {
            ViewBag.Title = "Книги";
            BooksListViewModel obj = new BooksListViewModel();
            obj.AllBooks = _allBooks.Books;
            obj.CurrentCategory = "Тут должно быть название жанра";
            return View(obj);
        }
        public ActionResult Create()
        {
            Book obj = new Book();
            //Book book = new Book();
            ViewBag.Authors = new SelectList(_allAuthors.ListofAuthors,"Id", "Surname");
            ViewBag.Categories = new SelectList(_allCategories.ListofCategories, "Id", "CategoryName");
            ViewBag.Publisher = new SelectList(_allPublishers.ListofPublishers,"Id","Name");
            ViewBag.Compilations = new SelectList(_allCompilations.ListofCompilations,"Id","Name");
            ViewBag.Tags = new SelectList(_allTags.ListofTags, "Id", "Name");
            return View(obj);
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";

                //var author = CreateAuthor("Name");

                //book.Author = author;

                db.Book.Add(book);

                db.SaveChanges();
                return RedirectToRoute(new { controller = "Books", action = "List" });

            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View(book);
        }

        //public Authors CreateAuthor(string authorName)
        //{
        //    Authors newAuthor = new Authors() { Name = authorName };
        //    db.Authors.Add(newAuthor);
        //    db.SaveChanges();
        //    return newAuthor;

        //}
        //public ActionResult CreateAuthor( Authors authors)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ViewBag.Message = "Валидация пройдена";
        //        db.Authors.Add(authors);
        //        db.SaveChanges();
        //        return RedirectToAction("list");
        //    }
        //    ViewBag.Message = "Запрос не прошел валидацию";
        //    return View();
        //}
        public ActionResult Delete(int id)
        {
            var authors = (from author in db.Authors select author).ToList();
            var categories = (from category in db.Category select category).ToList();
            var publishers = (from publisher in db.Publisher select publisher).ToList();
            var compilations = (from compilation in db.Compilation select compilation).ToList();

            var BookDelete = (from book in db.Book
                              where book.Id == id
                              select book).First();
            return View(BookDelete);
        }
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var BookDelete = (from book in db.Book
                              where book.Id == id
                              select book).First();
            try
            {
                db.Remove(BookDelete);
                db.SaveChanges();
                return RedirectToRoute(new { controller = "Books", action = "List" });
            }
            catch
            {
                return View(BookDelete);
            }


        }
        public ActionResult Edit(int id)
        {
            var books = (from book in db.Book select book).ToList();

            var authors = (from author in db.Authors select author).ToList();
            var categories = (from category in db.Category select category).ToList();
            var publishers = (from publisher in db.Publisher select publisher).ToList();
            var compilations = (from compilation in db.Compilation select compilation).ToList();
            var BookEdit = (from book in db.Book
                              where book.Id == id
                              select book).First();
            ViewBag.Authors = new SelectList(_allAuthors.ListofAuthors, "Id", "Surname");
            ViewBag.Categories = new SelectList(_allCategories.ListofCategories, "Id", "CategoryName");
            ViewBag.Publisher = new SelectList(_allPublishers.ListofPublishers, "Id", "Name");
            ViewBag.Compilations = new SelectList(_allCompilations.ListofCompilations, "Id", "Name");
            return View(BookEdit); 
        }
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var BookEdit = (from book in db.Book
                            where book.Id == id
                            select book).First();
            try
            {
                TryUpdateModelAsync(BookEdit);
                db.SaveChanges();
                return RedirectToRoute(new { controller = "Books", action = "List" });
            }
            catch
            {
                return View(BookEdit);
            }


        }
        public ActionResult Details(int id)
        {
            var books = (from book in db.Book select book).ToList();

            var authors = (from author in db.Authors select author).ToList();
            var categories = (from category in db.Category select category).ToList();
            var publishers = (from publisher in db.Publisher select publisher).ToList();
            var compilations = (from compilation in db.Compilation select compilation).ToList();

            var BookDetails = (from book in db.Book
                               where book.Id == id
                               select book).First();
            return View(BookDetails);
        }
        public ActionResult Book(int id)
        {
            var ThisBook = (from book in db.Book
                            where book.Id == id
                            select book).First();
            return View(ThisBook);
        }
    }

    


}

