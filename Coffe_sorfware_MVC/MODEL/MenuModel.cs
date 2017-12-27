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
    public class MenuModel
    {
        Connector cn = new Connector();
        public DataSet layDanhSachMenu()
        {
            try
            {
                string sqlStr = "select * from Menu";

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                cn.disconnect();
                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }//end
}
