using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Mocks
{
    public class Mock_Tags : ITags
    {
        public IEnumerable<Tags> ListofTags
        {
            get
            {
                return new List<Tags>                                       //ЗДЕСЬ ОПИСАТЬ ТЭГИ НА САЙТЕ
                {
                    new Tags {Name = "#1", },
                    new Tags {Name = "#2", }
                };
            }
        }
    }
}
