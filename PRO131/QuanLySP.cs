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
        private string idNhanVien;
        private string vaiTro;
        public QuanLySP(string tenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.tenNguoiDung = tenNguoiDung;
            this.idNhanVien = idNhanVien;
            this.vaiTro = vaiTro;
            labeUsername.Text = "Xin chào: " + tenNguoiDung;
        }

        DuAn da = new DuAn();

        private void QuanLySP_Load(object sender, EventArgs e)
        {
            var query = from sp in da.SanPhams
                        join ctsp in da.ChiTietSanPhams
                        on sp.ID_SanPham equals ctsp.ID_SanPham
                        join nv in da.NhanViens
                        on sp.ID_NhanVien equals nv.ID_NhanVien
                        join mauSac in da.MauSacs 
                        on ctsp.ID_MauSac equals mauSac.ID_MauSac
                        join kichCo in da.KichCos
                        on ctsp.ID_KichCo equals kichCo.ID_KichCo
                        join thuongHieu in da.ThuongHieus
                        on ctsp.ID_ThuongHieu equals thuongHieu.ID_ThuongHieu
                        select new SanPhamChiTietDTO
                        {
                            ID_SanPham = sp.ID_SanPham,
                            ID_ChiTietSP = ctsp.ID_ChiTietSP,
                            TenSanPham = sp.TenSanPham,
                            GiaNhap = sp.GiaNhap,
                            GiaBan = sp.GiaBan,
                            SoLuong = ctsp.SoLuong,
                            MauSac = mauSac.TenMauSac,
                            ID_MauSac = mauSac.ID_MauSac,
                            KichCo = kichCo.TenKichCo,
                            ID_KichCo = kichCo.ID_KichCo,
                            ThuongHieu = thuongHieu.TenThuongHieu,
                            ID_ThuongHieu = thuongHieu.ID_ThuongHieu,
                            TrangThai = ctsp.TrangThai,
                            NgayTao = sp.NgayTao,
                            NgayCapNhat = sp.NgayCapNhat,
                            NguoiTao = nv.TenNguoiDung,
                            NguoiCapNhat = nv.TenNguoiDung
                        };
            var result = query.ToList();
            gridViewQLSP.DataSource = result;

            gridViewQLSP.Columns["ID_SanPham"].HeaderText = "ID Sản phẩm";
            gridViewQLSP.Columns["ID_ChiTietSP"].HeaderText = "ID Chi tiết sản phẩm";
            gridViewQLSP.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            gridViewQLSP.Columns["GiaNhap"].HeaderText = "Giá nhập";
            gridViewQLSP.Columns["GiaBan"].HeaderText = "Giá bán";
            gridViewQLSP.Columns["SoLuong"].HeaderText = "Số lượng";
            gridViewQLSP.Columns["MauSac"].HeaderText = "Màu sắc";
            gridViewQLSP.Columns["ID_MauSac"].HeaderText = "ID Màu sắc";
            gridViewQLSP.Columns["KichCo"].HeaderText = "Kích cỡ";
            gridViewQLSP.Columns["ID_KichCo"].HeaderText = "ID Kích cỡ";
            gridViewQLSP.Columns["ThuongHieu"].HeaderText = "Thương hiệu";
            gridViewQLSP.Columns["ID_ThuongHieu"].HeaderText = "ID Thương hiệu";
            gridViewQLSP.Columns["TrangThai"].HeaderText = "Trạng thái";
            gridViewQLSP.Columns["NgayTao"].HeaderText = "Ngày tạo";
            gridViewQLSP.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
            gridViewQLSP.Columns["NguoiTao"].HeaderText = "Người tạo";
            gridViewQLSP.Columns["NguoiCapNhat"].HeaderText = "Người cập nhật";

            gridViewQLSP.Columns["ID_SanPham"].Visible = false;
            gridViewQLSP.Columns["ID_ChiTietSP"].Visible = false;
            gridViewQLSP.Columns["ID_MauSac"].Visible = false;
            gridViewQLSP.Columns["ID_KichCo"].Visible = false;
            gridViewQLSP.Columns["ID_ThuongHieu"].Visible = false;
        }



        private void buttonThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            string giaNhap = txtGiaNhap.Text.Trim();
            string giaBan = txtGiaBan.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string mauSac = txtMauSac.Text.Trim();
            string kichCo = txtSize.Text.Trim();
            string thuongHieu = txtThuongHieu.Text.Trim();
            string trangThai = "";

            if (radioConHang.Checked)
            {
                trangThai = "Còn hàng";
            }
            if (!radioConHang.Checked)
            {
                MessageBox.Show("Trạng thái không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tenSP) 
                || string.IsNullOrEmpty(giaNhap)
                || string.IsNullOrEmpty(giaBan) 
                || string.IsNullOrEmpty(soLuong)
                || string.IsNullOrEmpty(mauSac) 
                || string.IsNullOrEmpty(kichCo)
                || string.IsNullOrEmpty(thuongHieu) 
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Khai báo biến để lưu trữ dữ liệu sau khi chuyển đổi
            decimal giaNhapS;
            decimal giaBanS;
            // Kiểm tra nếu giá nhập và giá bán là số và lớn hơn 0, đồng thời giá bán phải lớn hơn giá nhập
            if (!decimal.TryParse(giaNhap, out giaNhapS) || !decimal.TryParse(giaBan, out giaBanS) ||
                giaNhapS <= 0 || giaBanS <= 0)
            {
                MessageBox.Show("Giá nhập và giá bán phải là số và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (giaBanS <= giaNhapS)
            {
                MessageBox.Show("Giá bán phải lớn hơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongS;
            if (!int.TryParse(soLuong, out soLuongS) || soLuongS <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu kích cỡ không thuộc 1 trong 4 giá trị "S, M, L, XL" thì báo lỗi
            if (kichCo != "S" && kichCo != "M" && kichCo != "L" && kichCo != "XL")
            {
                MessageBox.Show("Kích cỡ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem sản phẩm đã tồn tại chưa
            var sanPhamTonTai = da.ChiTietSanPhams.FirstOrDefault
                            (x => x.SanPham.TenSanPham == tenSP
                             && x.mauSac.TenMauSac == mauSac
                             && x.kichCo.TenKichCo == kichCo
                             && x.thuongHieu.TenThuongHieu == thuongHieu);
            if (sanPhamTonTai != null)
            {
                MessageBox.Show("Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SANPHAM sp = new SANPHAM
            {
                ID_SanPham = Guid.NewGuid().ToString(), // Sử dụng Guid để tạo ID duy nhất
                TenSanPham = tenSP,
                GiaNhap = giaNhapS,
                GiaBan = giaBanS,
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = tenNguoiDung, 
                NguoiCapNhat = tenNguoiDung,
                ID_NhanVien = idNhanVien

            };

            MAUSAC ms = new MAUSAC
            {
                ID_MauSac = Guid.NewGuid().ToString(),
                TenMauSac = mauSac
            };

            KICHCO kc = new KICHCO
            {
                ID_KichCo = Guid.NewGuid().ToString(),
                TenKichCo = kichCo
            };

            THUONGHIEU th = new THUONGHIEU
            {
                ID_ThuongHieu = Guid.NewGuid().ToString(),
                TenThuongHieu = thuongHieu
            };

            CHITIETSANPHAM ctsp = new CHITIETSANPHAM
            {
                ID_ChiTietSP = Guid.NewGuid().ToString(),
                ID_SanPham = sp.ID_SanPham,
                ID_ThuongHieu = th.ID_ThuongHieu,
                ID_KichCo = kc.ID_KichCo,
                ID_MauSac = ms.ID_MauSac,
                SoLuong = soLuongS,
                TrangThai = trangThai,
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = tenNguoiDung, 
                NguoiCapNhat = tenNguoiDung,
                ID_NhanVien = idNhanVien
            };

            try
            {
                da.SanPhams.Add(sp);
                da.MauSacs.Add(ms);
                da.KichCos.Add(kc);
                da.ThuongHieus.Add(th);
                da.ChiTietSanPhams.Add(ctsp);
                da.SaveChanges(); 
                QuanLySP_Load(sender, e); 
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewQLSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridViewQLSP.Rows[e.RowIndex];

                labeID_SP.Text = row.Cells["ID_SanPham"].Value.ToString();
                labeID_CTSP.Text = row.Cells["ID_ChiTietSP"].Value.ToString();
                labeNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
                labeNguoiTao.Text = row.Cells["NguoiTao"].Value.ToString();
                labeNgayCapNhat.Text = row.Cells["NgayCapNhat"].Value.ToString();
                labeNguoiCapNhat.Text = row.Cells["NguoiCapNhat"].Value.ToString();


                txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtThuongHieu.Text = row.Cells["ThuongHieu"].Value.ToString();
                txtMauSac.Text = row.Cells["MauSac"].Value.ToString();
                txtSize.Text = row.Cells["KichCo"].Value.ToString();
                string trangThai = row.Cells["TrangThai"].Value.ToString();
                if (trangThai == "Còn hàng")
                {
                    radioConHang.Checked = true;
                }
                else if (trangThai == "Hết hàng")
                {
                    radioHetHang.Checked = true;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labeID_CTSP.Text = "...";
            labeID_SP.Text = "...";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtMauSac.Text = "";
            txtSize.Text = "";
            txtSoLuong.Text = "";
            txtTenSP.Text = "";
            txtThuongHieu.Text = "";
            radioConHang.Checked = false;
            radioHetHang.Checked = false;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            string giaNhap = txtGiaNhap.Text.Trim();
            string giaBan = txtGiaBan.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string mauSac = txtMauSac.Text.Trim();
            string kichCo = txtSize.Text.Trim();
            string thuongHieu = txtThuongHieu.Text.Trim();
            string trangThai = "";

            if (radioConHang.Checked)
            {
                trangThai = "Còn hàng";
            }
            if (radioHetHang.Checked)
            {
                trangThai = "Hết hàng";
            }

            if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(giaNhap)
                || string.IsNullOrEmpty(giaBan) || string.IsNullOrEmpty(soLuong)
                || string.IsNullOrEmpty(mauSac) || string.IsNullOrEmpty(kichCo)
                || string.IsNullOrEmpty(thuongHieu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if(gridViewQLSP.SelectedRows.Count > 0)
            {
                string idMauSac = gridViewQLSP.SelectedRows[0].Cells["ID_MauSac"].Value.ToString();
                string idKichCo = gridViewQLSP.SelectedRows[0].Cells["ID_KichCo"].Value.ToString();
                string idThuongHieu = gridViewQLSP.SelectedRows[0].Cells["ID_ThuongHieu"].Value.ToString();

                if(idMauSac != null)
                {
                    var ms = da.MauSacs.FirstOrDefault(x => x.ID_MauSac == idMauSac);
                    if (ms != null)
                    {
                        ms.TenMauSac = mauSac;
                    }
                }
                if (idKichCo != null)
                {
                    var kc = da.KichCos.FirstOrDefault(x => x.ID_KichCo == idKichCo);
                    if (kc != null)
                    {
                        kc.TenKichCo = kichCo;
                    }
                }
                if (idThuongHieu != null)
                {
                    var th = da.ThuongHieus.FirstOrDefault(x => x.ID_ThuongHieu == idThuongHieu);
                    if (th != null)
                    {
                        th.TenThuongHieu = thuongHieu;
                    }
                }
            }    

            var sp = da.SanPhams.FirstOrDefault(x => x.ID_SanPham  == labeID_SP.Text);
            if(sp != null)
            {
                sp.TenSanPham = tenSP;
                sp.GiaNhap = giaNhapS;
                sp.GiaBan = giaBanS;
                sp.NgayCapNhat = DateTime.Now;
                sp.NguoiCapNhat = tenNguoiDung;
            };

            var ctsp = da.ChiTietSanPhams.FirstOrDefault(x => x.ID_ChiTietSP == labeID_CTSP.Text);
            if(ctsp != null)
            {
                ctsp.TrangThai = trangThai;
                ctsp.NgayCapNhat = DateTime.Now;
                ctsp.NguoiCapNhat = tenNguoiDung;
            }

            try
            {
                da.SaveChanges();
                QuanLySP_Load(sender, e);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from sp in da.SanPhams
                        join ctsp in da.ChiTietSanPhams
                        on sp.ID_SanPham equals ctsp.ID_SanPham
                        join nv in da.NhanViens
                        on sp.ID_NhanVien equals nv.ID_NhanVien
                        join mauSac in da.MauSacs
                        on ctsp.ID_MauSac equals mauSac.ID_MauSac
                        join kichCo in da.KichCos
                        on ctsp.ID_KichCo equals kichCo.ID_KichCo
                        join thuongHieu in da.ThuongHieus
                        on ctsp.ID_ThuongHieu equals thuongHieu.ID_ThuongHieu
                        select new SanPhamChiTietDTO
                        {
                            ID_SanPham = sp.ID_SanPham,
                            ID_ChiTietSP = ctsp.ID_ChiTietSP,
                            TenSanPham = sp.TenSanPham,
                            GiaNhap = sp.GiaNhap,
                            GiaBan = sp.GiaBan,
                            SoLuong = ctsp.SoLuong,
                            MauSac = mauSac.TenMauSac,
                            ID_MauSac = mauSac.ID_MauSac,
                            KichCo = kichCo.TenKichCo,
                            ID_KichCo = kichCo.ID_KichCo,
                            ThuongHieu = thuongHieu.TenThuongHieu,
                            ID_ThuongHieu = thuongHieu.ID_ThuongHieu,
                            TrangThai = ctsp.TrangThai,
                            NgayTao = sp.NgayTao,
                            NgayCapNhat = sp.NgayCapNhat,
                            NguoiTao = nv.TenNguoiDung,
                            NguoiCapNhat = nv.TenNguoiDung
                        };

            string selectedStatus = cbbLocTrangThai.Text;
            if (selectedStatus != "Tất cả")
            {
                query = query.Where(x => x.TrangThai == selectedStatus);
            }

            var result = query.ToList();
            gridViewQLSP.DataSource = result;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim().ToLower();
            var selectedItem = cbbTimKiem.SelectedItem;
            string searchField = selectedItem?.ToString();

            if (selectedItem == null || string.IsNullOrEmpty(searchField))
            {
                MessageBox.Show("Vui lòng chọn danh mục tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng điền thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    

            var query = from sp in da.SanPhams
                        join ctsp in da.ChiTietSanPhams
                        on sp.ID_SanPham equals ctsp.ID_SanPham
                        join nv in da.NhanViens
                        on sp.ID_NhanVien equals nv.ID_NhanVien
                        join mauSac in da.MauSacs
                        on ctsp.ID_MauSac equals mauSac.ID_MauSac
                        join kichCo in da.KichCos
                        on ctsp.ID_KichCo equals kichCo.ID_KichCo
                        join thuongHieu in da.ThuongHieus
                        on ctsp.ID_ThuongHieu equals thuongHieu.ID_ThuongHieu
                        select new SanPhamChiTietDTO
                        {
                            ID_SanPham = sp.ID_SanPham,
                            ID_ChiTietSP = ctsp.ID_ChiTietSP,
                            TenSanPham = sp.TenSanPham,
                            GiaNhap = sp.GiaNhap,
                            GiaBan = sp.GiaBan,
                            SoLuong = ctsp.SoLuong,
                            MauSac = mauSac.TenMauSac,
                            ID_MauSac = mauSac.ID_MauSac,
                            KichCo = kichCo.TenKichCo,
                            ID_KichCo = kichCo.ID_KichCo,
                            ThuongHieu = thuongHieu.TenThuongHieu,
                            ID_ThuongHieu = thuongHieu.ID_ThuongHieu,
                            TrangThai = ctsp.TrangThai,
                            NgayTao = sp.NgayTao,
                            NgayCapNhat = sp.NgayCapNhat,
                            NguoiTao = nv.TenNguoiDung,
                            NguoiCapNhat = nv.TenNguoiDung
                        };

            if (!string.IsNullOrEmpty(searchValue))
            {
                switch (searchField)
                {
                    case "Tên":
                        query = query.Where(x => x.TenSanPham.ToLower().Contains(searchValue));
                        break;
                    case "Màu sắc":
                        query = query.Where(x => x.MauSac.ToLower().Contains(searchValue));
                        break;
                    case "Kích cỡ":
                        query = query.Where(x => x.KichCo.ToLower().Contains(searchValue));
                        break;
                    case "Thương hiệu":
                        query = query.Where(x => x.ThuongHieu.ToLower().Contains(searchValue));
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn thuộc tính tìm kiếm hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }
            }

            var result = query.ToList();

            if (result.Count == 0)
            {
                gridViewQLSP.DataSource = null;
                MessageBox.Show("Không tìm thấy kết quả nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gridViewQLSP.DataSource = result;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormQuanLy fql = new FormQuanLy(idNhanVien, tenNguoiDung, vaiTro);
            fql.Show();
            this.Hide();
        }
    }
}
