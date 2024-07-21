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

        QuanLyBanAo qlba = new QuanLyBanAo();
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            bool isQuanLy = radioQL.Checked;
            bool isNhanVien = radioNV.Checked;
            
            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    

            if(radioNV.Checked == false && radioQL.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            // Tìm kiếm tài khoản có tên người và mật khẩu khớp với thông tin nhập vào
            var taiKhoan = qlba.TaiKhoan.FirstOrDefault(x => x.TenNguoiDung == user && x.MatKhau == pass);
            if (taiKhoan != null)
            {
                // Tìm kiếm nhân viên có ID_TaiKhoan khớp với ID_TaiKhoan tài khoản vừa tìm được
                var nhanVien = qlba.NhanVien.FirstOrDefault(x => x.ID_TaiKhoan == taiKhoan.ID_TaiKhoan);
                if (nhanVien != null)
                {
                    // Nếu người dùng chọn vai trò là quản lý và vai trò trong DB là "QuanLy" thì mở FormQuanLy
                    if (isQuanLy && nhanVien.VaiTro == "QuanLy")
                    {
                        FormQuanLy fql = new FormQuanLy(user);
                        fql.Show();
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (isNhanVien && nhanVien.VaiTro == "NhanVien")
                    {
                        FormNhanVien fnv = new FormNhanVien();
                        fnv.Show();
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sai vai trò hoặc tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
