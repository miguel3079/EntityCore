using Entity.Model.DAOs;
using Entity.Model.DTOs;
using System.Collections.Generic;

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

        public Context.User GetUsersById(int id)
        {
            return _userDao.GetUserById(id);
        }

        public bool InsertNewUser(UserDto userDto)
        {
            return _userDao.NewUser(userDto);
        }

        public bool DeleteUserById(int idUser)
        {
            return _userDao.DeleteUserById(idUser);
        }
    }
}
