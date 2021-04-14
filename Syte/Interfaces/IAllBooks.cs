using Syte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Interfaces
{
    interface IAllBooks
    {
        IEnumerable<Book> Books { get; set; }
        IEnumerable<Book> GetFavouriteBooks { get; set; }
        Book GetObjectBook(int BookID);
    }
}
