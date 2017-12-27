using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CONTROLELLER;
namespace GUI
{
    public partial class MenuForm : Form
    {
        MenuController menu = new MenuController();

        public MenuForm()
        {
            InitializeComponent();
            loadDanhSachMonDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnSearch2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idPrice_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        void loadDanhSachMonDataGridView()
        {
            List<CONTROLELLER.Menu> m = menu.getDSMenu();

            foreach(CONTROLELLER.Menu mon in m)
            {
                dgvFood.Rows.Add(mon.ID, mon.tenMon, mon.loai, mon.gia);
            }
        }


    }//end
}
