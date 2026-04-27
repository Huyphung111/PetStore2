namespace PetStore2.Forms
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlTongHoaDon;
        private System.Windows.Forms.Panel pnlTongDoanhThu;
        private System.Windows.Forms.Panel pnlLoaiHoaDon;
        private System.Windows.Forms.Label lblTongHoaDonTitle;
        private System.Windows.Forms.Label lblTongDoanhThuTitle;
        private System.Windows.Forms.Label lblLoaiHoaDonTitle;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblLoaiHoaDon;
        private System.Windows.Forms.Label lblBang;
        private System.Windows.Forms.DataGridView dgvThongKe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlTongHoaDon = new System.Windows.Forms.Panel();
            this.pnlTongDoanhThu = new System.Windows.Forms.Panel();
            this.pnlLoaiHoaDon = new System.Windows.Forms.Panel();
            this.lblTongHoaDonTitle = new System.Windows.Forms.Label();
            this.lblTongDoanhThuTitle = new System.Windows.Forms.Label();
            this.lblLoaiHoaDonTitle = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblLoaiHoaDon = new System.Windows.Forms.Label();
            this.lblBang = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.filterPanel.SuspendLayout();
            this.pnlTongHoaDon.SuspendLayout();
            this.pnlTongDoanhThu.SuspendLayout();
            this.pnlLoaiHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Text = "Thong ke doanh thu";
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSubtitle.Location = new System.Drawing.Point(28, 58);
            this.lblSubtitle.Text = "Du lieu lay tu view vw_ThongKeDoanhThu";
            this.filterPanel.BackColor = System.Drawing.Color.White;
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Location = new System.Drawing.Point(26, 92);
            this.filterPanel.Size = new System.Drawing.Size(630, 82);
            ConfigureLabel(this.lblTuNgay, "Tu ngay", 16, 14);
            ConfigureLabel(this.lblDenNgay, "Den ngay", 186, 14);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(16, 38);
            this.dtpTuNgay.Size = new System.Drawing.Size(140, 23);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(186, 38);
            this.dtpDenNgay.Size = new System.Drawing.Size(140, 23);
            ConfigureButton(this.btnXem, "Xem", 356, 36, System.Drawing.Color.FromArgb(56, 189, 248));
            ConfigureButton(this.btnLamMoi, "Lam moi", 466, 36, System.Drawing.Color.White);
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.filterPanel.Controls.Add(this.lblTuNgay);
            this.filterPanel.Controls.Add(this.lblDenNgay);
            this.filterPanel.Controls.Add(this.dtpTuNgay);
            this.filterPanel.Controls.Add(this.dtpDenNgay);
            this.filterPanel.Controls.Add(this.btnXem);
            this.filterPanel.Controls.Add(this.btnLamMoi);
            ConfigureSummaryPanel(this.pnlTongHoaDon, this.lblTongHoaDonTitle, this.lblTongHoaDon, "Tong hoa don", 26, 194);
            ConfigureSummaryPanel(this.pnlTongDoanhThu, this.lblTongDoanhThuTitle, this.lblTongDoanhThu, "Tong doanh thu", 243, 194);
            ConfigureSummaryPanel(this.pnlLoaiHoaDon, this.lblLoaiHoaDonTitle, this.lblLoaiHoaDon, "Loai hoa don", 460, 194);
            ConfigureLabel(this.lblBang, "Doanh thu theo ngay va loai hoa don", 26, 310);
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvThongKe.EnableHeadersVisualStyles = false;
            this.dgvThongKe.Location = new System.Drawing.Point(26, 338);
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(630, 220);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(224, 247, 250);
            this.ClientSize = new System.Drawing.Size(690, 590);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.pnlTongHoaDon);
            this.Controls.Add(this.pnlTongDoanhThu);
            this.Controls.Add(this.pnlLoaiHoaDon);
            this.Controls.Add(this.lblBang);
            this.Controls.Add(this.dgvThongKe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmThongKe";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Thong ke";
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.pnlTongHoaDon.ResumeLayout(false);
            this.pnlTongHoaDon.PerformLayout();
            this.pnlTongDoanhThu.ResumeLayout(false);
            this.pnlTongDoanhThu.PerformLayout();
            this.pnlLoaiHoaDon.ResumeLayout(false);
            this.pnlLoaiHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private static void ConfigureLabel(System.Windows.Forms.Label label, string text, int x, int y)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
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
            button.Size = new System.Drawing.Size(96, 36);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        private static void ConfigureSummaryPanel(System.Windows.Forms.Panel panel, System.Windows.Forms.Label title, System.Windows.Forms.Label value, string text, int x, int y)
        {
            panel.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            panel.Location = new System.Drawing.Point(x, y);
            panel.Size = new System.Drawing.Size(196, 94);
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            title.ForeColor = System.Drawing.Color.FromArgb(224, 247, 250);
            title.Location = new System.Drawing.Point(14, 14);
            title.Text = text;
            value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            value.ForeColor = System.Drawing.Color.White;
            value.Location = new System.Drawing.Point(14, 42);
            value.Size = new System.Drawing.Size(168, 34);
            value.Text = "0";
            panel.Controls.Add(title);
            panel.Controls.Add(value);
        }
    }
}
