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
        public IEnumerable<MyBooks> GetFavouriteBooks
        {
            get
            {
                return new List<MyBooks>                                       //ЗДЕСЬ ОПИСАТЬ СПИСОК ИЗБРАННЫХ КНИГ НА САЙТЕ
                {
                    new MyBooks {Name = "Мои книги", }
                };
            }
        }
    }
}
