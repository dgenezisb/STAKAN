using  Syte.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Syte.interfaces
{
    interface IBooksCategories
    {
        IEnumerable<Category> ListofCategories { get; }
    }
}
