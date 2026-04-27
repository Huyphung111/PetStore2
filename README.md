# PetStore2

Ứng dụng **quản lý cửa hàng thú cưng (Pet Shop)** viết bằng **C# WinForms (.NET Framework 4.8)**, sử dụng **SQL Server** làm cơ sở dữ liệu.

---

## 1) Tổng quan dự án

PetStore2 hỗ trợ vận hành một pet shop với 2 nhóm người dùng chính:

- **Admin**: quản trị dữ liệu nền, xử lý đơn mua thú cưng, xử lý lịch dịch vụ, quản lý tài khoản, theo dõi thống kê.
- **Khách hàng**: đăng nhập, xem thú cưng, tạo đơn mua thú cưng, đặt lịch dịch vụ và theo dõi dữ liệu của chính mình.

Luồng tổng quát:

1. Người dùng đăng nhập tại `frmLogin`.
2. Hệ thống nạp thông tin phiên (`TaiKhoanID`, `Username`, `HoTen`, `RoleID`).
3. `frmMain` hiển thị menu theo quyền (role-based UI).
4. Mỗi module xử lý nghiệp vụ riêng, đọc/ghi trực tiếp SQL qua `DatabaseHelper`.

---

## 2) Kiến trúc & công nghệ sử dụng

### 2.1 Công nghệ

- **UI**: Windows Forms.
- **Runtime**: .NET Framework 4.8.
- **Database**: Microsoft SQL Server.
- **Data access**: ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `SqlParameter`).
- **Project type**: WinExe (desktop app).

### 2.2 Thành phần lõi

- `Program.cs`
  - Điểm vào ứng dụng.
  - Lưu session toàn cục sau đăng nhập: `TaiKhoanID`, `Username`, `HoTen`, `RoleID`.
- `DatabaseHelper.cs`
  - `ExecuteQuery`: chạy SELECT, trả `DataTable`.
  - `ExecuteNonQuery`: chạy INSERT/UPDATE/DELETE.
  - `ExecuteStoredProcedure`: gọi stored procedure (nếu có).
- `App.config`
  - Khai báo connection string `ShopPet` tới CSDL `QuanLyPetShop`.

### 2.3 Cấu trúc thư mục chính

- `Forms/`:
  - `frmLogin`: đăng nhập.
  - `frmMain`: shell chính + điều hướng module.
  - `frmLoaiThuCung`: CRUD loại thú cưng.
  - `frmThuCung`: CRUD thú cưng + tìm kiếm + ngừng bán.
  - `frmDichVu`: CRUD dịch vụ + bật/tắt trạng thái.
  - `frmMuaThuCung`: tạo đơn mua, thanh toán/hủy đơn.
  - `frmDatDichVu`: đặt lịch, duyệt lịch, hoàn thành dịch vụ.
  - `frmTaiKhoan`: quản trị tài khoản và thông tin khách hàng.
  - `frmThongKe`: thống kê doanh thu theo khoảng ngày.
- `QuanLyPetShop.sql`: script tạo schema + dữ liệu mẫu + view thống kê.
- `SolutionItems/DATABASE_MAPPING.md`: mapping chuẩn schema được dùng.
- `HANDOFF_CONTEXT.md`: ngữ cảnh bàn giao và phạm vi nghiệp vụ.

---

## 3) Actor nghiệp vụ và phân quyền

## 3.1 Actor

### Admin (`VaiTro.MaVaiTro = 1`)

- Quản trị danh mục: Loại thú cưng, Thú cưng, Dịch vụ.
- Quản lý tài khoản (thêm/sửa/khoá mở).
- Xử lý đơn mua thú cưng: thanh toán/hủy đơn.
- Xử lý đặt lịch dịch vụ: chấp nhận, hoàn thành, hủy.
- Xem thống kê doanh thu.

### Khách hàng (`VaiTro.MaVaiTro = 2`)

- Xem danh sách thú cưng còn bán.
- Tạo đơn mua thú cưng.
- Xem lịch sử đơn/lịch của chính mình.
- Đặt lịch dịch vụ.

## 3.2 Cơ chế phân quyền trong UI

- Ở `frmMain`: ẩn các menu quản trị (`Loại thú cưng`, `Tài khoản`, `Thống kê`) khi không phải Admin.
- Ở từng form nghiệp vụ:
  - `frmThuCung`, `frmDichVu`: chỉ Admin thấy nút thêm/sửa/đổi trạng thái.
  - `frmMuaThuCung`: Khách hàng thấy `Mua`; Admin thấy `Thanh toán`, `Hủy đơn`.
  - `frmDatDichVu`: Khách hàng thấy `Đặt lịch`; Admin thấy `Chấp nhận`, `Hoàn thành`, `Hủy`.

