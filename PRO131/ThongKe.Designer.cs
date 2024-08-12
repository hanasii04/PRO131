namespace PRO131
{
    partial class ThongKe
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
            this.gridViewThongke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labeUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewThongke
            // 
            this.gridViewThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewThongke.Location = new System.Drawing.Point(59, 238);
            this.gridViewThongke.Name = "gridViewThongke";
            this.gridViewThongke.RowHeadersWidth = 82;
            this.gridViewThongke.RowTemplate.Height = 33;
            this.gridViewThongke.Size = new System.Drawing.Size(1117, 678);
            this.gridViewThongke.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê";
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Items.AddRange(new object[] {
            "Doanh thu",
            "Lợi nhuận",
            "Sản phẩm bán chạy",
            "Sản phẩm tồn kho"});
            this.cbbDanhMuc.Location = new System.Drawing.Point(190, 105);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(220, 33);
            this.cbbDanhMuc.TabIndex = 2;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Location = new System.Drawing.Point(667, 99);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(287, 31);
            this.dtpBatDau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày kết thúc";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Location = new System.Drawing.Point(667, 163);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(287, 31);
            this.dtpKetThuc.TabIndex = 6;
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Location = new System.Drawing.Point(993, 99);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(183, 94);
            this.buttonThongKe.TabIndex = 7;
            this.buttonThongKe.Text = "Thống kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(59, 24);
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
            this.labeUsername.Location = new System.Drawing.Point(911, 24);
            this.labeUsername.Name = "labeUsername";
            this.labeUsername.Size = new System.Drawing.Size(30, 25);
            this.labeUsername.TabIndex = 21;
            this.labeUsername.Text = "...";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 960);
            this.Controls.Add(this.labeUsername);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonThongKe);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBatDau);
            this.Controls.Add(this.cbbDanhMuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewThongke);
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewThongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labeUsername;
    }
}