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
        public int DateBD { set; get; }
        public int DateOfdeath { set; get; }
        public List<Book> book { set; get; }

    }
}
