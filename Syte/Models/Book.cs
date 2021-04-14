using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblio.Data.Models
{
    public class Book
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Author { set; get; }
        public string ShortDesc { set; get; }
        public string LongDesc { set; get; }
        public string Image { set; get; }
        public bool IsFavourite { set; get; }
        public int CategoryID { set; get; }
        public virtual Category Category { set; get; }

    }
}
