using Entity.Model.DAOs;
using Entity.Model.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class UserDao : IUserDao
    {
        public IEnumerable<Context.User> GetUser()
        {
             using (var context = new Context.DataContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
