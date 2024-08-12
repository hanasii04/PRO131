namespace PRO131
{
    partial class QuanLyNV
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.gridViewQLNV = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.radioQuanLy = new System.Windows.Forms.RadioButton();
            this.radioNhanVien = new System.Windows.Forms.RadioButton();
            this.labeIDNV = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonKhoaTK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labeUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labeTrangThai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeNgayCapNhat = new System.Windows.Forms.Label();
            this.labeNguoiCapNhat = new System.Windows.Forms.Label();
            this.labeNguoiTao = new System.Windows.Forms.Label();
            this.labeNgayTao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQLNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "SĐT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tên người dùng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Lọc theo trạng thái";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đang làm",
            "Nghỉ làm",
            "Tất cả"});
            this.cbbTrangThai.Location = new System.Drawing.Point(278, 407);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(172, 33);
            this.cbbTrangThai.TabIndex = 13;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // gridViewQLNV
            // 
            this.gridViewQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQLNV.Location = new System.Drawing.Point(69, 464);
            this.gridViewQLNV.Name = "gridViewQLNV";
            this.gridViewQLNV.RowHeadersWidth = 82;
            this.gridViewQLNV.RowTemplate.Height = 33;
            this.gridViewQLNV.Size = new System.Drawing.Size(1438, 416);
            this.gridViewQLNV.TabIndex = 14;
            this.gridViewQLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewQLNV_CellClick);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(69, 900);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(148, 93);
            this.buttonThem.TabIndex = 15;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(1359, 900);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(148, 95);
            this.buttonTimKiem.TabIndex = 16;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Vai trò",
            "Số điện thoại"});
            this.cbbTimKiem.Location = new System.Drawing.Point(1092, 903);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(197, 33);
            this.cbbTimKiem.TabIndex = 18;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1088, 964);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(201, 31);
            this.txtTimKiem.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(879, 903);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tìm theo danh mục";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(196, 95);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(201, 31);
            this.txtTenNV.TabIndex = 21;
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(196, 149);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(201, 31);
            this.txtTenNguoiDung.TabIndex = 22;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(196, 209);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(201, 31);
            this.txtMatKhau.TabIndex = 23;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(737, 43);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 31);
            this.txtSDT.TabIndex = 24;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(737, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(201, 31);
            this.txtDiaChi.TabIndex = 25;
            // 
            // radioQuanLy
            // 
            this.radioQuanLy.AutoSize = true;
            this.radioQuanLy.Location = new System.Drawing.Point(15, 41);
            this.radioQuanLy.Name = "radioQuanLy";
            this.radioQuanLy.Size = new System.Drawing.Size(117, 29);
            this.radioQuanLy.TabIndex = 26;
            this.radioQuanLy.TabStop = true;
            this.radioQuanLy.Text = "Quản lý";
            this.radioQuanLy.UseVisualStyleBackColor = true;
            // 
            // radioNhanVien
            // 
            this.radioNhanVien.AutoSize = true;
            this.radioNhanVien.Location = new System.Drawing.Point(159, 41);
            this.radioNhanVien.Name = "radioNhanVien";
            this.radioNhanVien.Size = new System.Drawing.Size(140, 29);
            this.radioNhanVien.TabIndex = 27;
            this.radioNhanVien.TabStop = true;
            this.radioNhanVien.Text = "Nhân viên";
            this.radioNhanVien.UseVisualStyleBackColor = true;
            // 
            // labeIDNV
            // 
            this.labeIDNV.AutoSize = true;
            this.labeIDNV.Location = new System.Drawing.Point(191, 49);
            this.labeIDNV.Name = "labeIDNV";
            this.labeIDNV.Size = new System.Drawing.Size(30, 25);
            this.labeIDNV.TabIndex = 30;
            this.labeIDNV.Text = "...";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(477, 900);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(148, 93);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(278, 900);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(148, 93);
            this.buttonCapNhat.TabIndex = 36;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonKhoaTK
            // 
            this.buttonKhoaTK.Location = new System.Drawing.Point(687, 900);
            this.buttonKhoaTK.Name = "buttonKhoaTK";
            this.buttonKhoaTK.Size = new System.Drawing.Size(148, 93);
            this.buttonKhoaTK.TabIndex = 38;
            this.buttonKhoaTK.Text = "Khóa tài khoản";
            this.buttonKhoaTK.UseVisualStyleBackColor = true;
            this.buttonKhoaTK.Click += new System.EventHandler(this.buttonKhoaTK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioQuanLy);
            this.groupBox2.Controls.Add(this.radioNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(618, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 97);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vai trò";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(69, 21);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 52);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Địa chỉ";
            // 
            // labeUsername
            // 
            this.labeUsername.AutoSize = true;
            this.labeUsername.Location = new System.Drawing.Point(1109, 21);
            this.labeUsername.Name = "labeUsername";
            this.labeUsername.Size = new System.Drawing.Size(30, 25);
            this.labeUsername.TabIndex = 42;
            this.labeUsername.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Trạng thái";
            // 
            // labeTrangThai
            // 
            this.labeTrangThai.AutoSize = true;
            this.labeTrangThai.Location = new System.Drawing.Point(736, 152);
            this.labeTrangThai.Name = "labeTrangThai";
            this.labeTrangThai.Size = new System.Drawing.Size(30, 25);
            this.labeTrangThai.TabIndex = 44;
            this.labeTrangThai.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1191, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người cập nhật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1191, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày cập nhật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1191, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Người tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1191, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày tạo";
            // 
            // labeNgayCapNhat
            // 
            this.labeNgayCapNhat.AutoSize = true;
            this.labeNgayCapNhat.Location = new System.Drawing.Point(1373, 231);
            this.labeNgayCapNhat.Name = "labeNgayCapNhat";
            this.labeNgayCapNhat.Size = new System.Drawing.Size(30, 25);
            this.labeNgayCapNhat.TabIndex = 31;
            this.labeNgayCapNhat.Text = "...";
            // 
            // labeNguoiCapNhat
            // 
            this.labeNguoiCapNhat.AutoSize = true;
            this.labeNguoiCapNhat.Location = new System.Drawing.Point(1373, 291);
            this.labeNguoiCapNhat.Name = "labeNguoiCapNhat";
            this.labeNguoiCapNhat.Size = new System.Drawing.Size(30, 25);
            this.labeNguoiCapNhat.TabIndex = 32;
            this.labeNguoiCapNhat.Text = "...";
            // 
            // labeNguoiTao
            // 
            this.labeNguoiTao.AutoSize = true;
            this.labeNguoiTao.Location = new System.Drawing.Point(1373, 180);
            this.labeNguoiTao.Name = "labeNguoiTao";
            this.labeNguoiTao.Size = new System.Drawing.Size(30, 25);
            this.labeNguoiTao.TabIndex = 33;
            this.labeNguoiTao.Text = "...";
            // 
            // labeNgayTao
            // 
            this.labeNgayTao.AutoSize = true;
            this.labeNgayTao.Location = new System.Drawing.Point(1373, 128);
            this.labeNgayTao.Name = "labeNgayTao";
            this.labeNgayTao.Size = new System.Drawing.Size(30, 25);
            this.labeNgayTao.TabIndex = 34;
            this.labeNgayTao.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labeTrangThai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labeIDNV);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTenNguoiDung);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(69, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 322);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1027);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeUsername);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonKhoaTK);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.labeNgayTao);
            this.Controls.Add(this.labeNguoiTao);
            this.Controls.Add(this.labeNguoiCapNhat);
            this.Controls.Add(this.labeNgayCapNhat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.gridViewQLNV);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QuanLyNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQLNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.DataGridView gridViewQLNV;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton radioQuanLy;
        private System.Windows.Forms.RadioButton radioNhanVien;
        private System.Windows.Forms.Label labeIDNV;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonKhoaTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeNgayCapNhat;
        private System.Windows.Forms.Label labeNguoiCapNhat;
        private System.Windows.Forms.Label labeNguoiTao;
        private System.Windows.Forms.Label labeNgayTao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}