using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        public int checkAccount(string _userName, string _passWord)
        {
            int res = 0;
            string strSql = string.Format("select * form account where [id] = '{0}' and pass ='{1}'}", _userName, _passWord);

            ProviderDAO p = new ProviderDAO();
            SqlCommand cmd = new SqlCommand(strSql, p.connect());
            return res;
        }
    }
}
