using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Category            //Параметры категории
    {
        public int Id { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public List<Book> Books { set; get; }

    }
}
