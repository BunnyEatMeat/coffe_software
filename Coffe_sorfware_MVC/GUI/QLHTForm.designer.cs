namespace GUI
{
    partial class QLHTForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudAdd = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbBeverage = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnTable7 = new System.Windows.Forms.Button();
            this.btnTable8 = new System.Windows.Forms.Button();
            this.btnTable9 = new System.Windows.Forms.Button();
            this.btnTable10 = new System.Windows.Forms.Button();
            this.btnTable11 = new System.Windows.Forms.Button();
            this.btnTable12 = new System.Windows.Forms.Button();
            this.btnTable13 = new System.Windows.Forms.Button();
            this.btnTable14 = new System.Windows.Forms.Button();
            this.btnTable15 = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdd)).BeginInit();
            this.flpTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = " Đăng xuất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(418, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 270);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(436, 335);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.nudDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Location = new System.Drawing.Point(418, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 67);
            this.panel3.TabIndex = 3;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(104, 25);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(165, 31);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(104, 20);
            this.nudDiscount.TabIndex = 5;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(165, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(104, 25);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(329, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 48);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudAdd);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbBeverage);
            this.panel4.Location = new System.Drawing.Point(418, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 59);
            this.panel4.TabIndex = 4;
            // 
            // nudAdd
            // 
            this.nudAdd.Location = new System.Drawing.Point(358, 19);
            this.nudAdd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAdd.Name = "nudAdd";
            this.nudAdd.Size = new System.Drawing.Size(48, 20);
            this.nudAdd.TabIndex = 3;
            this.nudAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 30);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(214, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbBeverage
            // 
            this.cbBeverage.FormattingEnabled = true;
            this.cbBeverage.Location = new System.Drawing.Point(3, 3);
            this.cbBeverage.Name = "cbBeverage";
            this.cbBeverage.Size = new System.Drawing.Size(214, 21);
            this.cbBeverage.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Controls.Add(this.btnTable1);
            this.flpTable.Controls.Add(this.btnTable2);
            this.flpTable.Controls.Add(this.btnTable3);
            this.flpTable.Controls.Add(this.btnTable4);
            this.flpTable.Controls.Add(this.btnTable5);
            this.flpTable.Controls.Add(this.btnTable6);
            this.flpTable.Controls.Add(this.btnTable7);
            this.flpTable.Controls.Add(this.btnTable8);
            this.flpTable.Controls.Add(this.btnTable9);
            this.flpTable.Controls.Add(this.btnTable10);
            this.flpTable.Controls.Add(this.btnTable11);
            this.flpTable.Controls.Add(this.btnTable12);
            this.flpTable.Controls.Add(this.btnTable13);
            this.flpTable.Controls.Add(this.btnTable14);
            this.flpTable.Controls.Add(this.btnTable15);
            this.flpTable.Location = new System.Drawing.Point(0, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(412, 409);
            this.flpTable.TabIndex = 5;
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(3, 3);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(75, 56);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Bàn 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(84, 3);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(75, 56);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "Bàn 2";
            this.btnTable2.UseVisualStyleBackColor = true;
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(165, 3);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(75, 56);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Bàn 3";
            this.btnTable3.UseVisualStyleBackColor = true;
            // 
            // btnTable4
            // 
            this.btnTable4.Location = new System.Drawing.Point(246, 3);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(75, 56);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "Bàn 4";
            this.btnTable4.UseVisualStyleBackColor = true;
            // 
            // btnTable5
            // 
            this.btnTable5.Location = new System.Drawing.Point(327, 3);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(75, 56);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "Bàn 5";
            this.btnTable5.UseVisualStyleBackColor = true;
            // 
            // btnTable6
            // 
            this.btnTable6.Location = new System.Drawing.Point(3, 65);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(75, 56);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "Bàn 6";
            this.btnTable6.UseVisualStyleBackColor = true;
            // 
            // btnTable7
            // 
            this.btnTable7.Location = new System.Drawing.Point(84, 65);
            this.btnTable7.Name = "btnTable7";
            this.btnTable7.Size = new System.Drawing.Size(75, 56);
            this.btnTable7.TabIndex = 6;
            this.btnTable7.Text = "Bàn 7";
            this.btnTable7.UseVisualStyleBackColor = true;
            // 
            // btnTable8
            // 
            this.btnTable8.Location = new System.Drawing.Point(165, 65);
            this.btnTable8.Name = "btnTable8";
            this.btnTable8.Size = new System.Drawing.Size(75, 56);
            this.btnTable8.TabIndex = 7;
            this.btnTable8.Text = "Bàn 8";
            this.btnTable8.UseVisualStyleBackColor = true;
            this.btnTable8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnTable9
            // 
            this.btnTable9.Location = new System.Drawing.Point(246, 65);
            this.btnTable9.Name = "btnTable9";
            this.btnTable9.Size = new System.Drawing.Size(75, 56);
            this.btnTable9.TabIndex = 8;
            this.btnTable9.Text = "Bàn 9";
            this.btnTable9.UseVisualStyleBackColor = true;
            // 
            // btnTable10
            // 
            this.btnTable10.Location = new System.Drawing.Point(327, 65);
            this.btnTable10.Name = "btnTable10";
            this.btnTable10.Size = new System.Drawing.Size(75, 56);
            this.btnTable10.TabIndex = 9;
            this.btnTable10.Text = "Bàn 10";
            this.btnTable10.UseVisualStyleBackColor = true;
            // 
            // btnTable11
            // 
            this.btnTable11.Location = new System.Drawing.Point(3, 127);
            this.btnTable11.Name = "btnTable11";
            this.btnTable11.Size = new System.Drawing.Size(75, 56);
            this.btnTable11.TabIndex = 10;
            this.btnTable11.Text = "Bàn 11";
            this.btnTable11.UseVisualStyleBackColor = true;
            // 
            // btnTable12
            // 
            this.btnTable12.Location = new System.Drawing.Point(84, 127);
            this.btnTable12.Name = "btnTable12";
            this.btnTable12.Size = new System.Drawing.Size(75, 56);
            this.btnTable12.TabIndex = 11;
            this.btnTable12.Text = "Bàn 12";
            this.btnTable12.UseVisualStyleBackColor = true;
            // 
            // btnTable13
            // 
            this.btnTable13.Location = new System.Drawing.Point(165, 127);
            this.btnTable13.Name = "btnTable13";
            this.btnTable13.Size = new System.Drawing.Size(75, 56);
            this.btnTable13.TabIndex = 12;
            this.btnTable13.Text = "Bàn 13";
            this.btnTable13.UseVisualStyleBackColor = true;
            // 
            // btnTable14
            // 
            this.btnTable14.Location = new System.Drawing.Point(246, 127);
            this.btnTable14.Name = "btnTable14";
            this.btnTable14.Size = new System.Drawing.Size(75, 56);
            this.btnTable14.TabIndex = 13;
            this.btnTable14.Text = "Bàn 14";
            this.btnTable14.UseVisualStyleBackColor = true;
            // 
            // btnTable15
            // 
            this.btnTable15.Location = new System.Drawing.Point(327, 127);
            this.btnTable15.Name = "btnTable15";
            this.btnTable15.Size = new System.Drawing.Size(75, 56);
            this.btnTable15.TabIndex = 14;
            this.btnTable15.Text = "Bàn 15";
            this.btnTable15.UseVisualStyleBackColor = true;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 30);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(104, 21);
            this.cbSwitchTable.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 447);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hệ thống";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdd)).EndInit();
            this.flpTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbBeverage;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown nudAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnTable7;
        private System.Windows.Forms.Button btnTable8;
        private System.Windows.Forms.Button btnTable9;
        private System.Windows.Forms.Button btnTable10;
        private System.Windows.Forms.Button btnTable11;
        private System.Windows.Forms.Button btnTable12;
        private System.Windows.Forms.Button btnTable13;
        private System.Windows.Forms.Button btnTable14;
        private System.Windows.Forms.Button btnTable15;
        private System.Windows.Forms.ComboBox cbSwitchTable;
    }
}

