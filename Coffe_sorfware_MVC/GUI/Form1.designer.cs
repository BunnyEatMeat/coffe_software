namespace GUI
{
    partial class frmQLNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNs = new System.Windows.Forms.Label();
            this.lbCv = new System.Windows.Forms.Label();
            this.lbLuong = new System.Windows.Forms.Label();
            this.lbttct = new System.Windows.Forms.Label();
            this.lbttc = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.dtgTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Nhân Viên";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(62, 41);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(40, 13);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã NV";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(65, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(54, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Họ và tên";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNs
            // 
            this.lbNs.AutoSize = true;
            this.lbNs.Location = new System.Drawing.Point(65, 111);
            this.lbNs.Name = "lbNs";
            this.lbNs.Size = new System.Drawing.Size(56, 13);
            this.lbNs.TabIndex = 3;
            this.lbNs.Text = "Ngày Sinh";
            // 
            // lbCv
            // 
            this.lbCv.AutoSize = true;
            this.lbCv.Location = new System.Drawing.Point(377, 41);
            this.lbCv.Name = "lbCv";
            this.lbCv.Size = new System.Drawing.Size(48, 13);
            this.lbCv.TabIndex = 4;
            this.lbCv.Text = "Chức Vụ";
            this.lbCv.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(380, 75);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(37, 13);
            this.lbLuong.TabIndex = 5;
            this.lbLuong.Text = "Lương";
            // 
            // lbttct
            // 
            this.lbttct.AutoSize = true;
            this.lbttct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbttct.ForeColor = System.Drawing.Color.Blue;
            this.lbttct.Location = new System.Drawing.Point(29, 23);
            this.lbttct.Name = "lbttct";
            this.lbttct.Size = new System.Drawing.Size(103, 16);
            this.lbttct.TabIndex = 6;
            this.lbttct.Text = "Thông tin chi tiết";
            // 
            // lbttc
            // 
            this.lbttc.AutoSize = true;
            this.lbttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbttc.ForeColor = System.Drawing.Color.Blue;
            this.lbttc.Location = new System.Drawing.Point(28, 181);
            this.lbttc.Name = "lbttc";
            this.lbttc.Size = new System.Drawing.Size(102, 16);
            this.lbttc.TabIndex = 7;
            this.lbttc.Text = "Thông tin chung";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(445, 154);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(545, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(648, 154);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(343, 154);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(440, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(440, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgTen,
            this.dtgNs,
            this.dtgGioitinh,
            this.dtgDc,
            this.dtgDt,
            this.dtgCv,
            this.dtgLuong});
            this.dataGridView1.Location = new System.Drawing.Point(32, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 139);
            this.dataGridView1.TabIndex = 17;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Location = new System.Drawing.Point(383, 110);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(51, 13);
            this.lbGioitinh.TabIndex = 18;
            this.lbGioitinh.Text = "Giới Tính";
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(445, 109);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(48, 17);
            this.cbNam.TabIndex = 19;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Location = new System.Drawing.Point(513, 109);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(40, 17);
            this.cbNu.TabIndex = 20;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            // 
            // dtgTen
            // 
            this.dtgTen.HeaderText = "Họ và Tên";
            this.dtgTen.Name = "dtgTen";
            // 
            // dtgNs
            // 
            this.dtgNs.HeaderText = "Ngày Sinh";
            this.dtgNs.Name = "dtgNs";
            // 
            // dtgGioitinh
            // 
            this.dtgGioitinh.HeaderText = "Giới Tính";
            this.dtgGioitinh.Name = "dtgGioitinh";
            // 
            // dtgDc
            // 
            this.dtgDc.HeaderText = "Địa chỉ";
            this.dtgDc.Name = "dtgDc";
            // 
            // dtgDt
            // 
            this.dtgDt.HeaderText = "Điện thoại";
            this.dtgDt.Name = "dtgDt";
            // 
            // dtgCv
            // 
            this.dtgCv.HeaderText = "Chức Vụ";
            this.dtgCv.Name = "dtgCv";
            // 
            // dtgLuong
            // 
            this.dtgLuong.HeaderText = "Lương";
            this.dtgLuong.Name = "dtgLuong";
            this.dtgLuong.Width = 62;
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 359);
            this.Controls.Add(this.cbNu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.lbGioitinh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbttc);
            this.Controls.Add(this.lbttct);
            this.Controls.Add(this.lbLuong);
            this.Controls.Add(this.lbCv);
            this.Controls.Add(this.lbNs);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label1);
            this.Name = "frmQLNV";
            this.Text = "frmQLNV";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbNs;
        private System.Windows.Forms.Label lbCv;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Label lbttct;
        private System.Windows.Forms.Label lbttc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLuong;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.CheckBox cbNu;
    }
}

