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
    public partial class editQLNVForm : Form
    {
        ChucVuController cvController = new ChucVuController();
        NhanVienController nvController = new NhanVienController();
        List<NhanVien> nv = new List<NhanVien>();
        public editQLNVForm(int ID)
        {
            InitializeComponent();
            loadChucVuComboBox();

            rdNam.Checked = true;
            nv = nvController.layNhanVienTheoIDC(ID);

            txtID.Text = nv[0].ID.ToString();
            txtTenNhanVien.Text = nv[0].hoTen.ToString();
            txtLuong.Text = nv[0].luong.ToString();
            txtSDT.Text = nv[0].dienThoai.ToString();
            txtDiaChi.Text = nv[0].diaChi.ToString();
        }

        void loadChucVuComboBox()
        {
            List<CONTROLELLER.ChucVu> cv = new List<ChucVu>();

            cv = cvController.layDanhSachChucVu();

            cbChucVu.DataSource = cv;
            cbChucVu.DisplayMember = "chucVu";
            cbChucVu.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        int kiemTraSDT(string sdt)
        {
            if (sdt.Count() > 14)
                return 0;
            foreach (char i in sdt)
            {
                if (char.IsLetter(i))
                {
                    return 0;
                }
            }
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int luong;
            string sdt;
            if (!int.TryParse(txtLuong.Text, out luong))
            {
                MessageBox.Show("Nhập lương sai");
            }
            else if (kiemTraSDT(txtSDT.Text.ToString()) == 0)
            {
                MessageBox.Show("Nhập số điện thoại sai!");
            }
            else
            {
                sdt = txtSDT.Text.ToString();
                string ngaySinh = dtpNgaySinh.Value.Date.ToString("yyyy/MM/dd");
                string tenNhanVien = txtTenNhanVien.Text.ToString();
                string diaChi = txtDiaChi.Text.ToString();
                int chucVu = (int)cbChucVu.SelectedValue;
                string gioiTinh;

                if (rdNam.Checked == true)
                    gioiTinh = rdNam.Text;
                else
                    gioiTinh = rdNu.Text;

                nvController.suaThongTinNhanVienC(int.Parse(txtID.Text),tenNhanVien, ngaySinh, gioiTinh, diaChi, sdt, chucVu, luong);
                MessageBox.Show("Sửa Thành Công!", "Sửa", MessageBoxButtons.OK);
            }
        }
    }//end
}
