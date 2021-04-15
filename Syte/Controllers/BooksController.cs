using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;

namespace Syte.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategories _allCategories;

        public BooksController(IAllBooks IAllBooks, IBooksCategories IBooksCategories)
        {
            _allBooks = IAllBooks;
            _allCategories = IBooksCategories;
        }
    }
}
