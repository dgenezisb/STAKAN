using Syte.Interfaces;
using Syte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Mocks
{
    public class Mock_Category : IBooksCategories
    {
        public IEnumerable<Category> ListofCategories {
            get{
                return new List<Category>                                       //ЗДЕСЬ ОПИСАТЬ КАТЕГОРИИ НА САЙТЕ
                {
                    new Category {CategoryName = "Детские", Description="Книги для детей",},
                    new Category {CategoryName = "Детективы", Description="Таинтвенные истории",},
                    new Category {CategoryName = "Научная фантастика", Description="Путешествия в мирах высоких технологий"},
                    new Category {CategoryName = "Приключения", Description="Истории об отважных путешественниках"}

                };
                


            }
        
        
        }
    }
}
