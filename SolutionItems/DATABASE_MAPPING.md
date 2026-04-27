# Dong bo schema QuanLyPetShop

File nay chot schema chinh thuc cho project `PetStore2`.

## Nguon dung lam chuan

Solution Items hien tai trong `PetStore2.sln` dang tro toi:

- `C:\Users\huyth\Downloads\QuanLyPetShop.sql`
- `C:\Users\huyth\Downloads\MoTa_Luong_QuanLyPetShop.md`

Project se di theo 2 file nay, khong di theo tai lieu cu o `D:\TEST\PetStore\SqlPetStore.md`.

## Khac nhau quan trong voi tai lieu cu

Tai lieu cu `SqlPetStore.md` dung:

- Database: `QuanLyShopPet`
- Bang quyen: `Role`
- Cot tai khoan: `TaiKhoanID`, `Username`, `RoleID`, `HoTen`
- Ban hang: `DonHang`, `ChiTietDonHang`
- Lich dich vu: `LichDichVu`
- Thong ke: `vw_TongDoanhThu`, `sp_ThongKeTongQuan`

SQL that cua solution dung:

- Database: `QuanLyPetShop`
- Bang quyen: `VaiTro`
- Cot tai khoan: `MaTaiKhoan`, `TenDangNhap`, `MaVaiTro`
- Ten khach hang nam o bang `KhachHang.HoTen`
- Mua thu cung: `DonMuaThuCung`
- Hoa don: `HoaDon`, `ChiTietHoaDon`
- Dat dich vu: `DatDichVu`
- Thong ke: `vw_ThongKeDoanhThu`

Vi vay cac form sau phai query theo schema `QuanLyPetShop.sql`.

## Connection string

`App.config` dang dung:

```xml
Data Source=huyne;Initial Catalog=QuanLyPetShop;Integrated Security=True;TrustServerCertificate=True
```

## Vai tro

Bang `VaiTro` trong SQL hien co 2 role:

| MaVaiTro | TenVaiTro |
|---|---|
| 1 | Admin |
| 2 | Khach hang |

Khong co role Nhan vien trong schema hien tai. Neu sau nay can Nhan vien thi them sau bang script rieng, con hien tai project se chia 2 quyen:

- Admin: quan ly du lieu, xu ly don/lich/hoa don/thong ke
- Khach hang: xem thu cung, mua thu cung, xem dich vu, dat dich vu

## Mapping bang/cot cho cac form

### Dang nhap

Bang:

- `TaiKhoan`
- `VaiTro`
- `KhachHang` lay ho ten neu la khach hang

Cot:

- `TaiKhoan.MaTaiKhoan`
- `TaiKhoan.TenDangNhap`
- `TaiKhoan.MatKhau`
- `TaiKhoan.MaVaiTro`
- `TaiKhoan.TrangThai`
- `VaiTro.TenVaiTro`
- `KhachHang.HoTen`

Tai khoan mau:

- `admin / 123456`
- `khach1 / 123456`

### Loai thu cung

Bang: `LoaiThuCung`

Cot:

- `MaLoai`
- `TenLoai`
- `MoTa`

SQL hien tai chua co cot `TrangThai`, nen neu xoa mem thi can them cot sau. Truoc mat co the xoa/cap nhat truc tiep.

### Thu cung

Bang: `ThuCung`

Cot:

- `MaThuCung`
- `TenThuCung`
- `MaLoai`
- `GiongLoai`
- `GioiTinh`
- `Tuoi`
- `MauSac`
- `GiaBan`
- `HinhAnh`
- `MoTa`
- `TrangThai`

Trang thai hop le theo mo ta:

- `Con ban`
- `Da ban`
- `Ngung ban`

Trong DB mau dang dung co dau tieng Viet. Khi code nen dung dung gia tri trong DB:

- `Còn bán`
- `Đã bán`
- `Ngừng bán`

### Dich vu

Bang: `DichVu`

Cot:

- `MaDichVu`
- `TenDichVu`
- `ThoiGianThucHien`
- `DonGia`
- `MoTa`
- `TrangThai`

### Dat dich vu

Bang: `DatDichVu`

Cot:

- `MaDatDichVu`
- `MaKhachHang`
- `MaDichVu`
- `TenThuCungKhach`
- `NgayDat`
- `GioBatDau`
- `GioKetThuc`
- `TrangThai`
- `GhiChu`

Trang thai:

- `Chờ xác nhận`
- `Đã chấp nhận`
- `Đã hoàn thành`
- `Đã hủy`

### Mua thu cung

Bang: `DonMuaThuCung`

Cot:

- `MaDonMua`
- `MaKhachHang`
- `MaThuCung`
- `NgayMua`
- `TrangThai`

Trang thai:

- `Chờ thanh toán`
- `Đã thanh toán`
- `Đã hủy`

### Hoa don

Bang:

- `HoaDon`
- `ChiTietHoaDon`

Cot `HoaDon`:

- `MaHoaDon`
- `MaKhachHang`
- `NgayLap`
- `TongTien`
- `LoaiHoaDon`
- `TrangThaiThanhToan`

Cot `ChiTietHoaDon`:

- `MaChiTiet`
- `MaHoaDon`
- `TenSanPhamDichVu`
- `SoLuong`
- `DonGia`
- `ThanhTien`

### Thong ke/

View hien co: `vw_ThongKeDoanhThu`

Cot:

- `Ngay`
- `LoaiHoaDon`
- `SoLuongHoaDon`
- `TongDoanhThu`

## Thu tu task tiep theo

1. Task 3: hoan thien `frmMain`, tao khung mo form con.
2. Task 4: tao `frmLoaiThuCung`.
3. Task 5: tao `frmThuCung`.
4. Task 6: tao `frmDichVu`.
5. Task 7: tao dang ky/danh sach khach hang neu can.
6. Task 8: tao luong mua thu cung va hoa don.
7. Task 9: tao dat dich vu va xu ly lich.
8. Task 10: tao thong ke doanh thu.
