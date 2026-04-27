namespace PetStore2.Forms
{
    partial class frmMuaThuCung
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlThuCung;
        private System.Windows.Forms.Panel pnlDonMua;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblThuCung;
        private System.Windows.Forms.Label lblDonMua;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.DataGridView dgvDonMua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnMua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlThuCung = new System.Windows.Forms.Panel();
            this.lblThuCung = new System.Windows.Forms.Label();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.pnlDonMua = new System.Windows.Forms.Panel();
            this.lblDonMua = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.dgvDonMua = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlThuCung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.pnlDonMua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonMua)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(24, 22);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(832, 72);
            this.pnlHeader.TabIndex = 0;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mua thú cưng";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.btnTimKiem);
            this.pnlSearch.Controls.Add(this.btnMua);
            this.pnlSearch.Controls.Add(this.btnLamMoi);
            this.pnlSearch.Location = new System.Drawing.Point(24, 110);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(832, 86);
            this.pnlSearch.TabIndex = 1;
            ConfigureLabel(this.lblTimKiem, "Tìm thú cưng", 22, 16);
            this.txtTimKiem.Location = new System.Drawing.Point(22, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(320, 23);
            this.txtTimKiem.TabIndex = 1;
            ConfigureButton(this.btnTimKiem, "Tìm", 358, 36, System.Drawing.Color.White);
            ConfigureButton(this.btnMua, "Mua", 474, 36, System.Drawing.Color.FromArgb(56, 189, 248));
            ConfigureButton(this.btnLamMoi, "Làm mới", 590, 36, System.Drawing.Color.White);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlThuCung
            // 
            this.pnlThuCung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThuCung.BackColor = System.Drawing.Color.White;
            this.pnlThuCung.Controls.Add(this.lblThuCung);
            this.pnlThuCung.Controls.Add(this.dgvThuCung);
            this.pnlThuCung.Location = new System.Drawing.Point(24, 212);
            this.pnlThuCung.Name = "pnlThuCung";
            this.pnlThuCung.Size = new System.Drawing.Size(832, 230);
            this.pnlThuCung.TabIndex = 2;
            ConfigureSectionTitle(this.lblThuCung, "Thú cưng còn bán", 22, 18);
            ConfigureGrid(this.dgvThuCung);
            this.dgvThuCung.Location = new System.Drawing.Point(22, 54);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.Size = new System.Drawing.Size(788, 154);
            this.dgvThuCung.TabIndex = 1;
            // 
            // pnlDonMua
            // 
            this.pnlDonMua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDonMua.BackColor = System.Drawing.Color.White;
            this.pnlDonMua.Controls.Add(this.lblDonMua);
            this.pnlDonMua.Controls.Add(this.btnThanhToan);
            this.pnlDonMua.Controls.Add(this.btnHuyDon);
            this.pnlDonMua.Controls.Add(this.dgvDonMua);
            this.pnlDonMua.Location = new System.Drawing.Point(24, 458);
            this.pnlDonMua.Name = "pnlDonMua";
            this.pnlDonMua.Size = new System.Drawing.Size(832, 212);
            this.pnlDonMua.TabIndex = 3;
            ConfigureSectionTitle(this.lblDonMua, "Đơn mua", 22, 18);
            ConfigureButton(this.btnThanhToan, "Thanh toán", 576, 14, System.Drawing.Color.FromArgb(56, 189, 248));
            ConfigureButton(this.btnHuyDon, "Hủy đơn", 692, 14, System.Drawing.Color.White);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            ConfigureGrid(this.dgvDonMua);
            this.dgvDonMua.Location = new System.Drawing.Point(22, 54);
            this.dgvDonMua.Name = "dgvDonMua";
            this.dgvDonMua.Size = new System.Drawing.Size(788, 136);
            this.dgvDonMua.TabIndex = 3;
            // 
            // frmMuaThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            this.ClientSize = new System.Drawing.Size(880, 692);
            this.Controls.Add(this.pnlDonMua);
            this.Controls.Add(this.pnlThuCung);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmMuaThuCung";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Mua thú cưng";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlThuCung.ResumeLayout(false);
            this.pnlThuCung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.pnlDonMua.ResumeLayout(false);
            this.pnlDonMua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonMua)).EndInit();
            this.ResumeLayout(false);
        }

        private static void ConfigureLabel(System.Windows.Forms.Label label, string text, int x, int y)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            label.Location = new System.Drawing.Point(x, y);
            label.Text = text;
        }

        private static void ConfigureSectionTitle(System.Windows.Forms.Label label, string text, int x, int y)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            label.Location = new System.Drawing.Point(x, y);
            label.Text = text;
        }

        private static void ConfigureButton(System.Windows.Forms.Button button, string text, int x, int y, System.Drawing.Color backColor)
        {
            button.BackColor = backColor;
            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            button.Location = new System.Drawing.Point(x, y);
            button.Size = new System.Drawing.Size(104, 38);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        private static void ConfigureGrid(System.Windows.Forms.DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
