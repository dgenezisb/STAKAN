using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Category
    {
        public int id { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public List<Book> Books { set; get; }

    }
}
