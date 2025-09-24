-- Script tạo cơ sở dữ liệu Quản lý Quán Net
-- Tạo database nếu chưa tồn tại
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'QuanNetDB')
BEGIN
    CREATE DATABASE QuanNetDB;
END
GO

USE QuanNetDB;
GO

-- Xóa các bảng nếu đã tồn tại (để chạy lại script)
IF OBJECT_ID('LichSuChoi', 'U') IS NOT NULL DROP TABLE LichSuChoi;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('GoiHoiVien', 'U') IS NOT NULL DROP TABLE GoiHoiVien;
GO

-- Tạo bảng GoiHoiVien trước vì KhachHang tham chiếu đến nó
CREATE TABLE GoiHoiVien (
    MaGoi INT IDENTITY(1,1) PRIMARY KEY,
    TenGoi NVARCHAR(100) NOT NULL,
    ThoiHan INT NOT NULL, -- Đơn vị: ngày
    GiaGoi DECIMAL(18,2) NOT NULL CHECK (GiaGoi > 0),
    MoTa NVARCHAR(255) NULL
);
GO

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE NOT NULL,
    SoTienNap DECIMAL(18,2) DEFAULT 0 CHECK (SoTienNap >= 0),
    SoGioDaChoi INT DEFAULT 0 CHECK (SoGioDaChoi >= 0),
    NgayDangKy DATETIME DEFAULT GETDATE(),
    MaGoiHV INT NULL FOREIGN KEY REFERENCES GoiHoiVien(MaGoi)
);
GO

-- Tạo bảng LichSuChoi
CREATE TABLE LichSuChoi (
    MaLS INT IDENTITY(1,1) PRIMARY KEY,
    IDKhachHang INT FOREIGN KEY REFERENCES KhachHang(ID) ON DELETE CASCADE,
    GioBatDau DATETIME NOT NULL,
    GioKetThuc DATETIME NOT NULL,
    SoTienSuDung DECIMAL(18,2) CHECK (SoTienSuDung >= 0)
);
GO

GO

-- Tạo View v_TongTienKhachHang
CREATE VIEW v_TongTienKhachHang AS
SELECT 
    kh.ID,
    kh.TenKH,
    kh.SoTienNap AS TongTienNap,
    ISNULL(SUM(lsc.SoTienSuDung), 0) AS TongTienDaSuDung
FROM KhachHang kh
LEFT JOIN LichSuChoi lsc ON kh.ID = lsc.IDKhachHang
GROUP BY kh.ID, kh.TenKH, kh.SoTienNap;
GO

-- Tạo View v_DanhSachHoiVien
CREATE VIEW v_DanhSachHoiVien AS
SELECT 
    kh.ID,
    kh.TenKH,
    kh.SoDienThoai,
    ghv.TenGoi,
    DATEADD(DAY, ghv.ThoiHan, kh.NgayDangKy) AS HanSuDung
FROM KhachHang kh
LEFT JOIN GoiHoiVien ghv ON kh.MaGoiHV = ghv.MaGoi
WHERE kh.MaGoiHV IS NOT NULL;
GO

-- Tạo Trigger cập nhật SoGioDaChoi khi INSERT vào LichSuChoi
CREATE TRIGGER trg_CapNhatSoGioDaChoi
ON LichSuChoi
AFTER INSERT
AS
BEGIN
    -- Kiểm tra GioKetThuc > GioBatDau
    IF EXISTS (SELECT 1 FROM inserted WHERE GioKetThuc <= GioBatDau)
    BEGIN
        RAISERROR('GioKetThuc phải lớn hơn GioBatDau', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    UPDATE KhachHang
    SET SoGioDaChoi = SoGioDaChoi + DATEDIFF(HOUR, i.GioBatDau, i.GioKetThuc)
    FROM KhachHang kh
    INNER JOIN inserted i ON kh.ID = i.IDKhachHang;
END;
GO

-- Tạo Function fn_TinhTongTien
CREATE FUNCTION fn_TinhTongTien (@IDKhachHang INT)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18,2);
    SELECT @TongTien = ISNULL(SUM(SoTienSuDung), 0)
    FROM LichSuChoi
    WHERE IDKhachHang = @IDKhachHang;
    RETURN @TongTien;
