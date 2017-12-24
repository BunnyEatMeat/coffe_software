using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ProviderDAO
    {
     
        SqlConnection cn;
        string strConnectSQL = @"Data Source=DESKTOP-KKHKH84\SQLEXPRESS;Initial Catalog=account;Integrated Security=True";

        public SqlConnection connect()
        {
            return cn = new SqlConnection(strConnectSQL);
        }

        public void disconnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Ngat ket noi khong thanh cong!");
            }
        }
    }//end
}
