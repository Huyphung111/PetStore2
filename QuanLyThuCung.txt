/* =========================================================
   DATABASE: QuanLyPetShop
   Muc dich: Do an quan ly PetShop co CRUD, phan quyen,
             mua thu cung, dat dich vu, hoa don, thong ke doanh thu
   He quan tri: SQL Server
   ========================================================= */

-- Neu database da ton tai thi co the xoa de tao lai
-- Luu y: Bo comment 3 dong duoi neu muon tao lai tu dau
-- USE master;
-- DROP DATABASE IF EXISTS QuanLyPetShop;
-- GO

CREATE DATABASE QuanLyPetShop;
GO

USE QuanLyPetShop;
GO

/* =========================================================
   1. BANG VAI TRO
   ========================================================= */
CREATE TABLE VaiTro (
    MaVaiTro INT IDENTITY(1,1) PRIMARY KEY,
    TenVaiTro NVARCHAR(50) NOT NULL
);
GO

INSERT INTO VaiTro (TenVaiTro)
VALUES 
(N'Admin'),
(N'Khách hàng');
GO

/* =========================================================
   2. BANG TAI KHOAN
   ========================================================= */
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL,
    MaVaiTro INT NOT NULL,
    TrangThai BIT DEFAULT 1,

    CONSTRAINT FK_TaiKhoan_VaiTro
    FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro)
);
GO

/* =========================================================
   3. BANG KHACH HANG
   ========================================================= */
CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100),
    DiaChi NVARCHAR(200),
    MaTaiKhoan INT NOT NULL UNIQUE,

    CONSTRAINT FK_KhachHang_TaiKhoan
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);
GO

/* =========================================================
   4. BANG LOAI THU CUNG
   ========================================================= */
CREATE TABLE LoaiThuCung (
    MaLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255)
);
GO

/* =========================================================
   5. BANG THU CUNG
   TrangThai goi y: Con ban, Da ban, Ngung ban
   ========================================================= */
CREATE TABLE ThuCung (
    MaThuCung INT IDENTITY(1,1) PRIMARY KEY,
    TenThuCung NVARCHAR(100) NOT NULL,
    MaLoai INT NOT NULL,
    GiongLoai NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    Tuoi INT,
    MauSac NVARCHAR(50),
    GiaBan DECIMAL(18,2) NOT NULL,
    HinhAnh NVARCHAR(255),
    MoTa NVARCHAR(500),
    TrangThai NVARCHAR(50) DEFAULT N'Còn bán',

    CONSTRAINT FK_ThuCung_LoaiThuCung
    FOREIGN KEY (MaLoai) REFERENCES LoaiThuCung(MaLoai)
);
GO

/* =========================================================
   6. BANG DICH VU
   ThoiGianThucHien tinh theo phut
   ========================================================= */
CREATE TABLE DichVu (
    MaDichVu INT IDENTITY(1,1) PRIMARY KEY,
    TenDichVu NVARCHAR(100) NOT NULL,
    ThoiGianThucHien INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    MoTa NVARCHAR(500),
    TrangThai BIT DEFAULT 1
);
GO

/* =========================================================
   7. BANG DAT DICH VU
   TrangThai goi y: Cho xac nhan, Da chap nhan, Da hoan thanh, Da huy
   ========================================================= */
CREATE TABLE DatDichVu (
    MaDatDichVu INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT NOT NULL,
    MaDichVu INT NOT NULL,
    TenThuCungKhach NVARCHAR(100),
    NgayDat DATE NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chờ xác nhận',
    GhiChu NVARCHAR(500),

    CONSTRAINT FK_DatDichVu_KhachHang
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),

    CONSTRAINT FK_DatDichVu_DichVu
    FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
);
GO

/* =========================================================
   8. BANG DON MUA THU CUNG
   TrangThai goi y: Cho thanh toan, Da thanh toan, Da huy
   ========================================================= */
