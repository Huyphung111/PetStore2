using System;
using System.Windows.Forms;

namespace PetStore2.Forms
{
    public partial class frmMain : Form
    {
        private Form _currentChildForm;

        public frmMain()
        {
            InitializeComponent();
            RegisterMenuEvents();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool isAdmin = Program.RoleID == 1;

            string displayName = string.IsNullOrWhiteSpace(Program.HoTen) ? Program.Username : Program.HoTen;
            lblWelcome.Text = "Xin chao, " + displayName;
            lblRole.Text = "Vai tro: " + GetRoleName(Program.RoleID);

            btnLoaiThuCung.Visible = isAdmin;
            btnTaiKhoan.Visible = isAdmin;
            btnThongKe.Visible = isAdmin;
        }

        private static string GetRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin";
                case 2:
                    return "Khach hang";
                default:
                    return "Chua xac dinh";
            }
        }

        private void RegisterMenuEvents()
        {
            btnThuCung.Click += (s, e) => OpenChildForm(new frmThuCung(), btnThuCung);
            btnLoaiThuCung.Click += (s, e) => OpenChildForm(new frmLoaiThuCung(), btnLoaiThuCung);
            btnDichVu.Click += (s, e) => OpenChildForm(new frmDichVu(), btnDichVu);
            btnBanHang.Click += (s, e) => OpenChildForm(new frmMuaThuCung(), btnBanHang);
            btnLichDichVu.Click += (s, e) => OpenChildForm(new frmDatDichVu(), btnLichDichVu);
            btnTaiKhoan.Click += (s, e) => OpenChildForm(new frmTaiKhoan(), btnTaiKhoan);
            btnThongKe.Click += (s, e) => OpenChildForm(new frmThongKe(), btnThongKe);
        }

        private void OpenChildForm(Form childForm, Button selectedButton)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
                _currentChildForm.Dispose();
            }

            ResetMenuButtons();
            SetActiveMenuButton(selectedButton);

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void ResetMenuButtons()
        {
            foreach (Control control in flpMenu.Controls)
            {
                Button button = control as Button;
                if (button == null)
                {
                    continue;
                }

                button.BackColor = System.Drawing.Color.White;
                button.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            }
        }

        private static void SetActiveMenuButton(Button button)
        {
            button.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
            button.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Program.TaiKhoanID = 0;
            Program.Username = null;
            Program.HoTen = null;
            Program.RoleID = 0;

            Close();
        }
    }
}
