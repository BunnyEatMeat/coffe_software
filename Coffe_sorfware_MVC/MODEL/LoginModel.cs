using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MODEL;


namespace MODEL
{
    public class LoginModel
    {
        Connector cn = new Connector();
        public bool Login(string a,string b)
        {
            cn.connect();
            string id = a;
            string pass = b;
            string sql = "select * from dbo.TAI_KHOAN where tenTK='" + id + "' and matKhauTK='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, cn.connect());
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                cn.disconnect();
                return true;
            }
            else
            {
                cn.disconnect();
                return false;
            }
          
        }
    }
}
