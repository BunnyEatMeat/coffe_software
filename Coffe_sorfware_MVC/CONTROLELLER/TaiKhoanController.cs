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
    public class TaiKhoanController
    {
        TaiKhoanModel tk = new TaiKhoanModel();
        List<TaiKhoan> tkL = new List<TaiKhoan>();

        public List<TaiKhoan> layDanhSachTaiKhoanC()
        {
            DataSet ds = tk.layDanhSachTaiKhoanM();

            foreach(DataRow r in ds.Tables[0].Rows)
            {
                tkL.Add(new TaiKhoan() { 
                    tenTK = (string)r["tenTK"],
                    matKhauTK = (string)r["matkhauTK"],
                    maNV = (int)r["maNV"]
                });
            }
            return tkL;
        }

        public void xoaTaiKhoanC(string us)
        {
            tk.xoaTaiKhoanM(us);
        }

        public void themTaiKhoanC(string us, string pas, int id)
        {
            tk.themTaiKhoanM(us, pas, id);
        }
    }
}
