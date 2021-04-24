using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Syte.Models
{
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public bool Commercial { set; get; }
        public List<Book> Books { set; get; }
    }
}
