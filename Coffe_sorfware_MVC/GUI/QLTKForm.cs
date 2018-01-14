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
    public partial class QLTKForm : Form
    {
        NhanVienController nv = new NhanVienController();
        TaiKhoanController tk = new TaiKhoanController();
        public QLTKForm()
        {
            InitializeComponent();
            loadNhanVienComboBox();
            loadTaiKhoanDadaGridView();
        }

        void loadNhanVienComboBox()
        {
            cbMember.DataSource = nv.layDanhSachNhanVienC();
            cbMember.DisplayMember = "hoTen";
            cbMember.ValueMember = "ID";
        }

        void loadTaiKhoanDadaGridView()
        {
            
            List<TaiKhoan> tkl = tk.layDanhSachTaiKhoanC();
            List<NhanVien> nvl = nv.layDanhSachNhanVienC();
            foreach(TaiKhoan i in tkl)
            {
                foreach(NhanVien n in nvl)
                {
                    if(n.ID == i.maNV)
                    {
                        dgvAccount.Rows.Add(i.tenTK, i.matKhauTK, n.hoTen);
                        break;
                    }
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPss.Text != txtCfPass.Text)
                MessageBox.Show("Mật Khẩu không đúng!");
            else
            {
                tk.themTaiKhoanC(txtUID.Text, txtPss.Text, int.Parse(cbMember.SelectedValue.ToString()));
                MessageBox.Show("Đã Thêm!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string getID = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn xóa khỏi danh sách không?", "Xóa", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes: 
                    tk.xoaTaiKhoanC(getID);
                    MessageBox.Show("Xóa Thành Công!");
                    dgvAccount.Rows.Remove(dgvAccount.SelectedRows[0]);
                    break;
                case DialogResult.No: break;
            }
        }
    }
}
