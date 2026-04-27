using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmDatDichVu : Form
    {
        public frmDatDichVu()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                LoadDichVu();
                LoadDanhSach();
                PhanQuyen();
            };
        }

        private void PhanQuyen()
        {
            bool isAdmin = Program.RoleID == 1;
            btnChapNhan.Visible = isAdmin;
            btnHoanThanh.Visible = isAdmin;
            btnHuy.Visible = isAdmin;
            cboTrangThai.Enabled = isAdmin;
            btnDatLich.Visible = !isAdmin;
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGioKetThuc();
        }

        private void dtpGioBatDau_ValueChanged(object sender, EventArgs e)
        {
            CapNhatGioKetThuc();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            DatLich();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            CapNhatTrangThai("Đã chấp nhận", false);
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            HoanThanhDichVu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CapNhatTrangThai("Đã hủy", false);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDongDangChon();
        }

        private void LoadDichVu()
        {
            cboDichVu.DisplayMember = "TenDichVu";
            cboDichVu.ValueMember = "MaDichVu";
            cboDichVu.DataSource = DatabaseHelper.ExecuteQuery(@"
SELECT MaDichVu, TenDichVu, ThoiGianThucHien, DonGia
FROM DichVu
WHERE TrangThai = 1
ORDER BY TenDichVu");

            CapNhatGioKetThuc();
        }

        private void LoadDanhSach()
        {
            string where = Program.RoleID == 1 ? string.Empty : "WHERE tk.MaTaiKhoan = @MaTaiKhoan";

            string sql = @"
SELECT ddv.MaDatDichVu, ddv.MaKhachHang, kh.HoTen, dv.MaDichVu, dv.TenDichVu,
       ddv.TenThuCungKhach, ddv.NgayDat, ddv.GioBatDau, ddv.GioKetThuc,
       ddv.TrangThai, ddv.GhiChu, dv.DonGia
FROM DatDichVu ddv
INNER JOIN KhachHang kh ON kh.MaKhachHang = ddv.MaKhachHang
INNER JOIN TaiKhoan tk ON tk.MaTaiKhoan = kh.MaTaiKhoan
INNER JOIN DichVu dv ON dv.MaDichVu = ddv.MaDichVu
" + where + @"
ORDER BY ddv.NgayDat DESC, ddv.GioBatDau DESC";

            SqlParameter[] parameters = Program.RoleID == 1
                ? null
                : new[] { new SqlParameter("@MaTaiKhoan", Program.TaiKhoanID) };

            dgvLich.DataSource = DatabaseHelper.ExecuteQuery(sql, parameters);

            if (dgvLich.Columns["MaKhachHang"] != null)
            {
                dgvLich.Columns["MaKhachHang"].Visible = false;
            }

            if (dgvLich.Columns["MaDichVu"] != null)
            {
                dgvLich.Columns["MaDichVu"].Visible = false;
            }

            DinhDangLuoiLich();
        }

        private void DinhDangLuoiLich()
        {
            DatTieuDeCot("MaDatDichVu", "Mã lịch", 70);
            DatTieuDeCot("HoTen", "Khách hàng", 140);
            DatTieuDeCot("TenDichVu", "Dịch vụ", 150);
            DatTieuDeCot("TenThuCungKhach", "Thú cưng", 120);
            DatTieuDeCot("NgayDat", "Ngày đặt", 95);
            DatTieuDeCot("GioBatDau", "Bắt đầu", 80);
            DatTieuDeCot("GioKetThuc", "Kết thúc", 80);
            DatTieuDeCot("TrangThai", "Trạng thái", 120);
            DatTieuDeCot("GhiChu", "Ghi chú", 160);
            DatTieuDeCot("DonGia", "Đơn giá", 95);

            if (dgvLich.Columns["NgayDat"] != null)
            {
                dgvLich.Columns["NgayDat"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvLich.Columns["DonGia"] != null)
            {
                dgvLich.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvLich.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvLich.ClearSelection();
        }

        private void DatTieuDeCot(string columnName, string headerText, int width)
        {
            if (dgvLich.Columns[columnName] == null)
            {
                return;
            }

            dgvLich.Columns[columnName].HeaderText = headerText;
            dgvLich.Columns[columnName].Width = width;
        }

        private void DatLich()
        {
            int? maKhachHang = LayMaKhachHangDangNhap();
            if (maKhachHang == null || !KiemTraDuLieu()) return;

            DateTime gioBatDau = LayGioBatDau();
            DateTime gioKetThuc = LayGioKetThuc();

            if (BiTrungLich(null, gioBatDau, gioKetThuc))
            {
                MessageBox.Show("Khung gio nay da co lich. Vui long chon gio khac.", "Trung lich",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO DatDichVu
(MaKhachHang, MaDichVu, TenThuCungKhach, NgayDat, GioBatDau, GioKetThuc, TrangThai, GhiChu)
VALUES
(@MaKhachHang, @MaDichVu, @TenThuCungKhach, @NgayDat, @GioBatDau, @GioKetThuc, @TrangThai, @GhiChu)",
                new[]
                {
                    new SqlParameter("@MaKhachHang", maKhachHang.Value),
                    new SqlParameter("@MaDichVu", Convert.ToInt32(cboDichVu.SelectedValue)),
                    new SqlParameter("@TenThuCungKhach", txtTenThuCungKhach.Text.Trim()),
                    new SqlParameter("@NgayDat", dtpNgayDat.Value.Date),
                    new SqlParameter("@GioBatDau", gioBatDau.TimeOfDay),
                    new SqlParameter("@GioKetThuc", gioKetThuc.TimeOfDay),
                    new SqlParameter("@TrangThai", "Chờ xác nhận"),
                    new SqlParameter("@GhiChu", txtGhiChu.Text.Trim())
                });

            MessageBox.Show("Dat lich thanh cong. Vui long cho Admin xac nhan.", "Thanh cong",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDanhSach();
            LamMoi();
        }

        private void CapNhatTrangThai(string trangThai, bool daTaoHoaDon)
        {
            int? maDatDichVu = LayMaDatDichVuDangChon();
            if (maDatDichVu == null) return;

            string trangThaiHienTai = dgvLich.CurrentRow.Cells["TrangThai"].Value.ToString();
            if (trangThaiHienTai == "Đã hoàn thành" && !daTaoHoaDon)
            {
                MessageBox.Show("Lich nay da hoan thanh.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE DatDichVu SET TrangThai = @TrangThai WHERE MaDatDichVu = @MaDatDichVu",
                new[]
                {
                    new SqlParameter("@TrangThai", trangThai),
                    new SqlParameter("@MaDatDichVu", maDatDichVu.Value)
                });

            LoadDanhSach();
            LamMoi();
        }

        private void HoanThanhDichVu()
        {
            int? maDatDichVu = LayMaDatDichVuDangChon();
            if (maDatDichVu == null) return;

            string trangThaiHienTai = dgvLich.CurrentRow.Cells["TrangThai"].Value.ToString();
            if (trangThaiHienTai == "Đã hoàn thành")
            {
                MessageBox.Show("Lich nay da hoan thanh va khong tao lai hoa don.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (trangThaiHienTai != "Đã chấp nhận")
            {
                MessageBox.Show("Chi lich da chap nhan moi duoc hoan thanh.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maKhachHang = Convert.ToInt32(dgvLich.CurrentRow.Cells["MaKhachHang"].Value);
            string tenDichVu = dgvLich.CurrentRow.Cells["TenDichVu"].Value.ToString();
            decimal donGia = Convert.ToDecimal(dgvLich.CurrentRow.Cells["DonGia"].Value);

            DataTable invoiceResult = DatabaseHelper.ExecuteQuery(@"
INSERT INTO HoaDon (MaKhachHang, TongTien, LoaiHoaDon, TrangThaiThanhToan)
VALUES (@MaKhachHang, @TongTien, @LoaiHoaDon, @TrangThaiThanhToan);
SELECT CAST(SCOPE_IDENTITY() AS INT) AS MaHoaDon;",
                new[]
                {
                    new SqlParameter("@MaKhachHang", maKhachHang),
                    new SqlParameter("@TongTien", donGia),
                    new SqlParameter("@LoaiHoaDon", "Dịch vụ"),
                    new SqlParameter("@TrangThaiThanhToan", "Chưa thanh toán")
                });

            int maHoaDon = Convert.ToInt32(invoiceResult.Rows[0]["MaHoaDon"]);

            DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO ChiTietHoaDon (MaHoaDon, TenSanPhamDichVu, SoLuong, DonGia)
VALUES (@MaHoaDon, @TenSanPhamDichVu, 1, @DonGia)",
                new[]
                {
                    new SqlParameter("@MaHoaDon", maHoaDon),
                    new SqlParameter("@TenSanPhamDichVu", tenDichVu),
                    new SqlParameter("@DonGia", donGia)
                });

            CapNhatTrangThai("Đã hoàn thành", true);
            MessageBox.Show("Da hoan thanh dich vu va tao hoa don #" + maHoaDon + ".", "Thanh cong",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraDuLieu()
        {
            if (cboDichVu.SelectedValue == null)
            {
                MessageBox.Show("Chua co dich vu dang hoat dong de dat lich.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenThuCungKhach.Text))
            {
                MessageBox.Show("Vui long nhap ten thu cung.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuCungKhach.Focus();
                return false;
            }

            if (dtpNgayDat.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngay dat khong duoc nho hon hom nay.", "Sai du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool BiTrungLich(int? maDatDichVu, DateTime gioBatDau, DateTime gioKetThuc)
        {
            string sql = @"
SELECT COUNT(*) AS SoLuong
FROM DatDichVu
WHERE NgayDat = @NgayDat
  AND TrangThai IN (N'Chờ xác nhận', N'Đã chấp nhận')
  AND @GioBatDau < GioKetThuc
  AND @GioKetThuc > GioBatDau";

            if (maDatDichVu != null)
            {
                sql += " AND MaDatDichVu <> @MaDatDichVu";
            }

            SqlParameter[] parameters = maDatDichVu == null
                ? new[]
                {
                    new SqlParameter("@NgayDat", dtpNgayDat.Value.Date),
                    new SqlParameter("@GioBatDau", gioBatDau.TimeOfDay),
                    new SqlParameter("@GioKetThuc", gioKetThuc.TimeOfDay)
                }
                : new[]
                {
                    new SqlParameter("@NgayDat", dtpNgayDat.Value.Date),
                    new SqlParameter("@GioBatDau", gioBatDau.TimeOfDay),
                    new SqlParameter("@GioKetThuc", gioKetThuc.TimeOfDay),
                    new SqlParameter("@MaDatDichVu", maDatDichVu.Value)
                };

            DataTable result = DatabaseHelper.ExecuteQuery(sql, parameters);
            return Convert.ToInt32(result.Rows[0]["SoLuong"]) > 0;
        }

        private int? LayMaKhachHangDangNhap()
        {
            DataTable result = DatabaseHelper.ExecuteQuery(
                "SELECT MaKhachHang FROM KhachHang WHERE MaTaiKhoan = @MaTaiKhoan",
                new[] { new SqlParameter("@MaTaiKhoan", Program.TaiKhoanID) });

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["MaKhachHang"]);
            }

            MessageBox.Show("Tai khoan hien tai chua co thong tin khach hang.", "Thieu du lieu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private int? LayMaDatDichVuDangChon()
        {
            if (dgvLich.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot lich dich vu.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return Convert.ToInt32(dgvLich.CurrentRow.Cells["MaDatDichVu"].Value);
        }

        private DateTime LayGioBatDau()
        {
            return dtpNgayDat.Value.Date
                .AddHours(dtpGioBatDau.Value.Hour)
                .AddMinutes(dtpGioBatDau.Value.Minute);
        }

        private DateTime LayGioKetThuc()
        {
            int thoiGian = LayThoiGianDichVu();
            return LayGioBatDau().AddMinutes(thoiGian);
        }

        private int LayThoiGianDichVu()
        {
            DataRowView row = cboDichVu.SelectedItem as DataRowView;
            if (row == null)
            {
                return 0;
            }

            return Convert.ToInt32(row["ThoiGianThucHien"]);
        }

        private void CapNhatGioKetThuc()
        {
            if (lblGioKetThuc == null) return;
            lblGioKetThuc.Text = LayGioKetThuc().ToString("HH:mm");
        }

        private void HienThiDongDangChon()
        {
            if (dgvLich.CurrentRow == null) return;

            cboDichVu.SelectedValue = Convert.ToInt32(dgvLich.CurrentRow.Cells["MaDichVu"].Value);
            txtTenThuCungKhach.Text = dgvLich.CurrentRow.Cells["TenThuCungKhach"].Value.ToString();
            dtpNgayDat.Value = Convert.ToDateTime(dgvLich.CurrentRow.Cells["NgayDat"].Value);

            TimeSpan gioBatDau = (TimeSpan)dgvLich.CurrentRow.Cells["GioBatDau"].Value;
            dtpGioBatDau.Value = DateTime.Today.Add(gioBatDau);

            cboTrangThai.Text = dgvLich.CurrentRow.Cells["TrangThai"].Value.ToString();
            object ghiChu = dgvLich.CurrentRow.Cells["GhiChu"].Value;
            txtGhiChu.Text = ghiChu == DBNull.Value ? string.Empty : ghiChu.ToString();
            CapNhatGioKetThuc();
        }

        private void LamMoi()
        {
            txtTenThuCungKhach.Clear();
            txtGhiChu.Clear();
            dtpNgayDat.Value = DateTime.Today;
            dtpGioBatDau.Value = DateTime.Today.AddHours(8);
            if (cboDichVu.Items.Count > 0) cboDichVu.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            dgvLich.ClearSelection();
            CapNhatGioKetThuc();
            txtTenThuCungKhach.Focus();
        }
    }
}
