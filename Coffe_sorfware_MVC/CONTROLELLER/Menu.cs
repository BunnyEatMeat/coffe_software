using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLELLER
{
    public class Menu
    {
        public int ID { get; set; }
        public string tenMon { get; set; }
        public int gia { get; set; }
        public int loai { get; set; }

        public Menu()
        {
            this.ID = 0;
            this.tenMon = null;
            this.gia = 0;
            this.loai = 0;
        }
    }//end
}
