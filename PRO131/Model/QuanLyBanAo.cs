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
        //public virtual DbSet<KHACHHANG> KhachHangs { get; set; }
        //public virtual DbSet<THUONGHIEU> ThuongHieus { get; set; }
        //public virtual DbSet<MAUSAC> MauSacs { get; set; }
        //public virtual DbSet<KICHCO> KichCos { get; set; }
        public virtual DbSet<SANPHAM> SanPham { get; set; }
        public virtual DbSet<CHITIETSANPHAM> ChiTietSanPham { get; set; }
        public virtual DbSet<NHANVIEN> NhanVien { get; set; }
        public virtual DbSet<VOUCHER> Voucher { get; set; }
        public virtual DbSet<HOADON> HoaDon { get; set; }
        public virtual DbSet<HOADONCHITIET> HoaDonChiTiet { get; set; }
        //public virtual DbSet<PHIEUNHAP> PhieuNhaps { get; set; }
        //public virtual DbSet<CTPHIEUNHAP> ChiTietPhieuNhaps { get; set; }
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

    //public class KHACHHANG
    //{
    //    [Key]
    //    public string ID_KhachHang { get; set; }
    //    public string TenKhachHang { get; set; }
    //    public string SoDienThoai { get; set; }
    //    public string DiaChi { get; set; }
    //    public string GioiTinh { get; set; }
    //    public DateTime NgayTao { get; set; }
    //    public DateTime NgayCapNhat { get; set; }
    //    public string NguoiTao { get; set; }
    //    public string NguoiCapNhat { get; set; }
    //}

    //public class THUONGHIEU
    //{
    //    [Key]
    //    public string ID_ThuongHieu { get; set; }
    //    public string TenThuongHieu { get; set; }
    //    public string TrangThai { get; set; }
    //    public DateTime NgayTao { get; set; }
    //    public DateTime NgayCapNhat { get; set; }
    //    public string NguoiTao { get; set; }
    //    public string NguoiCapNhat { get; set; }
    //}

    //public class MAUSAC
    //{
    //    [Key]
    //    public string ID_MauSac { get; set; }
    //    public string TenMauSac { get; set; }
    //    public string TrangThai { get; set; }
    //    public DateTime NgayTao { get; set; }
    //    public DateTime NgayCapNhat { get; set; }
    //    public string NguoiTao { get; set; }
    //    public string NguoiCapNhat { get; set; }
    //}

    //public class KICHCO
    //{
    //    [Key]
    //    public string ID_KichCo { get; set; }
    //    public string KichCo { get; set; }
    //    public string TrangThai { get; set; }
    //    public DateTime NgayTao { get; set; }
    //    public DateTime NgayCapNhat { get; set; }
    //    public string NguoiTao { get; set; }
    //    public string NguoiCapNhat { get; set; }
    //}

    public class SANPHAM
    {
        [Key]
        public string ID_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
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
        public string ID_ChiTietSP { get; set; }
        public string TenSanPham { get; set; }
        public string TrangThai { get; set; }
        public string HinhAnh { get; set; }
        public string ID_SanPham { get; set; }
        public string ThuongHieu { get; set; }
        public string MauSac { get; set; }
        public string KichCo { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }

        [ForeignKey("ID_SanPham")]
        public virtual SANPHAM SanPham { get; set; }
        //[ForeignKey("ID_ThuongHieu")]
        //public virtual THUONGHIEU ThuongHieu { get; set; }
        //[ForeignKey("ID_MauSac")]
        //public virtual MAUSAC MauSac { get; set; }
        //[ForeignKey("ID_KichCo")]
        //public virtual KICHCO KichCo { get; set; }
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
        //public string ID_KhachHang { get; set; }
        public string ID_NhanVien { get; set; }
        public string ID_Voucher { get; set; }

        //[ForeignKey("ID_KhachHang")]
        //public virtual KHACHHANG KhachHang { get; set; }
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

    //public class PHIEUNHAP
    //{
    //    [Key]
    //    public string ID_PhieuNhap { get; set; }
    //    public string NguoiNhap { get; set; }
    //    public DateTime NgayNhap { get; set; }
    //    public double TongTien { get; set; }
    //    public string TrangThai { get; set; }
    //    public int ID_NhanVien { get; set; }
    //    public DateTime NgayTao { get; set; }
    //    public DateTime NgayCapNhat { get; set; }
    //    public string NguoiTao { get; set; }
    //    public string NguoiCapNhat { get; set; }

    //    [ForeignKey("ID_NhanVien")]
    //    public virtual NHANVIEN NhanVien { get; set; }
    //}

    //public class CTPHIEUNHAP
    //{
    //    [Key]
    //    public string ID_ChiTietPhieuNhap { get; set; }
    //    public string TenSP { get; set; }
    //    public double Gia { get; set; }
    //    public string SoLuongNhap { get; set; }
    //    public string ID_PhieuNhap { get; set; }
    //    public DateTime NgayTao { get; set; }
    //    public DateTime NgayCapNhat { get; set; }
    //    public string NguoiTao { get; set; }
    //    public string NguoiCapNhat { get; set; }

    //    [ForeignKey("ID_PhieuNhap")]
    //    public virtual PHIEUNHAP PhieuNhap { get; set; }
    //}
}