namespace PetStore2.Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnThuCung;
        private System.Windows.Forms.Button btnLoaiThuCung;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnLichDichVu;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblContentTitle;

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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThuCung = new System.Windows.Forms.Button();
            this.btnLoaiThuCung = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnLichDichVu = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.flpMenu);
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.lblAppName);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 620);
            this.pnlSidebar.TabIndex = 0;
            // 
            // flpMenu
            // 
            this.flpMenu.Controls.Add(this.btnThuCung);
            this.flpMenu.Controls.Add(this.btnLoaiThuCung);
            this.flpMenu.Controls.Add(this.btnDichVu);
            this.flpMenu.Controls.Add(this.btnBanHang);
            this.flpMenu.Controls.Add(this.btnLichDichVu);
            this.flpMenu.Controls.Add(this.btnTaiKhoan);
            this.flpMenu.Controls.Add(this.btnThongKe);
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(18, 102);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(194, 390);
            this.flpMenu.TabIndex = 1;
            this.flpMenu.WrapContents = false;
            // 
            // btnThuCung
            // 
            this.btnThuCung.BackColor = System.Drawing.Color.White;
            this.btnThuCung.FlatAppearance.BorderSize = 0;
            this.btnThuCung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuCung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThuCung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnThuCung.Location = new System.Drawing.Point(3, 3);
            this.btnThuCung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnThuCung.Name = "btnThuCung";
            this.btnThuCung.Size = new System.Drawing.Size(188, 40);
            this.btnThuCung.TabIndex = 0;
            this.btnThuCung.Text = "Thu cung";
            this.btnThuCung.UseVisualStyleBackColor = false;
            // 
            // btnLoaiThuCung
            // 
            this.btnLoaiThuCung.BackColor = System.Drawing.Color.White;
            this.btnLoaiThuCung.FlatAppearance.BorderSize = 0;
            this.btnLoaiThuCung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiThuCung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoaiThuCung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLoaiThuCung.Location = new System.Drawing.Point(3, 54);
            this.btnLoaiThuCung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnLoaiThuCung.Name = "btnLoaiThuCung";
            this.btnLoaiThuCung.Size = new System.Drawing.Size(188, 40);
            this.btnLoaiThuCung.TabIndex = 1;
            this.btnLoaiThuCung.Text = "Loai thu cung";
            this.btnLoaiThuCung.UseVisualStyleBackColor = false;
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.White;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnDichVu.Location = new System.Drawing.Point(3, 105);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(188, 40);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dich vu";
            this.btnDichVu.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.White;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnBanHang.Location = new System.Drawing.Point(3, 156);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(188, 40);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "Mua thu cung";
            this.btnBanHang.UseVisualStyleBackColor = false;
            // 
            // btnLichDichVu
            // 
            this.btnLichDichVu.BackColor = System.Drawing.Color.White;
            this.btnLichDichVu.FlatAppearance.BorderSize = 0;
            this.btnLichDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichDichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLichDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLichDichVu.Location = new System.Drawing.Point(3, 207);
            this.btnLichDichVu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnLichDichVu.Name = "btnLichDichVu";
            this.btnLichDichVu.Size = new System.Drawing.Size(188, 40);
            this.btnLichDichVu.TabIndex = 4;
            this.btnLichDichVu.Text = "Dat dich vu";
            this.btnLichDichVu.UseVisualStyleBackColor = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(3, 258);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(188, 40);
            this.btnTaiKhoan.TabIndex = 5;
            this.btnTaiKhoan.Text = "Tai khoan";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnThongKe.Location = new System.Drawing.Point(3, 309);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(188, 40);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thong ke";
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnDangXuat.Location = new System.Drawing.Point(21, 552);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(188, 40);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Dang xuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(21, 28);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(162, 48);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "PetStore";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblRole);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(770, 86);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRole.Location = new System.Drawing.Point(37, 49);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(69, 28);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Vai tro";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblWelcome.Location = new System.Drawing.Point(34, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(166, 48);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Xin chao";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblContentTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 86);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(770, 534);
            this.pnlContent.TabIndex = 2;
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.AutoSize = true;
            this.lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblContentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblContentTitle.Location = new System.Drawing.Point(184, 24);
            this.lblContentTitle.Name = "lblContentTitle";
            this.lblContentTitle.Size = new System.Drawing.Size(361, 60);
            this.lblContentTitle.TabIndex = 0;
            this.lblContentTitle.Text = "Bang dieu khien";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1016, 659);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetStore - Menu chinh";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
