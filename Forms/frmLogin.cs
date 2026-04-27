using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblThongBao.Text = "Vui long nhap tai khoan va mat khau.";
                return;
            }

            const string sql = @"
SELECT tk.MaTaiKhoan AS TaiKhoanID,
       tk.TenDangNhap AS Username,
       ISNULL(kh.HoTen, tk.TenDangNhap) AS HoTen,
       tk.MaVaiTro AS RoleID,
       vt.TenVaiTro AS RoleName
FROM TaiKhoan tk
INNER JOIN VaiTro vt ON vt.MaVaiTro = tk.MaVaiTro
LEFT JOIN KhachHang kh ON kh.MaTaiKhoan = tk.MaTaiKhoan
WHERE tk.TenDangNhap = @Username
  AND tk.MatKhau = @MatKhau
  AND tk.TrangThai = 1";

            try
            {
                DataTable result = DatabaseHelper.ExecuteQuery(sql, new[]
                {
                    new SqlParameter("@Username", txtUsername.Text.Trim()),
                    new SqlParameter("@MatKhau", txtPassword.Text.Trim())
                });

                if (result.Rows.Count == 0)
                {
                    lblThongBao.Text = "Sai tai khoan hoac mat khau.";
                    return;
                }

                DataRow account = result.Rows[0];
                Program.TaiKhoanID = Convert.ToInt32(account["TaiKhoanID"]);
                Program.Username = account["Username"].ToString();
                Program.HoTen = account["HoTen"].ToString();
                Program.RoleID = Convert.ToInt32(account["RoleID"]);

                Hide();
                using (var mainForm = new frmMain())
                {
                    mainForm.ShowDialog();
                }

                txtPassword.Clear();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Khong the ket noi hoac dang nhap vao CSDL.\n" + ex.Message,
                    "Loi dang nhap",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
