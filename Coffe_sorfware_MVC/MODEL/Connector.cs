using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MODEL
{
    public class Connector
    {
        string strConn = @"Data Source=DESKTOP-KKHKH84\SQLEXPRESS;Initial Catalog=coffe_manager;Integrated Security=True";
        SqlConnection cn = null;
        public Connector()
        {
            cn = new SqlConnection(strConn);
        }
        public SqlConnection connect()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                return cn;
            }catch(SqlException ex)
            { 
                throw ex;
            }
        }

        public SqlConnection disconnect()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                return cn;
            }catch(SqlException ex)
            { 
                throw ex;
            }
        }

    }//end
}
