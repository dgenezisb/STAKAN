﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.ViewModels
{
    public class BooksCreateViewModel
    {
        public Book book { get; set; }
        public Authors authors { get; set; }
        public Category category { get; set; }
        public Publisher publisher { get; set; }
        public Compilations compilations { get; set; }
    }
}