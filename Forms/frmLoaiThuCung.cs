using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmLoaiThuCung : Form
    {
        public frmLoaiThuCung()
        {
            InitializeComponent();
            Load += (s, e) => LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            dgvLoai.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT MaLoai, TenLoai, MoTa FROM LoaiThuCung ORDER BY MaLoai DESC");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaLoai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaLoai();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDongDangChon();
        }

        private void ThemLoai()
        {
            if (!KiemTraDuLieu()) return;

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO LoaiThuCung (TenLoai, MoTa) VALUES (@TenLoai, @MoTa)",
                new[]
                {
                    new SqlParameter("@TenLoai", txtTenLoai.Text.Trim()),
                    new SqlParameter("@MoTa", txtMoTa.Text.Trim())
                });

            LoadDanhSach();
            LamMoi();
        }

        private void SuaLoai()
        {
            int? maLoai = LayMaLoaiDangChon();
            if (maLoai == null || !KiemTraDuLieu()) return;

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE LoaiThuCung SET TenLoai = @TenLoai, MoTa = @MoTa WHERE MaLoai = @MaLoai",
                new[]
                {
                    new SqlParameter("@TenLoai", txtTenLoai.Text.Trim()),
                    new SqlParameter("@MoTa", txtMoTa.Text.Trim()),
                    new SqlParameter("@MaLoai", maLoai.Value)
                });

            LoadDanhSach();
            LamMoi();
        }

        private void XoaLoai()
        {
            int? maLoai = LayMaLoaiDangChon();
            if (maLoai == null) return;

            if (MessageBox.Show("Xac nhan xoa loai thu cung nay?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                DatabaseHelper.ExecuteNonQuery(
                    "DELETE FROM LoaiThuCung WHERE MaLoai = @MaLoai",
                    new[] { new SqlParameter("@MaLoai", maLoai.Value) });

                LoadDanhSach();
                LamMoi();
            }
            catch (SqlException)
            {
                MessageBox.Show("Khong the xoa vi loai nay dang co thu cung su dung.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool KiemTraDuLieu()
        {
            if (!string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                return true;
            }

            MessageBox.Show("Vui long nhap ten loai.", "Thieu du lieu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenLoai.Focus();
            return false;
        }

        private int? LayMaLoaiDangChon()
        {
            if (dgvLoai.CurrentRow == null)
            {
                MessageBox.Show("Vui long chon mot dong.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return Convert.ToInt32(dgvLoai.CurrentRow.Cells["MaLoai"].Value);
        }

        private void HienThiDongDangChon()
        {
            if (dgvLoai.CurrentRow == null) return;

            txtTenLoai.Text = dgvLoai.CurrentRow.Cells["TenLoai"].Value.ToString();
            txtMoTa.Text = dgvLoai.CurrentRow.Cells["MoTa"].Value.ToString();
        }

        private void LamMoi()
        {
            txtTenLoai.Clear();
            txtMoTa.Clear();
            dgvLoai.ClearSelection();
            txtTenLoai.Focus();
        }
    }
}
