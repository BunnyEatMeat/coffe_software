using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace MODEL
{
    public class NhanVienModel
    {
        Connector cn = new Connector();

        public void themNhanVienM(string hoTen, string ngaySinh, string gioiTinh, string diaChi, string dienThoai, int chucVu, int luong)
        {
            try
            {
                string sqlStr = "insert into NHANVIEN(hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, chucVu, luong) values (N'"+ hoTen + "', N'" + ngaySinh +"', N'" + gioiTinh + "', N'" + diaChi + "', N'" + dienThoai + "', " + chucVu + ", " + luong + ")";

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataSet layDanhSachNhanVienM()
        {
            try
            {
                string sqlStr = "select * from NHANVIEN";

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

        public void xoaIDM(int ID)
        {
            try
            {
                string sqlStr = "DELETE NHANVIEN WHERE ID = " + ID;

                SqlCommand cmd = new SqlCommand(sqlStr, cn.connect());
                cmd.ExecuteNonQuery();

                cn.disconnect();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataSet layNhanVienTheoIDM(int ID)
        {
            try
            {
                string sqlStr = "select * from NHANVIEN where ID = " + ID;

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

        public void suaThongTinNhanVienM(int ID, string tenNhanVien, string ngaySinh, string gioiTinh, string diaChi, string sdt, int chucVu, int luong)
        {
            try
            {
                string sqlStr = "UPDATE NHANVIEN Set hoTen = N'"+ tenNhanVien + "', ngaySinh = N'" + ngaySinh +"', gioiTinh = N'" + gioiTinh + "', diaChi = N'" + diaChi + "', dienThoai = N'" + sdt + "', chucVu = " + chucVu + ", luong = " + luong + " " + " WHERE ID = " + ID;

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
