namespace PetStore2.Forms
{
    partial class frmThuCung
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenThuCung;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblGiongLoai;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTenThuCung;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txtGiongLoai;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.NumericUpDown nudTuoi;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNgungBan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvThuCung;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenThuCung = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblGiongLoai = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTenThuCung = new System.Windows.Forms.TextBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtGiongLoai = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.nudTuoi = new System.Windows.Forms.NumericUpDown();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNgungBan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thu cung";
            // 
            // labels
            // 
            this.lblTenThuCung.AutoSize = true;
            this.lblTenThuCung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenThuCung.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTenThuCung.Location = new System.Drawing.Point(27, 74);
            this.lblTenThuCung.Name = "lblTenThuCung";
            this.lblTenThuCung.Size = new System.Drawing.Size(82, 15);
            this.lblTenThuCung.TabIndex = 1;
            this.lblTenThuCung.Text = "Ten thu cung";
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblLoai.Location = new System.Drawing.Point(254, 74);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(31, 15);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "Loai";
            this.lblGiongLoai.AutoSize = true;
            this.lblGiongLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGiongLoai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGiongLoai.Location = new System.Drawing.Point(481, 74);
            this.lblGiongLoai.Name = "lblGiongLoai";
            this.lblGiongLoai.Size = new System.Drawing.Size(61, 15);
            this.lblGiongLoai.TabIndex = 3;
            this.lblGiongLoai.Text = "Giong loai";
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGioiTinh.Location = new System.Drawing.Point(27, 132);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(55, 15);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Gioi tinh";
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTuoi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTuoi.Location = new System.Drawing.Point(254, 132);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(31, 15);
            this.lblTuoi.TabIndex = 5;
            this.lblTuoi.Text = "Tuoi";
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMauSac.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMauSac.Location = new System.Drawing.Point(481, 132);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(51, 15);
            this.lblMauSac.TabIndex = 6;
            this.lblMauSac.Text = "Mau sac";
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGiaBan.Location = new System.Drawing.Point(27, 190);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(48, 15);
            this.lblGiaBan.TabIndex = 7;
            this.lblGiaBan.Text = "Gia ban";
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTrangThai.Location = new System.Drawing.Point(254, 190);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(64, 15);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trang thai";
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHinhAnh.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHinhAnh.Location = new System.Drawing.Point(481, 190);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(56, 15);
            this.lblHinhAnh.TabIndex = 9;
            this.lblHinhAnh.Text = "Hinh anh";
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMoTa.Location = new System.Drawing.Point(27, 248);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(39, 15);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mo ta";
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTimKiem.Location = new System.Drawing.Point(481, 248);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(57, 15);
            this.lblTimKiem.TabIndex = 11;
            this.lblTimKiem.Text = "Tim kiem";
            // 
            // inputs
            // 
            this.txtTenThuCung.Location = new System.Drawing.Point(27, 93);
            this.txtTenThuCung.Name = "txtTenThuCung";
            this.txtTenThuCung.Size = new System.Drawing.Size(190, 23);
            this.txtTenThuCung.TabIndex = 12;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Location = new System.Drawing.Point(254, 93);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(190, 23);
            this.cboLoai.TabIndex = 13;
            this.txtGiongLoai.Location = new System.Drawing.Point(481, 93);
            this.txtGiongLoai.Name = "txtGiongLoai";
            this.txtGiongLoai.Size = new System.Drawing.Size(190, 23);
            this.txtGiongLoai.TabIndex = 14;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Đực", "Cái" });
            this.cboGioiTinh.Location = new System.Drawing.Point(27, 151);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(190, 23);
            this.cboGioiTinh.TabIndex = 15;
            this.nudTuoi.Location = new System.Drawing.Point(254, 151);
            this.nudTuoi.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudTuoi.Name = "nudTuoi";
            this.nudTuoi.Size = new System.Drawing.Size(190, 23);
            this.nudTuoi.TabIndex = 16;
            this.txtMauSac.Location = new System.Drawing.Point(481, 151);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(190, 23);
            this.txtMauSac.TabIndex = 17;
            this.txtGiaBan.Location = new System.Drawing.Point(27, 209);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(190, 23);
            this.txtGiaBan.TabIndex = 18;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] { "Còn bán", "Đã bán", "Ngừng bán" });
            this.cboTrangThai.Location = new System.Drawing.Point(254, 209);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(190, 23);
            this.cboTrangThai.TabIndex = 19;
            this.txtHinhAnh.Location = new System.Drawing.Point(481, 209);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(190, 23);
            this.txtHinhAnh.TabIndex = 20;
            this.txtMoTa.Location = new System.Drawing.Point(27, 267);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(417, 23);
            this.txtMoTa.TabIndex = 21;
            this.txtTimKiem.Location = new System.Drawing.Point(481, 267);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(135, 23);
            this.txtTimKiem.TabIndex = 22;
            // 
            // buttons
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnTimKiem.Location = new System.Drawing.Point(624, 265);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(47, 27);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tim";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnThem.Location = new System.Drawing.Point(27, 312);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 34);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnSua.Location = new System.Drawing.Point(137, 312);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 34);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnNgungBan.BackColor = System.Drawing.Color.White;
            this.btnNgungBan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNgungBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgungBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNgungBan.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnNgungBan.Location = new System.Drawing.Point(247, 312);
            this.btnNgungBan.Name = "btnNgungBan";
            this.btnNgungBan.Size = new System.Drawing.Size(96, 34);
            this.btnNgungBan.TabIndex = 26;
            this.btnNgungBan.Text = "Ngung ban";
            this.btnNgungBan.UseVisualStyleBackColor = false;
            this.btnNgungBan.Click += new System.EventHandler(this.btnNgungBan_Click);
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnLamMoi.Location = new System.Drawing.Point(357, 312);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 34);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AllowUserToAddRows = false;
            this.dgvThuCung.AllowUserToDeleteRows = false;
            this.dgvThuCung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuCung.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuCung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvThuCung.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvThuCung.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.EnableHeadersVisualStyles = false;
            this.dgvThuCung.Location = new System.Drawing.Point(27, 367);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.ReadOnly = true;
            this.dgvThuCung.RowHeadersVisible = false;
            this.dgvThuCung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuCung.Size = new System.Drawing.Size(644, 145);
            this.dgvThuCung.TabIndex = 28;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);
            // 
            // frmThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            this.ClientSize = new System.Drawing.Size(720, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenThuCung);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblGiongLoai);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblMauSac);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTenThuCung);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.txtGiongLoai);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.nudTuoi);
            this.Controls.Add(this.txtMauSac);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.txtHinhAnh);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNgungBan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvThuCung);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmThuCung";
            this.Text = "Thu cung";
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
