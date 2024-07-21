using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace PRO131.Model
{
    public class QuanLyBanAo : DbContext
    {

        public QuanLyBanAo()
            : base("name=QuanLyBanAo")
        {
        }

        public virtual DbSet<TAIKHOAN> TaiKhoan { get; set; }
        public virtual DbSet<SANPHAM> SanPham { get; set; }
        public virtual DbSet<CHITIETSANPHAM> ChiTietSanPham { get; set; }
        public virtual DbSet<NHANVIEN> NhanVien { get; set; }
        public virtual DbSet<VOUCHER> Voucher { get; set; }
        public virtual DbSet<HOADON> HoaDon { get; set; }
        public virtual DbSet<HOADONCHITIET> HoaDonChiTiet { get; set; }

    }

    public class TAIKHOAN
    {
        [Key]
        public string ID_TaiKhoan { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class SANPHAM
    {
        [Key]
        public string ID_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_TaiKhoan { get; set; }

        [ForeignKey("ID_TaiKhoan")]
        public virtual TAIKHOAN TaiKhoan { get; set; }
    }

    public class CHITIETSANPHAM
    {
        [Key]
        public string ID_ChiTietSP { get; set; }
        public string TrangThai { get; set; }
        public string HinhAnh { get; set; }
        public string ThuongHieu { get; set; }
        public string MauSac { get; set; }
        public string KichCo { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_SanPham { get; set; }
        [ForeignKey("ID_SanPham")]
        public virtual SANPHAM SanPham { get; set; }
        public string ID_TaiKhoan { get; set; }

        [ForeignKey("ID_TaiKhoan")]
        public virtual TAIKHOAN TaiKhoan { get; set; }

    }

    public class SanPhamChiTietDTO
    {
        public string ID_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MauSac { get; set; }
        public string Size { get; set; }
        public string ThuongHieu { get; set; }
        public string HinhAnh { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }


    public class NHANVIEN
    {
        [Key]
        public string ID_NhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string SoCCCD { get; set; }
        public string TrangThai { get; set; }
        public string VaiTro { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_TaiKhoan { get; set; }

        [ForeignKey("ID_TaiKhoan")]
        public virtual TAIKHOAN TaiKhoan { get; set; }
    }

    public class VOUCHER
    {
        [Key]
        public string ID_Voucher { get; set; }
        public string TenVoucher { get; set; }
        public double PhanTramGiam { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime HanSuDung { get; set; }
        public string TrangThai { get; set; }
    }

    public class HOADON
    {
        [Key]
        public string ID_HoaDon { get; set; }
        public string TenKH { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public double TongTien { get; set; }
        public string TrangThai { get; set; }
        public string ID_NhanVien { get; set; }
        public string ID_Voucher { get; set; }

        [ForeignKey("ID_NhanVien")]
        public virtual NHANVIEN NhanVien { get; set; }
        [ForeignKey("ID_Voucher")]
        public virtual VOUCHER Voucher { get; set; }
    }

    public class HOADONCHITIET
    {
        [Key]
        public string ID_HoaDonChiTiet { get; set; }
        public string TenSP { get; set; }
        public string ThuongHieu { get; set; }
        public string MauSac { get; set; }
        public string KichCo { get; set; }
        public int SoLuong { get; set; }
        public double PhanTramGiam { get; set; }
        public double Gia { get; set; }
        public string ID_HoaDon { get; set; }
        public string ID_ChiTietSP { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }

        [ForeignKey("ID_HoaDon")]
        public virtual HOADON HoaDon { get; set; }
        [ForeignKey("ID_ChiTietSP")]
        public virtual CHITIETSANPHAM ChiTietSanPham { get; set; }
    }
}