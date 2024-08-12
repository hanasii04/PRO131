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
    public partial class FormQuanLy : Form
    {
        private string tenNguoiDung;
        private string idNhanVien;
        private string vaiTro;
        public FormQuanLy(string tenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.tenNguoiDung = tenNguoiDung;
            this.idNhanVien = idNhanVien;
            this.vaiTro = vaiTro;
            labeUsername.Text = "Xin chào: " + tenNguoiDung;
            FunctionByRole();
        }

        private void FunctionByRole()
        {
            if (vaiTro == "Quản lý")
            {
                buttonQLSP.Visible = true;
                buttonQLHD.Visible = true;
                buttonQLNV.Visible = true;
                buttonQLVC.Visible = true;
                buttonTK.Visible = true;
                buttonBH.Visible = true;
            }
            else if (vaiTro == "Nhân viên")
            {
                buttonQLSP.Visible = false;
                buttonQLHD.Visible = false;
                buttonQLNV.Visible = false;
                buttonQLVC.Visible = false;
                buttonTK.Visible = false;
                buttonBH.Visible = true;
            }
        }

        private void buttonQLSP_Click(object sender, EventArgs e)
        {
            QuanLySP qlsp = new QuanLySP(this.tenNguoiDung, this.idNhanVien, this.vaiTro);
            qlsp.Show();
            this.Hide();
        }

        private void buttonQLHD_Click(object sender, EventArgs e)
        {
            QuanLyHD qlhd = new QuanLyHD(this.tenNguoiDung, this.idNhanVien, this.vaiTro);
            qlhd.Show();
            this.Hide();
        }

        private void buttonQLNV_Click_1(object sender, EventArgs e)
        {
            QuanLyNV qlnv = new QuanLyNV(this.tenNguoiDung, this.idNhanVien, this.vaiTro);
            qlnv.Show();
            this.Hide();
        }

        private void buttonQLVC_Click(object sender, EventArgs e)
        {
            QuanLyVC qlvc = new QuanLyVC(this.tenNguoiDung, this.idNhanVien, this.vaiTro);
            qlvc.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe(this.tenNguoiDung, this.idNhanVien, this.vaiTro);
            tk.Show();
            this.Hide();
        }

        private void buttonBH_Click(object sender, EventArgs e)
        {
            BanHang bh = new BanHang(this.tenNguoiDung, this.idNhanVien, this.vaiTro);
            bh.Show();
            this.Hide();
        }
    }
}
