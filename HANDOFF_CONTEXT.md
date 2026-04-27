# PetStore2 - Handoff Context

## Muc tieu do an

Xay dung ung dung quan ly PetShop bang WinForms C# .NET Framework 4.8 va SQL Server.

He thong co 2 nhom nguoi dung:

- Admin: quan ly du lieu, xu ly don mua, dat dich vu, hoa don, thong ke.
- Khach hang: dang nhap, xem thu cung, mua thu cung, xem dich vu, dat lich dich vu.

Giao dien dang di theo ti le mau:

- 70% xanh nhat: nen tong the.
- 20% den/xanh den: sidebar, text chinh, vung dieu huong.
- 10% trang/xanh nhan: panel noi dung, nut hanh dong.

## Nguon schema dung lam chuan

Solution Items trong `PetStore2.sln` dang tro toi:

- `C:\Users\huyth\Downloads\QuanLyPetShop.sql`
- `C:\Users\huyth\Downloads\MoTa_Luong_QuanLyPetShop.md`

Project nay di theo schema `QuanLyPetShop.sql`, khong di theo tai lieu cu o:

- `D:\TEST\PetStore\SqlPetStore.md`

Ly do: file cu dung schema khac nhu `Role`, `DonHang`, `ChiTietDonHang`, `LichDichVu`; con database that cua project dung `VaiTro`, `DonMuaThuCung`, `HoaDon`, `ChiTietHoaDon`, `DatDichVu`.

## Connection string

File: `App.config`

```xml
Data Source=huyne;Initial Catalog=QuanLyPetShop;Integrated Security=True;TrustServerCertificate=True
```

Luu y: keyword dung la `TrustServerCertificate=True`, khong phai `Trust Server Certificate=True`.

## Tai khoan test

Theo SQL mau:

- Admin: `admin / 123456`
- Khach hang: `khach1 / 123456`

## Bang/cot chinh dang dung

### VaiTro

- `MaVaiTro`
- `TenVaiTro`

Role hien co:

- `1`: Admin
- `2`: Khach hang

### TaiKhoan

- `MaTaiKhoan`
- `TenDangNhap`
- `MatKhau`
- `MaVaiTro`
- `TrangThai`

### KhachHang

- `MaKhachHang`
- `HoTen`
- `SoDienThoai`
- `Email`
- `DiaChi`
- `MaTaiKhoan`

### LoaiThuCung

- `MaLoai`
- `TenLoai`
- `MoTa`

### ThuCung

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

Trang thai dang dung:

- `Còn bán`
- `Đã bán`
- `Ngừng bán`

### DichVu

- `MaDichVu`
- `TenDichVu`
- `ThoiGianThucHien`
- `DonGia`
- `MoTa`
- `TrangThai`

### DatDichVu

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

### DonMuaThuCung

- `MaDonMua`
- `MaKhachHang`
- `MaThuCung`
- `NgayMua`
- `TrangThai`

Trang thai:

- `Chờ thanh toán`
- `Đã thanh toán`
- `Đã hủy`

### HoaDon

- `MaHoaDon`
- `MaKhachHang`
- `NgayLap`
- `TongTien`
- `LoaiHoaDon`
- `TrangThaiThanhToan`

### ChiTietHoaDon

- `MaChiTiet`
- `MaHoaDon`
- `TenSanPhamDichVu`
- `SoLuong`
- `DonGia`
- `ThanhTien`

### View thong ke

- `vw_ThongKeDoanhThu`

Cot:

- `Ngay`
- `LoaiHoaDon`
- `SoLuongHoaDon`
- `TongDoanhThu`

## Task da lam xong

### Task 1: Nen mong project

Da xong:

- Them `DatabaseHelper.cs`
- Them connection string `ShopPet` vao `App.config`
- Sua `Program.cs` de luu session dang nhap:
  - `TaiKhoanID`
  - `Username`
  - `HoTen`
  - `RoleID`
- Tao `frmLogin`
- Tao `frmMain`
- Build thanh cong

### Task 2: Dong bo schema SQL

Da xong:

- Kiem tra SQL trong Solution Items.
- Xac nhan schema dung la `QuanLyPetShop.sql`.
- Tao `SolutionItems\DATABASE_MAPPING.md`.
- Sua login query tu schema cu sang schema that:
  - `Role` -> `VaiTro`
  - `Username` -> `TenDangNhap`
  - `TaiKhoanID` -> `MaTaiKhoan`

### Task 3: Hoan thien menu chinh

Da xong:

- `frmMain` co sidebar menu.
- Mo form con trong `pnlContent`.
- Co cac module:
  - `frmThuCung`
  - `frmLoaiThuCung`
  - `frmDichVu`
  - `frmMuaThuCung`
  - `frmDatDichVu`
  - `frmTaiKhoan`
  - `frmThongKe`
- Button menu doi mau khi dang active.

### Task 4: CRUD LoaiThuCung

Da xong:

- Form: `Forms\frmLoaiThuCung.cs`
- Hien thi danh sach loai thu cung.
- Them/sua/xoa.
- Validate `TenLoai`.
- Chan loi khi xoa loai dang duoc thu cung su dung.

### Task 5: CRUD ThuCung

Da xong:

- Form: `Forms\frmThuCung.cs`
- Hien thi danh sach thu cung join `LoaiThuCung`.
- Tim kiem theo ten thu cung, loai, giong loai.
- Them/sua thu cung.
- Cap nhat trang thai `Ngừng bán`.
- Admin moi thay nut them/sua/ngung ban; khach chi xem.

### Task 6: CRUD DichVu

Da xong:

