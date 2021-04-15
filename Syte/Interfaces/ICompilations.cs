using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    interface ICompilations
    {
        IEnumerable<Book> ListofBooks { get; } //Функция получает список всех книг
    }
}
