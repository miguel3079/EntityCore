using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Logica
{
    public class Encrypter
    {
        public string DesEncripterPass(string passEncrypted)
        {
            byte[] decryted = Convert.FromBase64String(passEncrypted);
            string password = System.Text.Encoding.Unicode.GetString(decryted);
            return password;
        }

        public string EncripterPass(string pass)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pass);
            return Convert.ToBase64String(encryted);
        }
    }
}
