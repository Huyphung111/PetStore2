namespace PetStore2.Forms
{
    partial class frmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.NumericUpDown nudThoiGian;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDoiTrangThai;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDichVu;

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
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.nudThoiGian = new System.Windows.Forms.NumericUpDown();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDoiTrangThai = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dich vu";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTenDichVu.Location = new System.Drawing.Point(30, 86);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(109, 25);
            this.lblTenDichVu.TabIndex = 27;
            this.lblTenDichVu.Text = "Ten dich vu";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblThoiGian.Location = new System.Drawing.Point(320, 86);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(151, 25);
            this.lblThoiGian.TabIndex = 26;
            this.lblThoiGian.Text = "Thoi gian (phut)";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblDonGia.Location = new System.Drawing.Point(500, 86);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(78, 25);
            this.lblDonGia.TabIndex = 25;
            this.lblDonGia.Text = "Don gia";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblMoTa.Location = new System.Drawing.Point(30, 148);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(62, 25);
            this.lblMoTa.TabIndex = 24;
            this.lblMoTa.Text = "Mo ta";
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(30, 110);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(260, 31);
            this.txtTenDichVu.TabIndex = 23;
            // 
            // nudThoiGian
            // 
            this.nudThoiGian.Location = new System.Drawing.Point(320, 110);
            this.nudThoiGian.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nudThoiGian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThoiGian.Name = "nudThoiGian";
            this.nudThoiGian.Size = new System.Drawing.Size(150, 31);
            this.nudThoiGian.TabIndex = 22;
            this.nudThoiGian.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(500, 110);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(140, 31);
            this.txtDonGia.TabIndex = 21;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(30, 172);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(440, 31);
            this.txtMoTa.TabIndex = 20;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Location = new System.Drawing.Point(500, 174);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(140, 24);
            this.chkTrangThai.TabIndex = 19;
            this.chkTrangThai.Text = "Dang hoat dong";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnThem.Location = new System.Drawing.Point(30, 214);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 36);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnSua.Location = new System.Drawing.Point(140, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 36);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDoiTrangThai
            // 
            this.btnDoiTrangThai.BackColor = System.Drawing.Color.White;
            this.btnDoiTrangThai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnDoiTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDoiTrangThai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnDoiTrangThai.Location = new System.Drawing.Point(250, 214);
            this.btnDoiTrangThai.Name = "btnDoiTrangThai";
            this.btnDoiTrangThai.Size = new System.Drawing.Size(96, 36);
            this.btnDoiTrangThai.TabIndex = 16;
            this.btnDoiTrangThai.Text = "Bat/Tat";
            this.btnDoiTrangThai.UseVisualStyleBackColor = false;
            this.btnDoiTrangThai.Click += new System.EventHandler(this.btnDoiTrangThai_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnLamMoi.Location = new System.Drawing.Point(360, 214);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 36);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvDichVu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDichVu.ColumnHeadersHeight = 34;
            this.dgvDichVu.EnableHeadersVisualStyles = false;
            this.dgvDichVu.Location = new System.Drawing.Point(35, 252);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowHeadersWidth = 62;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(610, 220);
            this.dgvDichVu.TabIndex = 14;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            this.ClientSize = new System.Drawing.Size(690, 530);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDoiTrangThai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.chkTrangThai);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.nudThoiGian);
            this.Controls.Add(this.txtTenDichVu);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmDichVu";
            this.Padding = new System.Windows.Forms.Padding(28);
            this.Text = "Dich vu";
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
