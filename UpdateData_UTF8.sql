    -- Script chèn lại dữ liệu với encoding UTF-8 đúng
    USE QuanNetDB;
    GO

    -- Xóa dữ liệu cũ
    DELETE FROM LichSuChoi;
    DELETE FROM KhachHang;
    DELETE FROM GoiHoiVien;
    GO

    -- Thêm dữ liệu GoiHoiVien với prefix N cho Unicode
    INSERT INTO GoiHoiVien (TenGoi, ThoiHan, GiaGoi, MoTa) VALUES 
    (N'Gói Cơ Bản', 30, 50000, N'Gói hội viên cơ bản 30 ngày'),
    (N'Gói VIP', 90, 150000, N'Gói hội viên VIP 90 ngày'),
    (N'Gói Platinum', 365, 500000, N'Gói hội viên Platinum cả năm');
    GO

    -- Thêm dữ liệu KhachHang với prefix N cho Unicode
    INSERT INTO KhachHang (TenKH, SoDienThoai, SoTienNap) VALUES 
    (N'Nguyễn Văn An', '0123456789', 100000),
    (N'Trần Thị Bảo', '0987654321', 200000),
    (N'Lê Minh Cường', '0909123456', 50000),
    (N'Phạm Thị Dung', '0912345678', 150000);
    GO

    -- Kiểm tra ID khách hàng trước khi thêm lịch sử
    DECLARE @ID1 INT, @ID2 INT, @ID3 INT, @ID4 INT;
    SELECT @ID1 = MIN(ID) FROM KhachHang WHERE TenKH LIKE N'%Nguyễn%';
    SELECT @ID2 = MIN(ID) FROM KhachHang WHERE TenKH LIKE N'%Trần%';
    SELECT @ID3 = MIN(ID) FROM KhachHang WHERE TenKH LIKE N'%Lê%';
    SELECT @ID4 = MIN(ID) FROM KhachHang WHERE TenKH LIKE N'%Phạm%';

    -- Thêm dữ liệu LichSuChoi với ID đúng
    INSERT INTO LichSuChoi (IDKhachHang, GioBatDau, GioKetThuc, SoTienSuDung) VALUES
    (@ID1, '2024-01-01 10:00:00', '2024-01-01 12:00:00', 20000),
    (@ID2, '2024-01-01 14:00:00', '2024-01-01 16:30:00', 25000),
    (@ID3, '2024-01-02 09:00:00', '2024-01-02 11:00:00', 20000),
    (@ID1, '2024-01-02 15:00:00', '2024-01-02 17:00:00', 20000);
    GO

    PRINT N'Dữ liệu đã được cập nhật với encoding UTF-8!';
    GO