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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonQLSP
            // 
            this.buttonQLSP.Location = new System.Drawing.Point(93, 104);
            this.buttonQLSP.Name = "buttonQLSP";
            this.buttonQLSP.Size = new System.Drawing.Size(368, 164);
            this.buttonQLSP.TabIndex = 6;
            this.buttonQLSP.Text = "Quản lý sản phẩm";
            this.buttonQLSP.UseVisualStyleBackColor = true;
            this.buttonQLSP.Click += new System.EventHandler(this.buttonQLSP_Click);
            // 
            // buttonBH
            // 
            this.buttonBH.Location = new System.Drawing.Point(93, 1310);
            this.buttonBH.Name = "buttonBH";
            this.buttonBH.Size = new System.Drawing.Size(368, 164);
            this.buttonBH.TabIndex = 12;
            this.buttonBH.Text = "Bán hàng";
            this.buttonBH.UseVisualStyleBackColor = true;
            // 
            // buttonTK
            // 
            this.buttonTK.Location = new System.Drawing.Point(93, 1071);
            this.buttonTK.Name = "buttonTK";
            this.buttonTK.Size = new System.Drawing.Size(368, 164);
            this.buttonTK.TabIndex = 13;
            this.buttonTK.Text = "Thống kê";
            this.buttonTK.UseVisualStyleBackColor = true;
            // 
            // buttonQLVC
            // 
            this.buttonQLVC.Location = new System.Drawing.Point(93, 834);
            this.buttonQLVC.Name = "buttonQLVC";
            this.buttonQLVC.Size = new System.Drawing.Size(368, 164);
            this.buttonQLVC.TabIndex = 14;
            this.buttonQLVC.Text = "Quản lý voucher";
            this.buttonQLVC.UseVisualStyleBackColor = true;
            // 
            // buttonQLHD
            // 
            this.buttonQLHD.Location = new System.Drawing.Point(93, 586);
            this.buttonQLHD.Name = "buttonQLHD";
            this.buttonQLHD.Size = new System.Drawing.Size(368, 164);
            this.buttonQLHD.TabIndex = 15;
            this.buttonQLHD.Text = "Quản lý hóa đơn";
            this.buttonQLHD.UseVisualStyleBackColor = true;
            // 
            // buttonQLNV
            // 
            this.buttonQLNV.Location = new System.Drawing.Point(93, 347);
            this.buttonQLNV.Name = "buttonQLNV";
            this.buttonQLNV.Size = new System.Drawing.Size(368, 164);
            this.buttonQLNV.TabIndex = 16;
            this.buttonQLNV.Text = "Quản lý nhân viên";
            this.buttonQLNV.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(535, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2248, 1370);
            this.panel1.TabIndex = 17;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonQLNV);
            this.Controls.Add(this.buttonQLHD);
            this.Controls.Add(this.buttonQLVC);
            this.Controls.Add(this.buttonTK);
            this.Controls.Add(this.buttonBH);
            this.Controls.Add(this.buttonQLSP);
            this.Name = "FormQuanLy";
            this.Text = "FormQuanLy";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonQLSP;
        private System.Windows.Forms.Button buttonBH;
        private System.Windows.Forms.Button buttonTK;
        private System.Windows.Forms.Button buttonQLVC;
        private System.Windows.Forms.Button buttonQLHD;
        private System.Windows.Forms.Button buttonQLNV;
        private System.Windows.Forms.Panel panel1;
    }
}