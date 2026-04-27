using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmThuCung : Form
    {
        public frmThuCung()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                LoadLoaiThuCung();
                LoadDanhSach();
                PhanQuyen();
            };
        }

        private void PhanQuyen()
        {
            bool isAdmin = Program.RoleID == 1;
            btnThem.Visible = isAdmin;
            btnSua.Visible = isAdmin;
            btnNgungBan.Visible = isAdmin;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSach(txtTimKiem.Text.Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThuCung();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThuCung();
        }

        private void btnNgungBan_Click(object sender, EventArgs e)
        {
            NgungBanThuCung();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDongDangChon();
        }

        private void LoadLoaiThuCung()
        {
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            cboLoai.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT MaLoai, TenLoai FROM LoaiThuCung ORDER BY TenLoai");
        }

        private void LoadDanhSach(string keyword = "")
        {
            const string sql = @"
SELECT tc.MaThuCung, tc.TenThuCung, tc.MaLoai, ltc.TenLoai, tc.GiongLoai,
       tc.GioiTinh, tc.Tuoi, tc.MauSac, tc.GiaBan, tc.HinhAnh, tc.MoTa, tc.TrangThai
FROM ThuCung tc
INNER JOIN LoaiThuCung ltc ON ltc.MaLoai = tc.MaLoai
WHERE tc.TenThuCung LIKE @Keyword
   OR ltc.TenLoai LIKE @Keyword
   OR tc.GiongLoai LIKE @Keyword
ORDER BY tc.MaThuCung DESC";

            dgvThuCung.DataSource = DatabaseHelper.ExecuteQuery(sql, new[]
            {
                new SqlParameter("@Keyword", "%" + keyword + "%")
            });

            if (dgvThuCung.Columns["MaLoai"] != null)
            {
                dgvThuCung.Columns["MaLoai"].Visible = false;
            }
        }

        private void ThemThuCung()
        {
            if (!KiemTraDuLieu(out decimal giaBan)) return;

            const string sql = @"
INSERT INTO ThuCung
(TenThuCung, MaLoai, GiongLoai, GioiTinh, Tuoi, MauSac, GiaBan, HinhAnh, MoTa, TrangThai)
VALUES
(@TenThuCung, @MaLoai, @GiongLoai, @GioiTinh, @Tuoi, @MauSac, @GiaBan, @HinhAnh, @MoTa, @TrangThai)";

            DatabaseHelper.ExecuteNonQuery(sql, TaoParameters(giaBan));
            LoadDanhSach();
            LamMoi();
        }

        private void SuaThuCung()
        {
            int? maThuCung = LayMaThuCungDangChon();
            if (maThuCung == null || !KiemTraDuLieu(out decimal giaBan)) return;

            const string sql = @"
UPDATE ThuCung
SET TenThuCung = @TenThuCung,
    MaLoai = @MaLoai,
    GiongLoai = @GiongLoai,
    GioiTinh = @GioiTinh,
    Tuoi = @Tuoi,
    MauSac = @MauSac,
    GiaBan = @GiaBan,
    HinhAnh = @HinhAnh,
    MoTa = @MoTa,
    TrangThai = @TrangThai
WHERE MaThuCung = @MaThuCung";

            SqlParameter[] parameters = TaoParameters(giaBan);
            Array.Resize(ref parameters, parameters.Length + 1);
            parameters[parameters.Length - 1] = new SqlParameter("@MaThuCung", maThuCung.Value);

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
            LoadDanhSach();
            LamMoi();
        }

        private void NgungBanThuCung()
        {
            int? maThuCung = LayMaThuCungDangChon();
            if (maThuCung == null) return;

            if (MessageBox.Show("Chuyen thu cung nay sang trang thai Ngung ban?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE ThuCung SET TrangThai = @TrangThai WHERE MaThuCung = @MaThuCung",
                new[]
                {
                    new SqlParameter("@TrangThai", "Ngừng bán"),
                    new SqlParameter("@MaThuCung", maThuCung.Value)
                });

            LoadDanhSach();
            LamMoi();
        }

        private SqlParameter[] TaoParameters(decimal giaBan)
        {
            return new[]
            {
                new SqlParameter("@TenThuCung", txtTenThuCung.Text.Trim()),
                new SqlParameter("@MaLoai", Convert.ToInt32(cboLoai.SelectedValue)),
                new SqlParameter("@GiongLoai", txtGiongLoai.Text.Trim()),
                new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                new SqlParameter("@Tuoi", Convert.ToInt32(nudTuoi.Value)),
                new SqlParameter("@MauSac", txtMauSac.Text.Trim()),
                new SqlParameter("@GiaBan", giaBan),
                new SqlParameter("@HinhAnh", txtHinhAnh.Text.Trim()),
                new SqlParameter("@MoTa", txtMoTa.Text.Trim()),
                new SqlParameter("@TrangThai", cboTrangThai.Text)
            };
        }

        private bool KiemTraDuLieu(out decimal giaBan)
        {
            giaBan = 0;

            if (string.IsNullOrWhiteSpace(txtTenThuCung.Text))
            {
                MessageBox.Show("Vui long nhap ten thu cung.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuCung.Focus();
                return false;
            }

            if (cboLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui long chon loai thu cung.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out giaBan) || giaBan < 0)
            {
                MessageBox.Show("Gia ban phai la so khong am.", "Sai du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
            {
                cboGioiTinh.SelectedIndex = 0;
            }

            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                cboTrangThai.SelectedIndex = 0;
            }

            return true;
        }

        private int? LayMaThuCungDangChon()
        {
            if (dgvThuCung.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot dong.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return Convert.ToInt32(dgvThuCung.CurrentRow.Cells["MaThuCung"].Value);
        }

        private void HienThiDongDangChon()
        {
            if (dgvThuCung.CurrentRow == null) return;

            txtTenThuCung.Text = dgvThuCung.CurrentRow.Cells["TenThuCung"].Value.ToString();
            cboLoai.SelectedValue = Convert.ToInt32(dgvThuCung.CurrentRow.Cells["MaLoai"].Value);
            txtGiongLoai.Text = dgvThuCung.CurrentRow.Cells["GiongLoai"].Value.ToString();
            cboGioiTinh.Text = dgvThuCung.CurrentRow.Cells["GioiTinh"].Value.ToString();
            object tuoi = dgvThuCung.CurrentRow.Cells["Tuoi"].Value;
            nudTuoi.Value = tuoi == DBNull.Value ? 0 : Convert.ToDecimal(tuoi);
            txtMauSac.Text = dgvThuCung.CurrentRow.Cells["MauSac"].Value.ToString();
            txtGiaBan.Text = Convert.ToDecimal(dgvThuCung.CurrentRow.Cells["GiaBan"].Value).ToString("0");
            txtHinhAnh.Text = dgvThuCung.CurrentRow.Cells["HinhAnh"].Value.ToString();
            txtMoTa.Text = dgvThuCung.CurrentRow.Cells["MoTa"].Value.ToString();
            cboTrangThai.Text = dgvThuCung.CurrentRow.Cells["TrangThai"].Value.ToString();
        }

        private void LamMoi()
        {
            txtTenThuCung.Clear();
            txtGiongLoai.Clear();
            txtMauSac.Clear();
            txtGiaBan.Clear();
            txtHinhAnh.Clear();
            txtMoTa.Clear();
            txtTimKiem.Clear();
            nudTuoi.Value = 0;
            if (cboLoai.Items.Count > 0) cboLoai.SelectedIndex = 0;
            if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            dgvThuCung.ClearSelection();
            txtTenThuCung.Focus();
        }
    }
}
