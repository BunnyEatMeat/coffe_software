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
    public class NhanVienController
    {
        NhanVienModel nvModel = new NhanVienModel();

        public void themNhanVienC(string hoTen, string ngaySinh, string gioiTinh, string diaChi, string dienThoai, int chucVu, int luong)
        {
            nvModel.themNhanVienM(hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, chucVu, luong);
        }

        public List<NhanVien> layDanhSachNhanVienC()
        {
            DataSet ds = nvModel.layDanhSachNhanVienM();
            List<NhanVien> nvList = new List<NhanVien>();

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                nvList.Add(new NhanVien() {
                    ID = (int)row["ID"],
                    hoTen = (string)row["hoTen"],
                    ngaySinh = row["ngaySinh"].ToString(),
                    gioiTinh = (string)row["gioiTinh"],
                    diaChi = (string)row["diaChi"],
                    dienThoai = (string)row["dienThoai"],
                    chucVu = (int)row["chucVu"],
                    luong = (int)row["luong"]
                });
            }
            return nvList;
        }

        public void xoaNhanVienC(int ID)
        {
            nvModel.xoaIDM(ID);
        }

        public List<NhanVien> layNhanVienTheoIDC(int ID)
        {
            DataSet ds = nvModel.layDanhSachNhanVienM();
            List<NhanVien> nvList = new List<NhanVien>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                nvList.Add(new NhanVien()
                {
                    ID = (int)row["ID"],
                    hoTen = (string)row["hoTen"],
                    ngaySinh = row["ngaySinh"].ToString(),
                    gioiTinh = (string)row["gioiTinh"],
                    diaChi = (string)row["diaChi"],
                    dienThoai = (string)row["dienThoai"],
                    chucVu = (int)row["chucVu"],
                    luong = (int)row["luong"]
                });
            }
            return nvList;
        }

        public void suaThongTinNhanVienC(int ID,string tenNhanVien, string ngaySinh, string gioiTinh, string diaChi, string sdt, int chucVu, int luong)
        {
            nvModel.suaThongTinNhanVienM(ID, tenNhanVien, ngaySinh, gioiTinh, diaChi, sdt, chucVu, luong);
        }
    }//end
}
