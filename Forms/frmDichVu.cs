using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                LoadDanhSach();
                PhanQuyen();
            };
        }

        private void PhanQuyen()
        {
            bool isAdmin = Program.RoleID == 1;
            btnThem.Visible = isAdmin;
            btnSua.Visible = isAdmin;
            btnDoiTrangThai.Visible = isAdmin;
        }

        private void LoadDanhSach()
        {
            dgvDichVu.DataSource = DatabaseHelper.ExecuteQuery(@"
SELECT MaDichVu, TenDichVu, ThoiGianThucHien, DonGia, MoTa, TrangThai
FROM DichVu
ORDER BY MaDichVu DESC");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDichVu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaDichVu();
        }

        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            DoiTrangThai();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDongDangChon();
        }

        private void ThemDichVu()
        {
            if (!KiemTraDuLieu(out decimal donGia)) return;

            DatabaseHelper.ExecuteNonQuery(@"
INSERT INTO DichVu (TenDichVu, ThoiGianThucHien, DonGia, MoTa, TrangThai)
VALUES (@TenDichVu, @ThoiGianThucHien, @DonGia, @MoTa, @TrangThai)",
                TaoParameters(donGia));

            LoadDanhSach();
            LamMoi();
        }

        private void SuaDichVu()
        {
            int? maDichVu = LayMaDichVuDangChon();
            if (maDichVu == null || !KiemTraDuLieu(out decimal donGia)) return;

            SqlParameter[] parameters = TaoParameters(donGia);
            Array.Resize(ref parameters, parameters.Length + 1);
            parameters[parameters.Length - 1] = new SqlParameter("@MaDichVu", maDichVu.Value);

            DatabaseHelper.ExecuteNonQuery(@"
UPDATE DichVu
SET TenDichVu = @TenDichVu,
    ThoiGianThucHien = @ThoiGianThucHien,
    DonGia = @DonGia,
    MoTa = @MoTa,
    TrangThai = @TrangThai
WHERE MaDichVu = @MaDichVu", parameters);

            LoadDanhSach();
            LamMoi();
        }

        private void DoiTrangThai()
        {
            int? maDichVu = LayMaDichVuDangChon();
            if (maDichVu == null) return;

            bool trangThaiHienTai = Convert.ToBoolean(dgvDichVu.CurrentRow.Cells["TrangThai"].Value);

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE DichVu SET TrangThai = @TrangThai WHERE MaDichVu = @MaDichVu",
                new[]
                {
                    new SqlParameter("@TrangThai", !trangThaiHienTai),
                    new SqlParameter("@MaDichVu", maDichVu.Value)
                });

            LoadDanhSach();
            LamMoi();
        }

        private SqlParameter[] TaoParameters(decimal donGia)
        {
            return new[]
            {
                new SqlParameter("@TenDichVu", txtTenDichVu.Text.Trim()),
                new SqlParameter("@ThoiGianThucHien", Convert.ToInt32(nudThoiGian.Value)),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@MoTa", txtMoTa.Text.Trim()),
                new SqlParameter("@TrangThai", chkTrangThai.Checked)
            };
        }

        private bool KiemTraDuLieu(out decimal donGia)
        {
            donGia = 0;

            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text))
            {
                MessageBox.Show("Vui long nhap ten dich vu.", "Thieu du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDichVu.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out donGia) || donGia < 0)
            {
                MessageBox.Show("Don gia phai la so khong am.", "Sai du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private int? LayMaDichVuDangChon()
        {
            if (dgvDichVu.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot dich vu.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return Convert.ToInt32(dgvDichVu.CurrentRow.Cells["MaDichVu"].Value);
        }

        private void HienThiDongDangChon()
        {
            if (dgvDichVu.CurrentRow == null) return;

            txtTenDichVu.Text = dgvDichVu.CurrentRow.Cells["TenDichVu"].Value.ToString();
            nudThoiGian.Value = Convert.ToDecimal(dgvDichVu.CurrentRow.Cells["ThoiGianThucHien"].Value);
            txtDonGia.Text = Convert.ToDecimal(dgvDichVu.CurrentRow.Cells["DonGia"].Value).ToString("0");
            txtMoTa.Text = dgvDichVu.CurrentRow.Cells["MoTa"].Value.ToString();
            chkTrangThai.Checked = Convert.ToBoolean(dgvDichVu.CurrentRow.Cells["TrangThai"].Value);
        }

        private void LamMoi()
        {
            txtTenDichVu.Clear();
            nudThoiGian.Value = 30;
            txtDonGia.Clear();
            txtMoTa.Clear();
            chkTrangThai.Checked = true;
            dgvDichVu.ClearSelection();
            txtTenDichVu.Focus();
        }
    }
}
