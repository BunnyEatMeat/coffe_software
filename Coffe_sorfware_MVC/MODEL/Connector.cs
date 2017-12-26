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
        string strConn = "";
        SqlConnection cn = null;
        public Connector()
        {
            cn = new SqlConnection(strConn);
        }

        public void connect()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }catch(SqlException ex)
            { 
                throw ex;
            }
        }

        public void disconnect()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }catch(SqlException ex)
            { 
                throw ex;
            }
        }

    }//end
}
