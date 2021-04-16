using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> AllBooks { get; set; }

        public string CurrentCategory { get; set; }
    }
}
