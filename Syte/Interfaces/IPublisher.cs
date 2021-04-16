using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    interface IPublisher
    {
        IEnumerable<Publisher> ListofPublisher { get; } //Функция получает список всех издательств
    }
}
