namespace PetStore2.Forms
{
    partial class frmTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDoiTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDoiTrangThai = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(14, 14);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(694, 58);
            this.pnlHeader.TabIndex = 0;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tài khoản";
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblTenDangNhap);
            this.pnlForm.Controls.Add(this.lblMatKhau);
            this.pnlForm.Controls.Add(this.lblVaiTro);
            this.pnlForm.Controls.Add(this.lblHoTen);
            this.pnlForm.Controls.Add(this.lblSoDienThoai);
            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.lblDiaChi);
            this.pnlForm.Controls.Add(this.lblTimKiem);
            this.pnlForm.Controls.Add(this.txtTenDangNhap);
            this.pnlForm.Controls.Add(this.txtMatKhau);
            this.pnlForm.Controls.Add(this.cboVaiTro);
            this.pnlForm.Controls.Add(this.chkTrangThai);
            this.pnlForm.Controls.Add(this.txtHoTen);
            this.pnlForm.Controls.Add(this.txtSoDienThoai);
            this.pnlForm.Controls.Add(this.txtEmail);
            this.pnlForm.Controls.Add(this.txtDiaChi);
            this.pnlForm.Controls.Add(this.txtTimKiem);
            this.pnlForm.Controls.Add(this.btnTimKiem);
            this.pnlForm.Location = new System.Drawing.Point(14, 84);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(694, 174);
            this.pnlForm.TabIndex = 1;
            // 
            // labels
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTenDangNhap.Location = new System.Drawing.Point(20, 12);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(92, 15);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMatKhau.Location = new System.Drawing.Point(230, 12);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(58, 15);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblVaiTro.Location = new System.Drawing.Point(440, 12);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(41, 15);
            this.lblVaiTro.TabIndex = 2;
            this.lblVaiTro.Text = "Vai trò";
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHoTen.Location = new System.Drawing.Point(20, 66);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(44, 15);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên";
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblSoDienThoai.Location = new System.Drawing.Point(230, 66);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(82, 15);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblEmail.Location = new System.Drawing.Point(440, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDiaChi.Location = new System.Drawing.Point(20, 120);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(45, 15);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTimKiem.Location = new System.Drawing.Point(440, 120);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(58, 15);
            this.lblTimKiem.TabIndex = 7;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // inputs
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(20, 32);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(180, 23);
            this.txtTenDangNhap.TabIndex = 8;
            this.txtMatKhau.Location = new System.Drawing.Point(230, 32);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(180, 23);
            this.txtMatKhau.TabIndex = 9;
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(440, 32);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(130, 23);
            this.cboVaiTro.TabIndex = 10;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.chkTrangThai.Location = new System.Drawing.Point(590, 32);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(90, 24);
            this.chkTrangThai.TabIndex = 11;
            this.chkTrangThai.Text = "Hoạt động";
            this.txtHoTen.Location = new System.Drawing.Point(20, 86);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 23);
            this.txtHoTen.TabIndex = 12;
            this.txtSoDienThoai.Location = new System.Drawing.Point(230, 86);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(180, 23);
            this.txtSoDienThoai.TabIndex = 13;
            this.txtEmail.Location = new System.Drawing.Point(440, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 23);
            this.txtEmail.TabIndex = 14;
            this.txtDiaChi.Location = new System.Drawing.Point(20, 140);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(390, 23);
            this.txtDiaChi.TabIndex = 15;
            this.txtTimKiem.Location = new System.Drawing.Point(440, 140);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 23);
            this.txtTimKiem.TabIndex = 16;
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnTimKiem.Location = new System.Drawing.Point(602, 134);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(58, 34);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnThem);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnDoiTrangThai);
            this.pnlActions.Controls.Add(this.btnLamMoi);
            this.pnlActions.Location = new System.Drawing.Point(14, 270);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(694, 56);
            this.pnlActions.TabIndex = 2;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnThem.Location = new System.Drawing.Point(20, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnSua.Location = new System.Drawing.Point(136, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnDoiTrangThai.BackColor = System.Drawing.Color.White;
            this.btnDoiTrangThai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnDoiTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDoiTrangThai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnDoiTrangThai.Location = new System.Drawing.Point(252, 10);
            this.btnDoiTrangThai.Name = "btnDoiTrangThai";
            this.btnDoiTrangThai.Size = new System.Drawing.Size(104, 36);
            this.btnDoiTrangThai.TabIndex = 2;
            this.btnDoiTrangThai.Text = "Bật/Tắt";
            this.btnDoiTrangThai.UseVisualStyleBackColor = false;
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnLamMoi.Location = new System.Drawing.Point(368, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(104, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnDoiTrangThai.Click += new System.EventHandler(this.btnDoiTrangThai_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.lblDanhSach);
            this.pnlGrid.Controls.Add(this.dgvTaiKhoan);
            this.pnlGrid.Location = new System.Drawing.Point(14, 338);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(694, 180);
            this.pnlGrid.TabIndex = 3;
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDanhSach.Location = new System.Drawing.Point(20, 14);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(151, 20);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách tài khoản";
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ColumnHeadersHeight = 34;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(20, 44);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(654, 116);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            this.ClientSize = new System.Drawing.Size(722, 534);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmTaiKhoan";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "Tài khoản";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
