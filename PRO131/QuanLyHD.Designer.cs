namespace PRO131
{
    partial class QuanLyHD
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
            this.gridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.labeTenNguoiDung = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.gridViewHoaDonChiTiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDonChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewHoaDon
            // 
            this.gridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHoaDon.Location = new System.Drawing.Point(63, 255);
            this.gridViewHoaDon.Name = "gridViewHoaDon";
            this.gridViewHoaDon.RowHeadersWidth = 82;
            this.gridViewHoaDon.RowTemplate.Height = 33;
            this.gridViewHoaDon.Size = new System.Drawing.Size(1599, 413);
            this.gridViewHoaDon.TabIndex = 0;
            this.gridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewHoaDon_CellClick);
            // 
            // labeTenNguoiDung
            // 
            this.labeTenNguoiDung.AutoSize = true;
            this.labeTenNguoiDung.Location = new System.Drawing.Point(1450, 40);
            this.labeTenNguoiDung.Name = "labeTenNguoiDung";
            this.labeTenNguoiDung.Size = new System.Drawing.Size(30, 25);
            this.labeTenNguoiDung.TabIndex = 3;
            this.labeTenNguoiDung.Text = "...";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(907, 155);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(193, 77);
            this.buttonTimKiem.TabIndex = 4;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(63, 40);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 52);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1226, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "Lọc theo trạng thái";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(622, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 25);
            this.label14.TabIndex = 43;
            this.label14.Text = "Nhập mã hóa đơn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(564, 201);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(282, 31);
            this.txtTimKiem.TabIndex = 44;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán",
            "Tất cả"});
            this.cbbTrangThai.Location = new System.Drawing.Point(1455, 199);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(207, 33);
            this.cbbTrangThai.TabIndex = 45;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // gridViewHoaDonChiTiet
            // 
            this.gridViewHoaDonChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHoaDonChiTiet.Location = new System.Drawing.Point(63, 745);
            this.gridViewHoaDonChiTiet.Name = "gridViewHoaDonChiTiet";
            this.gridViewHoaDonChiTiet.RowHeadersWidth = 82;
            this.gridViewHoaDonChiTiet.RowTemplate.Height = 33;
            this.gridViewHoaDonChiTiet.Size = new System.Drawing.Size(1599, 413);
            this.gridViewHoaDonChiTiet.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 694);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Thông tin hóa đơn chi tiết";
            // 
            // QuanLyHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 1209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewHoaDonChiTiet);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.labeTenNguoiDung);
            this.Controls.Add(this.gridViewHoaDon);
            this.Name = "QuanLyHD";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.QuanLyHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDonChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewHoaDon;
        private System.Windows.Forms.Label labeTenNguoiDung;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.DataGridView gridViewHoaDonChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}