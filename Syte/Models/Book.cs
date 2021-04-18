using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Book              //Параметры книги
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int AuthorID { set; get; }
        public virtual Authors Author { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }
        public bool IsFavourite { set; get; }
        public int CategoryID { set; get; }
        //public virtual MyBooks MyBooks { set; get; }
        public int ReviewsID { set; get; }
        public virtual Reviews Reviews { set; get; }
        public virtual Category Category { set; get; }
        //public virtual Tags Tags { set; get; }
        
        public int PublisherID { set; get; }
        
        public virtual Publisher Publisher { set; get; }
        //public virtual Compilations Compilation { set; get; }

    }
}