- Form: `Forms\frmDichVu.cs`
- Hien thi danh sach dich vu.
- Admin them/sua/bat tat trang thai.
- Validate:
  - `TenDichVu`
  - `ThoiGianThucHien`
  - `DonGia`
- Khach hang chi xem.

### Task 7: DatDichVu

Da xong:

- Form: `Forms\frmDatDichVu.cs`
- Khach hang dat lich dich vu.
- Tu tinh `GioKetThuc` dua tren `ThoiGianThucHien`.
- Kiem tra trung lich theo ngay/gio.
- Admin chap nhan, huy, hoan thanh lich.
- Khi hoan thanh thi tao `HoaDon` va `ChiTietHoaDon` loai `Dịch vụ`.

Flow:

```text
Khach dat lich
-> Chờ xác nhận
-> Admin chấp nhận
-> Đã chấp nhận
-> Admin hoàn thành
-> Tạo hóa đơn dịch vụ
-> Đã hoàn thành
```

### Task 8: Mua thu cung + hoa don

Da xong:

- Form: `Forms\frmMuaThuCung.cs`
- Khach hang xem thu cung `Còn bán`.
- Khach tao `DonMuaThuCung` trang thai `Chờ thanh toán`.
- Admin xem tat ca don mua.
- Admin thanh toan don:
  - Tao `HoaDon`
  - Tao `ChiTietHoaDon`
  - Cap nhat `DonMuaThuCung` thanh `Đã thanh toán`
  - Cap nhat `ThuCung` thanh `Đã bán`
- Admin co the huy don `Chờ thanh toán`.

Flow:

```text
Khach chon thu cung
-> Tao DonMuaThuCung
-> Chờ thanh toán
-> Admin thanh toán
-> Tạo hóa đơn
-> ThuCung thành Đã bán
```

### Task 9: Quan ly tai khoan / khach hang

Da xong:

- Form: `Forms\frmTaiKhoan.cs`
- Admin xem danh sach `TaiKhoan` join `VaiTro` va `KhachHang`.
- Tim kiem theo ten dang nhap, vai tro, ho ten, so dien thoai.
- Them tai khoan.
- Sua tai khoan.
- Bat/tat trang thai.
- Tao/sua thong tin `KhachHang` khi role la Khach hang.
- Chan trung `TenDangNhap`.
- Khong cho tat tai khoan dang dang nhap.

## Cau truc project hien tai

```text
PetStore2/
├── App.config
├── DatabaseHelper.cs
├── Form1.cs
├── Form1.Designer.cs
├── HANDOFF_CONTEXT.md
├── PetStore2.csproj
├── PetStore2.sln
├── Program.cs
├── Forms/
│   ├── ModulePlaceholderForm.cs
│   ├── frmDatDichVu.cs
│   ├── frmDichVu.cs
│   ├── frmLoaiThuCung.cs
│   ├── frmLogin.cs
│   ├── frmLogin.Designer.cs
│   ├── frmMain.cs
│   ├── frmMain.Designer.cs
│   ├── frmMuaThuCung.cs
│   ├── frmTaiKhoan.cs
│   ├── frmThongKe.cs
│   └── frmThuCung.cs
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs
│   ├── Resources.resx
│   ├── Settings.Designer.cs
│   └── Settings.settings
└── SolutionItems/
    └── DATABASE_MAPPING.md
```

## Luu y ky thuat

- Project khong dung Entity Framework.
- Query SQL viet truc tiep trong form.
- Moi query DB di qua `DatabaseHelper`.
- Nen dung `SqlParameter` cho moi input nguoi dung.
- Password hien dang luu plain text theo dung muc tieu do an sinh vien.
- `Form1` van con trong project nhung khong dung lam startup nua.
- Startup hien tai la `Forms.frmLogin`.
- Cac form chuc nang chinh da duoc tach theo dang WinForms Designer chuan:
  - Logic nam trong `frmX.cs`.
  - Controls/layout nam trong `frmX.Designer.cs`.
  - Visual Studio co the hien thi/nest file Designer theo `DependentUpon` trong `.csproj`.
- Thu muc nay khong phai git repository, `git status` se bao loi.
- Da build nhieu lan bang MSBuild va gan day nhat build thanh cong.

### Task 10: Thong ke doanh thu

Da xong:

- Form: `Forms\frmThongKe.cs`
- Doc view `vw_ThongKeDoanhThu`.
- Loc theo ngay tu/den.
- Hien doanh thu theo ngay va loai hoa don.
- Tong so hoa don da thanh toan.
- Tong doanh thu.
- Hien so loai hoa don trong khoang loc.
- Giao dien dung tong mau xanh nhat / xanh den / trang theo style `frmMain` va cac form da lam.

## Viec con lai de lam

### Task 11: Ra loi va polish demo

Can lam:

- Chay app theo flow tu dau den cuoi.
- Test login Admin/Khach.
- Test CRUD loai thu cung.
- Test CRUD thu cung.
- Test CRUD dich vu.
- Test khach dat dich vu, Admin chap nhan/hoan thanh.
- Test khach mua thu cung, Admin thanh toan.
- Test tai khoan moi.
- Sua loi UI neu bi tran/noi dung khong vua.

## Lenh build da dung

```powershell
& 'C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe' .\PetStore2.csproj /p:Configuration=Debug /p:Platform="AnyCPU" /v:minimal
```

Ket qua build gan day:

```text
PetStore2 -> D:\TEST\PetStore2\bin\Debug\PetStore2.exe
```

## Goi y prompt khi sang cua so moi

Co the noi:

```text
Day la project PetStore2. Hay doc file HANDOFF_CONTEXT.md truoc, sau do tiep tuc Task 10: Thong ke doanh thu.
```
