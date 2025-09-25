/* =============================================================
    SCRIPT CHÍNH KHỞI TẠO CSDL QUÁN NET (TỐI GỌN)
    Gồm 3 phần chính:
        1. CẤU TRÚC (DDL: database, bảng, view, function, trigger, stored procedure)
        2. DỮ LIỆU MẪU (khởi tạo dữ liệu tham khảo)
        3. PHÂN QUYỀN (Role, User, cấp quyền chi tiết)
    Có thể chạy lại nhiều lần an toàn (idempotent) nhờ kiểm tra tồn tại trước khi DROP.
    Lưu ý: Thay đổi mật khẩu trong môi trường triển khai thật để đảm bảo bảo mật.
============================================================= */

/* ============================
    1. CẤU TRÚC (SCHEMA)
    - Tạo database (nếu chưa có)
    - Xóa đối tượng cũ (theo đúng thứ tự phụ thuộc)
    - Tạo lại bảng, view, trigger, function, stored procedures
============================ */
IF DB_ID('QuanNetDB') IS NULL
    CREATE DATABASE QuanNetDB;
GO
USE QuanNetDB;
GO

-- XÓA CÁC ĐỐI TƯỢNG CŨ (đúng thứ tự phụ thuộc để tránh lỗi khóa ngoại / tham chiếu)
IF OBJECT_ID('dbo.trg_CapNhatSoGioDaChoi','TR') IS NOT NULL DROP TRIGGER dbo.trg_CapNhatSoGioDaChoi;
IF OBJECT_ID('dbo.v_TongTienKhachHang','V') IS NOT NULL DROP VIEW dbo.v_TongTienKhachHang;
IF OBJECT_ID('dbo.v_DanhSachHoiVien','V') IS NOT NULL DROP VIEW dbo.v_DanhSachHoiVien;
IF OBJECT_ID('dbo.sp_XemLichSuChoi','P') IS NOT NULL DROP PROCEDURE dbo.sp_XemLichSuChoi;
IF OBJECT_ID('dbo.sp_DangKyGoiHoiVien','P') IS NOT NULL DROP PROCEDURE dbo.sp_DangKyGoiHoiVien;
IF OBJECT_ID('dbo.sp_TimKiemKhachHang','P') IS NOT NULL DROP PROCEDURE dbo.sp_TimKiemKhachHang;
IF OBJECT_ID('dbo.sp_NapTien','P') IS NOT NULL DROP PROCEDURE dbo.sp_NapTien;
IF OBJECT_ID('dbo.sp_ThemKhachHang','P') IS NOT NULL DROP PROCEDURE dbo.sp_ThemKhachHang;
IF OBJECT_ID('dbo.fn_TinhTongTien','FN') IS NOT NULL DROP FUNCTION dbo.fn_TinhTongTien;
IF OBJECT_ID('dbo.LichSuChoi','U') IS NOT NULL DROP TABLE dbo.LichSuChoi;
IF OBJECT_ID('dbo.KhachHang','U') IS NOT NULL DROP TABLE dbo.KhachHang;
IF OBJECT_ID('dbo.GoiHoiVien','U') IS NOT NULL DROP TABLE dbo.GoiHoiVien;
GO

-- BẢNG: GoiHoiVien (Danh mục gói hội viên)
CREATE TABLE dbo.GoiHoiVien (
    MaGoi      INT IDENTITY(1,1) PRIMARY KEY,
    TenGoi     NVARCHAR(100) NOT NULL,
    ThoiHan    INT NOT NULL CHECK (ThoiHan > 0), -- ngày
    GiaGoi     DECIMAL(18,2) NOT NULL CHECK (GiaGoi > 0),
    MoTa       NVARCHAR(255) NULL
);
GO

