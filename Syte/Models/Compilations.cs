using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Compilations
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Desc { set; get; }
        public List<Book> Books { set; get; }

    }
}