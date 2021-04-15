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
                    return new List<Authors>                                       //ЗДЕСЬ ОПИСАТЬ АВТОРОВ НА САЙТЕ
                {
                    new Authors {Name = "Евгений", Surname="Велтистов",},
                    new Authors {Name = "Иван", Surname="Тургенев",},
                    new Authors {Name = "Борис", Surname="Акунин"},
                    new Authors {Name = "Стивенсон", Surname="Роберт"}

                };
                }


            }
    }


    
}
