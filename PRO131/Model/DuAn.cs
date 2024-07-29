using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace PRO131.Model
{
    public class DuAn : DbContext
    {
        public DuAn()
            : base("name=DuAn")
        {
        }

        public virtual DbSet<SANPHAM> SanPhams { get; set; }
        public virtual DbSet<CHITIETSANPHAM> ChiTietSanPhams { get; set; }
        public virtual DbSet<NHANVIEN> NhanViens { get; set; }
        public virtual DbSet<VOUCHER> Vouchers { get; set; }
        public virtual DbSet<HOADON> HoaDons { get; set; }
        public virtual DbSet<HOADONCHITIET> HoaDonChiTiets { get; set; }
        public virtual DbSet<MAUSAC> MauSacs { get; set; }
        public virtual DbSet<KICHCO> KichCos { get; set; }
        public virtual DbSet<THUONGHIEU> ThuongHieus { get; set; }

    }

    public class NHANVIEN
    {
        [Key]
        public string ID_NhanVien { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
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
    }

    public class SANPHAM
    {
        [Key]
        public string ID_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_NhanVien { get; set; }

        [ForeignKey("ID_NhanVien")]
        public virtual NHANVIEN NhanVien { get; set; }
    }

    public class MAUSAC
    {
        [Key]
        public string ID_MauSac { get; set; }
        public string TenMauSac { get; set; }
    }
    public class KICHCO
    {
        [Key]
        public string ID_KichCo { get; set; }
        public string TenKichCo { get; set; }
    }
    public class THUONGHIEU
    {
        [Key]
        public string ID_ThuongHieu { get; set; }
        public string TenThuongHieu { get; set; }
    }

    public class CHITIETSANPHAM
    {
        [Key]
        public string ID_ChiTietSP { get; set; }
        public string TrangThai { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_SanPham { get; set; }

        [ForeignKey("ID_SanPham")]
        public virtual SANPHAM SanPham { get; set; }

        public string ID_NhanVien { get; set; }

        [ForeignKey("ID_NhanVien")]
        public virtual NHANVIEN NhanVien { get; set; }

        public string ID_MauSac { get; set; }
        [ForeignKey("ID_MauSac")]
        public virtual MAUSAC mauSac { get; set; }
        public string ID_KichCo { get; set; }
        [ForeignKey("ID_KichCo")]
        public virtual KICHCO kichCo { get; set; }
        public string ID_ThuongHieu { get; set; }
        [ForeignKey("ID_ThuongHieu")]
        public virtual THUONGHIEU thuongHieu { get; set; }

    }

    public class SanPhamChiTietDTO
    {
        public string ID_SanPham { get; set; }
        public string ID_ChiTietSP { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MauSac { get; set; }
        public string ID_MauSac { get; set; }
        public string KichCo { get; set; }
        public string ID_KichCo { get; set; }
        public string ThuongHieu { get; set; }
        public string ID_ThuongHieu { get; set; }
        public string HinhAnh { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }


    public class VOUCHER
    {
        [Key]
        public string ID_Voucher { get; set; }
        public string TenVoucher { get; set; }
        public decimal PhanTramGiam { get; set; }
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
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_NhanVien { get; set; }

        [ForeignKey("ID_NhanVien")]
        public virtual NHANVIEN NhanVien { get; set; }
        public string ID_Voucher { get; set; }

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
        public decimal TongTien { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public string ID_HoaDon { get; set; }

        [ForeignKey("ID_HoaDon")]
        public virtual HOADON HoaDon { get; set; }
        public string ID_ChiTietSP { get; set; }
        [ForeignKey("ID_ChiTietSP")]
        public virtual CHITIETSANPHAM ChiTietSanPham { get; set; }
    }

}