CREATE TABLE DonMuaThuCung (
    MaDonMua INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT NOT NULL,
    MaThuCung INT NOT NULL,
    NgayMua DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) DEFAULT N'Chờ thanh toán',

    CONSTRAINT FK_DonMuaThuCung_KhachHang
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),

    CONSTRAINT FK_DonMuaThuCung_ThuCung
    FOREIGN KEY (MaThuCung) REFERENCES ThuCung(MaThuCung)
);
GO

/* =========================================================
   9. BANG HOA DON
   LoaiHoaDon goi y: Mua thu cung, Dich vu
   TrangThaiThanhToan goi y: Chua thanh toan, Da thanh toan
   ========================================================= */
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT NOT NULL,
    NgayLap DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,
    LoaiHoaDon NVARCHAR(50) NOT NULL,
    TrangThaiThanhToan NVARCHAR(50) DEFAULT N'Chưa thanh toán',

    CONSTRAINT FK_HoaDon_KhachHang
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);
GO

/* =========================================================
   10. BANG CHI TIET HOA DON
   Luu ten thu cung hoac ten dich vu trong hoa don
   ========================================================= */
CREATE TABLE ChiTietHoaDon (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT NOT NULL,
    TenSanPhamDichVu NVARCHAR(200) NOT NULL,
    SoLuong INT DEFAULT 1,
    DonGia DECIMAL(18,2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia),

    CONSTRAINT FK_ChiTietHoaDon_HoaDon
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
);
GO

/* =========================================================
   11. DU LIEU MAU
   ========================================================= */
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaVaiTro)
VALUES 
('admin', '123456', 1),
('khach1', '123456', 2);
GO

INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiaChi, MaTaiKhoan)
VALUES 
(N'Nguyễn Văn A', '0909123456', 'khach1@gmail.com', N'TP Hồ Chí Minh', 2);
GO

INSERT INTO LoaiThuCung (TenLoai, MoTa)
VALUES
(N'Chó', N'Các giống chó cảnh'),
(N'Mèo', N'Các giống mèo cảnh'),
(N'Chim', N'Các loại chim cảnh'),
(N'Cá', N'Các loại cá cảnh');
GO

INSERT INTO ThuCung 
(TenThuCung, MaLoai, GiongLoai, GioiTinh, Tuoi, MauSac, GiaBan, MoTa)
VALUES
(N'Milu', 1, N'Poodle', N'Đực', 1, N'Nâu', 3500000, N'Chó Poodle dễ thương'),
(N'Mimi', 2, N'Mèo Anh lông ngắn', N'Cái', 2, N'Xám', 4500000, N'Mèo khỏe mạnh, thân thiện'),
(N'Bông', 1, N'Corgi', N'Cái', 1, N'Vàng trắng', 6000000, N'Chó Corgi năng động'),
(N'Xám', 2, N'Mèo Ba Tư', N'Đực', 2, N'Trắng xám', 5000000, N'Mèo Ba Tư lông dài');
GO

INSERT INTO DichVu 
(TenDichVu, ThoiGianThucHien, DonGia, MoTa)
VALUES
(N'Tắm thú cưng', 60, 150000, N'Tắm và vệ sinh cơ bản'),
(N'Cắt tỉa lông', 90, 250000, N'Cắt tỉa lông theo yêu cầu'),
(N'Khám sức khỏe cơ bản', 30, 200000, N'Kiểm tra sức khỏe tổng quát'),
(N'Cắt móng', 30, 100000, N'Cắt móng và vệ sinh chân cho thú cưng');
GO

/* =========================================================
   12. VIEW THONG KE DOANH THU
   ========================================================= */
CREATE VIEW vw_ThongKeDoanhThu AS
SELECT 
    CAST(NgayLap AS DATE) AS Ngay,
    LoaiHoaDon,
    COUNT(MaHoaDon) AS SoLuongHoaDon,
    SUM(TongTien) AS TongDoanhThu
FROM HoaDon
WHERE TrangThaiThanhToan = N'Đã thanh toán'
GROUP BY CAST(NgayLap AS DATE), LoaiHoaDon;
GO

/* =========================================================
   13. CAU LENH MAU: KIEM TRA TRUNG LICH DICH VU
   Doi ngay va gio theo du lieu nguoi dung chon
   ========================================================= */
