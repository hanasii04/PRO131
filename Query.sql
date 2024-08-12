USE DuAn
SELECT * 
FROM SANPHAMs 
WHERE ID_SanPham = 'SP001';

SELECT * 
FROM CHITIETSANPHAMs 
WHERE ID_SanPham = 'SP001';

UPDATE NHANVIENs
SET VaiTro = 'Quan ly'
WHERE TenNguoiDung = 'hoang'



SELECT * FROM NHANVIENs
SELECT * FROM SANPHAMs
SELECT * FROM CHITIETSANPHAMs
SELECT * FROM VOUCHERs
DELETE FROM NHANVIENs

INSERT INTO NHANVIENs (ID_NhanVien, TenNguoiDung, MatKhau, TenNhanVien, SDT, DiaChi, TrangThai, VaiTro, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat)
VALUES ('NV001', 'hoang', '123', 'Nguyen Van A', '0123456789', '123 Nguyen Trai, Hanoi', 'Active', 'QuanLy', '2023-01-01', '2023-01-01', 'Admin', 'Admin');

INSERT INTO NHANVIENs (ID_NhanVien, TenNguoiDung, MatKhau, TenNhanVien, SDT, DiaChi, TrangThai, VaiTro, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat)
VALUES ('NV002', 'hao', '123', 'Tran Thi B', '0987654321', '456 Le Loi, Ho Chi Minh', 'Inactive', 'NhanVien', '2023-02-01', '2023-02-01', 'Admin', 'Admin');

INSERT INTO VOUCHERs(ID_Voucher, TenVoucher, PhanTramGiam, SoLuong, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, HanSuDung)
VALUES ('V001', 'Khuyến Mãi 10%', 10, 100, '2023-06-01', '2023-06-01', 'Admin', 'Admin', '2023-12-31');

INSERT INTO HOADONs (ID_HoaDon, TenKH, TrangThai, TongTien, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, ID_NhanVien, ID_Voucher)
VALUES ('HD001', 'Nguyễn Văn A', 'Thành công', 300000, '2023-07-01', '2023-07-01', 'Admin', 'Admin', 'NV001', 'V001');

INSERT INTO SANPHAMs (ID_SanPham, TenSanPham, GiaNhap, GiaBan, SoLuong, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, ID_NhanVien)
VALUES ('SP001', 'Áo Thun', 100000, 150000, 20, '2023-07-01', '2023-07-01', 'Admin', 'Admin', 'NV001');
INSERT INTO SANPHAMs (ID_SanPham, TenSanPham, GiaNhap, GiaBan, SoLuong, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, ID_NhanVien)
VALUES ('SP002', 'Áo Polo', 200000, 400000, 30, '2023-07-01', '2023-07-01', 'Admin', 'Admin', 'NV001');


INSERT INTO KICHCOes(ID_KichCo, TenKichCo)
VALUES ('KC001', 'L');
INSERT INTO KICHCOes(ID_KichCo, TenKichCo)
VALUES ('KC002', 'M');


INSERT INTO MAUSACs (ID_MauSac, TenMauSac)
VALUES ('MS001', 'Trắng');
INSERT INTO MAUSACs (ID_MauSac, TenMauSac)
VALUES ('MS002', 'Đen');

INSERT INTO THUONGHIEUx (ID_ThuongHieu, TenThuongHieu)
VALUES ('TH001', 'Nike');
INSERT INTO THUONGHIEUx (ID_ThuongHieu, TenThuongHieu)
VALUES ('TH002', 'Adidas');


INSERT INTO CHITIETSANPHAMs (ID_ChiTietSP, TrangThai, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, ID_SanPham, ID_NhanVien, ID_MauSac, ID_KichCo, ID_ThuongHieu)
VALUES ('CTSP001', 'Mới', '2023-07-01', '2023-07-01', 'Admin', 'Admin', 'SP001', 'NV001', 'MS001', 'KC001', 'TH001');
INSERT INTO CHITIETSANPHAMs (ID_ChiTietSP, TrangThai, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, ID_SanPham, ID_NhanVien, ID_MauSac, ID_KichCo, ID_ThuongHieu)
VALUES ('CTSP002', 'Mới', '2023-07-01', '2023-07-01', 'Admin', 'Admin', 'SP002', 'NV001', 'MS002', 'KC002', 'TH002');


INSERT INTO HOADONCHITIETs(ID_HoaDonChiTiet, TenSP, ThuongHieu, MauSac, KichCo, SoLuong, NgayTao, NgayCapNhat, NguoiTao, NguoiCapNhat, ID_HoaDon, ID_ChiTietSP)
VALUES ('CTHD001', 'Áo Thun', 'Nike', 'Trắng', 'L', 2, '2023-07-01', '2023-07-01', 'Admin', 'Admin', 'HD001', 'CTSP001');

SELECT * FROM HOADONCHITIETs
SELECT * FROM HOADONs
DELETE FROM HOADONs