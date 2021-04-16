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
        private readonly AppDBContext appDBContent;
        public BookRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Book> Books => appDBContent.Book.Include(c=> c.Category); // получаем все данные, которые релевантны опр категории

        public Book GetObjectBook(int BookID) => appDBContent.Book.FirstOrDefault(p=>p.Id==BookID);
        
    }
}
