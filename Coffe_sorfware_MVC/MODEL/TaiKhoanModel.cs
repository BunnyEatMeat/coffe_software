using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace MODEL
{
    public class TaiKhoanModel
    {
        Connector cn = new Connector();

        public DataSet layDanhSachTaiKhoanM()
        {
            try
            {
                string sqlStr = "select * from tai_khoan";

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

        public void themTaiKhoanM(string us, string pas, int nv)
        {
            try
            {
                string sqlStr = "insert into tai_khoan(tenTK, matKhauTK, maNV) values('"+us+"', '"+pas+"', "+nv+")";

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void xoaTaiKhoanM(string us)
        {
            try
            {
                string sqlStr = "DELETE tai_khoan WHERE tenTK = '"+us+"'";

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