-- BẢNG: KhachHang (Thông tin khách, có thể liên kết gói hội viên)
CREATE TABLE dbo.KhachHang (
    ID           INT IDENTITY(1,1) PRIMARY KEY,
    TenKH        NVARCHAR(100) NOT NULL,
    SoDienThoai  VARCHAR(15) UNIQUE NOT NULL,
    SoTienNap    DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (SoTienNap >= 0),
    SoGioDaChoi  INT NOT NULL DEFAULT 0 CHECK (SoGioDaChoi >= 0),
    NgayDangKy   DATETIME NOT NULL DEFAULT GETDATE(),
    MaGoiHV      INT NULL REFERENCES dbo.GoiHoiVien(MaGoi)
);
GO

-- BẢNG: LichSuChoi (Lịch sử giờ chơi + tiền sử dụng, liên kết khách hàng)
CREATE TABLE dbo.LichSuChoi (
    MaLS          INT IDENTITY(1,1) PRIMARY KEY,
    IDKhachHang   INT NOT NULL REFERENCES dbo.KhachHang(ID) ON DELETE CASCADE,
    GioBatDau     DATETIME NOT NULL,
    GioKetThuc    DATETIME NOT NULL,
    SoTienSuDung  DECIMAL(18,2) NOT NULL CHECK (SoTienSuDung >= 0)
);
GO

-- VIEW: v_TongTienKhachHang (Tổng quan nạp & tiêu theo khách)
CREATE VIEW dbo.v_TongTienKhachHang AS
SELECT kh.ID,
       kh.TenKH,
       kh.SoTienNap AS TongTienNap,
       ISNULL(SUM(lsc.SoTienSuDung),0) AS TongTienDaSuDung
FROM dbo.KhachHang kh
LEFT JOIN dbo.LichSuChoi lsc ON kh.ID = lsc.IDKhachHang
GROUP BY kh.ID, kh.TenKH, kh.SoTienNap;
GO

-- VIEW: v_DanhSachHoiVien (Danh sách khách có gói hội viên + hạn sử dụng)
CREATE VIEW dbo.v_DanhSachHoiVien AS
SELECT kh.ID,
       kh.TenKH,
       kh.SoDienThoai,
       ghv.TenGoi,
       DATEADD(DAY, ghv.ThoiHan, kh.NgayDangKy) AS HanSuDung
FROM dbo.KhachHang kh
JOIN dbo.GoiHoiVien ghv ON kh.MaGoiHV = ghv.MaGoi;
GO

-- TRIGGER: cập nhật cột SoGioDaChoi của KhachHang sau mỗi lịch sử chơi hợp lệ
CREATE TRIGGER dbo.trg_CapNhatSoGioDaChoi
ON dbo.LichSuChoi
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM inserted WHERE GioKetThuc <= GioBatDau)
    BEGIN
        RAISERROR (N'GioKetThuc phải lớn hơn GioBatDau',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END;
    UPDATE kh
        SET SoGioDaChoi = kh.SoGioDaChoi + DATEDIFF(HOUR, i.GioBatDau, i.GioKetThuc)
    FROM dbo.KhachHang kh
    JOIN inserted i ON kh.ID = i.IDKhachHang;
END;
GO

-- FUNCTION: fn_TinhTongTien (Tính tổng SoTienSuDung của 1 khách)
CREATE FUNCTION dbo.fn_TinhTongTien (@IDKhachHang INT)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18,2);
    SELECT @TongTien = ISNULL(SUM(SoTienSuDung),0)
    FROM dbo.LichSuChoi
    WHERE IDKhachHang = @IDKhachHang;
    RETURN @TongTien;
END;
GO

-- PROC: sp_ThemKhachHang (Thêm khách mới)
CREATE PROCEDURE dbo.sp_ThemKhachHang
    @TenKH NVARCHAR(100),
    @SoDienThoai VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.KhachHang (TenKH, SoDienThoai) VALUES (@TenKH, @SoDienThoai);
END;
GO

-- PROC: sp_NapTien (Cộng dồn số tiền vào tài khoản khách)
CREATE PROCEDURE dbo.sp_NapTien
    @ID INT,
    @SoTien DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.KhachHang SET SoTienNap = SoTienNap + @SoTien WHERE ID = @ID;
END;
GO

