using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using DAO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            AccountDTO ac = new AccountDTO();
            ac.UserName = txt_UserName.Text.ToString();
            ac.PassWord = txt_UserName.Text.ToString();

            AccountDAO lg = new AccountDAO();
            int chck = lg.checkAccount(ac.UserName, ac.PassWord);

            if (chck == 1)
                MessageBox.Show("Success!");
            else
                MessageBox.Show("Fail!");
        }
    }
}
