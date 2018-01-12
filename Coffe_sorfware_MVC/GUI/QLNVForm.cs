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
    public partial class frmQLNV : Form
    {
        ChucVuController cvController = new ChucVuController();
        NhanVienController nvController = new NhanVienController();
        public frmQLNV()
        {
            InitializeComponent();
            loadChucVuComboBox();
            loadDanhSachNhanVienDataGridView();

            cbChucVu.SelectedIndex = 0;
            rdNam.Checked = true;
        }

        void loadChucVuComboBox()
        {
            List<CONTROLELLER.ChucVu> cv = new List<ChucVu>();

            cv = cvController.layDanhSachChucVu();

            cbChucVu.DataSource = cv;
            cbChucVu.DisplayMember = "chucVu";
            cbChucVu.ValueMember = "ID";

        }

        int kiemTraSDT(string sdt)
        {
            if (sdt.Count() > 14)
                return 0;
            foreach(char i in sdt)
            {
                if(char.IsLetter(i))
                {
                    return 0;
                }
            }
            return 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int luong;
            string sdt;
            if(!int.TryParse(txtLuong.Text, out luong))
            {
                MessageBox.Show("Nhập lương sai");
            }
            else if(kiemTraSDT(txtSDT.Text.ToString()) == 0)
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

                nvController.themNhanVienC(tenNhanVien, ngaySinh, gioiTinh, diaChi, sdt, chucVu, luong);
                MessageBox.Show("Thêm Thành Công!", "Thêm",MessageBoxButtons.OK);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void loadDanhSachNhanVienDataGridView()
        {
            List<NhanVien> nvList = new List<NhanVien>();
            List<ChucVu> cvList = new List<ChucVu>();

            nvList = nvController.layDanhSachNhanVienC();
            cvList = cvController.layDanhSachChucVu();
            foreach(NhanVien nv in nvList)
            {
                string loaiChucVu = null ;
                foreach(ChucVu cv in cvList)
                {
                    if(cv.ID == nv.chucVu)
                    {
                        dgvThongTinNhanVien.Rows.Add(nv.hoTen, nv.ngaySinh, nv.gioiTinh, nv.diaChi, nv.dienThoai, cv.chucVu, nv.luong, nv.ID);
                        break;
                    }
                    
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string getID = dgvThongTinNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            int ID = int.Parse(getID);

            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn xóa khỏi danh sách không?", "Xóa", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes: nvController.xoaNhanVienC(ID);
                    MessageBox.Show("Xóa Thành Công!");
                    dgvThongTinNhanVien.Rows.Remove(dgvThongTinNhanVien.SelectedRows[0]);
                    break;
                case DialogResult.No: break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string getID = dgvThongTinNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            int ID = int.Parse(getID);

            editQLNVForm qlnv = new editQLNVForm(ID);
            qlnv.Show();
        }
    }//end
}
