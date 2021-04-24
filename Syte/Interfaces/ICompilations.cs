using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    public interface ICompilations
    {
        IEnumerable<Compilations> ListofCompilations { get; } //Функция получает список всех подборок
    }
}
