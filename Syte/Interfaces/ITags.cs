using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte.Interfaces
{
   public interface ITags
    {
        IEnumerable<Tags> ListofTags { get;}
    }
}
