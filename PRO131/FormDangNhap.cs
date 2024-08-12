using PRO131.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        DuAn da = new DuAn();
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tìm kiếm tài khoản có tên người và mật khẩu khớp với thông tin nhập vào
            var nhanVien = da.NhanViens.FirstOrDefault(x => x.TenNguoiDung == user && x.MatKhau == pass);
            if (nhanVien != null)
            {
                if (nhanVien.TrangThai == "Nghỉ làm")
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nhanVien.VaiTro == "Quản lý")
                {
                    FormQuanLy fql = new FormQuanLy(nhanVien.TenNguoiDung, nhanVien.ID_NhanVien, nhanVien.VaiTro);
                    fql.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (nhanVien.VaiTro == "Nhân viên")
                {
                    FormQuanLy fql = new FormQuanLy(nhanVien.TenNguoiDung, nhanVien.ID_NhanVien, nhanVien.VaiTro);
                    fql.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHienThiMatKhau.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void labeQuenMK_DoubleClick(object sender, EventArgs e)
        {
            QuenMK mk = new QuenMK();
            mk.Show();
            this.Hide();
        }
    }
}
