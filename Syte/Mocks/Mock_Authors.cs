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
<<<<<<< HEAD
                    return new List<Authors>                                       //ЗДЕСЬ ОПИСАТЬ  НА САЙТЕ
=======
                    return new List<Authors>                                       //ЗДЕСЬ ОПИСАТЬ АВТОРОВ НА САЙТЕ
>>>>>>> b4a7c39dc18e7b56d704cf9d5be41c48da48d8c0
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
