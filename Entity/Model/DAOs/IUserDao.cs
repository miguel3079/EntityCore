﻿using Entity.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Model.DAOs
{
    public interface IUserDao
    {
        IEnumerable<Context.User> GetUser();

        Context.User GetUserById(int id);

        bool NewUser(UserDto userDto);

        bool DeleteUserById(int idUser);
    }
}
