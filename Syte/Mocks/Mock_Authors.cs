using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Mocks
{
    public class Mock_Authors :IAuthors
    {
        
            public IEnumerable<Authors> ListofAuthors
            {
                get
                {
                    return new List<Authors>                                       //ЗДЕСЬ ОПИСАТЬ КАТЕГОРИИ НА САЙТЕ
                {
                    new Authors {name = "Евгений", surname="Велтистов",},
                    new Authors {name = "Иван", surname="Тургенев",},
                    new Authors {name = "Борис", surname="Акунин"},
                    new Authors {name = "Стивенсон", surname="Роберт"}

                };
                }


            }

        public IEnumerable<Book> Books { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    
}