-- SELECT *
-- FROM DatDichVu
-- WHERE NgayDat = '2026-04-26'
-- AND TrangThai IN (N'Chờ xác nhận', N'Đã chấp nhận')
-- AND (
--     '09:00' < GioKetThuc
--     AND '10:00' > GioBatDau
-- );

/* =========================================================
   14. CAU LENH MAU: ADMIN CHAP NHAN DICH VU
   ========================================================= */
-- UPDATE DatDichVu
-- SET TrangThai = N'Đã chấp nhận'
-- WHERE MaDatDichVu = 1;

/* =========================================================
   15. CAU LENH MAU: HOAN THANH DICH VU VA TAO HOA DON
   ========================================================= */
-- DECLARE @MaKhachHang_DV INT;
-- DECLARE @TenDichVu NVARCHAR(100);
-- DECLARE @DonGia_DV DECIMAL(18,2);

-- SELECT 
--     @MaKhachHang_DV = ddv.MaKhachHang,
--     @TenDichVu = dv.TenDichVu,
--     @DonGia_DV = dv.DonGia
-- FROM DatDichVu ddv
-- JOIN DichVu dv ON ddv.MaDichVu = dv.MaDichVu
-- WHERE ddv.MaDatDichVu = 1;

-- INSERT INTO HoaDon (MaKhachHang, TongTien, LoaiHoaDon, TrangThaiThanhToan)
-- VALUES (@MaKhachHang_DV, @DonGia_DV, N'Dịch vụ', N'Chưa thanh toán');

-- DECLARE @MaHoaDon_DV INT = SCOPE_IDENTITY();

-- INSERT INTO ChiTietHoaDon (MaHoaDon, TenSanPhamDichVu, SoLuong, DonGia)
-- VALUES (@MaHoaDon_DV, @TenDichVu, 1, @DonGia_DV);

-- UPDATE DatDichVu
-- SET TrangThai = N'Đã hoàn thành'
-- WHERE MaDatDichVu = 1;

/* =========================================================
   16. CAU LENH MAU: KHACH HANG MUA THU CUNG VA TAO HOA DON
   ========================================================= */
-- DECLARE @MaKhachHang_Mua INT = 1;
-- DECLARE @MaThuCung_Mua INT = 1;
-- DECLARE @TenThuCung NVARCHAR(100);
-- DECLARE @GiaBan DECIMAL(18,2);

-- SELECT 
--     @TenThuCung = TenThuCung,
--     @GiaBan = GiaBan
-- FROM ThuCung
-- WHERE MaThuCung = @MaThuCung_Mua;

-- INSERT INTO DonMuaThuCung (MaKhachHang, MaThuCung, TrangThai)
-- VALUES (@MaKhachHang_Mua, @MaThuCung_Mua, N'Đã thanh toán');

-- INSERT INTO HoaDon (MaKhachHang, TongTien, LoaiHoaDon, TrangThaiThanhToan)
-- VALUES (@MaKhachHang_Mua, @GiaBan, N'Mua thú cưng', N'Đã thanh toán');

-- DECLARE @MaHoaDon_Mua INT = SCOPE_IDENTITY();

-- INSERT INTO ChiTietHoaDon (MaHoaDon, TenSanPhamDichVu, SoLuong, DonGia)
-- VALUES (@MaHoaDon_Mua, @TenThuCung, 1, @GiaBan);

-- UPDATE ThuCung
-- SET TrangThai = N'Đã bán'
-- WHERE MaThuCung = @MaThuCung_Mua;

/* =========================================================
   17. CAU LENH MAU: XEM THONG KE DOANH THU
   ========================================================= */
-- SELECT * FROM vw_ThongKeDoanhThu;

/* =========================================================
   18. CAU LENH KIEM TRA DU LIEU
   ========================================================= */
SELECT * FROM VaiTro;
SELECT * FROM TaiKhoan;
SELECT * FROM KhachHang;
SELECT * FROM LoaiThuCung;
SELECT * FROM ThuCung;
SELECT * FROM DichVu;
GO

