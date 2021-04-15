using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Mocks
{
    public class Mock_MyBooks : IMyBooks
    {
        public IEnumerable<Book> GetFavouriteBooks => throw new NotImplementedException();
    }
}
