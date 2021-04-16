using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Mocks
{
    public class Mock_Compilations : ICompilations
    {
        public IEnumerable<Compilations> ListofCompilations
        {
            get
            {
                return new List<Compilations>                                       //ЗДЕСЬ ОПИСАТЬ ПОДБОРКИ НА САЙТЕ
                {
                    new Compilations {Name = "Детские книги", Desc="Книги для детей всех возрастов",},
                };
            }
        }
    }
}
