using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    interface IAuthors      //Интерфейс для работы с авторами
    {
        IEnumerable<Authors> ListofAuthors { get;} //Функция получает список всех авторов
    }
}
