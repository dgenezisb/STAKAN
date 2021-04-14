using Biblio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Biblio.Data.Interfaces
{
    interface IBooksCategories
    {
        IEnumerable<Category> ListofCategories { get; }
    }
}
