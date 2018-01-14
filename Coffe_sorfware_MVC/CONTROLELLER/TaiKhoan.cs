using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLELLER
{
    public class TaiKhoan
    {
        public string tenTK { get; set; }
        public string matKhauTK { get; set; }
        public int maNV { get; set; }
        public TaiKhoan()
        {
            this.tenTK = null;
            this.matKhauTK = null;
            this.maNV = 0;
        }
    }
}
