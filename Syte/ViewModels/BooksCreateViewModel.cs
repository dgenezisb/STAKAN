using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.ViewModels
{
    public class BooksCreateViewModel
    {
        public Book book { get; set; }
        public IEnumerable<Book> bookEnum { get; set; }
        public Reviews reviews { get; set; }


    }
}
