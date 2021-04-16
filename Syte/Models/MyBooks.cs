using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class MyBooks
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public List<Book> Books { set; get; }
    }
}
