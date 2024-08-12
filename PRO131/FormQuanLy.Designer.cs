namespace PRO131
{
    partial class FormQuanLy
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
            this.buttonQLSP = new System.Windows.Forms.Button();
            this.buttonBH = new System.Windows.Forms.Button();
            this.buttonTK = new System.Windows.Forms.Button();
            this.buttonQLVC = new System.Windows.Forms.Button();
            this.buttonQLHD = new System.Windows.Forms.Button();
            this.buttonQLNV = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labeUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonQLSP
            // 
            this.buttonQLSP.Location = new System.Drawing.Point(42, 125);
            this.buttonQLSP.Name = "buttonQLSP";
            this.buttonQLSP.Size = new System.Drawing.Size(305, 131);
            this.buttonQLSP.TabIndex = 6;
            this.buttonQLSP.Text = "Quản lý sản phẩm";
            this.buttonQLSP.UseVisualStyleBackColor = true;
            this.buttonQLSP.Click += new System.EventHandler(this.buttonQLSP_Click);
            // 
            // buttonBH
            // 
            this.buttonBH.Location = new System.Drawing.Point(1111, 336);
            this.buttonBH.Name = "buttonBH";
            this.buttonBH.Size = new System.Drawing.Size(305, 131);
            this.buttonBH.TabIndex = 12;
            this.buttonBH.Text = "Bán hàng";
            this.buttonBH.UseVisualStyleBackColor = true;
            this.buttonBH.Click += new System.EventHandler(this.buttonBH_Click);
            // 
            // buttonTK
            // 
            this.buttonTK.Location = new System.Drawing.Point(567, 336);
            this.buttonTK.Name = "buttonTK";
            this.buttonTK.Size = new System.Drawing.Size(305, 131);
            this.buttonTK.TabIndex = 13;
            this.buttonTK.Text = "Thống kê";
            this.buttonTK.UseVisualStyleBackColor = true;
            this.buttonTK.Click += new System.EventHandler(this.buttonTK_Click);
            // 
            // buttonQLVC
            // 
            this.buttonQLVC.Location = new System.Drawing.Point(1111, 125);
            this.buttonQLVC.Name = "buttonQLVC";
            this.buttonQLVC.Size = new System.Drawing.Size(305, 131);
            this.buttonQLVC.TabIndex = 14;
            this.buttonQLVC.Text = "Quản lý voucher";
            this.buttonQLVC.UseVisualStyleBackColor = true;
            this.buttonQLVC.Click += new System.EventHandler(this.buttonQLVC_Click);
            // 
            // buttonQLHD
            // 
            this.buttonQLHD.Location = new System.Drawing.Point(42, 336);
            this.buttonQLHD.Name = "buttonQLHD";
            this.buttonQLHD.Size = new System.Drawing.Size(305, 131);
            this.buttonQLHD.TabIndex = 15;
            this.buttonQLHD.Text = "Quản lý hóa đơn";
            this.buttonQLHD.UseVisualStyleBackColor = true;
            this.buttonQLHD.Click += new System.EventHandler(this.buttonQLHD_Click);
            // 
            // buttonQLNV
            // 
            this.buttonQLNV.Location = new System.Drawing.Point(567, 125);
            this.buttonQLNV.Name = "buttonQLNV";
            this.buttonQLNV.Size = new System.Drawing.Size(305, 131);
            this.buttonQLNV.TabIndex = 18;
            this.buttonQLNV.Text = "Quản lý nhân viên";
            this.buttonQLNV.UseVisualStyleBackColor = true;
            this.buttonQLNV.Click += new System.EventHandler(this.buttonQLNV_Click_1);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(42, 32);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 52);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labeUsername
            // 
            this.labeUsername.AutoSize = true;
            this.labeUsername.Location = new System.Drawing.Point(1111, 32);
            this.labeUsername.Name = "labeUsername";
            this.labeUsername.Size = new System.Drawing.Size(30, 25);
            this.labeUsername.TabIndex = 20;
            this.labeUsername.Text = "...";
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 517);
            this.Controls.Add(this.labeUsername);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonQLNV);
            this.Controls.Add(this.buttonQLHD);
            this.Controls.Add(this.buttonQLVC);
            this.Controls.Add(this.buttonTK);
            this.Controls.Add(this.buttonBH);
            this.Controls.Add(this.buttonQLSP);
            this.Name = "FormQuanLy";
            this.Text = "Quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQLSP;
        private System.Windows.Forms.Button buttonBH;
        private System.Windows.Forms.Button buttonTK;
        private System.Windows.Forms.Button buttonQLVC;
        private System.Windows.Forms.Button buttonQLHD;
        private System.Windows.Forms.Button buttonQLNV;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labeUsername;
    }
}