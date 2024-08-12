using iTextSharp.text.pdf;
using iTextSharp.text;
using PRO131.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class BanHang : Form
    {
        private string TenNguoiDung;
        private string idNhanVien;
        private string vaiTro;

        public BanHang(string TenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.TenNguoiDung = TenNguoiDung;
            this.idNhanVien = idNhanVien;
            this.vaiTro = vaiTro;
            labeUsername.Text = "Xin chào: " + TenNguoiDung;
            buttonThanhToan.Enabled = false;
            buttonXuatHD.Enabled = false;
        }
        DuAn da = new DuAn();

        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadHoaDon();
        }

        private void LoadSanPham()
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
            var result_1 = query.ToList();
            gridViewListSP.DataSource = result_1;

            var result_2 = result_1.Select((item, index) => new
            {
                STT = index + 1, // Tạo cột STT với giá trị tăng dần bắt đầu từ 1
                item.ID_SanPham,
                item.ID_ChiTietSP,
                item.TenSanPham,
                item.GiaNhap,
                item.GiaBan,
                item.SoLuong,
                item.MauSac,
                item.ID_MauSac,
                item.KichCo,
                item.ID_KichCo,
                item.ThuongHieu,
                item.ID_ThuongHieu,
                item.TrangThai,
                item.NgayTao,
                item.NgayCapNhat,
                item.NguoiTao,
                item.NguoiCapNhat
            }).ToList();

            gridViewListSP.DataSource = result_2;

            gridViewListSP.Columns["STT"].HeaderText = "STT";
            gridViewListSP.Columns["ID_SanPham"].HeaderText = "ID Sản phẩm";
            gridViewListSP.Columns["ID_ChiTietSP"].HeaderText = "ID Chi tiết sản phẩm";
            gridViewListSP.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            gridViewListSP.Columns["GiaNhap"].HeaderText = "Giá nhập";
            gridViewListSP.Columns["GiaBan"].HeaderText = "Giá";
            gridViewListSP.Columns["SoLuong"].HeaderText = "Số lượng";
            gridViewListSP.Columns["MauSac"].HeaderText = "Màu sắc";
            gridViewListSP.Columns["ID_MauSac"].HeaderText = "ID Màu sắc";
            gridViewListSP.Columns["KichCo"].HeaderText = "Kích cỡ";
            gridViewListSP.Columns["ID_KichCo"].HeaderText = "ID Kích cỡ";
            gridViewListSP.Columns["ThuongHieu"].HeaderText = "Thương hiệu";
            gridViewListSP.Columns["ID_ThuongHieu"].HeaderText = "ID Thương hiệu";
            gridViewListSP.Columns["TrangThai"].HeaderText = "Trạng thái";
            gridViewListSP.Columns["NgayTao"].HeaderText = "Ngày tạo";
            gridViewListSP.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
            gridViewListSP.Columns["NguoiTao"].HeaderText = "Người tạo";
            gridViewListSP.Columns["NguoiCapNhat"].HeaderText = "Người cập nhật";

            gridViewListSP.Columns["ID_SanPham"].Visible = false;
            gridViewListSP.Columns["ID_ChiTietSP"].Visible = false;
            gridViewListSP.Columns["ID_MauSac"].Visible = false;
            gridViewListSP.Columns["ID_KichCo"].Visible = false;
            gridViewListSP.Columns["ID_ThuongHieu"].Visible = false;
            gridViewListSP.Columns["GiaNhap"].Visible = false;
            gridViewListSP.Columns["NgayTao"].Visible = false;
            gridViewListSP.Columns["NgayCapNhat"].Visible = false;
            gridViewListSP.Columns["NguoiTao"].Visible = false;
            gridViewListSP.Columns["NguoiCapNhat"].Visible = false;

            gridViewListSP.Columns["STT"].DisplayIndex = 0;
        }

        private void LoadHoaDon()
        {
            // Lấy danh sách hóa đơn chưa thanh toán từ cơ sở dữ liệu
            var hoaDons = da.HoaDons
                            .Where(hd => hd.TrangThai == "Chưa thanh toán")
                            .ToList();

            var hoaDonView = hoaDons.Select((hd, index) => new
            {
                STT = index + 1,
                ID_HoaDon = hd.ID_HoaDon,
                NgayTao = hd.NgayTao,
                NguoiTao = hd.NguoiTao,
                ThanhTien = hd.TongTien,
                TrangThai = hd.TrangThai
            }).ToList();

            gridViewHoaDon.DataSource = hoaDonView;

            gridViewHoaDon.Columns["STT"].HeaderText = "STT";
            gridViewHoaDon.Columns["ID_HoaDon"].HeaderText = "ID Hóa đơn";
            gridViewHoaDon.Columns["NgayTao"].HeaderText = "Ngày tạo";
            gridViewHoaDon.Columns["NguoiTao"].HeaderText = "Người tạo";
            gridViewHoaDon.Columns["ThanhTien"].HeaderText = "Thành tiền";
            gridViewHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";

            gridViewHoaDon.Columns["STT"].DisplayIndex = 0;
        }


        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            if (gridViewListSP.SelectedRows.Count > 0)
            {
                var selectedRow = gridViewListSP.SelectedRows[0];
                string idSanPham = selectedRow.Cells["ID_SanPham"].Value.ToString();
                string idCTSP = selectedRow.Cells["ID_ChiTietSP"].Value.ToString();
                decimal giaBan = Convert.ToDecimal(selectedRow.Cells["GiaBan"].Value);
                int soLuong = 1;

                // Tìm hóa đơn chưa thanh toán của nhân viên hiện tại
                var hoaDon = da.HoaDons.FirstOrDefault(hd => hd.ID_NhanVien == idNhanVien && hd.TrangThai == "Chưa thanh toán");

                if (hoaDon == null)
                {
                    // Tạo hóa đơn mới nếu chưa có
                    hoaDon = new HOADON
                    {
                        ID_HoaDon = Guid.NewGuid().ToString(),
                        TenKH = "Khách vãng lai",
                        TrangThai = "Chưa thanh toán",
                        TongTien = 0, // Sẽ cập nhật sau
                        NgayTao = DateTime.Now,
                        NgayCapNhat = DateTime.Now,
                        NguoiTao = TenNguoiDung,
                        NguoiCapNhat = TenNguoiDung,
                        ID_NhanVien = idNhanVien,
                        ID_Voucher = null
                    };
                    da.HoaDons.Add(hoaDon);
                    da.SaveChanges();
                }

                // Kiểm tra sản phẩm đã tồn tại trong HOADONCHITIET chưa
                var hoaDonChiTiet = da.HoaDonChiTiets.FirstOrDefault(hdct => hdct.ID_HoaDon == hoaDon.ID_HoaDon && hdct.ID_ChiTietSP == idCTSP);

                if (hoaDonChiTiet != null)
                {
                    // Nếu sản phẩm đã tồn tại, tăng số lượng và cập nhật số lượng tồn kho
                    hoaDonChiTiet.SoLuong += soLuong;
                    da.SaveChanges();
                }
                else
                {
                    // Nếu sản phẩm chưa có trong chi tiết hóa đơn, thêm mới
                    hoaDonChiTiet = new HOADONCHITIET
                    {
                        ID_HoaDonChiTiet = Guid.NewGuid().ToString(),
                        ID_HoaDon = hoaDon.ID_HoaDon,
                        ID_ChiTietSP = idCTSP,
                        TenSP = selectedRow.Cells["TenSanPham"].Value.ToString(),
                        MauSac = selectedRow.Cells["MauSac"].Value.ToString(),
                        KichCo = selectedRow.Cells["KichCo"].Value.ToString(),
                        ThuongHieu = selectedRow.Cells["ThuongHieu"].Value.ToString(),
                        SoLuong = soLuong,
                        NgayTao = DateTime.Now,
                        NguoiTao = TenNguoiDung,
                        NgayCapNhat = DateTime.Now,
                        NguoiCapNhat = TenNguoiDung
                    };
                    da.HoaDonChiTiets.Add(hoaDonChiTiet);
                    da.SaveChanges();
                }

                // Cập nhật tổng tiền của hóa đơn
                hoaDon.TongTien += giaBan * soLuong;
                da.SaveChanges();

                MessageBox.Show("Sản phẩm đã được thêm vào hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm từ danh sách sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormQuanLy fql = new FormQuanLy(this.TenNguoiDung, this.idNhanVien, this.vaiTro);
            fql.Show();
            this.Hide();
        }

        private void gridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string idHoaDon = gridViewHoaDon.Rows[e.RowIndex].Cells["ID_HoaDon"].Value.ToString();

                // Truy vấn thông tin chi tiết của hóa đơn từ bảng HOADONCHITIET
                var chiTietHoaDon = from ct in da.HoaDonChiTiets
                                    join ctsp in da.ChiTietSanPhams
                                    on ct.ID_ChiTietSP equals ctsp.ID_ChiTietSP
                                    join sp in da.SanPhams
                                    on ctsp.ID_SanPham equals sp.ID_SanPham
                                    join ms in da.MauSacs
                                    on ctsp.ID_MauSac equals ms.ID_MauSac
                                    join kc in da.KichCos
                                    on ctsp.ID_KichCo equals kc.ID_KichCo
                                    join th in da.ThuongHieus
                                    on ctsp.ID_ThuongHieu equals th.ID_ThuongHieu
                                    where ct.ID_HoaDon == idHoaDon
                                    select new
                                    {
                                        ct.ID_HoaDonChiTiet,
                                        ct.ID_HoaDon,
                                        sp.TenSanPham,
                                        MauSac = ms.TenMauSac,
                                        KichCo = kc.TenKichCo,
                                        ThuongHieu = th.TenThuongHieu,
                                        ct.SoLuong,
                                        sp.GiaBan,
                                        ThanhTien = ct.SoLuong * sp.GiaBan
                                    };

                var chiTietList = chiTietHoaDon.ToList();

                gridViewHoaDonChiTiet.DataSource = chiTietList;

                // Thiết lập tiêu đề cho các cột trong gridViewHoaDonChiTiet
                gridViewHoaDonChiTiet.Columns["ID_HoaDonChiTiet"].HeaderText = "ID Chi tiết hóa đơn";
                gridViewHoaDonChiTiet.Columns["ID_HoaDon"].HeaderText = "ID Hóa đơn";
                gridViewHoaDonChiTiet.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
                gridViewHoaDonChiTiet.Columns["MauSac"].HeaderText = "Màu sắc";
                gridViewHoaDonChiTiet.Columns["KichCo"].HeaderText = "Kích cỡ";
                gridViewHoaDonChiTiet.Columns["ThuongHieu"].HeaderText = "Thương hiệu";
                gridViewHoaDonChiTiet.Columns["SoLuong"].HeaderText = "Số lượng";
                gridViewHoaDonChiTiet.Columns["GiaBan"].HeaderText = "Giá bán";
                gridViewHoaDonChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền";

                labeNhanVien.Text = TenNguoiDung;
                labeMaHD.Text = idHoaDon.ToString();
                labeThanhTien.Text = gridViewHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            }
        }

        private void buttonXoaHD_Click(object sender, EventArgs e)
        {
            if (gridViewHoaDon.SelectedRows.Count > 0)
            {
                // Lấy ID_HoaDon từ dòng được chọn
                string idHoaDon = gridViewHoaDon.SelectedRows[0].Cells["ID_HoaDon"].Value.ToString();

                // Xóa chi tiết hóa đơn từ bảng HOADONCHITIET
                var chiTietHoaDon = da.HoaDonChiTiets.Where(ct => ct.ID_HoaDon == idHoaDon).ToList();
                da.HoaDonChiTiets.RemoveRange(chiTietHoaDon);

                // Xóa hóa đơn từ bảng HOADON
                var hoaDon = da.HoaDons.FirstOrDefault(hd => hd.ID_HoaDon == idHoaDon);
                if (hoaDon != null)
                {
                    da.HoaDons.Remove(hoaDon);
                }

                da.SaveChanges();

                LoadHoaDon();
                gridViewHoaDonChiTiet.DataSource = null;

                MessageBox.Show("Hóa đơn và chi tiết hóa đơn đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal thanhTien;
            decimal tienKhachDua;
            decimal tienThua = 0;

            // Kiểm tra giá trị thành tiền có hợp lệ không
            if (!decimal.TryParse(labeThanhTien.Text, out thanhTien))
            {
                MessageBox.Show("Giá trị thành tiền không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonThanhToan.Enabled = false;
                return;
            }

            // Kiểm tra tiền khách đưa có hợp lệ không
            if (!decimal.TryParse(txtTienKhachDua.Text, out tienKhachDua))
            {
                MessageBox.Show("Số tiền khách đưa không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonThanhToan.Enabled = false;
                return;
            }

            // Kiểm tra số tiền khách đưa có đủ không
            if (tienKhachDua >= thanhTien)
            {
                tienThua = tienKhachDua - thanhTien;

                labeTienThua.Text = tienThua.ToString("C"); // Định dạng số tiền theo định dạng tiền tệ

                buttonThanhToan.Enabled = true;
            }
            else
            {
                // Thông báo số tiền khách đưa chưa đủ
                labeTienThua.Text = "0";
                buttonThanhToan.Enabled = false;
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string mgg = txtMGG.Text.Trim();

            // Kiểm tra tên khách hàng có bị bỏ trống hoặc chỉ chứa chữ không
            if (string.IsNullOrEmpty(tenKH) || !tenKH.All(char.IsLetter))
            {
                // Hiển thị cảnh báo và yêu cầu người dùng nhập tên khách hàng
                DialogResult result = MessageBox.Show("Tên khách hàng đang bị bỏ trống, bạn có muốn điền vào không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if(result == DialogResult.Yes)
                {
                    return; // Kết thúc hàm để người dùng có thể nhập tên
                }
                // Nếu chọn "No", sử dụng tên khách hàng mặc định
                tenKH = "Khách vãng lai";
            }

            VOUCHER voucher = null;

            // Kiểm tra nếu ô txtMGG bị bỏ trống
            if (string.IsNullOrEmpty(mgg))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn nhập mã giảm giá không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    return; // Kết thúc hàm để người dùng có thể nhập mã giảm giá
                }
            }
            else
            {
                // Nếu mã giảm giá không bị bỏ trống, kiểm tra mã giảm giá trong database
                voucher = da.Vouchers.FirstOrDefault(v => v.TenVoucher == mgg);
                if (voucher == null)
                {
                    MessageBox.Show("Mã giảm giá không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var hoaDon = da.HoaDons.FirstOrDefault(hd => hd.ID_NhanVien == idNhanVien && hd.TrangThai == "Chưa thanh toán");
            if (hoaDon != null)
            {
                hoaDon.TenKH = tenKH;
                hoaDon.TrangThai = "Đã thanh toán";

                if (voucher != null)
                {
                    decimal phanTramGiam = voucher.PhanTramGiam / 100m;
                    decimal thanhTien = hoaDon.TongTien;
                    decimal soTienGiam = thanhTien * phanTramGiam;
                    thanhTien -= soTienGiam;
                    hoaDon.TongTien = thanhTien;

                    //labeTienGiam.Text = soTienGiam.ToString("N0") + " VND";
                    labeThanhTien.Text = thanhTien.ToString("N0") + " VND";

                    voucher.SoLuong -= 1;
                }

                // Cập nhật số lượng tồn kho sau khi thanh toán thành công
                var chiTietHoaDonList = da.HoaDonChiTiets.Where(ct => ct.ID_HoaDon == hoaDon.ID_HoaDon).ToList();
                foreach (var item in chiTietHoaDonList)
                {
                    var chiTietSP = da.ChiTietSanPhams.FirstOrDefault(ctsp => ctsp.ID_ChiTietSP == item.ID_ChiTietSP);
                    if (chiTietSP != null)
                    {
                        chiTietSP.SoLuong -= item.SoLuong;
                    }
                }

                da.SaveChanges();

                // Xóa dữ liệu từ gridView sau khi thanh toán
                gridViewHoaDon.DataSource = null;
                gridViewHoaDonChiTiet.DataSource = null;

                // Load lại danh sách sản phẩm sau khi thanh toán 
                LoadSanPham();
                buttonXuatHD.Enabled = true;
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonXuatHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hóa đơn nào được chọn không
            if (string.IsNullOrEmpty(labeMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xuất.");
                return;
            }

            try
            {
                // Tạo đối tượng tài liệu PDF mới
                using (var document = new Document())
                {
                    // Tạo đối tượng lưu trữ PDF
                    using (var stream = new MemoryStream())
                    {
                        var writer = PdfWriter.GetInstance(document, stream);
                        document.Open();

                        // Đặt phông chữ hỗ trợ tiếng Việt
                        var fontTitle = FontFactory.GetFont("Tahoma", Convert.ToString(16), Font.Bold);
                        var fontHeader = FontFactory.GetFont("Tahoma", Convert.ToString(16), Font.Bold);
                        var fontNormal = FontFactory.GetFont("Tahoma", Convert.ToString(16), Font.Bold);

                        // Thêm tiêu đề hóa đơn
                        document.Add(new Paragraph("COUTURE SHIRT", fontTitle) { Alignment = Element.ALIGN_CENTER });
                        document.Add(new Paragraph("Đia ch: 123 Ho Tung Mau, Nam Ta Liem, Ha Noi", fontNormal) { Alignment = Element.ALIGN_CENTER });
                        document.Add(new Paragraph("\n"));

                        // Thêm thông tin hóa đơn
                        document.Add(new Paragraph("THONG TIN HOA ĐON:", fontHeader));
                        document.Add(new Paragraph($"Ma hoa đon: {labeMaHD.Text}", fontNormal));
                        document.Add(new Paragraph($"Ten khach hang: {txtTenKH.Text.Trim()}", fontNormal));
                        document.Add(new Paragraph($"Ten nhan vien: {labeNhanVien.Text}", fontNormal));
                        document.Add(new Paragraph($"Ngay tao: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}", fontNormal));
                        document.Add(new Paragraph("\n"));

                        // Thêm chi tiết hóa đơn
                        var table = new PdfPTable(4);
                        table.WidthPercentage = 100;
                        table.SetWidths(new float[] { 2f, 1f, 1f, 2f });

                        // Thêm tiêu đề cột
                        table.AddCell(new Phrase("Ten san pham", fontNormal));
                        table.AddCell(new Phrase("So luong", fontNormal));
                        table.AddCell(new Phrase("Gia ban", fontNormal));
                        table.AddCell(new Phrase("Thanh tien", fontNormal));

                        // Thêm dữ liệu chi tiết hóa đơn
                        var chiTietHoaDon = from ct in da.HoaDonChiTiets
                                            join ctsp in da.ChiTietSanPhams
                                            on ct.ID_ChiTietSP equals ctsp.ID_ChiTietSP
                                            join sp in da.SanPhams
                                            on ctsp.ID_SanPham equals sp.ID_SanPham
                                            where ct.ID_HoaDon == labeMaHD.Text
                                            select new
                                            {
                                                sp.TenSanPham,
                                                sp.GiaBan,
                                                ct.SoLuong,
                                                ThanhTien = ct.SoLuong * sp.GiaBan
                                            };

                        var chiTietList = chiTietHoaDon.ToList();
                        decimal tongTien = 0;

                        foreach (var item in chiTietList)
                        {
                            table.AddCell(new Phrase(item.TenSanPham, fontNormal));
                            table.AddCell(new Phrase(item.SoLuong.ToString(), fontNormal));
                            table.AddCell(new Phrase(item.GiaBan.ToString("C"), fontNormal));
                            table.AddCell(new Phrase(item.ThanhTien.ToString("C"), fontNormal));
                            tongTien += item.ThanhTien;
                        }

                        // Áp dụng voucher giảm giá nếu có
                        decimal tienGiam = 0;
                        if (!string.IsNullOrEmpty(txtMGG.Text))
                        {
                            // Giả sử bạn đã tính và hiển thị số tiền giảm vào labelTienGiam
                            decimal.TryParse(labeTienGiam.Text, out tienGiam);
                        }

                        var thanhTienSauGiam = labeThanhTien.Text;

                        // Thêm tổng tiền và thành tiền sau khi giảm vào cuối bảng
                        table.AddCell("");
                        table.AddCell("");
                        table.AddCell(new Phrase("Tong tien:", fontNormal));
                        table.AddCell(new Phrase(tongTien.ToString("C"), fontNormal));

                        table.AddCell("");
                        table.AddCell("");
                        table.AddCell(new Phrase("Tong tien sau khi giam:", fontNormal));
                        table.AddCell(new Phrase(thanhTienSauGiam, fontNormal));

                        document.Add(table);

                        // Đóng tài liệu PDF
                        document.Close();

                        // Lưu file PDF vào đĩa với tên file tự động tăng
                        string folderPath = @"C:\Users\thong\OneDrive\Desktop\Bill"; // Thay đổi đường dẫn nếu cần
                        string fileName = GetNextFileName(folderPath);
                        File.WriteAllBytes(Path.Combine(folderPath, fileName), stream.ToArray());

                        gridViewHoaDon.DataSource = null;
                        gridViewHoaDonChiTiet.DataSource = null;
                        MessageBox.Show($"Xuất hóa đơn thành công! Tên file: {fileName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xuất hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetNextFileName(string folderPath)
        {
            int fileNumber = 1;
            string fileName;

            do
            {
                fileName = $"hoadon{fileNumber}.pdf";
                fileNumber++;
            } while (File.Exists(Path.Combine(folderPath, fileName)));

            return fileName;
        }

        private void txtMGG_TextChanged(object sender, EventArgs e)
        {
            string mgg = txtMGG.Text.Trim();
            decimal thanhTien = 0m;
            decimal soTienGiam = 0m;

            // Kiểm tra nếu mã giảm giá không bị bỏ trống
            if (!string.IsNullOrEmpty(mgg))
            {
                // Kiểm tra mã giảm giá trong database
                VOUCHER voucher = da.Vouchers.FirstOrDefault(v => v.TenVoucher == mgg);
                if (voucher != null)
                {
                    decimal phanTramGiam = voucher.PhanTramGiam / 100m;

                    // Lấy tổng tiền của hóa đơn
                    var hoaDon = da.HoaDons.FirstOrDefault(hd => hd.ID_NhanVien == idNhanVien && hd.TrangThai == "Chưa thanh toán");
                    if (hoaDon != null)
                    {
                        thanhTien = hoaDon.TongTien;
                        soTienGiam = thanhTien * phanTramGiam;
                        thanhTien -= soTienGiam;

                        // Cập nhật các label
                        labeTienGiam.Text = soTienGiam.ToString("N0") + " VND";
                        labeThanhTien.Text = thanhTien.ToString("N0") + " VND";

                        // Cập nhật tiền thừa
                        if (decimal.TryParse(txtTienKhachDua.Text.Trim(), out decimal tienKhachDu))
                        {
                            decimal tienThua = tienKhachDu - thanhTien;
                            labeTienThua.Text = tienThua >= 0 ? tienThua.ToString("N0") + " VND" : "0 VND";
                        }
                    }
                }
                else
                {
                    // Nếu mã giảm giá không tồn tại, xóa số tiền giảm và cập nhật thành tiền
                    labeTienGiam.Text = "0 VND";
                    var hoaDon = da.HoaDons.FirstOrDefault(hd => hd.ID_NhanVien == idNhanVien && hd.TrangThai == "Chưa thanh toán");
                    if (hoaDon != null)
                    {
                        thanhTien = hoaDon.TongTien;
                        labeThanhTien.Text = thanhTien.ToString("N0") + " VND";
                    }

                    // Cập nhật tiền thừa
                    if (decimal.TryParse(txtTienKhachDua.Text.Trim(), out decimal tienKhachDu))
                    {
                        decimal tienThua = tienKhachDu - thanhTien;
                        labeTienThua.Text = tienThua >= 0 ? tienThua.ToString("N0") + " VND" : "0 VND";
                    }
                }
            }
            else
            {
                // Nếu không nhập mã giảm giá, xóa số tiền giảm và cập nhật thành tiền
                labeTienGiam.Text = "0 VND";
                var hoaDon = da.HoaDons.FirstOrDefault(hd => hd.ID_NhanVien == idNhanVien && hd.TrangThai == "Chưa thanh toán");
                if (hoaDon != null)
                {
                    thanhTien = hoaDon.TongTien;
                    labeThanhTien.Text = thanhTien.ToString("N0") + " VND";
                }

                // Cập nhật tiền thừa
                if (decimal.TryParse(txtTienKhachDua.Text.Trim(), out decimal tienKhachDu))
                {
                    decimal tienThua = tienKhachDu - thanhTien;
                    labeTienThua.Text = tienThua >= 0 ? tienThua.ToString("N0") + " VND" : "0 VND";
                }
            }
        }


    }
}