-- PROC: sp_TimKiemKhachHang (Tìm khách bằng tên hoặc SĐT)
CREATE PROCEDURE dbo.sp_TimKiemKhachHang
    @Keyword NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.KhachHang
    WHERE TenKH LIKE '%' + @Keyword + '%' OR SoDienThoai LIKE '%' + @Keyword + '%';
END;
GO

-- PROC: sp_DangKyGoiHoiVien (Gắn gói hội viên cho khách)
CREATE PROCEDURE dbo.sp_DangKyGoiHoiVien
    @IDKhachHang INT,
    @MaGoi INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.KhachHang SET MaGoiHV = @MaGoi WHERE ID = @IDKhachHang;
END;
GO

-- PROC: sp_XemLichSuChoi (Trả về lịch sử theo ID khách)
CREATE PROCEDURE dbo.sp_XemLichSuChoi
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.LichSuChoi WHERE IDKhachHang = @ID ORDER BY GioBatDau DESC;
END;
GO

/* ============================
    2. DỮ LIỆU MẪU (SAMPLE DATA)
    - Xóa dữ liệu cũ (nếu cần làm sạch)
    - Thêm gói hội viên mẫu
    - Thêm khách hàng mẫu (một số đã gắn gói)
    - Thêm lịch sử chơi minh họa
============================ */
-- XÓA DỮ LIỆU CŨ (giữ cấu trúc, chỉ làm sạch nội dung)
DELETE FROM dbo.LichSuChoi;
DELETE FROM dbo.KhachHang;
DELETE FROM dbo.GoiHoiVien;
GO

-- THÊM DỮ LIỆU: Bảng GoiHoiVien
INSERT INTO dbo.GoiHoiVien (TenGoi, ThoiHan, GiaGoi, MoTa) VALUES
 (N'Gói Cơ Bản', 30,  50000,  N'Gói hội viên cơ bản 30 ngày'),
 (N'Gói VIP',     90, 150000, N'Gói hội viên VIP 90 ngày'),
 (N'Gói Platinum',365, 500000, N'Gói hội viên Platinum 1 năm');
GO

-- THÊM DỮ LIỆU: Bảng KhachHang (gắn MaGoiHV nếu là hội viên)
INSERT INTO dbo.KhachHang (TenKH, SoDienThoai, SoTienNap, MaGoiHV) VALUES
 (N'Nguyễn Văn An', '0123456789', 150000, 1),
 (N'Trần Thị Bảo',  '0987654321', 200000, 2),
 (N'Lê Minh Cường', '0909123456',  80000, NULL),
 (N'Phạm Thị Dung', '0912345678', 120000, 3);
GO

-- THÊM DỮ LIỆU: Bảng LichSuChoi (dựa theo ID khách đã chèn ở trên)
DECLARE @ID1 INT = (SELECT MIN(ID) FROM dbo.KhachHang WHERE TenKH LIKE N'%Nguyễn Văn An%');
DECLARE @ID2 INT = (SELECT MIN(ID) FROM dbo.KhachHang WHERE TenKH LIKE N'%Trần Thị Bảo%');
DECLARE @ID3 INT = (SELECT MIN(ID) FROM dbo.KhachHang WHERE TenKH LIKE N'%Lê Minh Cường%');
DECLARE @ID4 INT = (SELECT MIN(ID) FROM dbo.KhachHang WHERE TenKH LIKE N'%Phạm Thị Dung%');

INSERT INTO dbo.LichSuChoi (IDKhachHang, GioBatDau, GioKetThuc, SoTienSuDung) VALUES
 (@ID1,'2024-01-01 10:00','2024-01-01 12:00',20000),
 (@ID2,'2024-01-01 14:00','2024-01-01 16:30',25000),
 (@ID3,'2024-01-02 09:00','2024-01-02 11:00',18000),
 (@ID1,'2024-01-02 15:00','2024-01-02 17:10',23000),
 (@ID4,'2024-01-03 08:30','2024-01-03 10:00',17000);
GO

