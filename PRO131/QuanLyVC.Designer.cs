namespace PRO131
{
    partial class QuanLyVC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridViewQLVC = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.labeNguoiCapNhat = new System.Windows.Forms.Label();
            this.labeNgayCapNhat = new System.Windows.Forms.Label();
            this.labeNgayTao = new System.Windows.Forms.Label();
            this.txtPhanTramGiam = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labeUsername = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeNguoiTao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQLVC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên voucher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phần trăm giảm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hạn sử dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày tạo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Người tạo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày cập nhật";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Người cập nhật";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lọc theo trạng thái";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Còn hạn",
            "Hết hạn"});
            this.comboBox1.Location = new System.Drawing.Point(273, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // gridViewQLVC
            // 
            this.gridViewQLVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQLVC.Location = new System.Drawing.Point(57, 386);
            this.gridViewQLVC.Name = "gridViewQLVC";
            this.gridViewQLVC.RowHeadersWidth = 82;
            this.gridViewQLVC.RowTemplate.Height = 33;
            this.gridViewQLVC.Size = new System.Drawing.Size(1179, 391);
            this.gridViewQLVC.TabIndex = 10;
            this.gridViewQLVC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewQLVC_CellClick);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(57, 807);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(127, 68);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // labeNguoiCapNhat
            // 
            this.labeNguoiCapNhat.AutoSize = true;
            this.labeNguoiCapNhat.Location = new System.Drawing.Point(246, 190);
            this.labeNguoiCapNhat.Name = "labeNguoiCapNhat";
            this.labeNguoiCapNhat.Size = new System.Drawing.Size(30, 25);
            this.labeNguoiCapNhat.TabIndex = 12;
            this.labeNguoiCapNhat.Text = "...";
            // 
            // labeNgayCapNhat
            // 
            this.labeNgayCapNhat.AutoSize = true;
            this.labeNgayCapNhat.Location = new System.Drawing.Point(246, 143);
            this.labeNgayCapNhat.Name = "labeNgayCapNhat";
            this.labeNgayCapNhat.Size = new System.Drawing.Size(30, 25);
            this.labeNgayCapNhat.TabIndex = 13;
            this.labeNgayCapNhat.Text = "...";
            // 
            // labeNgayTao
            // 
            this.labeNgayTao.AutoSize = true;
            this.labeNgayTao.Location = new System.Drawing.Point(246, 54);
            this.labeNgayTao.Name = "labeNgayTao";
            this.labeNgayTao.Size = new System.Drawing.Size(30, 25);
            this.labeNgayTao.TabIndex = 15;
            this.labeNgayTao.Text = "...";
            // 
            // txtPhanTramGiam
            // 
            this.txtPhanTramGiam.Location = new System.Drawing.Point(216, 137);
            this.txtPhanTramGiam.Name = "txtPhanTramGiam";
            this.txtPhanTramGiam.Size = new System.Drawing.Size(235, 31);
            this.txtPhanTramGiam.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(216, 93);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(235, 31);
            this.txtSoLuong.TabIndex = 18;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(216, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(235, 31);
            this.txtTen.TabIndex = 19;
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.Location = new System.Drawing.Point(216, 184);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(280, 31);
            this.dtpHanSuDung.TabIndex = 20;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(273, 807);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(127, 68);
            this.buttonCapNhat.TabIndex = 21;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(484, 807);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 68);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(57, 23);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 52);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labeUsername
            // 
            this.labeUsername.AutoSize = true;
            this.labeUsername.Location = new System.Drawing.Point(1040, 23);
            this.labeUsername.Name = "labeUsername";
            this.labeUsername.Size = new System.Drawing.Size(30, 25);
            this.labeUsername.TabIndex = 24;
            this.labeUsername.Text = "...";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(1109, 807);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(127, 68);
            this.buttonTimKiem.TabIndex = 25;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(816, 826);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(235, 31);
            this.txtTimKiem.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeNguoiTao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labeNguoiCapNhat);
            this.groupBox1.Controls.Add(this.labeNgayCapNhat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labeNgayTao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(727, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 241);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // labeNguoiTao
            // 
            this.labeNguoiTao.AutoSize = true;
            this.labeNguoiTao.Location = new System.Drawing.Point(246, 99);
            this.labeNguoiTao.Name = "labeNguoiTao";
            this.labeNguoiTao.Size = new System.Drawing.Size(30, 25);
            this.labeNguoiTao.TabIndex = 16;
            this.labeNguoiTao.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPhanTramGiam);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpHanSuDung);
            this.groupBox2.Location = new System.Drawing.Point(57, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 241);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin voucher";
            // 
            // QuanLyVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 906);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.labeUsername);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gridViewQLVC);
            this.Name = "QuanLyVC";
            this.Text = "Quản lý voucher";
            this.Load += new System.EventHandler(this.QuanLyVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQLVC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridViewQLVC;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label labeNguoiCapNhat;
        private System.Windows.Forms.Label labeNgayCapNhat;
        private System.Windows.Forms.Label labeNgayTao;
        private System.Windows.Forms.TextBox txtPhanTramGiam;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labeUsername;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeNguoiTao;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}