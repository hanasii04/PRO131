namespace PRO131
{
    partial class QuenMK
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
            this.buttonLayLaiMK = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lấy lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // buttonLayLaiMK
            // 
            this.buttonLayLaiMK.Location = new System.Drawing.Point(423, 347);
            this.buttonLayLaiMK.Name = "buttonLayLaiMK";
            this.buttonLayLaiMK.Size = new System.Drawing.Size(187, 69);
            this.buttonLayLaiMK.TabIndex = 3;
            this.buttonLayLaiMK.Text = "Cấp lại mật khẩu";
            this.buttonLayLaiMK.UseVisualStyleBackColor = true;
            this.buttonLayLaiMK.Click += new System.EventHandler(this.buttonLayLaiMK_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(333, 161);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(277, 31);
            this.txtSDT.TabIndex = 4;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(333, 288);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(277, 31);
            this.txtMatKhauMoi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập tên người dùng";
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(333, 223);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(277, 31);
            this.txtTenNguoiDung.TabIndex = 7;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(26, 25);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 52);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 453);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.buttonLayLaiMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuenMK";
            this.Text = "Lấy lại mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLayLaiMK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Button buttonBack;
    }
}