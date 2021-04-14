using Syte.Interfaces;
using Syte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Mocks
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
                    new Book{Name = "", Description = "", Image = "", IsFavourite = false ,  Category= _categoryBooks.ListofCategories.ElementAt(2) }
                };
            }
        
        }
        public IEnumerable<Book> GetFavouriteBooks { get; set; }
        IEnumerable<Book> IAllBooks.Books { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Book GetObjectBook(int BookID)
        {
            throw new NotImplementedException();
        }
    }
}
