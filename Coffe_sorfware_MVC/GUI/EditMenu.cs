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
    public partial class EditMenu : Form
    {
        CONTROLELLER.MenuController menu = new MenuController();
        int getID = 0;
        public EditMenu(int id)
        {
            InitializeComponent();
            cbLoai.SelectedIndex = 0;
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            getID = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
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

                    DialogResult dr = MessageBox.Show("Bạn có chắc là muốn Sửa thành" + tenMon + " ?", "Sửa", MessageBoxButtons.YesNo);

                    switch (dr)
                    {
                        case DialogResult.Yes: menu.suaMon(getID,tenMon, loai, gia);
                            MessageBox.Show("Sửa Thành Công!");
                            Close();
                            break;
                        case DialogResult.No: break;
                    }
                }
            }
        }


    }//end
}
