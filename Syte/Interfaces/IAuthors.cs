using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    interface IAuthors
    {
        IEnumerable<Book> Books { get; set; }
    }
}
