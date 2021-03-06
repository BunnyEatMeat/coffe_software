﻿namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHTForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSoTienKhachDua = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienThoi = new System.Windows.Forms.TextBox();
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
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdd)).BeginInit();
            this.flpTable.SuspendLayout();
            this.SuspendLayout();
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
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(436, 335);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSoTienKhachDua);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTienThoi);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Location = new System.Drawing.Point(418, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 76);
            this.panel3.TabIndex = 3;
            // 
            // txtSoTienKhachDua
            // 
            this.txtSoTienKhachDua.Location = new System.Drawing.Point(12, 33);
            this.txtSoTienKhachDua.Name = "txtSoTienKhachDua";
            this.txtSoTienKhachDua.Size = new System.Drawing.Size(95, 20);
            this.txtSoTienKhachDua.TabIndex = 12;
            this.txtSoTienKhachDua.Text = "0";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Cyan;
            this.btnThanhToan.Location = new System.Drawing.Point(331, 44);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(113, 34);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 10;
            this.txtTongTien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(139, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiền khách đưa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiền Thối";
            // 
            // txtTienThoi
            // 
            this.txtTienThoi.Enabled = false;
            this.txtTienThoi.Location = new System.Drawing.Point(219, 33);
            this.txtTienThoi.Name = "txtTienThoi";
            this.txtTienThoi.Size = new System.Drawing.Size(100, 20);
            this.txtTienThoi.TabIndex = 6;
            this.txtTienThoi.Text = "0";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Cyan;
            this.btnCheck.Location = new System.Drawing.Point(329, 9);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Tính Tổng Tiền";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            this.btnAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnAdd.Location = new System.Drawing.Point(237, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.cbBeverage.Items.AddRange(new object[] {
            "Thức Uống",
            "Đồ Dùng"});
            this.cbBeverage.Location = new System.Drawing.Point(3, 3);
            this.cbBeverage.Name = "cbBeverage";
            this.cbBeverage.Size = new System.Drawing.Size(214, 21);
            this.cbBeverage.TabIndex = 0;
            this.cbBeverage.SelectedIndexChanged += new System.EventHandler(this.cbBeverage_SelectedIndexChanged);
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
            // QLHTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(854, 447);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLHTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hệ thống";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdd)).EndInit();
            this.flpTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbBeverage;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown nudAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTienThoi;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtSoTienKhachDua;
    }
}

