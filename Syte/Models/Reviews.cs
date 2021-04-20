using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Reviews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { set; get; }
        public string NameOfBook { set; get; }
        public int BookId { set; get; }
        [ForeignKey(nameof(BookId))]
        public Book Book  { set; get; }
        public string Review { set; get; }

    }
}
