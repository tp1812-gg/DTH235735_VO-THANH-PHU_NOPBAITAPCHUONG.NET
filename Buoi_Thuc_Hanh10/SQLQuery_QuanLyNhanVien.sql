CREATE DATABASE QuanLyNhanVien;
USE QuanLyNhanVien;
GO

-- BẢNG CHỨC VỤ
CREATE TABLE chucvu (
    macv CHAR(5) PRIMARY KEY,
    tencv NVARCHAR(50),
    hspchucap FLOAT
);

-- BẢNG NHÂN VIÊN
CREATE TABLE nhanvien (
    manv CHAR(5) PRIMARY KEY,
    holot NVARCHAR(30),
    tennv NVARCHAR(20),
    phai NVARCHAR(5),
    ngaysinh DATE,
    macv CHAR(5) FOREIGN KEY REFERENCES chucvu(macv)
);

-- BẢNG QUÁ TRÌNH LƯƠNG
CREATE TABLE quatrinhluong (
    manv CHAR(5),
    ngaybd DATE,
    hsluong FLOAT,
    ghichu NVARCHAR(100),
    PRIMARY KEY (manv, ngaybd),
    FOREIGN KEY (manv) REFERENCES nhanvien(manv)
);

-- DỮ LIỆU CHỨC VỤ
INSERT INTO chucvu VALUES
('CV01', N'Giám đốc', 3.0),
('CV02', N'Phó giám đốc', 2.5),
('CV03', N'Trưởng phòng', 2.0),
('CV04', N'Nhân viên', 1.2);

-- DỮ LIỆU NHÂN VIÊN
INSERT INTO nhanvien VALUES
('NV01', N'Nguyễn Văn', N'An', N'Nam', '1990-01-10', 'CV04'),
('NV02', N'Lê Thị', N'Bích', N'Nữ', '1993-05-20', 'CV03'),
('NV03', N'Trần Văn', N'Cường', N'Nam', '1988-09-15', 'CV02');

-- DỮ LIỆU QUÁ TRÌNH LƯƠNG
INSERT INTO quatrinhluong VALUES
('NV01', '2021-01-01', 2.34, N'Tăng lương định kỳ'),
('NV01', '2022-01-01', 2.67, N'Tăng lương năm'),
('NV02', '2021-01-01', 3.25, N'Lương cơ bản'),
('NV03', '2022-06-01', 3.75, N'Tăng chức vụ');

SELECT * FROM chucvu;
SELECT * FROM nhanvien;
SELECT * FROM quatrinhluong;
