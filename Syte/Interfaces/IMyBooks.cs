using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    public interface IMyBooks
    {
        IEnumerable<MyBooks> ListofMyBooks {get; } //Получить список любимых книг или добавить в него элемент
    }
}
