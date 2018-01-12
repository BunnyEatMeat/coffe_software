namespace GUI
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.btnQLHT = new System.Windows.Forms.Button();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLHT
            // 
            this.btnQLHT.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnQLHT.ForeColor = System.Drawing.Color.Azure;
            this.btnQLHT.Location = new System.Drawing.Point(302, 77);
            this.btnQLHT.Name = "btnQLHT";
            this.btnQLHT.Size = new System.Drawing.Size(155, 107);
            this.btnQLHT.TabIndex = 0;
            this.btnQLHT.Text = "Bán Hàng";
            this.btnQLHT.UseVisualStyleBackColor = false;
            this.btnQLHT.Click += new System.EventHandler(this.btnQLHT_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnQLTK.ForeColor = System.Drawing.Color.Azure;
            this.btnQLTK.Location = new System.Drawing.Point(302, 206);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(155, 107);
            this.btnQLTK.TabIndex = 1;
            this.btnQLTK.Text = "Quản Lý Tài Khoàn";
            this.btnQLTK.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMenu.ForeColor = System.Drawing.Color.Azure;
            this.btnMenu.Location = new System.Drawing.Point(474, 206);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 107);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnQLNV.ForeColor = System.Drawing.Color.Azure;
            this.btnQLNV.Location = new System.Drawing.Point(474, 77);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(155, 107);
            this.btnQLNV.TabIndex = 3;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Location = new System.Drawing.Point(545, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 26);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 417);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnQLTK);
            this.Controls.Add(this.btnQLHT);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLHT;
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnLogout;
    }
}