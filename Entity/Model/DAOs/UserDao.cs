using Entity.Model.DAOs;
using Entity.Model.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public Context.User GetUserById(int id)
        {
            using (var context = new Context.DataContext())
            {
                return context.Users.Where(x => x.IdUser == id).FirstOrDefault();
            }
        }

        public bool NewUser(UserDto userDto)
        {
            try
            {
                using (var context = new Context.DataContext())
                {
                    context.Users.InsertOnSubmit(DtoToContextUser(userDto));
                    context.SubmitChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool DeleteUserById(int idUser)
        {
            try
            {
                using (var context = new Context.DataContext())
                {
                    var userDelete = context.Users.Where(x => x.IdUser == idUser).FirstOrDefault();
                    context.Users.DeleteOnSubmit(userDelete);
                    context.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Context.User DtoToContextUser(UserDto userDto)
        {
            return new Context.User
            {
                Name = userDto.Name,
                Surname = userDto.Surname,
                Email = userDto.Email,
                Pass = userDto.Password,
                Active = userDto.Status
            };
        }
    }
}