---

## 4) Quy trình nghiệp vụ chi tiết

## 4.1 Quy trình đăng nhập

1. Nhập username/password.
2. Kiểm tra tài khoản đang hoạt động (`TaiKhoan.TrangThai = 1`).
3. Join `VaiTro` + `KhachHang` để lấy role và tên hiển thị.
4. Gán session vào `Program.*`.
5. Mở `frmMain` theo role.

## 4.2 Quy trình mua thú cưng

### Khách hàng

1. Tìm và chọn thú cưng trạng thái **Còn bán**.
2. Bấm **Mua** để tạo bản ghi `DonMuaThuCung` với trạng thái **Chờ thanh toán**.

### Admin

1. Chọn đơn mua.
2. Nếu hợp lệ (chưa thanh toán/chưa hủy và thú cưng còn bán):
   - Tạo `HoaDon` loại **Mua thú cưng** với trạng thái thanh toán **Đã thanh toán**.
   - Tạo `ChiTietHoaDon`.
   - Cập nhật `DonMuaThuCung = Đã thanh toán`.
   - Cập nhật `ThuCung = Đã bán`.
3. Có thể hủy đơn ở trạng thái **Chờ thanh toán**.

## 4.3 Quy trình đặt lịch dịch vụ

### Khách hàng

1. Chọn dịch vụ đang hoạt động.
2. Nhập tên thú cưng, chọn ngày/giờ bắt đầu.
3. Hệ thống tự tính giờ kết thúc theo `ThoiGianThucHien`.
4. Kiểm tra trùng lịch theo điều kiện giao nhau khung giờ trong cùng ngày.
5. Nếu hợp lệ, tạo `DatDichVu` trạng thái **Chờ xác nhận**.

### Admin

1. Chọn lịch để **Chấp nhận** hoặc **Hủy**.
2. Khi **Hoàn thành**:
   - Chỉ áp dụng cho lịch đang **Đã chấp nhận**.
   - Tạo `HoaDon` loại **Dịch vụ** (trạng thái thanh toán ban đầu: **Chưa thanh toán**).
   - Tạo `ChiTietHoaDon`.
   - Cập nhật lịch thành **Đã hoàn thành**.

## 4.4 Quy trình quản trị tài khoản

- Thêm tài khoản mới với role.
- Nếu role là khách hàng thì tạo kèm bản ghi `KhachHang`.
- Sửa tài khoản + cập nhật/khởi tạo thông tin khách hàng tương ứng.
- Đổi trạng thái active/inactive (có chặn việc tự khóa tài khoản đang đăng nhập).

## 4.5 Quy trình thống kê doanh thu

- Đọc dữ liệu từ view `vw_ThongKeDoanhThu` trong khoảng ngày chọn.
- Tổng hợp số hóa đơn, tổng doanh thu, số loại hóa đơn hiển thị trên form.

---

## 5) Danh sách chức năng theo module

## 5.1 `frmLoaiThuCung`

- Danh sách loại thú cưng.
- Thêm / sửa / xóa.
- Validate bắt buộc tên loại.
- Chặn xóa khi có ràng buộc khóa ngoại từ `ThuCung`.

## 5.2 `frmThuCung`

- Danh sách thú cưng (join loại).
- Tìm kiếm theo tên thú cưng / loại / giống.
- Thêm / sửa thông tin đầy đủ (giới tính, tuổi, màu, giá, ảnh, mô tả, trạng thái).
- Nghiệp vụ **Ngừng bán**.

## 5.3 `frmDichVu`

- Danh sách dịch vụ.
- Thêm / sửa dịch vụ.
- Bật/tắt trạng thái hoạt động (`BIT`).
- Validate tên dịch vụ, đơn giá.

## 5.4 `frmMuaThuCung`

- Danh sách thú cưng còn bán.
- Tạo đơn mua (khách hàng).
- Xem danh sách đơn mua (Admin xem tất cả, khách hàng chỉ xem của mình).
- Thanh toán đơn -> sinh hóa đơn + chi tiết hóa đơn + cập nhật trạng thái thú cưng.
- Hủy đơn chờ thanh toán.

## 5.5 `frmDatDichVu`

