using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Mocks
{
    public class Mock_Reviews : IReviews
    {
        public IEnumerable<Reviews> ListofReviews  
        {
            get
            {
                return new List<Reviews>   //ЗДЕСЬ ОПИСАТЬ ОТЗЫВЫ НА САЙТЕ                                   
                {
                    new Reviews {Name = "Отзыв 1", },
                    new Reviews {Name = "Отзыв 2", }
                };
            }
        }
    }
}
