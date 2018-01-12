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
    public partial class QLHTForm : Form
    {
        CONTROLELLER.MenuController menuC = new MenuController();
        int thanhToan = 0;
        public QLHTForm()
        {
            InitializeComponent();

            cbBeverage.SelectedIndex = 0;
            loadMenuToCombobox(cbBeverage.SelectedIndex);
        }

        void loadMenuToCombobox(int n)
        {
            List<CONTROLELLER.Menu> menuList = new List<CONTROLELLER.Menu>();
            List<CONTROLELLER.Menu> menuFood = new List<CONTROLELLER.Menu>();

            menuList = menuC.getDSMenu();
            foreach(CONTROLELLER.Menu mon in menuList)
            {
                if (mon.loai == (n+1))
                    menuFood.Add(mon);
            }

            cbFood.DataSource = menuFood;
            cbFood.DisplayMember = "tenMon";
            cbFood.ValueMember = "ID";
        }

        private void cbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBeverage.SelectedIndex == 0)
                loadMenuToCombobox(0);
            else if (cbBeverage.SelectedIndex == 1)
                loadMenuToCombobox(1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenMon = cbFood.Text.ToString();
            string loai = cbBeverage.Text.ToString();
            int soLuong = int.Parse(nudAdd.Value.ToString());
            int gia = 0;

            int getID = int.Parse(cbFood.SelectedValue.ToString());

            List<CONTROLELLER.Menu> menuList = new List<CONTROLELLER.Menu>();
            menuList = menuC.getDSMenu();
            foreach(CONTROLELLER.Menu mon in menuList)
            {
                if (mon.ID == getID)
                    gia = mon.gia;
            }

            gia *= soLuong;

            ListViewItem item = new ListViewItem(tenMon);
            item.SubItems.Add(loai);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(gia.ToString());

            lsvBill.Items.Add(item);

            thanhToan += gia;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = thanhToan.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int tienKD;
            if (!int.TryParse(txtSoTienKhachDua.Text, out tienKD))
            {
                MessageBox.Show("Số tiền nhập sai!");
                txtSoTienKhachDua.Text = "0";
            }
            
            int tienthoi = 0;
            tienthoi = tienKD - thanhToan;
            if (tienthoi < 0)
                txtTienThoi.Text = "Đưa không đủ";
            else
                txtTienThoi.Text = tienthoi.ToString();

            lsvBill.Clear();
        }

    }//end
}
