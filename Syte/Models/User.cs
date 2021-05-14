using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Name { set; get; }
        //public string Surname { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        
        public List<MyBooks> MyBooks { set; get; }

    }
}
