using Entity.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Model.DAOs
{
    public class LoginDao : ILoginDao
    {
        private Encrypter _encrypter;

        public LoginDao()
        {
            _encrypter = new Encrypter();
        }

        public bool LoginUser(string name, string pass)
        {
            Context.User result;
            
            using (var context = new Context.DataContext())
            {
                result = context.Users.Where(x => x.Name == name && x.Pass == _encrypter.EncripterPass(pass) && x.Active == true).FirstOrDefault();
            }

            if (result == null) return false;
            else return true;
        }
    }
}
