using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.ViewModels;

namespace Syte.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly ICategories _allCategories;

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
    }
}
