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
        //TAIKHOAN tk = new TAIKHOAN();
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
                // Nếu người dùng chọn vai trò là quản lý và vai trò trong DB là "QuanLy" thì mở FormQuanLy
                if (nhanVien.VaiTro == "QuanLy")
                {
                    FormQuanLy fql = new FormQuanLy(nhanVien.ID_NhanVien);
                    fql.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (nhanVien.VaiTro == "NhanVien")
                {
                    FormNhanVien fnv = new FormNhanVien();
                    fnv.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
