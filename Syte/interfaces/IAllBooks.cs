using Syte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Interfaces
{
    interface IAllBooks                   //Интерфейс для работы со всеми книгами
    {
        IEnumerable<Book> Books { get; set; } //Получить список всех книг на сайте или добавить в него элемент
        IEnumerable<Book> GetFavouriteBooks { get; set; } //Получить список любимых книг или добавить в него элемент
        IEnumerable<Book> GetAuthorsBooks { get;} //Получить все книги определённого автора
        Book GetObjectBook(int BookID); //Получить книгу по ID
    }
}
