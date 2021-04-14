using Biblio.Data.Interfaces;
using Biblio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblio.Data.Mocks
{
    public class Mock_Books : IAllBooks
    {
        private readonly IBooksCategories _categoryBooks = new Mock_Category();
        public IEnumerable<Book> Books 
        {
            get
            {
                return new List<Book>                                                       //ЗДЕСЬ ОПИСАТЬ КНИГИ НА САЙТЕ
                {
                    new Book{Name = "", ShortDesc = "", LongDesc = "", Image = "", IsFavourite = false ,  Category= _categoryBooks.ListofCategories.ElementAt(2) }
                };
            }
        
        }
        public IEnumerable<Book> GetFavouriteBooks { get; set; }

        public Book GetObjectBook(int BookID)
        {
            throw new NotImplementedException();
        }
    }
}
