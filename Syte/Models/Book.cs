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
        
        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { set; get; }
        
        public List<Tags> Tags { get; set; } = new List<Tags>();
        public List<MyBooks> MyBooks { get; set; } = new List<MyBooks>();
        public int PublisherID { set; get; }
        [ForeignKey(nameof(PublisherID))]
        public virtual Publisher Publisher { set; get; }
        public List<Reviews> Reviews { set; get; }
        public int CompilationID { set; get; }
        [ForeignKey(nameof(CompilationID))]
        public virtual Compilations Compilation { set; get; }
    }
}
