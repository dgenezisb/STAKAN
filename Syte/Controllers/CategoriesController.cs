using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;

namespace Syte.Controllers
{
    public class CategoriesController: Controller
    {
        private readonly ICategories _categories;
        public CategoriesController(ICategories iCategories)
        {
            _categories = iCategories;
        }

        public ViewResult ListOfCategories()
        {
            var categories = _categories.ListofCategories;
            return View(categories);
        }
    }
}
