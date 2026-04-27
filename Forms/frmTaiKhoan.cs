using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                LoadVaiTro();
                LoadDanhSach();
            };
        }

        private void LoadVaiTro()
        {
            cboVaiTro.DisplayMember = "TenVaiTro";
            cboVaiTro.ValueMember = "MaVaiTro";
            cboVaiTro.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT MaVaiTro, TenVaiTro FROM VaiTro ORDER BY MaVaiTro");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaTaiKhoan();
        }

        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            DoiTrangThai();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSach(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDongDangChon();
        }

        private void LoadDanhSach(string keyword = "")
        {
            const string sql = @"
SELECT tk.MaTaiKhoan, kh.MaKhachHang, tk.TenDangNhap, tk.MatKhau, tk.MaVaiTro,
       vt.TenVaiTro, tk.TrangThai, kh.HoTen, kh.SoDienThoai, kh.Email, kh.DiaChi
FROM TaiKhoan tk
INNER JOIN VaiTro vt ON vt.MaVaiTro = tk.MaVaiTro
LEFT JOIN KhachHang kh ON kh.MaTaiKhoan = tk.MaTaiKhoan
WHERE tk.TenDangNhap LIKE @Keyword
   OR vt.TenVaiTro LIKE @Keyword
   OR kh.HoTen LIKE @Keyword
   OR kh.SoDienThoai LIKE @Keyword
ORDER BY tk.MaTaiKhoan DESC";

            dgvTaiKhoan.DataSource = DatabaseHelper.ExecuteQuery(sql, new[]
            {
                new SqlParameter("@Keyword", "%" + keyword + "%")
            });

            HideColumn("MaKhachHang");
            HideColumn("MaVaiTro");
            HideColumn("MatKhau");
            DinhDangLuoiTaiKhoan();
        }

        private void DinhDangLuoiTaiKhoan()
        {
            DatTieuDeCot("MaTaiKhoan", "Mã TK", 70);
            DatTieuDeCot("TenDangNhap", "Tên đăng nhập", 130);
            DatTieuDeCot("TenVaiTro", "Vai trò", 90);
            DatTieuDeCot("TrangThai", "Hoạt động", 90);
            DatTieuDeCot("HoTen", "Họ tên", 150);
            DatTieuDeCot("SoDienThoai", "Số điện thoại", 120);
            DatTieuDeCot("Email", "Email", 170);
            DatTieuDeCot("DiaChi", "Địa chỉ", 190);

            dgvTaiKhoan.ClearSelection();
        }

        private void DatTieuDeCot(string columnName, string headerText, int width)
        {
            if (dgvTaiKhoan.Columns[columnName] == null)
            {
                return;
            }

            dgvTaiKhoan.Columns[columnName].HeaderText = headerText;
            dgvTaiKhoan.Columns[columnName].Width = width;
        }

        private void HideColumn(string columnName)
        {
            if (dgvTaiKhoan.Columns[columnName] != null)
            {
                dgvTaiKhoan.Columns[columnName].Visible = false;
            }
        }

        private void ThemTaiKhoan()
        {
            if (!KiemTraDuLieu(true)) return;

            if (TenDangNhapDaTonTai(txtTenDangNhap.Text.Trim(), null))
            {
                MessageBox.Show("Ten dang nhap da ton tai.", "Trung du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable result = DatabaseHelper.ExecuteQuery(@"
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaVaiTro, TrangThai)
VALUES (@TenDangNhap, @MatKhau, @MaVaiTro, @TrangThai);
SELECT CAST(SCOPE_IDENTITY() AS INT) AS MaTaiKhoan;",
                new[]
                {
                    new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                    new SqlParameter("@MatKhau", txtMatKhau.Text.Trim()),
                    new SqlParameter("@MaVaiTro", Convert.ToInt32(cboVaiTro.SelectedValue)),
                    new SqlParameter("@TrangThai", chkTrangThai.Checked)
                });

            int maTaiKhoan = Convert.ToInt32(result.Rows[0]["MaTaiKhoan"]);

            if (Convert.ToInt32(cboVaiTro.SelectedValue) == 2)
            {
                DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiaChi, MaTaiKhoan)
VALUES (@HoTen, @SoDienThoai, @Email, @DiaChi, @MaTaiKhoan)",
                    new[]
                    {
                        new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
                        new SqlParameter("@SoDienThoai", txtSoDienThoai.Text.Trim()),
                        new SqlParameter("@Email", txtEmail.Text.Trim()),
                        new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                        new SqlParameter("@MaTaiKhoan", maTaiKhoan)
                    });
            }

            LoadDanhSach();
            LamMoi();
        }

        private void SuaTaiKhoan()
        {
            int? maTaiKhoan = LayMaTaiKhoanDangChon();
            if (maTaiKhoan == null || !KiemTraDuLieu(false)) return;

            if (TenDangNhapDaTonTai(txtTenDangNhap.Text.Trim(), maTaiKhoan.Value))
            {
                MessageBox.Show("Ten dang nhap da ton tai.", "Trung du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper.ExecuteNonQuery(@"
UPDATE TaiKhoan
SET TenDangNhap = @TenDangNhap,
    MatKhau = @MatKhau,
    MaVaiTro = @MaVaiTro,
    TrangThai = @TrangThai
WHERE MaTaiKhoan = @MaTaiKhoan",
                new[]
                {
                    new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                    new SqlParameter("@MatKhau", txtMatKhau.Text.Trim()),
                    new SqlParameter("@MaVaiTro", Convert.ToInt32(cboVaiTro.SelectedValue)),
                    new SqlParameter("@TrangThai", chkTrangThai.Checked),
                    new SqlParameter("@MaTaiKhoan", maTaiKhoan.Value)
                });

            UpsertKhachHang(maTaiKhoan.Value);
            LoadDanhSach();
            LamMoi();
        }

        private void UpsertKhachHang(int maTaiKhoan)
        {
            bool isKhachHang = Convert.ToInt32(cboVaiTro.SelectedValue) == 2;
            DataTable existing = DatabaseHelper.ExecuteQuery(
                "SELECT MaKhachHang FROM KhachHang WHERE MaTaiKhoan = @MaTaiKhoan",
                new[] { new SqlParameter("@MaTaiKhoan", maTaiKhoan) });

            if (!isKhachHang)
            {
                return;
            }

            if (existing.Rows.Count == 0)
            {
                DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiaChi, MaTaiKhoan)
VALUES (@HoTen, @SoDienThoai, @Email, @DiaChi, @MaTaiKhoan)",
                    TaoKhachHangParameters(maTaiKhoan));
            }
            else
            {
                DatabaseHelper.ExecuteNonQuery(@"
UPDATE KhachHang
SET HoTen = @HoTen,
    SoDienThoai = @SoDienThoai,
    Email = @Email,
    DiaChi = @DiaChi
WHERE MaTaiKhoan = @MaTaiKhoan",
                    TaoKhachHangParameters(maTaiKhoan));
            }
        }

        private SqlParameter[] TaoKhachHangParameters(int maTaiKhoan)
        {
            return new[]
            {
                new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
                new SqlParameter("@SoDienThoai", txtSoDienThoai.Text.Trim()),
                new SqlParameter("@Email", txtEmail.Text.Trim()),
                new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                new SqlParameter("@MaTaiKhoan", maTaiKhoan)
            };
        }

        private void DoiTrangThai()
        {
            int? maTaiKhoan = LayMaTaiKhoanDangChon();
            if (maTaiKhoan == null) return;

            if (maTaiKhoan.Value == Program.TaiKhoanID)
            {
                MessageBox.Show("Khong nen tat trang thai tai khoan dang dang nhap.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool trangThaiHienTai = Convert.ToBoolean(dgvTaiKhoan.CurrentRow.Cells["TrangThai"].Value);

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE TaiKhoan SET TrangThai = @TrangThai WHERE MaTaiKhoan = @MaTaiKhoan",
                new[]
                {
                    new SqlParameter("@TrangThai", !trangThaiHienTai),
                    new SqlParameter("@MaTaiKhoan", maTaiKhoan.Value)
                });

            LoadDanhSach();
            LamMoi();
        }

        private bool KiemTraDuLieu(bool isCreate)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui long nhap ten dang nhap.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui long nhap mat khau.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }

            if (cboVaiTro.SelectedValue == null)
            {
                MessageBox.Show("Vui long chon vai tro.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Convert.ToInt32(cboVaiTro.SelectedValue) == 2 && string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Tai khoan khach hang can co ho ten.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            return true;
        }

        private bool TenDangNhapDaTonTai(string tenDangNhap, int? maTaiKhoanBoQua)
        {
            string sql = "SELECT COUNT(*) AS SoLuong FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters;

            if (maTaiKhoanBoQua == null)
            {
                parameters = new[] { new SqlParameter("@TenDangNhap", tenDangNhap) };
            }
            else
            {
                sql += " AND MaTaiKhoan <> @MaTaiKhoan";
                parameters = new[]
                {
                    new SqlParameter("@TenDangNhap", tenDangNhap),
                    new SqlParameter("@MaTaiKhoan", maTaiKhoanBoQua.Value)
                };
            }

            DataTable result = DatabaseHelper.ExecuteQuery(sql, parameters);
            return Convert.ToInt32(result.Rows[0]["SoLuong"]) > 0;
        }

        private int? LayMaTaiKhoanDangChon()
        {
            if (dgvTaiKhoan.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot tai khoan.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["MaTaiKhoan"].Value);
        }

        private void HienThiDongDangChon()
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            txtTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
            cboVaiTro.SelectedValue = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["MaVaiTro"].Value);
            chkTrangThai.Checked = Convert.ToBoolean(dgvTaiKhoan.CurrentRow.Cells["TrangThai"].Value);
            txtHoTen.Text = LayGiaTriChuoi("HoTen");
            txtSoDienThoai.Text = LayGiaTriChuoi("SoDienThoai");
            txtEmail.Text = LayGiaTriChuoi("Email");
            txtDiaChi.Text = LayGiaTriChuoi("DiaChi");
        }

        private string LayGiaTriChuoi(string columnName)
        {
            object value = dgvTaiKhoan.CurrentRow.Cells[columnName].Value;
            return value == DBNull.Value ? string.Empty : value.ToString();
        }

        private void LamMoi()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtTimKiem.Clear();
            chkTrangThai.Checked = true;
            if (cboVaiTro.Items.Count > 0) cboVaiTro.SelectedIndex = 0;
            dgvTaiKhoan.ClearSelection();
            txtTenDangNhap.Focus();
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
