namespace PRO131
{
    partial class BanHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridViewHoaDonChiTiet = new System.Windows.Forms.DataGridView();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewListSP = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labeTienGiam = new System.Windows.Forms.Label();
            this.labeThanhTien = new System.Windows.Forms.Label();
            this.txtMGG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.labeTienThua = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonXuatHD = new System.Windows.Forms.Button();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.labeMaHD = new System.Windows.Forms.Label();
            this.labeNhanVien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labeUsername = new System.Windows.Forms.Label();
            this.buttonXoaHD = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDonChiTiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListSP)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridViewHoaDonChiTiet);
            this.groupBox3.Location = new System.Drawing.Point(12, 1104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1205, 487);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // gridViewHoaDonChiTiet
            // 
            this.gridViewHoaDonChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHoaDonChiTiet.Location = new System.Drawing.Point(29, 44);
            this.gridViewHoaDonChiTiet.Name = "gridViewHoaDonChiTiet";
            this.gridViewHoaDonChiTiet.RowHeadersWidth = 82;
            this.gridViewHoaDonChiTiet.RowTemplate.Height = 33;
            this.gridViewHoaDonChiTiet.Size = new System.Drawing.Size(1130, 434);
            this.gridViewHoaDonChiTiet.TabIndex = 0;
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.Location = new System.Drawing.Point(1298, 284);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(269, 127);
            this.buttonThemSP.TabIndex = 4;
            this.buttonThemSP.Text = "Thêm vào hóa đơn";
            this.buttonThemSP.UseVisualStyleBackColor = true;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridViewHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 597);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1205, 487);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // gridViewHoaDon
            // 
            this.gridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHoaDon.Location = new System.Drawing.Point(29, 44);
            this.gridViewHoaDon.Name = "gridViewHoaDon";
            this.gridViewHoaDon.RowHeadersWidth = 82;
            this.gridViewHoaDon.RowTemplate.Height = 33;
            this.gridViewHoaDon.Size = new System.Drawing.Size(1130, 434);
            this.gridViewHoaDon.TabIndex = 0;
            this.gridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewHoaDon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewListSP);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1205, 487);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // gridViewListSP
            // 
            this.gridViewListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewListSP.Location = new System.Drawing.Point(29, 44);
            this.gridViewListSP.Name = "gridViewListSP";
            this.gridViewListSP.RowHeadersWidth = 82;
            this.gridViewListSP.RowTemplate.Height = 33;
            this.gridViewListSP.Size = new System.Drawing.Size(1130, 434);
            this.gridViewListSP.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.labeTienGiam);
            this.groupBox4.Controls.Add(this.labeThanhTien);
            this.groupBox4.Controls.Add(this.txtMGG);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtTienKhachDua);
            this.groupBox4.Controls.Add(this.labeTienThua);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.buttonXuatHD);
            this.groupBox4.Controls.Add(this.buttonThanhToan);
            this.groupBox4.Controls.Add(this.txtTenKH);
            this.groupBox4.Controls.Add(this.labeMaHD);
            this.groupBox4.Controls.Add(this.labeNhanVien);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(1646, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1162, 1286);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin thanh toán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tiền giảm ";
            // 
            // labeTienGiam
            // 
            this.labeTienGiam.AutoSize = true;
            this.labeTienGiam.Location = new System.Drawing.Point(433, 588);
            this.labeTienGiam.Name = "labeTienGiam";
            this.labeTienGiam.Size = new System.Drawing.Size(30, 25);
            this.labeTienGiam.TabIndex = 21;
            this.labeTienGiam.Text = "...";
            // 
            // labeThanhTien
            // 
            this.labeThanhTien.AutoSize = true;
            this.labeThanhTien.Location = new System.Drawing.Point(433, 781);
            this.labeThanhTien.Name = "labeThanhTien";
            this.labeThanhTien.Size = new System.Drawing.Size(30, 25);
            this.labeThanhTien.TabIndex = 20;
            this.labeThanhTien.Text = "...";
            // 
            // txtMGG
            // 
            this.txtMGG.Location = new System.Drawing.Point(438, 485);
            this.txtMGG.Name = "txtMGG";
            this.txtMGG.Size = new System.Drawing.Size(494, 31);
            this.txtMGG.TabIndex = 19;
            this.txtMGG.TextChanged += new System.EventHandler(this.txtMGG_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã giảm giá";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(438, 377);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(494, 31);
            this.txtTienKhachDua.TabIndex = 17;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            // 
            // labeTienThua
            // 
            this.labeTienThua.AutoSize = true;
            this.labeTienThua.Location = new System.Drawing.Point(433, 684);
            this.labeTienThua.Name = "labeTienThua";
            this.labeTienThua.Size = new System.Drawing.Size(30, 25);
            this.labeTienThua.TabIndex = 15;
            this.labeTienThua.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 684);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tiền thừa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiền khách đưa";
            // 
            // buttonXuatHD
            // 
            this.buttonXuatHD.Location = new System.Drawing.Point(663, 886);
            this.buttonXuatHD.Name = "buttonXuatHD";
            this.buttonXuatHD.Size = new System.Drawing.Size(269, 100);
            this.buttonXuatHD.TabIndex = 12;
            this.buttonXuatHD.Text = "Xuất hóa đơn";
            this.buttonXuatHD.UseVisualStyleBackColor = true;
            this.buttonXuatHD.Click += new System.EventHandler(this.buttonXuatHD_Click);
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Location = new System.Drawing.Point(174, 886);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(269, 100);
            this.buttonThanhToan.TabIndex = 11;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(438, 172);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(494, 31);
            this.txtTenKH.TabIndex = 10;
            // 
            // labeMaHD
            // 
            this.labeMaHD.AutoSize = true;
            this.labeMaHD.Location = new System.Drawing.Point(433, 278);
            this.labeMaHD.Name = "labeMaHD";
            this.labeMaHD.Size = new System.Drawing.Size(30, 25);
            this.labeMaHD.TabIndex = 9;
            this.labeMaHD.Text = "...";
            // 
            // labeNhanVien
            // 
            this.labeNhanVien.AutoSize = true;
            this.labeNhanVien.Location = new System.Drawing.Point(433, 91);
            this.labeNhanVien.Name = "labeNhanVien";
            this.labeNhanVien.Size = new System.Drawing.Size(30, 25);
            this.labeNhanVien.TabIndex = 7;
            this.labeNhanVien.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 781);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(41, 22);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 52);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labeUsername
            // 
            this.labeUsername.AutoSize = true;
            this.labeUsername.Location = new System.Drawing.Point(2487, 49);
            this.labeUsername.Name = "labeUsername";
            this.labeUsername.Size = new System.Drawing.Size(30, 25);
            this.labeUsername.TabIndex = 21;
            this.labeUsername.Text = "...";
            // 
            // buttonXoaHD
            // 
            this.buttonXoaHD.Location = new System.Drawing.Point(1298, 769);
            this.buttonXoaHD.Name = "buttonXoaHD";
            this.buttonXoaHD.Size = new System.Drawing.Size(269, 127);
            this.buttonXoaHD.TabIndex = 8;
            this.buttonXoaHD.Text = "Xóa hóa đơn";
            this.buttonXoaHD.UseVisualStyleBackColor = true;
            this.buttonXoaHD.Click += new System.EventHandler(this.buttonXoaHD_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2860, 1594);
            this.Controls.Add(this.labeUsername);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonXoaHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonThemSP);
            this.Controls.Add(this.groupBox3);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDonChiTiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListSP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridViewHoaDonChiTiet;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridViewHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewListSP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label labeMaHD;
        private System.Windows.Forms.Label labeNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXuatHD;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label labeTienThua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labeUsername;
        private System.Windows.Forms.Button buttonXoaHD;
        private System.Windows.Forms.TextBox txtMGG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeTienGiam;
        private System.Windows.Forms.Label labeThanhTien;
    }
}