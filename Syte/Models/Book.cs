using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Syte.Models
{
    public class Book              //Параметры книги
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Name { set; get; }
        public int AuthorID { set; get; }
        [ForeignKey(nameof(AuthorID))]
        public virtual Authors Author { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }
        public bool IsFavourite { set; get; }
        public int CategoryID { set; get; }
        //public virtual MyBooks MyBooks { set; get; }
        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { set; get; }
        //public virtual Tags Tags { set; get; }
        public ICollection<Tags> Tag{ get; set; }
        public Book()
        {
            Tag = new List<Tags>();
        }
        public int PublisherID { set; get; }
        [ForeignKey(nameof(PublisherID))]
        public virtual Publisher Publisher { set; get; }
        //public virtual Compilations Compilation { set; get; }
        public List<Reviews> Reviews { set; get; }
    }
}
