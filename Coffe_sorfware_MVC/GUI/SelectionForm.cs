using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuF = new MenuForm();
            menuF.Show();
        }

        private void btnQLHT_Click(object sender, EventArgs e)
        {
            QLHTForm qlhtF = new QLHTForm();
            qlhtF.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQLNV qlnvF = new frmQLNV();
            qlnvF.Show();
        }
    }//end
}
