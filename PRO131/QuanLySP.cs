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
    public partial class QuanLySP : Form
    {
        public QuanLySP()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            string giaNhap = txtGiaNhap.Text.Trim();
            string giaBan = txtGiaBan.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string mauSac = txtMauSac.Text.Trim();
            string size = txtSize.Text.Trim();
            string thuongHieu = txtThuongHieu.Text.Trim();
            string hinhAnh = txtHinhAnh.Text.Trim();
            string trangThai;

            if (radioConHang.Checked)
            {
                trangThai = "Còn hàng";
            }
            if (radioHetHang.Checked)
            {
                trangThai = "Hết hàng";
            }

            if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(giaNhap) || string.IsNullOrEmpty(giaBan) ||
            string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(mauSac) || string.IsNullOrEmpty(size) ||
            string.IsNullOrEmpty(thuongHieu) || string.IsNullOrEmpty(hinhAnh) ||
            (!radioConHang.Checked && !radioHetHang.Checked))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu trường tên sản phẩm chứa số
            if (tenSP.Any(char.IsDigit))
            {
                MessageBox.Show("Tên sản phẩm không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal giaNhapS;
            decimal giaBanS = 0;

            // Kiểm tra nếu giá nhập và giá bán là số và lớn hơn 0, đồng thời giá bán phải không lớn hơn giá nhập
            if (!decimal.TryParse(giaNhap, out giaNhapS) || !decimal.TryParse(giaBan, out giaBanS) ||
                giaNhapS <= 0 || giaBanS <= 0 || giaBanS > giaNhapS)
            {
                string errorMessage;

                if (giaNhapS <= 0 || giaBanS <= 0)
                {
                    errorMessage = "Giá nhập và giá bán phải là số và lớn hơn 0";
                }
                else
                {
                    errorMessage = "Giá bán phải lớn hơn giá nhập";
                }

                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongS;
            if(!int.TryParse(soLuong, out soLuongS))
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            if(soLuongS <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

        }
    }
}
