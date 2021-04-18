using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class AuthorsRepository : IAuthors
    {
        private readonly AppDBContext appDBContent;
        public AuthorsRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Authors> ListofAuthors => appDBContent.Authors;
    }
}
