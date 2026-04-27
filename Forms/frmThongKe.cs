using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
                dtpDenNgay.Value = DateTime.Today;
                LoadThongKe();
            };
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LoadThongKe()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Tu ngay khong duoc lon hon Den ngay.", "Sai du lieu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string sql = @"
SELECT Ngay, LoaiHoaDon, SoLuongHoaDon, TongDoanhThu
FROM vw_ThongKeDoanhThu
WHERE Ngay BETWEEN @TuNgay AND @DenNgay
ORDER BY Ngay DESC, LoaiHoaDon";

            DataTable table = DatabaseHelper.ExecuteQuery(sql, new[]
            {
                new SqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                new SqlParameter("@DenNgay", dtpDenNgay.Value.Date)
            });

            dgvThongKe.DataSource = table;
            DinhDangCot();
            HienThiTongHop(table);
        }

        private void DinhDangCot()
        {
            if (dgvThongKe.Columns["Ngay"] != null)
            {
                dgvThongKe.Columns["Ngay"].HeaderText = "Ngay";
                dgvThongKe.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvThongKe.Columns["LoaiHoaDon"] != null)
            {
                dgvThongKe.Columns["LoaiHoaDon"].HeaderText = "Loai hoa don";
            }

            if (dgvThongKe.Columns["SoLuongHoaDon"] != null)
            {
                dgvThongKe.Columns["SoLuongHoaDon"].HeaderText = "So hoa don";
                dgvThongKe.Columns["SoLuongHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvThongKe.Columns["TongDoanhThu"] != null)
            {
                dgvThongKe.Columns["TongDoanhThu"].HeaderText = "Tong doanh thu";
                dgvThongKe.Columns["TongDoanhThu"].DefaultCellStyle.Format = "N0";
                dgvThongKe.Columns["TongDoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void HienThiTongHop(DataTable table)
        {
            int tongHoaDon = 0;
            decimal tongDoanhThu = 0;
            int soLoaiHoaDon = 0;

            foreach (DataRow row in table.Rows)
            {
                tongHoaDon += Convert.ToInt32(row["SoLuongHoaDon"]);
                tongDoanhThu += Convert.ToDecimal(row["TongDoanhThu"]);
            }

            if (table.Rows.Count > 0)
            {
                soLoaiHoaDon = table.DefaultView.ToTable(true, "LoaiHoaDon").Rows.Count;
            }

            lblTongHoaDon.Text = tongHoaDon.ToString("N0");
            lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " VND";
            lblLoaiHoaDon.Text = soLoaiHoaDon.ToString("N0");
        }

        private void LamMoi()
        {
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;
            LoadThongKe();
        }
    }
}
