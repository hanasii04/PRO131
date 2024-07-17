using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace PRO131.Model
{
    public class QuanLyBanAo : DbContext
    {
        // Your context has been configured to use a 'QuanLyBanAo' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PRO131.Model.QuanLyBanAo' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuanLyBanAo' 
        // connection string in the application configuration file.
        public QuanLyBanAo()
            : base("name=QuanLyBanAo")
        {
        }

        public virtual DbSet<TAIKHOAN> TaiKhoans { get; set; }
        public virtual DbSet<KHACHHANG> KhachHangs { get; set; }
        public virtual DbSet<THUONGHIEU> ThuongHieus { get; set; }
        public virtual DbSet<MAUSAC> MauSacs { get; set; }
        public virtual DbSet<KICHCO> KichCos { get; set; }
        public virtual DbSet<SANPHAM> SanPhams { get; set; }
        public virtual DbSet<CHITIETSANPHAM> ChiTietSanPhams { get; set; }
        public virtual DbSet<NHANVIEN> NhanViens { get; set; }
        public virtual DbSet<VOUCHER> Vouchers { get; set; }
        public virtual DbSet<HOADON> HoaDons { get; set; }
        public virtual DbSet<HOADONCHITIET> HoaDonChiTiets { get; set; }
        public virtual DbSet<PHIEUNHAP> PhieuNhaps { get; set; }
        public virtual DbSet<CTPHIEUNHAP> ChiTietPhieuNhaps { get; set; }
    }

    public class TAIKHOAN
    {
        [Key]
        public int ID_TaiKhoan { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class KHACHHANG
    {
        [Key]
        public int ID_KhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class THUONGHIEU
    {
        [Key]
        public int ID_ThuongHieu { get; set; }
        public string TenThuongHieu { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class MAUSAC
    {
        [Key]
        public int ID_MauSac { get; set; }
        public string TenMauSac { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class KICHCO
    {
        [Key]
        public int ID_KichCo { get; set; }
        public string KichCo { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class SANPHAM
    {
        [Key]
        public int ID_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public double Gia { get; set; }
        public int SoLuong { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }

    public class CHITIETSANPHAM
    {
        [Key]
        public int ID_ChiTietSP { get; set; }
        public string TenSanPham { get; set; }
        public string TrangThai { get; set; }
        public string HinhAnh { get; set; }
        public int ID_SanPham { get; set; }
        public int ID_ThuongHieu { get; set; }
        public int ID_MauSac { get; set; }
        public int ID_KichCo { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }

        [ForeignKey("ID_SanPham")]
        public virtual SANPHAM SanPham { get; set; }
        [ForeignKey("ID_ThuongHieu")]
        public virtual THUONGHIEU ThuongHieu { get; set; }
        [ForeignKey("ID_MauSac")]
        public virtual MAUSAC MauSac { get; set; }
        [ForeignKey("ID_KichCo")]
        public virtual KICHCO KichCo { get; set; }
    }

    public class NHANVIEN
    {
        [Key]
        public int ID_NhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string SoCCCD { get; set; }
        public string TrangThai { get; set; }
        public string VaiTro { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public int ID_TaiKhoan { get; set; }

        [ForeignKey("ID_TaiKhoan")]
        public virtual TAIKHOAN TaiKhoan { get; set; }
    }

    public class VOUCHER
    {
        [Key]
        public int ID_Voucher { get; set; }
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
        public int ID_HoaDon { get; set; }
        public string TenKH { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public double TongTien { get; set; }
        public string TrangThai { get; set; }
        public int ID_KhachHang { get; set; }
        public int ID_NhanVien { get; set; }
        public int ID_Voucher { get; set; }

        [ForeignKey("ID_KhachHang")]
        public virtual KHACHHANG KhachHang { get; set; }
        [ForeignKey("ID_NhanVien")]
        public virtual NHANVIEN NhanVien { get; set; }
        [ForeignKey("ID_Voucher")]
        public virtual VOUCHER Voucher { get; set; }
    }

    public class HOADONCHITIET
    {
        [Key]
        public int ID_HoaDonChiTiet { get; set; }
        public string TenSP { get; set; }
        public string ThuongHieu { get; set; }
        public string MauSac { get; set; }
        public string Size { get; set; }
        public int SoLuong { get; set; }
        public double PhanTramGiam { get; set; }
        public double Gia { get; set; }
        public int ID_HoaDon { get; set; }
        public int ID_ChiTietSP { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }

        [ForeignKey("ID_HoaDon")]
        public virtual HOADON HoaDon { get; set; }
        [ForeignKey("ID_ChiTietSP")]
        public virtual CHITIETSANPHAM ChiTietSanPham { get; set; }
    }

    public class PHIEUNHAP
    {
        [Key]
        public int ID_PhieuNhap { get; set; }
        public string NguoiNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TongTien { get; set; }
        public string TrangThai { get; set; }
        public int ID_NhanVien { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }

        [ForeignKey("ID_NhanVien")]
        public virtual NHANVIEN NhanVien { get; set; }
    }

    public class CTPHIEUNHAP
    {
        [Key]
        public int ID_ChiTietPhieuNhap { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }
        public int SoLuongNhap { get; set; }
        public int ID_PhieuNhap { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }

        [ForeignKey("ID_PhieuNhap")]
        public virtual PHIEUNHAP PhieuNhap { get; set; }
    }
}