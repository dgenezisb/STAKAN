using Syte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
    interface IBooksCategories
    {
        IEnumerable<Category> ListofCategories { get; }
    }
}
