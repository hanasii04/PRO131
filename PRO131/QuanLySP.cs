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
    public partial class QuanLySP : Form
    {
        private string tenNguoiDung;
        public QuanLySP(string tenNguoiDung)
        {
            InitializeComponent();
            this.tenNguoiDung = tenNguoiDung;
            comboSize.Items.Add("S");
            comboSize.Items.Add("M");
            comboSize.Items.Add("L");
            comboSize.Items.Add("XL");
        }

        QuanLyBanAo qlba = new QuanLyBanAo();

        private void QuanLySP_Load(object sender, EventArgs e)
        {
            var query = from sp in qlba.SanPham
                        join ctsp in qlba.ChiTietSanPham
                        on sp.ID_SanPham equals ctsp.ID_SanPham
                        join tk in qlba.TaiKhoan
                        on sp.ID_TaiKhoan equals tk.ID_TaiKhoan
                        select new SanPhamChiTietDTO
                        {
                            ID_SanPham = ctsp.ID_ChiTietSP,
                            TenSanPham = sp.TenSanPham,
                            GiaNhap = sp.GiaNhap,
                            GiaBan = sp.GiaBan,
                            SoLuong = sp.SoLuong,
                            MauSac = ctsp.MauSac,
                            Size = ctsp.KichCo,
                            ThuongHieu = ctsp.ThuongHieu,
                            HinhAnh = ctsp.HinhAnh,
                            TrangThai = ctsp.TrangThai,
                            NgayTao = sp.NgayTao,
                            NgayCapNhat = sp.NgayCapNhat,
                            NguoiTao = tk.TenNguoiDung,
                            NguoiCapNhat = tk.TenNguoiDung
                        };

            var result = query.ToList();

            if (result == null || !result.Any())
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gridViewQLSP.DataSource = result;
            }
        }



        private void buttonThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            string giaNhap = txtGiaNhap.Text.Trim();
            string giaBan = txtGiaBan.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string mauSac = txtMauSac.Text.Trim();
            string size = comboSize.SelectedItem.ToString().Trim();
            string thuongHieu = txtThuongHieu.Text.Trim();
            string hinhAnh = txtHinhAnh.Text.Trim();
            string trangThai = "";

            if (radioConHang.Checked)
            {
                trangThai = "Còn hàng";
            }
            if (radioHetHang.Checked)
            {
                trangThai = "Hết hàng";
            }

            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng điền Tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(giaNhap))
            {
                MessageBox.Show("Vui lòng điền Giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(giaBan))
            {
                MessageBox.Show("Vui lòng điền Giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(soLuong))
            {
                MessageBox.Show("Vui lòng điền Số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(mauSac))
            {
                MessageBox.Show("Vui lòng điền Màu sắc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(size))
            {
                MessageBox.Show("Vui lòng điền Size", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(thuongHieu))
            {
                MessageBox.Show("Vui lòng điền Thương hiệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(hinhAnh))
            {
                MessageBox.Show("Vui lòng điền Hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!radioConHang.Checked && !radioHetHang.Checked)
            {
                MessageBox.Show("Vui lòng chọn Trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu trường tên sản phẩm chứa số
            if (tenSP.Any(char.IsDigit))
            {
                MessageBox.Show("Tên sản phẩm không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal giaNhapS;
            decimal giaBanS;

            // Kiểm tra nếu giá nhập và giá bán là số và lớn hơn 0, đồng thời giá bán phải lớn hơn giá nhập
            if (!decimal.TryParse(giaNhap, out giaNhapS) || !decimal.TryParse(giaBan, out giaBanS) ||
                giaNhapS <= 0 || giaBanS <= 0)
            {
                MessageBox.Show("Giá nhập và giá bán phải là số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // In ra giá trị để kiểm tra
            MessageBox.Show($"Giá nhập: {giaNhapS}, Giá bán: {giaBanS}");

            if (giaBanS <= giaNhapS)
            {
                MessageBox.Show("Giá bán phải lớn hơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongS;
            if (!int.TryParse(soLuong, out soLuongS))
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (soLuongS <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SANPHAM sp = new SANPHAM
            {
                ID_SanPham = Guid.NewGuid().ToString(), // Sử dụng Guid để tạo ID duy nhất
                TenSanPham = tenSP,
                GiaNhap = giaNhapS,
                GiaBan = giaBanS,
                SoLuong = soLuongS,
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = tenNguoiDung, // Giả sử bạn đã có giá trị tenNguoiDung
                NguoiCapNhat = tenNguoiDung
            };

            CHITIETSANPHAM ctsp = new CHITIETSANPHAM
            {
                ID_ChiTietSP = Guid.NewGuid().ToString(), // Sử dụng Guid để tạo ID duy nhất
                MauSac = mauSac,
                KichCo = size,
                ThuongHieu = thuongHieu,
                HinhAnh = hinhAnh,
                TrangThai = trangThai,
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = tenNguoiDung, // Giả sử bạn đã có giá trị tenNguoiDung
                NguoiCapNhat = tenNguoiDung,
                ID_SanPham = sp.ID_SanPham // Thiết lập khóa ngoại
            };

            try
            {
                qlba.SanPham.Add(sp);
                qlba.ChiTietSanPham.Add(ctsp);
                qlba.SaveChanges(); // Lưu các thay đổi vào cơ sở dữ liệu
                QuanLySP_Load(sender, e); // Gọi lại phương thức load để cập nhật dữ liệu

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
