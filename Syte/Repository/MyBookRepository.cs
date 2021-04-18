using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class MyBookRepository : IMyBooks
    {
        private readonly AppDBContent appDBContent;
        public MyBookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Book> GetFavouriteBooks => appDBContent.Book.Where(p => p.IsFavourite).Include(c => c.Category);// получаем только те, которые у нас занесены в избранное "Мои Книги"
    }
}
