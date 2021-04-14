using Biblio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblio.Data.Interfaces
{
    interface IAllBooks
    {
        IEnumerable<Book> Books { get; set; }
        IEnumerable<Book> GetFavouriteBooks { get; set; }
        Book GetObjectBook(int BookID);
    }
}
