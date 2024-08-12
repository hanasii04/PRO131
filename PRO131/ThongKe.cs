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
    public partial class ThongKe : Form
    {
        private string idNhanVien;
        private string tenNguoiDung;
        private string vaiTro;
        public ThongKe(string tenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
            this.tenNguoiDung = tenNguoiDung;
            this.vaiTro = vaiTro;
            labeUsername.Text = "Xin chào: " + tenNguoiDung;
        }
        DuAn da = new DuAn();

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormQuanLy fql = new FormQuanLy(idNhanVien, tenNguoiDung, vaiTro);
            fql.Show();
            this.Hide();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các trường
            string selectedCategory = cbbDanhMuc.SelectedItem.ToString();
            DateTime startDate = dtpBatDau.Value;
            DateTime endDate = dtpKetThuc.Value;

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Vui lòng chọn danh mục thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (startDate == null || endDate == null)
            {
                MessageBox.Show("Vui lòng chọn khoảng thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var query = da.HoaDons.Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate);

            switch (selectedCategory)
            {
                case "Sản phẩm bán chạy":
                    var spBanChay = da.HoaDonChiTiets
                        .Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate)
                        .GroupBy(hd => new
                        {
                            hd.ChiTietSanPham.ID_SanPham,
                            hd.ChiTietSanPham.SanPham.TenSanPham,
                            hd.ChiTietSanPham.SanPham.GiaBan,
                            hd.ChiTietSanPham.mauSac.TenMauSac,
                            hd.ChiTietSanPham.kichCo.TenKichCo,
                            hd.ChiTietSanPham.thuongHieu.TenThuongHieu 
                        })
                        .Select(x => new
                        {
                            TenSanPham = x.Key.TenSanPham,
                            MauSac = x.Key.TenMauSac,
                            KichCo = x.Key.TenKichCo,
                            ThuongHieu = x.Key.TenThuongHieu,
                            SoLuongBan = x.Sum(hd => hd.SoLuong),
                            GiaBan = x.Key.GiaBan,
                            TongTien = x.Sum(hd => hd.SoLuong * x.Key.GiaBan)
                        })
                        .OrderByDescending(g => g.SoLuongBan)
                        .ToList();

                    gridViewThongke.DataSource = spBanChay;
                    gridViewThongke.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
                    gridViewThongke.Columns["MauSac"].HeaderText = "Màu sắc";
                    gridViewThongke.Columns["KichCo"].HeaderText = "Kích cỡ";
                    gridViewThongke.Columns["ThuongHieu"].HeaderText = "Thương hiệu";
                    gridViewThongke.Columns["SoLuongBan"].HeaderText = "Số lượng bán";
                    gridViewThongke.Columns["GiaBan"].HeaderText = "Giá bán";
                    gridViewThongke.Columns["TongTien"].HeaderText = "Tổng tiền";
                    break;


                case "Sản phẩm tồn kho":
                    var spTonKho = da.ChiTietSanPhams
                        .Where(ctsp => ctsp.SanPham.NgayTao >= startDate && ctsp.SanPham.NgayTao <= endDate)
                        .GroupBy(ctsp => new
                        {
                            ctsp.ID_SanPham,
                            ctsp.SanPham.TenSanPham,
                            ctsp.SanPham.GiaBan,
                            ctsp.mauSac.TenMauSac,
                            ctsp.kichCo.TenKichCo,
                            ctsp.thuongHieu.TenThuongHieu
                        })
                        .Select(g => new
                        {
                            TenSanPham = g.Key.TenSanPham,
                            MauSac = g.Key.TenMauSac,
                            KichCo = g.Key.TenKichCo,
                            ThuongHieu = g.Key.TenThuongHieu,
                            SoLuongTon = g.Sum(ctsp => ctsp.SoLuong), 
                            GiaBan = g.Key.GiaBan
                        })
                        .OrderByDescending(g => g.SoLuongTon)
                        .ToList();

                    gridViewThongke.DataSource = spTonKho;
                    gridViewThongke.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                    gridViewThongke.Columns["MauSac"].HeaderText = "Màu Sắc";
                    gridViewThongke.Columns["KichCo"].HeaderText = "Kích Cỡ";
                    gridViewThongke.Columns["ThuongHieu"].HeaderText = "Thương Hiệu";
                    gridViewThongke.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn";
                    gridViewThongke.Columns["GiaBan"].HeaderText = "Giá Bán";
                    break;

                case "Doanh thu":
                    var tongDoanhThu = da.HoaDonChiTiets
                        .Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate)
                        .Sum(hd => hd.SoLuong * hd.ChiTietSanPham.SanPham.GiaBan);

                    var doanhThu = new[]
                    {
                        new{ TongDoanhThu = tongDoanhThu }
                    }.ToList();

                    gridViewThongke.DataSource = doanhThu;
                    gridViewThongke.Columns["TongDoanhThu"].HeaderText = "Tổng doanh thu";
                    break;


                case "Lợi nhuận":
                    var tongLoiNhuan = da.HoaDonChiTiets
                        .Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate)
                        .Sum(hd => (hd.ChiTietSanPham.SanPham.GiaBan - hd.ChiTietSanPham.SanPham.GiaNhap) * hd.SoLuong);

                    var loiNhuan = new[]
                    {
                        new { TongLoiNhuan = tongLoiNhuan }
                    }.ToList();

                    gridViewThongke.DataSource = loiNhuan;
                    gridViewThongke.Columns["TongLoiNhuan"].HeaderText = "Tổng lợi nhuận";
                    break;


                default:
                    MessageBox.Show("Danh mục thống kê không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

    }
}
