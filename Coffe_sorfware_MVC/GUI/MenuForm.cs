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
            loadDanhSachLoaiMonCombobox();
        }

        void loadDanhSachMonDataGridView()
        {
            List<CONTROLELLER.Menu> m = menu.getDSMenu();

            foreach(CONTROLELLER.Menu mon in m)
            {
                dgvMenu.Rows.Add(mon.ID, mon.tenMon, mon.loai, mon.gia);
            }
        }

        void loadDanhSachLoaiMonCombobox()
        {
            cbLoai.SelectedIndex = 0;
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }


    }//end
}
