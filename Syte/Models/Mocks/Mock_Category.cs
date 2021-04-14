using Biblio.Data.Interfaces;
using Biblio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.interfaces
{
    public class Mock_Category : IBooksCategories
    {
        public IEnumerable<Category> ListofCategories {
            get{
                return new List<Category>                                       //ЗДЕСЬ ОПИСАТЬ КАТЕГОРИИ НА САЙТЕ
                {
                    new Category {categoryName = "Детские", description="Книги для детей",},
                    new Category {categoryName = "Детективы", description="Таинтвенные истории",},
                    new Category {categoryName = "Научная фантастика", description="Путешествия в мирах высоких технологий"},
                    new Category {categoryName = "Приключения", description="Истории об отважных путешественниках"}

                };
                


            }
        
        
        }
    }
}
