using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class BookRepository : IAllBooks

    {
        private readonly AppDBContext appDBContext;
        public BookRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<Book> Books => appDBContext.Book.Include(c=> c.Category); // получаем все данные, которые релевантны опр категории

        public Book GetObjectBook(int BookID) => appDBContext.Book.FirstOrDefault(p=>p.Id==BookID);
        
    }
}
