using Syte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Interfaces
{
    public interface IAllBooks                   //Интерфейс для работы со всеми книгами
    {
        IEnumerable<Book> Books { get; } //Получить список всех книг на сайте (или добавить в него элемент)
      
        //IEnumerable<Book> GetAuthorsBooks { get;} //Получить все книги определённого автора     ( мне кажется не нужна реализация. так как мы и так получаем все данные по опр категории при помощи 1 метода)
        Book GetObjectBook(int BookID); //Получить книгу по ID
    }
}
