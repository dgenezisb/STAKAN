using Syte.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.interfaces
{
    interface IAllBooks
    {
        IEnumerable<Book> Books { get; set; }
        IEnumerable<Book> GetFavouriteBooks { get; set; }
        Book GetObjectBook(int BookID);
    }
}
