using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Model.DAOs
{
    interface ILoginDao
    {
        bool LoginUser(string name, string pass);
    }
}
