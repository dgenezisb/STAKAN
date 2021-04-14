using Syte.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Models
{
    public class Authors
    {
        public int id { set; get; }
        public string name { set; get; }
        public string surname { set; get; }
        public int DateBD { set; get; }
        public int DateOfdeath { set; get; }
        public List<Book> book { set; get; }

    }
}
