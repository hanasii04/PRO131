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
    public partial class QuanLyVC : Form
    {
        private string idNhanVien;
        private string tenNguoiDung;
        private string vaiTro;
        public string selectedVoucherID;
        public QuanLyVC(string tenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
            this.tenNguoiDung = tenNguoiDung;
            this.vaiTro = vaiTro;
            labeUsername.Text = "Xin chào: " + tenNguoiDung;
        }
        DuAn da = new DuAn();
        private void QuanLyVC_Load(object sender, EventArgs e)
        {
            List<VOUCHER> vc = da.Vouchers.ToList();
            gridViewQLVC.DataSource = vc;

            gridViewQLVC.Columns["ID_Voucher"].HeaderText = "ID Voucher";
            gridViewQLVC.Columns["TenVoucher"].HeaderText = "Tên Voucher";
            gridViewQLVC.Columns["SoLuong"].HeaderText = "Số Lượng";
            gridViewQLVC.Columns["PhanTramGiam"].HeaderText = "Phần Trăm Giảm";
            gridViewQLVC.Columns["HanSuDung"].HeaderText = "Hạn Sử Dụng";
            gridViewQLVC.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            gridViewQLVC.Columns["NguoiTao"].HeaderText = "Người Tạo";
            gridViewQLVC.Columns["NgayCapNhat"].HeaderText = "Ngày Cập Nhật";
            gridViewQLVC.Columns["NguoiCapNhat"].HeaderText = "Người Cập Nhật";

            gridViewQLVC.Columns["NgayTao"].Visible = false;
            gridViewQLVC.Columns["NguoiTao"].Visible = false;
            gridViewQLVC.Columns["NgayCapNhat"].Visible = false;
            gridViewQLVC.Columns["NguoiCapNhat"].Visible = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string phanTramGiam = txtPhanTramGiam.Text.Trim();
            string hsd = dtpHanSuDung.Text.Trim();

            if (string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(soLuong) ||
                string.IsNullOrEmpty(phanTramGiam) ||
                string.IsNullOrEmpty(hsd)
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var timKiemTenVC = da.Vouchers.FirstOrDefault(x => x.TenVoucher == ten);
            if(timKiemTenVC != null)
            {
                MessageBox.Show("Tên voucher đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            int soLuongS;
            if(!int.TryParse(soLuong, out soLuongS) || soLuongS < 1)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal phanTramGiamS;
            if (!decimal.TryParse(phanTramGiam, out phanTramGiamS))
            {
                MessageBox.Show("Phần trăm giảm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phanTramGiamS < 1 || phanTramGiamS > 100)
            {
                MessageBox.Show("Phần trăm giảm phải nằm trong khoảng từ 1 đến 100", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime hsdS;
            if (!DateTime.TryParse(hsd, out hsdS))
            {
                MessageBox.Show("Hạn sử dụng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hsdS < DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng phải nằm trong tương lai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            VOUCHER vc = new VOUCHER();
            vc.ID_Voucher = Guid.NewGuid().ToString();
            vc.PhanTramGiam = phanTramGiamS;
            vc.TenVoucher = ten;
            vc.SoLuong = soLuongS;
            vc.HanSuDung = hsdS;
            vc.NguoiTao = tenNguoiDung;
            vc.NguoiCapNhat = tenNguoiDung;
            vc.NgayTao = DateTime.Now;
            vc.NgayCapNhat = DateTime.Now;

            try
            {
                da.Vouchers.Add(vc);
                da.SaveChanges();
                QuanLyVC_Load(sender, e);
                MessageBox.Show("Thêm voucher thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gridViewQLVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridViewQLVC.Rows[e.RowIndex];

                selectedVoucherID = row.Cells["ID_Voucher"].Value.ToString();

                txtTen.Text = row.Cells["TenVoucher"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtPhanTramGiam.Text = row.Cells["PhanTramGiam"].Value.ToString();
                dtpHanSuDung.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
                labeNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
                labeNguoiTao.Text = row.Cells["NguoiTao"].Value.ToString();
                labeNgayCapNhat.Text = row.Cells["NgayCapNhat"].Value.ToString();
                labeNguoiCapNhat.Text = row.Cells["NguoiCapNhat"].Value.ToString();
            }
        }


        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedVoucherID))
            {
                MessageBox.Show("Vui lòng chọn voucher cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //string ten = txtTen.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string phanTramGiam = txtPhanTramGiam.Text.Trim();
            string hsd = dtpHanSuDung.Text.Trim();

            if (string.IsNullOrEmpty(hsd) ||
                string.IsNullOrEmpty(soLuong) ||
                string.IsNullOrEmpty(phanTramGiam)
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongS;
            if (!int.TryParse(soLuong, out soLuongS) || soLuongS < 1)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal phanTramGiamS;
            if (!decimal.TryParse(phanTramGiam, out phanTramGiamS))
            {
                MessageBox.Show("Phần trăm giảm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phanTramGiamS < 1 || phanTramGiamS > 100)
            {
                MessageBox.Show("Phần trăm giảm phải nằm trong khoảng từ 1 đến 100", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime hsdS;
            if (!DateTime.TryParse(hsd, out hsdS))
            {
                MessageBox.Show("Hạn sử dụng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hsdS <= DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng phải nằm trong tương lai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var vc = da.Vouchers.FirstOrDefault(v => v.ID_Voucher == selectedVoucherID);
            if (vc != null)
            {
                //vc.TenVoucher = ten;
                vc.SoLuong = soLuongS;
                vc.PhanTramGiam = phanTramGiamS;
                vc.HanSuDung = hsdS;
                vc.NguoiCapNhat = tenNguoiDung;
                vc.NgayCapNhat = DateTime.Now;

                try
                {
                    da.SaveChanges();
                    MessageBox.Show("Cập nhật voucher thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLyVC_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy voucher cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormQuanLy fql = new FormQuanLy(idNhanVien, tenNguoiDung, vaiTro);
            fql.Show();
            this.Hide();
        }

        private void labeNguoiTao_Click(object sender, EventArgs e)
        {

        }
    }
}
