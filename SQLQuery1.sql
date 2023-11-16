
CREATE TRIGGER trg_InsertAndUpdateNewKhachHang
ON KhachHang
FOR INSERT, UPDATE
AS
BEGIN
 
-- check ten KH
IF EXISTS (SELECT * FROM inserted WHERE TRIM(HoVaTen) = '')
BEGIN
 RAISERROR('Tên KH không được để trống', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END
-- check Email 
IF EXISTS (SELECT * FROM inserted WHERE TRIM(Email) = '')
BEGIN
 RAISERROR('Email không được để trống', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END
-- check SDT
IF EXISTS (SELECT * FROM inserted WHERE TRIM(SoDienThoai) = '')
BEGIN
 RAISERROR('SDT KH không được để trống', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END
-- check Giới Tính
IF EXISTS (SELECT * FROM inserted WHERE Trim(GioiTinh) <> N'Nam' OR Trim(GioiTinh) <> N'Nữ')
BEGIN
 RAISERROR('Giới tính không xác định', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END
IF EXISTS (SELECT * FROM inserted WHERE Len(TRIM(SoDienThoai)) <>10 )
BEGIN
 RAISERROR('SDT phải là 10 số', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END
IF EXISTS (SELECT * FROM KhachHang WHERE SoDienThoai IN (SELECT SoDienThoai FROM
inserted))
BEGIN
 RAISERROR('SDT đã tồn tại', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END
END;

