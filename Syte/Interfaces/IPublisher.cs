using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    public interface IPublisher
    {
        IEnumerable<Publisher> ListofPublishers { get; } //Функция получает список всех издательств
    }
}
