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
    public partial class QuanLyHD : Form
    {
        private string tenNguoiDung;
        private string idNhanVien;
        private string vaiTro;
        public QuanLyHD(string tenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.tenNguoiDung = tenNguoiDung;
            this.idNhanVien = idNhanVien;
            this.vaiTro = vaiTro;
        }
        DuAn da = new DuAn();

        private void QuanLyHD_Load(object sender, EventArgs e)
        {
            List<HOADON> hd = da.HoaDons.ToList();
            gridViewHoaDon.DataSource = hd;

            gridViewHoaDon.Columns["NgayCapNhat"].Visible = false;
            gridViewHoaDon.Columns["NguoiCapNhat"].Visible = false;
            gridViewHoaDon.Columns["NhanVien"].Visible = false;
            gridViewHoaDon.Columns["Voucher"].Visible = false;
            gridViewHoaDon.Columns["ID_NhanVien"].Visible = false;
            //gridViewHoaDon.Columns["ID_Voucher"].Visible = false;
        }

        private void gridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedHoaDonID = gridViewHoaDon.Rows[e.RowIndex].Cells["ID_HoaDon"].Value.ToString();

                // Lấy danh sách chi tiết hóa đơn từ cơ sở dữ liệu dựa trên ID hóa đơn
                var chiTietHoaDon = da.HoaDonChiTiets
                                     .Where(ct => ct.ID_HoaDon == selectedHoaDonID)
                                     .Select(ct => new
                                     {
                                         ct.TenSP,
                                         ct.ThuongHieu,
                                         ct.MauSac,
                                         ct.KichCo,
                                         ct.SoLuong,
                                         ct.NgayTao,
                                         ct.NguoiTao

                                     })
                                     .ToList();

                gridViewHoaDonChiTiet.DataSource = chiTietHoaDon;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormQuanLy fql = new FormQuanLy(tenNguoiDung, idNhanVien, vaiTro);
            fql.Show();
            this.Hide();
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = da.HoaDons
                .Select(ct => new
                {
                    ct.ID_HoaDon,
                    ct.TenKH,
                    ct.TrangThai,
                    ct.TongTien,
                    ct.NgayTao,
                    ct.NguoiTao
                });

            string selectedStatus = cbbTrangThai.Text;

            // Nếu giá trị không phải là "Tất cả"
            // thì lọc danh sách hóa đơn theo trạng thái = với giá trị đã chọn
            if (selectedStatus != "Tất cả")
            {
                 query = query.Where(x => x.TrangThai == selectedStatus);
            }
            var query2 = query.ToList();
            gridViewHoaDon.DataSource = query2;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text.Trim();

            if(string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để tìm kiếm");
                return;
            }    

            var timKiemHoaDon = da.HoaDons.FirstOrDefault(x => x.ID_HoaDon == value);
            if(timKiemHoaDon != null)
            {
                                        // Chuyển đổi đối tượng timKiemHoaDon thành 1 list,
                                        // vì dataGridView cần 1 list để hiển thị
                gridViewHoaDon.DataSource = new List<HOADON> { timKiemHoaDon };
            }
            else
            {
                gridViewHoaDon.DataSource = null;
                MessageBox.Show("Mã hóa đơn không tồn tại");
            }

        }
    }
}
