using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Syte.Models
{
    public class Tags
    {
        private Guid guid;
        private string v;
        private Book book;

        public Tags(Guid guid, string v, Book book, Book book1)
        {
            this.guid = guid;
            this.v = v;
            this.book = book;
        }

        public Tags()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Name { set; get; }
        //public List<Book> Books { set; get; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
