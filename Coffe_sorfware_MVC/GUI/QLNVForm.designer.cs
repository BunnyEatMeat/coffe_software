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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNV));
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.dtgTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
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
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(65, 52);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(54, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Họ và tên";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNs
            // 
            this.lbNs.AutoSize = true;
            this.lbNs.Location = new System.Drawing.Point(65, 83);
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
            this.btnSua.BackColor = System.Drawing.Color.Lime;
            this.btnSua.Location = new System.Drawing.Point(445, 163);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Lime;
            this.btnXoa.Location = new System.Drawing.Point(543, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 39);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Lime;
            this.btnThoat.Location = new System.Drawing.Point(635, 163);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 39);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Location = new System.Drawing.Point(342, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(139, 49);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(132, 20);
            this.txtTenNhanVien.TabIndex = 13;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(440, 73);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(100, 20);
            this.txtLuong.TabIndex = 15;
            this.txtLuong.Text = "0";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(141, 83);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(196, 20);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // dgvThongTinNhanVien
            // 
            this.dgvThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgTen,
            this.dtgNs,
            this.dtgGioitinh,
            this.dtgDc,
            this.dtgDt,
            this.dtgCv,
            this.dtgLuong,
            this.Column1});
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(32, 208);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.ReadOnly = true;
            this.dgvThongTinNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(701, 139);
            this.dgvThongTinNhanVien.TabIndex = 17;
            // 
            // dtgTen
            // 
            this.dtgTen.HeaderText = "Họ và Tên";
            this.dtgTen.Name = "dtgTen";
            this.dtgTen.ReadOnly = true;
            // 
            // dtgNs
            // 
            this.dtgNs.HeaderText = "Ngày Sinh";
            this.dtgNs.Name = "dtgNs";
            this.dtgNs.ReadOnly = true;
            // 
            // dtgGioitinh
            // 
            this.dtgGioitinh.HeaderText = "Giới Tính";
            this.dtgGioitinh.Name = "dtgGioitinh";
            this.dtgGioitinh.ReadOnly = true;
            // 
            // dtgDc
            // 
            this.dtgDc.HeaderText = "Địa chỉ";
            this.dtgDc.Name = "dtgDc";
            this.dtgDc.ReadOnly = true;
            // 
            // dtgDt
            // 
            this.dtgDt.HeaderText = "Điện thoại";
            this.dtgDt.Name = "dtgDt";
            this.dtgDt.ReadOnly = true;
            // 
            // dtgCv
            // 
            this.dtgCv.HeaderText = "Chức Vụ";
            this.dtgCv.Name = "dtgCv";
            this.dtgCv.ReadOnly = true;
            // 
            // dtgLuong
            // 
            this.dtgLuong.HeaderText = "Lương";
            this.dtgLuong.Name = "dtgLuong";
            this.dtgLuong.ReadOnly = true;
            this.dtgLuong.Width = 62;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(445, 111);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 19;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(498, 111);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 20;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(440, 38);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(141, 112);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(141, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(163, 20);
            this.txtDiaChi.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Địa chỉ";
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(745, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lbGioitinh);
            this.Controls.Add(this.dgvThongTinNhanVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTenNhanVien);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLNV";
            this.Text = "Quản Lý";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

