namespace PetStore2.Forms
{
    partial class frmDatDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblTenThuCung;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblKetThucTitle;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtTenThuCungKhach;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLich;

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
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblTenThuCung = new System.Windows.Forms.Label();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblKetThucTitle = new System.Windows.Forms.Label();
            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.txtTenThuCungKhach = new System.Windows.Forms.TextBox();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvLich = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).BeginInit();
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đặt dịch vụ";
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblDichVu);
            this.pnlForm.Controls.Add(this.lblTenThuCung);
            this.pnlForm.Controls.Add(this.lblNgayDat);
            this.pnlForm.Controls.Add(this.lblGioBatDau);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.lblGhiChu);
            this.pnlForm.Controls.Add(this.lblKetThucTitle);
            this.pnlForm.Controls.Add(this.lblGioKetThuc);
            this.pnlForm.Controls.Add(this.cboDichVu);
            this.pnlForm.Controls.Add(this.txtTenThuCungKhach);
            this.pnlForm.Controls.Add(this.dtpNgayDat);
            this.pnlForm.Controls.Add(this.dtpGioBatDau);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.txtGhiChu);
            this.pnlForm.Location = new System.Drawing.Point(14, 84);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(694, 132);
            this.pnlForm.TabIndex = 1;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDichVu.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDichVu.Location = new System.Drawing.Point(20, 12);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(48, 15);
            this.lblDichVu.TabIndex = 0;
            this.lblDichVu.Text = "Dịch vụ";
            // 
            // lblTenThuCung
            // 
            this.lblTenThuCung.AutoSize = true;
            this.lblTenThuCung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenThuCung.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTenThuCung.Location = new System.Drawing.Point(286, 12);
            this.lblTenThuCung.Name = "lblTenThuCung";
            this.lblTenThuCung.Size = new System.Drawing.Size(80, 15);
            this.lblTenThuCung.TabIndex = 1;
            this.lblTenThuCung.Text = "Tên thú cưng";
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayDat.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblNgayDat.Location = new System.Drawing.Point(500, 12);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(55, 15);
            this.lblNgayDat.TabIndex = 2;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioBatDau.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGioBatDau.Location = new System.Drawing.Point(20, 70);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(72, 15);
            this.lblGioBatDau.TabIndex = 3;
            this.lblGioBatDau.Text = "Giờ bắt đầu";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTrangThai.Location = new System.Drawing.Point(168, 70);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(62, 15);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGhiChu.Location = new System.Drawing.Point(344, 70);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(48, 15);
            this.lblGhiChu.TabIndex = 5;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblKetThucTitle
            // 
            this.lblKetThucTitle.AutoSize = true;
            this.lblKetThucTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKetThucTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblKetThucTitle.Location = new System.Drawing.Point(500, 70);
            this.lblKetThucTitle.Name = "lblKetThucTitle";
            this.lblKetThucTitle.Size = new System.Drawing.Size(73, 15);
            this.lblKetThucTitle.TabIndex = 6;
            this.lblKetThucTitle.Text = "Giờ kết thúc";
            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGioKetThuc.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGioKetThuc.Location = new System.Drawing.Point(500, 90);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(140, 25);
            this.lblGioKetThuc.TabIndex = 13;
            this.lblGioKetThuc.Text = "08:30";
            this.lblGioKetThuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(20, 32);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(240, 23);
            this.cboDichVu.TabIndex = 7;
            this.cboDichVu.SelectedIndexChanged += new System.EventHandler(this.cboDichVu_SelectedIndexChanged);
            // 
            // txtTenThuCungKhach
            // 
            this.txtTenThuCungKhach.Location = new System.Drawing.Point(286, 32);
            this.txtTenThuCungKhach.Name = "txtTenThuCungKhach";
            this.txtTenThuCungKhach.Size = new System.Drawing.Size(188, 23);
            this.txtTenThuCungKhach.TabIndex = 8;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(500, 32);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(140, 23);
            this.dtpNgayDat.TabIndex = 9;
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.CustomFormat = "HH:mm";
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioBatDau.Location = new System.Drawing.Point(20, 90);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(120, 23);
            this.dtpGioBatDau.TabIndex = 10;
            this.dtpGioBatDau.ValueChanged += new System.EventHandler(this.dtpGioBatDau_ValueChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chờ xác nhận",
            "Đã chấp nhận",
            "Đã hoàn thành",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(168, 90);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(150, 23);
            this.cboTrangThai.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(344, 90);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(130, 23);
            this.txtGhiChu.TabIndex = 12;
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnDatLich);
            this.pnlActions.Controls.Add(this.btnChapNhan);
            this.pnlActions.Controls.Add(this.btnHoanThanh);
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLamMoi);
            this.pnlActions.Location = new System.Drawing.Point(14, 228);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(694, 56);
            this.pnlActions.TabIndex = 2;
            // 
            // buttons
            // 
            this.btnDatLich.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.btnDatLich.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnDatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatLich.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnDatLich.Location = new System.Drawing.Point(20, 10);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(104, 36);
            this.btnDatLich.TabIndex = 0;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = false;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            this.btnChapNhan.BackColor = System.Drawing.Color.White;
            this.btnChapNhan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnChapNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChapNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChapNhan.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnChapNhan.Location = new System.Drawing.Point(136, 10);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(104, 36);
            this.btnChapNhan.TabIndex = 1;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.UseVisualStyleBackColor = false;
            this.btnHoanThanh.BackColor = System.Drawing.Color.White;
            this.btnHoanThanh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHoanThanh.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnHoanThanh.Location = new System.Drawing.Point(252, 10);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(104, 36);
            this.btnHoanThanh.TabIndex = 2;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnHuy.Location = new System.Drawing.Point(368, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 36);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnLamMoi.Location = new System.Drawing.Point(484, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(104, 36);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.lblDanhSach);
            this.pnlGrid.Controls.Add(this.dgvLich);
            this.pnlGrid.Location = new System.Drawing.Point(14, 296);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(694, 222);
            this.pnlGrid.TabIndex = 3;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDanhSach.Location = new System.Drawing.Point(20, 16);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(166, 20);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách lịch dịch vụ";
            // 
            // dgvLich
            // 
            this.dgvLich.AllowUserToAddRows = false;
            this.dgvLich.AllowUserToDeleteRows = false;
            this.dgvLich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvLich.BackgroundColor = System.Drawing.Color.White;
            this.dgvLich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvLich.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvLich.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLich.ColumnHeadersHeight = 34;
            this.dgvLich.EnableHeadersVisualStyles = false;
            this.dgvLich.Location = new System.Drawing.Point(20, 48);
            this.dgvLich.Name = "dgvLich";
            this.dgvLich.ReadOnly = true;
            this.dgvLich.RowHeadersVisible = false;
            this.dgvLich.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLich.Size = new System.Drawing.Size(654, 154);
            this.dgvLich.TabIndex = 1;
            this.dgvLich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLich_CellClick);
            // 
            // frmDatDichVu
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
            this.Name = "frmDatDichVu";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "Đặt dịch vụ";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
