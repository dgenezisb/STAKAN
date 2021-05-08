using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Syte.Models
{
    public class MyBooks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        //public List<Book> Books { set; get; }
        public int UserID { set; get; }
        [ForeignKey(nameof(UserID))]
        public virtual User User { set; get; }
    }
}
