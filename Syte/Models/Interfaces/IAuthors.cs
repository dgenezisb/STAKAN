using Syte.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.interfaces
{
    interface IAuthors
    {
        IEnumerable<Book> Books { get; }
    }
}
