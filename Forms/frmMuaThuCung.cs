using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmMuaThuCung : Form
    {
        public frmMuaThuCung()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                LoadThuCung();
                LoadDonMua();
                PhanQuyen();
            };
        }

        private void PhanQuyen()
        {
            bool isAdmin = Program.RoleID == 1;
            btnMua.Visible = !isAdmin;
            btnThanhToan.Visible = isAdmin;
            btnHuyDon.Visible = isAdmin;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadThuCung(txtTimKiem.Text.Trim());
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            TaoDonMua();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanDonMua();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            HuyDonMua();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LoadThuCung(string keyword = "")
        {
            const string sql = @"
SELECT tc.MaThuCung, tc.TenThuCung, ltc.TenLoai, tc.GiongLoai,
       tc.GioiTinh, tc.Tuoi, tc.MauSac, tc.GiaBan, tc.TrangThai
FROM ThuCung tc
INNER JOIN LoaiThuCung ltc ON ltc.MaLoai = tc.MaLoai
WHERE tc.TrangThai = N'Còn bán'
  AND (tc.TenThuCung LIKE @Keyword OR ltc.TenLoai LIKE @Keyword OR tc.GiongLoai LIKE @Keyword)
ORDER BY tc.MaThuCung DESC";

            dgvThuCung.DataSource = DatabaseHelper.ExecuteQuery(sql, new[]
            {
                new SqlParameter("@Keyword", "%" + keyword + "%")
            });
        }

        private void LoadDonMua()
        {
            string where = Program.RoleID == 1 ? string.Empty : "WHERE tk.MaTaiKhoan = @MaTaiKhoan";

            string sql = @"
SELECT dm.MaDonMua, dm.MaKhachHang, kh.HoTen, tc.MaThuCung, tc.TenThuCung,
       tc.GiaBan, dm.NgayMua, dm.TrangThai
FROM DonMuaThuCung dm
INNER JOIN KhachHang kh ON kh.MaKhachHang = dm.MaKhachHang
INNER JOIN TaiKhoan tk ON tk.MaTaiKhoan = kh.MaTaiKhoan
INNER JOIN ThuCung tc ON tc.MaThuCung = dm.MaThuCung
" + where + @"
ORDER BY dm.NgayMua DESC";

            SqlParameter[] parameters = Program.RoleID == 1
                ? null
                : new[] { new SqlParameter("@MaTaiKhoan", Program.TaiKhoanID) };

            dgvDonMua.DataSource = DatabaseHelper.ExecuteQuery(sql, parameters);

            if (dgvDonMua.Columns["MaKhachHang"] != null)
            {
                dgvDonMua.Columns["MaKhachHang"].Visible = false;
            }
        }

        private void TaoDonMua()
        {
            if (dgvThuCung.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon thu cung can mua.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int? maKhachHang = LayMaKhachHangDangNhap();
            if (maKhachHang == null) return;

            int maThuCung = Convert.ToInt32(dgvThuCung.CurrentRow.Cells["MaThuCung"].Value);
            string tenThuCung = dgvThuCung.CurrentRow.Cells["TenThuCung"].Value.ToString();

            if (MessageBox.Show("Tao don mua cho " + tenThuCung + "?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO DonMuaThuCung (MaKhachHang, MaThuCung, TrangThai)
VALUES (@MaKhachHang, @MaThuCung, @TrangThai)",
                new[]
                {
                    new SqlParameter("@MaKhachHang", maKhachHang.Value),
                    new SqlParameter("@MaThuCung", maThuCung),
                    new SqlParameter("@TrangThai", "Chờ thanh toán")
                });

            MessageBox.Show("Da tao don mua. Vui long cho Admin thanh toan.", "Thanh cong",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDonMua();
        }

        private void ThanhToanDonMua()
        {
            if (!LayDonMuaDangChon(out int maDonMua, out int maKhachHang, out int maThuCung, out string tenThuCung, out decimal giaBan, out string trangThai))
            {
                return;
            }

            if (trangThai == "Đã thanh toán")
            {
                MessageBox.Show("Don nay da thanh toan.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (trangThai == "Đã hủy")
            {
                MessageBox.Show("Don da huy khong the thanh toan.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThaiThuCung = LayTrangThaiThuCung(maThuCung);
            if (trangThaiThuCung != "Còn bán")
            {
                MessageBox.Show("Thu cung nay khong con o trang thai Con ban.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable invoiceResult = DatabaseHelper.ExecuteQuery(@"
INSERT INTO HoaDon (MaKhachHang, TongTien, LoaiHoaDon, TrangThaiThanhToan)
VALUES (@MaKhachHang, @TongTien, @LoaiHoaDon, @TrangThaiThanhToan);
SELECT CAST(SCOPE_IDENTITY() AS INT) AS MaHoaDon;",
                new[]
                {
                    new SqlParameter("@MaKhachHang", maKhachHang),
                    new SqlParameter("@TongTien", giaBan),
                    new SqlParameter("@LoaiHoaDon", "Mua thú cưng"),
                    new SqlParameter("@TrangThaiThanhToan", "Đã thanh toán")
                });

            int maHoaDon = Convert.ToInt32(invoiceResult.Rows[0]["MaHoaDon"]);

            DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO ChiTietHoaDon (MaHoaDon, TenSanPhamDichVu, SoLuong, DonGia)
VALUES (@MaHoaDon, @TenSanPhamDichVu, 1, @DonGia)",
                new[]
                {
                    new SqlParameter("@MaHoaDon", maHoaDon),
                    new SqlParameter("@TenSanPhamDichVu", tenThuCung),
                    new SqlParameter("@DonGia", giaBan)
                });

            DatabaseHelper.ExecuteNonQuery(@"
UPDATE DonMuaThuCung SET TrangThai = @TrangThai WHERE MaDonMua = @MaDonMua;
UPDATE ThuCung SET TrangThai = @TrangThaiThuCung WHERE MaThuCung = @MaThuCung;",
                new[]
                {
                    new SqlParameter("@TrangThai", "Đã thanh toán"),
                    new SqlParameter("@MaDonMua", maDonMua),
                    new SqlParameter("@TrangThaiThuCung", "Đã bán"),
                    new SqlParameter("@MaThuCung", maThuCung)
                });

            MessageBox.Show("Da thanh toan va tao hoa don #" + maHoaDon + ".", "Thanh cong",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadThuCung();
            LoadDonMua();
        }

        private void HuyDonMua()
        {
            if (!LayDonMuaDangChon(out int maDonMua, out int maKhachHang, out int maThuCung, out string tenThuCung, out decimal giaBan, out string trangThai))
            {
                return;
            }

            if (trangThai != "Chờ thanh toán")
            {
                MessageBox.Show("Chi don Cho thanh toan moi duoc huy.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xac nhan huy don mua " + tenThuCung + "?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE DonMuaThuCung SET TrangThai = @TrangThai WHERE MaDonMua = @MaDonMua",
                new[]
                {
                    new SqlParameter("@TrangThai", "Đã hủy"),
                    new SqlParameter("@MaDonMua", maDonMua)
                });

            LoadDonMua();
        }

        private bool LayDonMuaDangChon(out int maDonMua, out int maKhachHang, out int maThuCung, out string tenThuCung, out decimal giaBan, out string trangThai)
        {
            maDonMua = 0;
            maKhachHang = 0;
            maThuCung = 0;
            tenThuCung = string.Empty;
            giaBan = 0;
            trangThai = string.Empty;

            if (dgvDonMua.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot don mua.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            maDonMua = Convert.ToInt32(dgvDonMua.CurrentRow.Cells["MaDonMua"].Value);
            maKhachHang = Convert.ToInt32(dgvDonMua.CurrentRow.Cells["MaKhachHang"].Value);
            maThuCung = Convert.ToInt32(dgvDonMua.CurrentRow.Cells["MaThuCung"].Value);
            tenThuCung = dgvDonMua.CurrentRow.Cells["TenThuCung"].Value.ToString();
            giaBan = Convert.ToDecimal(dgvDonMua.CurrentRow.Cells["GiaBan"].Value);
            trangThai = dgvDonMua.CurrentRow.Cells["TrangThai"].Value.ToString();
            return true;
        }

        private string LayTrangThaiThuCung(int maThuCung)
        {
            DataTable result = DatabaseHelper.ExecuteQuery(
                "SELECT TrangThai FROM ThuCung WHERE MaThuCung = @MaThuCung",
                new[] { new SqlParameter("@MaThuCung", maThuCung) });

            return result.Rows.Count == 0 ? string.Empty : result.Rows[0]["TrangThai"].ToString();
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

        private void LamMoi()
        {
            txtTimKiem.Clear();
            LoadThuCung();
            LoadDonMua();
            dgvThuCung.ClearSelection();
            dgvDonMua.ClearSelection();
        }
    }
}
