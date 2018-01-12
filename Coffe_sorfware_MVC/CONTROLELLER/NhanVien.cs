using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLELLER
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public int chucVu { get; set; }
        public int luong { get; set; }

        public NhanVien()
        {
            this.ID = 0;
            this.hoTen = null;
            this.ngaySinh = null;
            this.gioiTinh = null;
            this.diaChi = null;
            this.dienThoai = null;
            this.chucVu = 0;
            this.luong = 0;
        }
    }
}
