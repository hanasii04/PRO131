using PRO131.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class QuanLyNV : Form
    {
        private string tenNguoiDung;
        private string idNhanVien;
        private string vaiTro;

        public QuanLyNV(string tenNguoiDung, string idNhanVien, string vaiTro)
        {
            InitializeComponent();
            this.tenNguoiDung = tenNguoiDung;
            this.idNhanVien = idNhanVien;
            this.vaiTro = vaiTro;
            labeUsername.Text = "Xin chào: " + tenNguoiDung;
            
        }
        DuAn da = new DuAn();

        private void QuanLyNV_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> nv = da.NhanViens.ToList();
            gridViewQLNV.DataSource = nv;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text.Trim();
            string username = txtTenNguoiDung.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string vaiTro = "";

            if (radioNhanVien.Checked)
            {
                vaiTro = "NhanVien";
            }
            else if (radioQuanLy.Checked)
            {
                vaiTro = "QuanLy";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenNV) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(sdt) ||
                string.IsNullOrEmpty(diaChi)
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra nếu tên nhân viên chứa số
            if (tenNV.Any(char.IsDigit))
            {
                MessageBox.Show("Tên nhân viên không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!sdt.StartsWith("0") || sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng '0' và phải đủ 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tất cả các ký tự không phải là số thì báo lỗi
            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (da.NhanViens.Any(x => x.TenNguoiDung == username))
            {
                MessageBox.Show("Tên người dùng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diaChi.Length < 3)
            {
                MessageBox.Show("Địa chỉ phải có ít nhất 3 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (da.NhanViens.Any(x => x.SDT == sdt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NHANVIEN nv = new NHANVIEN();
            nv.ID_NhanVien = Guid.NewGuid().ToString();
            nv.TenNhanVien = tenNV;
            nv.TenNguoiDung = username;
            nv.MatKhau = password;
            nv.SDT = sdt;
            nv.DiaChi = diaChi;
            nv.VaiTro = vaiTro;
            nv.TrangThai = "Đang làm";
            nv.NgayTao = DateTime.Now;
            nv.NgayCapNhat = DateTime.Now;
            nv.NguoiTao = tenNguoiDung;
            nv.NguoiCapNhat = tenNguoiDung;

            try
            {
                da.NhanViens.Add(nv);
                da.SaveChanges();
                QuanLyNV_Load(sender, e);
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            txtTenNguoiDung.Text = "";
            labeNguoiTao.Text = "";
            labeNgayTao.Text = "";
            labeNgayCapNhat.Text = "";
            labeNguoiCapNhat.Text = "";
            labeIDNV.Text = "";
            labeTrangThai.Text = "";
            radioNhanVien.Checked = false;
            radioQuanLy.Checked = false;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text.Trim();
            string username = txtTenNguoiDung.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string vaiTro = "";
            

            if (radioNhanVien.Checked)
            {
                vaiTro = "Nhân viên";
            }
            else if (radioQuanLy.Checked)
            {
                vaiTro = "Quản lý";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenNV) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(sdt) ||
                string.IsNullOrEmpty(diaChi)
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra nếu tên nhân viên chứa số
            if (tenNV.Any(char.IsDigit))
            {
                MessageBox.Show("Tên nhân viên không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!sdt.StartsWith("0") || sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng '0' và phải đủ 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tất cả các ký tự không phải là số thì báo lỗi
            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diaChi.Length < 2)
            {
                MessageBox.Show("Địa chỉ phải có ít nhất 2 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 5 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            var nv = da.NhanViens.FirstOrDefault(x => x.ID_NhanVien == labeIDNV.Text);
            if(nv != null)
            {
                nv.TenNhanVien = tenNV;
                nv.MatKhau = password;
                nv.VaiTro = vaiTro;
                nv.NgayCapNhat = DateTime.Now;
                nv.NguoiCapNhat = tenNguoiDung;
            }
            try
            {
                da.SaveChanges();
                QuanLyNV_Load(sender, e);
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridViewQLNV.Rows[e.RowIndex];

                labeIDNV.Text = row.Cells["ID_NhanVien"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtTenNguoiDung.Text = row.Cells["TenNguoiDung"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                labeNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
                labeNguoiTao.Text = row.Cells["NguoiTao"].Value.ToString();
                labeNgayCapNhat.Text = row.Cells["NgayCapNhat"].Value.ToString();
                labeNguoiCapNhat.Text = row.Cells["NguoiCapNhat"].Value.ToString();
                labeTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

                string vaiTro = row.Cells["VaiTro"].Value.ToString();

                if (vaiTro == "Nhân viên")
                {
                    radioNhanVien.Checked = true;
                }
                else if (vaiTro == "Quản lý")
                {
                    radioQuanLy.Checked = true;
                }
            }
        }

        private void buttonKhoaTK_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong GridView hay không
            if (gridViewQLNV.SelectedRows.Count > 0)
            {
                // Lấy ID của nhân viên từ hàng được chọn trong GridView
                string id = gridViewQLNV.SelectedRows[0].Cells["ID_NhanVien"].Value.ToString();

                var nhanVien = da.NhanViens.FirstOrDefault(x => x.ID_NhanVien == id);

                if (nhanVien != null)
                {
                    if (nhanVien.ID_NhanVien == idNhanVien)
                    {
                        MessageBox.Show("Bạn không thể khóa tài khoản của mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (nhanVien.VaiTro == "Quản lý")
                    {
                        MessageBox.Show("Không thể khóa tài khoản của quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    nhanVien.TrangThai = "Nghỉ làm";
                    nhanVien.NgayCapNhat = DateTime.Now;
                    nhanVien.NguoiCapNhat = tenNguoiDung;

                    try
                    {
                        da.SaveChanges();
                        QuanLyNV_Load(sender, e);
                        MessageBox.Show("Khóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần khóa tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần khóa tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormQuanLy fql = new FormQuanLy(tenNguoiDung, idNhanVien, vaiTro);
            fql.Show();
            this.Hide();
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

            var query = from nv in da.NhanViens
                        select new
                        {
                            nv.TenNhanVien,
                            nv.TenNguoiDung,
                            nv.MatKhau,
                            nv.VaiTro,
                            nv.SDT,
                            nv.DiaChi,
                            nv.TrangThai
                        };

            switch (searchField)
            {
                case "Vai trò":
                    query = query.Where(x => x.VaiTro.ToLower().Contains(searchValue));
                    break;
                case "Số điện thoại":
                    query = query.Where(x => x.SDT.ToLower().Contains(searchValue));
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn thuộc tính tìm kiếm hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            var result = query.ToList();

            if (result.Count == 0)
            {
                gridViewQLNV.DataSource = null;
                MessageBox.Show("Không tìm thấy kết quả nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gridViewQLNV.DataSource = result;
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from nv in da.NhanViens
                        select new 
                        {
                            nv.TenNhanVien,
                            nv.TenNguoiDung,
                            nv.MatKhau,
                            nv.VaiTro,
                            nv.SDT,
                            nv.DiaChi,
                            nv.TrangThai
                        };

            string selectedStatus = cbbTrangThai.Text;

            // Nếu không phải là "Tất cả", lọc theo trạng thái đã chọn
            if (selectedStatus != "Tất cả")
            {
                query = query.Where(x => x.TrangThai == selectedStatus);
            }

            var result = query.ToList();
            gridViewQLNV.DataSource = result;

            if (result.Count == 0)
            {
                gridViewQLNV.DataSource = null;
                MessageBox.Show("Không tìm thấy kết quả nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gridViewQLNV.DataSource = result;
            }
        }

    }
}
