using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Mocks
{
    public class Mock_User : IUser
    {
        public IEnumerable<User> ListofUser
        {
            get
            {
                return new List<User>            //ЗДЕСЬ ОПИСАТЬ ПОЛЬЗОВАТЕЛЕЙ НА САЙТЕ                          
                {
                    new User {Name = "Читатель",Age=21 },
                    new User {Name = "Модератор", Age=40}
                };
            }
        }
    }
}
