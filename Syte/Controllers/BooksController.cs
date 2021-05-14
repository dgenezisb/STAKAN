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
        private readonly AppDBContext db;

        public BooksController(IAllBooks IAllBooks, ICategories IBooksCategories, IAuthors IAllAuthors, IPublisher IAllPublishers,ICompilations IAllCompilations, AppDBContext db)
        {
            _allBooks = IAllBooks;
            _allCategories = IBooksCategories;
            _allAuthors = IAllAuthors;
            _allPublishers = IAllPublishers;
            _allCompilations = IAllCompilations;
            this.db = db;
        }

        public ActionResult Index()
        {
            var books = (from book in db.Book select book).ToList();
            var authors = (from author in db.Authors select author).ToList();
            var categories = (from category in db.Category select category).ToList();
            var publishers = (from publisher in db.Publisher select publisher).ToList();
            var compilations = (from compilation in db.Compilation select compilation).ToList();
            //foreach (var book in books)
            //{
            //    foreach (var author in authors)
            //    {
            //        if (book.AuthorID == author.Id)
            //            book.Author.Surname = author.Surname;        
            //    }
            //    foreach (var category in categories)
            //    {
            //        if (book.CategoryID == category.Id)
            //            book.Category.CategoryName = category.CategoryName;
            //    }
            //    foreach (var publisher in publishers)
            //    {
            //        if (book.PublisherID == publisher.Id)
            //            book.Publisher.Name = publisher.Name;
            //    }
            //    foreach (var compilation in compilations)
            //    {
            //        if (book.CompilationID == compilation.Id)
            //            book.Compilation.Name = compilation.Name;
              //}
            
            return View(books);
        }



        public ViewResult List()
        {
            ViewBag.Title = "Наши книги";
            BooksListViewModel obj = new BooksListViewModel();
            obj.AllBooks = _allBooks.Books;
            //obj.AllCategories = _allCategories.ListofCategories;
            obj.CurrentCategory = "Тут должно быть название жанра";
            return View(obj);
        }
        public ActionResult Create()
        {
            BooksCreateViewModel obj = new BooksCreateViewModel();
            //Book book = new Book();
            ViewBag.Authors = new SelectList(_allAuthors.ListofAuthors,"Id", "Surname");
            ViewBag.Categories = new SelectList(_allCategories.ListofCategories, "Id", "CategoryName");
            ViewBag.Publisher = new SelectList(_allPublishers.ListofPublishers,"Id","Name");
            ViewBag.Compilations = new SelectList(_allCompilations.ListofCompilations,"Id","Name");
            return View(obj);
        }
        [HttpPost]
        public ActionResult Create(Book book, Category category, Authors authors, Compilations compilations, Publisher publisher)
        {
            //if (string.IsNullOrEmpty(book.Name))
            //{
            //    ModelState.AddModelError("Name", "Некорректное название книги");
            //}
            //else if (book.Name.Length > 5)
            //{
            //    ModelState.AddModelError("Name", "Недопустимая длина строки");
            //}

            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                db.Authors.Add(authors);
                db.Category.Add(category);
                db.Book.Add(book);
                db.Publisher.Add(publisher);
                db.Compilation.Add(compilations);
                db.SaveChanges();
                return RedirectToAction("list");
            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View(book);
        }
        public ActionResult Delete(int id)
        {
            var authors = (from author in db.Authors select author).ToList();
            var categories = (from category in db.Category select category).ToList();
            var publishers = (from publisher in db.Publisher select publisher).ToList();
            var compilations = (from compilation in db.Compilation select compilation).ToList();

            var BookDelete = (from book in db.Book
                              where book.Id == id
                              select book).First();
            //foreach (var author in authors)
            //{
            //    if (BookDelete.AuthorID == author.Id)
            //        BookDelete.Author.Surname = author.Surname;
            //}
            //foreach (var category in categories)
            //{
            //    if (BookDelete.CategoryID == category.Id)
            //        BookDelete.Category.CategoryName = category.CategoryName;
            //}
            //foreach (var publisher in publishers)
            //{
            //    if (BookDelete.PublisherID == publisher.Id)
            //        BookDelete.Publisher.Name = publisher.Name;
            //}
            //foreach (var compilation in compilations)
            //{
            //    if (BookDelete.CompilationID == compilation.Id)
            //        BookDelete.Compilation.Name = compilation.Name;
            //}
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
                return RedirectToAction("list");
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
            //foreach (var book in books)
            //{
            //    foreach (var author in authors)
            //    {
            //        if (book.AuthorID == author.Id)
            //            book.Author.Surname = author.Surname;
            //    }
            //    foreach (var category in categories)
            //    {
            //        if (book.CategoryID == category.Id)
            //            book.Category.CategoryName = category.CategoryName;
            //    }
            //}
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
                return RedirectToAction("index");
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
    }
    


}