END;
GO

-- Tạo Stored Procedure sp_ThemKhachHang
CREATE PROCEDURE sp_ThemKhachHang
    @TenKH NVARCHAR(100),
    @SoDienThoai VARCHAR(15)
AS
BEGIN
    INSERT INTO KhachHang (TenKH, SoDienThoai)
    VALUES (@TenKH, @SoDienThoai);
END;
GO

-- Tạo Stored Procedure sp_NapTien
CREATE PROCEDURE sp_NapTien
    @ID INT,
    @SoTien DECIMAL(18,2)
AS
BEGIN
    UPDATE KhachHang
    SET SoTienNap = SoTienNap + @SoTien
    WHERE ID = @ID;
END;
GO

-- Tạo Stored Procedure sp_TimKiemKhachHang
CREATE PROCEDURE sp_TimKiemKhachHang
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM KhachHang
    WHERE TenKH LIKE '%' + @Keyword + '%' OR SoDienThoai LIKE '%' + @Keyword + '%';
END;
GO

-- Tạo Stored Procedure sp_DangKyGoiHoiVien
CREATE PROCEDURE sp_DangKyGoiHoiVien
    @IDKhachHang INT,
    @MaGoi INT
AS
BEGIN
    UPDATE KhachHang
    SET MaGoiHV = @MaGoi
    WHERE ID = @IDKhachHang;
END;
GO

-- Tạo Stored Procedure sp_XemLichSuChoi
CREATE PROCEDURE sp_XemLichSuChoi
    @ID INT
AS
BEGIN
    SELECT * FROM LichSuChoi
    WHERE IDKhachHang = @ID
    ORDER BY GioBatDau DESC;
END;
GO

-- Xóa user cũ nếu tồn tại
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'adminnet')
BEGIN
    DROP LOGIN adminnet;
END
GO

IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'nhanvien')
BEGIN
    DROP LOGIN nhanvien;
END
GO

-- Tạo user adminnet với password đơn giản
CREATE LOGIN adminnet WITH PASSWORD = '123456';
GO
USE QuanNetDB;
CREATE USER adminnet FOR LOGIN adminnet;
ALTER ROLE db_owner ADD MEMBER adminnet;
GO

-- Tạo user nhanvien với password đơn giản
CREATE LOGIN nhanvien WITH PASSWORD = '123456';
GO
USE QuanNetDB;
CREATE USER nhanvien FOR LOGIN nhanvien;
ALTER ROLE db_datareader ADD MEMBER nhanvien;
ALTER ROLE db_datawriter ADD MEMBER nhanvien;
GRANT EXECUTE TO nhanvien;
GO

-- Chèn dữ liệu mẫu (tùy chọn)

GO

-- Xóa dữ liệu cũ và thêm dữ liệu mới với encoding đúng
DELETE FROM LichSuChoi;
DELETE FROM KhachHang;
DELETE FROM GoiHoiVien;

INSERT INTO GoiHoiVien (TenGoi, ThoiHan, GiaGoi, MoTa) VALUES 
(N'Gói Cơ Bản', 30, 50000, N'Gói hội viên cơ bản 30 ngày'),
(N'Gói VIP', 90, 150000, N'Gói hội viên VIP 90 ngày');

INSERT INTO KhachHang (TenKH, SoDienThoai, SoTienNap) VALUES 
(N'Nguyễn Văn A', '0123456789', 100000),
(N'Trần Thị B', '0987654321', 200000),
(N'Lê Minh C', '0909123456', 50000);
GO

INSERT INTO LichSuChoi (IDKhachHang, GioBatDau, GioKetThuc, SoTienSuDung) VALUES
(1, '2024-01-01 10:00:00', '2024-01-01 12:00:00', 20000),
(2, '2024-01-01 14:00:00', '2024-01-01 16:30:00', 25000);
GO

PRINT 'Database QuanNetDB đã được tạo thành công!';
PRINT 'Tài khoản đăng nhập:';
PRINT '  - adminnet / 123456 (Admin)';
PRINT '  - nhanvien / 123456 (Nhân viên)';
GO