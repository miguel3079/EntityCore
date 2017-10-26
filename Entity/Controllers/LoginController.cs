using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity.Model.DAOs;
using Entity.Model.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Entity.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private ILoginDao _loginDao;

        public LoginController()
        {
            _loginDao = new LoginDao();
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]UserDto user)
        {
            return _loginDao.LoginUser(user.Name, user.Password);
        }
    }
}
