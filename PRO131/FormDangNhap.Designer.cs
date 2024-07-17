namespace PRO131
{
    partial class FormDangNhap
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.radioQL = new System.Windows.Forms.RadioButton();
            this.radioNV = new System.Windows.Forms.RadioButton();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phần mềm quản lý bán áo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(341, 273);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(290, 31);
            this.txtPass.TabIndex = 13;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(341, 189);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(290, 31);
            this.txtUser.TabIndex = 14;
            // 
            // radioQL
            // 
            this.radioQL.AutoSize = true;
            this.radioQL.Location = new System.Drawing.Point(92, 364);
            this.radioQL.Name = "radioQL";
            this.radioQL.Size = new System.Drawing.Size(117, 29);
            this.radioQL.TabIndex = 15;
            this.radioQL.TabStop = true;
            this.radioQL.Text = "Quản lý";
            this.radioQL.UseVisualStyleBackColor = true;
            // 
            // radioNV
            // 
            this.radioNV.AutoSize = true;
            this.radioNV.Location = new System.Drawing.Point(341, 364);
            this.radioNV.Name = "radioNV";
            this.radioNV.Size = new System.Drawing.Size(140, 29);
            this.radioNV.TabIndex = 16;
            this.radioNV.TabStop = true;
            this.radioNV.Text = "Nhân viên";
            this.radioNV.UseVisualStyleBackColor = true;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(470, 452);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(161, 67);
            this.buttonThoat.TabIndex = 17;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(92, 452);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(161, 67);
            this.buttonDangNhap.TabIndex = 18;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 592);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.radioNV);
            this.Controls.Add(this.radioQL);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.RadioButton radioQL;
        private System.Windows.Forms.RadioButton radioNV;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangNhap;
    }
}