- Danh sách dịch vụ hoạt động để đặt lịch.
- Tự tính giờ kết thúc theo thời lượng dịch vụ.
- Kiểm tra trùng lịch.
- Quản lý trạng thái lịch (chờ xác nhận/chấp nhận/hoàn thành/hủy).
- Hoàn thành lịch -> sinh hóa đơn dịch vụ + chi tiết hóa đơn.

## 5.6 `frmTaiKhoan`

- Danh sách tài khoản + thông tin khách hàng liên quan.
- Tìm kiếm theo username, vai trò, họ tên, số điện thoại.
- Thêm / sửa tài khoản.
- Kiểm tra trùng tên đăng nhập.
- Đổi trạng thái tài khoản.

## 5.7 `frmThongKe`

- Lọc theo `Từ ngày` - `Đến ngày`.
- Hiển thị thống kê doanh thu theo ngày và loại hóa đơn.
- Hiển thị tổng số hóa đơn, tổng doanh thu, số loại hóa đơn.

---

## 6) Mô hình dữ liệu (Database)

## 6.1 Database chính

- Tên CSDL: `QuanLyPetShop`.

## 6.2 Các bảng chính

- `VaiTro`
- `TaiKhoan`
- `KhachHang`
- `LoaiThuCung`
- `ThuCung`
- `DichVu`
- `DatDichVu`
- `DonMuaThuCung`
- `HoaDon`
- `ChiTietHoaDon`

## 6.3 Đối tượng phân tích

- View: `vw_ThongKeDoanhThu` (chỉ lấy hóa đơn đã thanh toán).

## 6.4 Dữ liệu mẫu

Script có sẵn tài khoản test:

- Admin: `admin / 123456`
- Khách hàng: `khach1 / 123456`

---

## 7) Công cụ & quy trình phát triển

## 7.1 Công cụ phát triển

- Visual Studio (hỗ trợ WinForms + .NET Framework 4.8).
- SQL Server + SQL Server Management Studio (SSMS) để chạy script và kiểm tra dữ liệu.
- Git để quản lý phiên bản mã nguồn.

## 7.2 Quy trình setup local

1. Mở SQL Server, chạy file `QuanLyPetShop.sql` để tạo DB + seed data.
2. Cập nhật `Data Source` trong `App.config` theo máy cá nhân.
3. Mở `PetStore2.sln` bằng Visual Studio.
4. Build và chạy.
5. Đăng nhập bằng tài khoản mẫu để kiểm tra luồng nghiệp vụ.

## 7.3 Quy trình vận hành nghiệp vụ gợi ý

1. Admin quản lý danh mục thú cưng/dịch vụ.
2. Khách hàng tạo đơn mua hoặc đặt lịch dịch vụ.
3. Admin duyệt xử lý đơn/lịch.
4. Hệ thống sinh hóa đơn và ghi nhận dữ liệu doanh thu.
5. Admin theo dõi dashboard thống kê theo thời gian.

---

## 8) Lưu ý kỹ thuật quan trọng

- Mọi truy vấn đều dùng `SqlParameter` để tránh SQL Injection do nối chuỗi dữ liệu người dùng.
- Một số nghiệp vụ nhiều bước (tạo hóa đơn + cập nhật trạng thái) hiện chưa gói trong transaction; nên cân nhắc bổ sung transaction khi nâng cấp.
- Chuỗi trạng thái tiếng Việt có dấu cần nhất quán với dữ liệu DB để tránh lỗi lọc/so khớp.
- Mật khẩu hiện đang lưu dạng plain text theo dữ liệu mẫu đồ án; nên nâng cấp hash (BCrypt/PBKDF2/Argon2) nếu đưa vào môi trường thật.

---

## 9) Định hướng mở rộng

- Bổ sung transaction + logging cho các nghiệp vụ quan trọng.
- Mã hóa/hash mật khẩu và thêm chức năng đổi mật khẩu.
- Phân tầng kiến trúc (Repository/Service) để giảm SQL trong code-behind Form.
- Thêm upload/preview ảnh thú cưng thực tế.
- Tích hợp báo cáo biểu đồ doanh thu theo tuần/tháng.
- Thêm phân quyền chi tiết hơn (VD: nhân viên lễ tân, kế toán).

---

## 10) Tài liệu liên quan

- `QuanLyPetShop.sql`
- `SolutionItems/DATABASE_MAPPING.md`
- `HANDOFF_CONTEXT.md`

> README này được cập nhật theo đúng hiện trạng source code và luồng nghiệp vụ đang triển khai trong project `PetStore2`.
