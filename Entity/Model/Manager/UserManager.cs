using Entity.Model.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Model.Manager
{
    public class UserManager
    {
        private readonly IUserDao _userDao;

        public UserManager()
        {
            _userDao = new UserDao();
        }
        public IEnumerable<Context.User> GetUsers()
        {
            return _userDao.GetUser();
        }
    }
}