/* ============================
    3. PHÂN QUYỀN (SECURITY / PERMISSIONS)
    - Tạo role ứng dụng (rl_admin, rl_nhanvien, rl_hoivien)
    - Xóa user/login cũ (nếu chạy lại ở môi trường dev)
    - Tạo login + user mới
    - Gán quyền cụ thể theo vai trò:
         + Admin: toàn quyền (db_owner)
         + Nhân viên: CRUD khách & lịch sử, xem gói, chạy các thủ tục nghiệp vụ
         + Hội viên: chỉ xem thông tin & lịch sử của hệ thống (lọc theo ứng dụng)
============================ */
-- TẠO ROLE (nếu chưa tồn tại)
IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = 'rl_admin')    CREATE ROLE rl_admin;
IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = 'rl_nhanvien') CREATE ROLE rl_nhanvien;
IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = 'rl_hoivien')  CREATE ROLE rl_hoivien;
GO

-- XÓA USER / LOGIN CŨ (tùy chọn, phục vụ làm sạch trong môi trường phát triển)
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'adminnet') DROP USER adminnet;
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'nhanvien') DROP USER nhanvien;
IF EXISTS (SELECT * FROM sys.database_principals WHERE name = 'hoivien')  DROP USER hoivien;
GO
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'adminnet') DROP LOGIN adminnet;
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'nhanvien') DROP LOGIN nhanvien;
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'hoivien')  DROP LOGIN hoivien;
GO

-- TẠO LOGIN & USER ỨNG DỤNG
CREATE LOGIN adminnet WITH PASSWORD = '123456';
CREATE LOGIN nhanvien WITH PASSWORD = '123456';
CREATE LOGIN hoivien  WITH PASSWORD = '123456';
GO
CREATE USER adminnet FOR LOGIN adminnet;
CREATE USER nhanvien FOR LOGIN nhanvien;
CREATE USER hoivien  FOR LOGIN hoivien;
GO

-- PHÂN QUYỀN: Admin toàn quyền qua db_owner
ALTER ROLE db_owner ADD MEMBER adminnet;
ALTER ROLE rl_admin ADD MEMBER adminnet;
GO

-- PHÂN QUYỀN: Nhân viên (CRUD khách + lịch sử, xem gói, xem báo cáo, chạy proc)
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.KhachHang TO rl_nhanvien;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.LichSuChoi TO rl_nhanvien;
GRANT SELECT ON dbo.GoiHoiVien TO rl_nhanvien;
GRANT SELECT ON dbo.v_TongTienKhachHang TO rl_nhanvien; -- (báo cáo nghiệp vụ)
GRANT EXECUTE ON dbo.sp_ThemKhachHang     TO rl_nhanvien;
GRANT EXECUTE ON dbo.sp_NapTien           TO rl_nhanvien;
GRANT EXECUTE ON dbo.sp_TimKiemKhachHang  TO rl_nhanvien;
GRANT EXECUTE ON dbo.sp_DangKyGoiHoiVien  TO rl_nhanvien;
GRANT EXECUTE ON dbo.sp_XemLichSuChoi     TO rl_nhanvien;
ALTER ROLE rl_nhanvien ADD MEMBER nhanvien;
GO

-- PHÂN QUYỀN: Hội viên (chỉ đọc dữ liệu cho phép + xem lịch sử)
GRANT SELECT ON dbo.KhachHang TO rl_hoivien;
GRANT SELECT ON dbo.LichSuChoi TO rl_hoivien;
GRANT SELECT ON dbo.v_DanhSachHoiVien TO rl_hoivien;
GRANT EXECUTE ON dbo.sp_XemLichSuChoi TO rl_hoivien;
ALTER ROLE rl_hoivien ADD MEMBER hoivien;
GO

PRINT N'=== Deploy thành công QuanNetDB ===';
PRINT N'Tài khoản mẫu:';
PRINT N'  - adminnet / 123456 (Admin)';
PRINT N'  - nhanvien / 123456 (Nhân viên)';
PRINT N'  - hoivien  / 123456 (Hội viên)';
GO