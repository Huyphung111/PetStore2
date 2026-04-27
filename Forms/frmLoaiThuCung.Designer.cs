namespace PetStore2.Forms
{
    partial class frmLoaiThuCung
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLoai;

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
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(28, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Loai thu cung";
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenLoai.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTenLoai.Location = new System.Drawing.Point(30, 86);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(50, 15);
            this.lblTenLoai.TabIndex = 1;
            this.lblTenLoai.Text = "Ten loai";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMoTa.Location = new System.Drawing.Point(300, 86);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(39, 15);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mo ta";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(30, 110);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(250, 23);
            this.txtTenLoai.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(300, 110);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(340, 23);
            this.txtMoTa.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnThem.Location = new System.Drawing.Point(30, 154);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 36);
            this.btnThem.TabIndex = 5;
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
            this.btnSua.Location = new System.Drawing.Point(140, 154);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 36);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnXoa.Location = new System.Drawing.Point(250, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 36);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnLamMoi.Location = new System.Drawing.Point(360, 154);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 36);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvLoai.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvLoai.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoai.EnableHeadersVisualStyles = false;
            this.dgvLoai.Location = new System.Drawing.Point(30, 214);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersVisible = false;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(610, 220);
            this.dgvLoai.TabIndex = 9;
            this.dgvLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellClick);
            // 
            // frmLoaiThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            this.ClientSize = new System.Drawing.Size(690, 460);
            this.Controls.Add(this.dgvLoai);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTenLoai);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmLoaiThuCung";
            this.Padding = new System.Windows.Forms.Padding(28);
            this.Text = "Loai thu cung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
