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
            this.btnQLHT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLHT
            // 
            this.btnQLHT.Location = new System.Drawing.Point(474, 86);
            this.btnQLHT.Name = "btnQLHT";
            this.btnQLHT.Size = new System.Drawing.Size(155, 107);
            this.btnQLHT.TabIndex = 0;
            this.btnQLHT.Text = "QLHT";
            this.btnQLHT.UseVisualStyleBackColor = true;
            this.btnQLHT.Click += new System.EventHandler(this.btnQLHT_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(304, 86);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 107);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(304, 215);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(155, 107);
            this.btnQLNV.TabIndex = 3;
            this.btnQLNV.Text = "QLNV";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(545, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 26);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 352);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQLHT);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLHT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnLogout;
    }
}