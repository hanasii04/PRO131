using PRO131.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            txtMatKhauMoi.Enabled = false;
        }

        DuAn da = new DuAn();
        private void buttonLayLaiMK_Click(object sender, EventArgs e)
        {
            string tenNguoiDung = txtTenNguoiDung.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(tenNguoiDung) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var timKiem = da.NhanViens.FirstOrDefault(u => u.TenNguoiDung == tenNguoiDung && u.SDT == sdt);

            if (timKiem == null)
            {
                MessageBox.Show("Tên người dùng hoặc số điện thoại không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo mật khẩu mới
            string newPassword = GenerateRandomPassword(6);

            txtMatKhauMoi.Text = newPassword;   

            timKiem.MatKhau = newPassword;
            da.SaveChanges();

            MessageBox.Show("Lấy lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        // Hàm tạo mật khẩu ngẫu nhiên
        private string GenerateRandomPassword(int length)
        {
            const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder sb = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                for (int i = 0; i < length; i++)
                {
                    byte b = randomBytes[i];
                    sb.Append(validChars[b % validChars.Length]);
                }
            }
            return sb.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }
    }
}
