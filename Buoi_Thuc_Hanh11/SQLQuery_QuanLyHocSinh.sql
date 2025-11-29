-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyHocSinh;
GO

USE QuanLyHocSinh;
GO

-- Bảng quê quán
CREATE TABLE quequan (
    maqq CHAR(5) PRIMARY KEY,
    tenqq NVARCHAR(50)
);
GO

-- Bảng học sinh
CREATE TABLE hocsinh (
    mahs CHAR(5) PRIMARY KEY,
    holot NVARCHAR(30),
    tenhs NVARCHAR(20),
    phai NVARCHAR(3),
    ngaysinh DATE,
    maqq CHAR(5) FOREIGN KEY REFERENCES quequan(maqq)
);
GO

-- Thêm dữ liệu mẫu
INSERT INTO quequan VALUES 
('QQ01', N'Hà Nội'),
('QQ02', N'Hải Phòng'),
('QQ03', N'Đà Nẵng');

INSERT INTO hocsinh VALUES
('HS01', N'Nguyễn Văn', N'An', N'Nam', '2006-04-19', 'QQ01'),
('HS02', N'Lê Thị', N'Thảo', N'Nữ', '2005-10-12', 'QQ02'),
('HS03', N'Phan Văn', N'Khánh', N'Nam', '2007-03-21', 'QQ03');

SELECT * FROM quequan;
SELECT * FROM hocsinh;