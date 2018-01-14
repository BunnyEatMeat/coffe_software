using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
using System.Data;

namespace CONTROLELLER
{
    public class LoginController
    {
        LoginModel login = new LoginModel();
        public bool Kiemtra(string a, string b)
        {
            return login.Login(a,b);
        }
    }
}
