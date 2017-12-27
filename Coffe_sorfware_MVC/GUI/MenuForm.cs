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
            List<CONTROLELLER.Menu> m = new List<CONTROLELLER.Menu>();
            m = menu.getDSMenu();

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" || txtGia.Text == "")
                MessageBox.Show("Không được để trống ô này!");
            else
            {
                int gia;
                if (!int.TryParse(txtGia.Text, out gia))
                    MessageBox.Show("Nhập giá không đúng!");
                else
                {
                    gia = int.Parse(txtGia.Text);
                    string tenMon = txtTenMon.Text.ToString();
                    int loai = 0;

                    if (cbLoai.SelectedIndex == 0)
                        loai = 1;// Nước uống
                    if (cbLoai.SelectedIndex == 1)
                        loai = 2;// Đồ dùng

                    DialogResult dr = MessageBox.Show("Bạn có chắc là muốn thêm " + tenMon + " vào danh sách không?", "Thêm", MessageBoxButtons.YesNo);
                    
                    switch(dr)
                    {
                        case DialogResult.Yes: menu.themMon(tenMon, loai, gia);
                            MessageBox.Show("Thêm Thành Công!");
                            txtGia.Clear();
                            txtTenMon.Clear();
                            dgvMenu.Rows.Clear();
                            loadDanhSachMonDataGridView();
                            break;
                        case DialogResult.No: break;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string getID = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();
            string getName = dgvMenu.SelectedRows[0].Cells[1].Value.ToString();

            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn xóa " + getName + " khỏi danh sách không?", "Xóa", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes: menu.xoaMon(int.Parse(getID));
                    MessageBox.Show("Xóa Thành Công!");
                    dgvMenu.Rows.Remove(dgvMenu.SelectedRows[0]);
                    break;
                case DialogResult.No: break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string getID = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();
            int ID = int.Parse(getID);
            EditMenu ed = new EditMenu(ID);
            ed.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvMenu.Rows.Clear();
            loadDanhSachMonDataGridView();
        }

    }//end
}
