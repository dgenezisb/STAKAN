using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { set; get; }
        public List<Book> Books { set; get; }

    }
}
