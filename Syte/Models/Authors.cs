using Syte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Authors
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Surname { set; get; }
        public string DateBD { set; get; }
        public string DateOfdeath { set; get; }
        public List<Book> Books { set; get; }

    }
}