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
    public partial class Login : Form
    {
        LoginController kt = new LoginController();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a;
            if (this.txt1.TextLength == 0 || this.txt2.TextLength == 0)
            {
                if (this.txt1.TextLength == 0)
                {
                    this.txt1.ForeColor = Color.Red;
                    this.txt1.Text = "Không được bỏ trống!";

                }
                if (this.txt2.TextLength == 0)
                {
                    this.txt2.ForeColor = Color.Red;
                    this.txt2.UseSystemPasswordChar = true;
                    this.txt2.Text = "Không được bỏ trống!";
                }
            }
            else
            {
                a = kt.Kiemtra(txt1.Text, txt2.Text);
                if (a == true)
                {
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo");
                    SelectionForm f = new SelectionForm();
                    f.Show();
                }
                else
                    if (a == false && this.txt2.Text != "Không được bỏ trống!" && this.txt1.Text != "Không được bỏ trống!")
                    {
                        MessageBox.Show("Đăng nhập Thất Bại !", "Thông báo");
                    }
            }
        }

        private void txt2_MouseClick(object sender, MouseEventArgs e)
        {
            this.txt2.ForeColor = Color.Black;
            this.txt2.UseSystemPasswordChar = false;
            this.txt2.Text = "";
        }

        private void txt1_MouseClick(object sender, MouseEventArgs e)
        {
            this.txt1.ForeColor = Color.Black;
            this.txt1.Text = "";
        }

    }
}
