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

        public void themMenu(string tenMon, int loaiMon, int giaMon)
        {
            try
            {
                string sqlStr = "insert into MENU(tenMon, gia, loai) values (" + "N'"+ tenMon + "', "+ giaMon+ ", " + loaiMon + ")";

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void xoaMon(int ID)
        {
            try
            {
                string sqlStr = "DELETE MENU WHERE ID = " + ID;

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void suaMon(int ID,string tenMon, int loaiMon, int giaMon)
        {
            try
            {
                string sqlStr = "UPDATE MENU Set tenMon = N'" + tenMon + "' , loai = " + loaiMon + " , gia = " + giaMon + " WHERE ID = " + ID;

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }//end
}
