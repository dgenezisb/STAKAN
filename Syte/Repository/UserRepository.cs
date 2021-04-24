using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class UserRepository : IUser
    {
        private readonly AppDBContext appDBContent;
        public UserRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<User> ListofUser => appDBContent.User;
    }
}
