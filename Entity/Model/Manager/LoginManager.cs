using Entity.Model.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Model.Manager
{
    public class LoginManager
    {
        private ILoginDao _loginDao;

        public LoginManager()
        {
            _loginDao = new LoginDao();
        }

        public bool LoginUser(string name, string pass)
        {
            return _loginDao.LoginUser(name, pass);
        }
    }
}
