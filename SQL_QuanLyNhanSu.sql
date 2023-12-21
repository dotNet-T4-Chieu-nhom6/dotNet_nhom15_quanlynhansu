Go
Create Database QuanLyNhanSu
Go
Use QuanLyNhanSu

--use master
--drop database QuanLyNhanSu
Go
Create Table PhongBan
(
idphongban int identity(1,1) primary key,
tenphongban nvarchar(100)
)
Go
Create Table Users
(
idU int identity(1,1) primary key ,
nameU varchar(100),
passU varchar(100),
emailU varchar(100),
phanquyen nvarchar(100)
)

Go
Create Table NhanVien
(
idnv int identity(1,1) primary key,
tennv nvarchar(200),
ngaysinh Datetime,
gioitinh nvarchar(100),
diachi nvarchar(MAX),
email varchar(100),
didong int,
vanhoa nvarchar(100),
chuyenmon nvarchar(100),
idphongban int ,
luong decimal(10,2)
CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY (idphongban)REFERENCES PhongBan(idphongban)
)
Go
Create Table HopDong
(
idhd varchar(200) primary key,
idnv int,
loaihd nvarchar(100),
chucvu nvarchar(100),
tenphongban nvarchar(100),
trangthai nvarchar(100),
phucap decimal(10,2),
luongHD decimal(10,2),
CONSTRAINT FK_HopDong_NhanVien FOREIGN KEY (idnv) REFERENCES NhanVien(idnv)
)
Go
Insert into PhongBan(tenphongban) Values
(N'phòng IT'),
(N'phòng nhân sự'),
(N'phòng kế toán')
Go
Insert into Users(nameU, passU, emailU, phanquyen ) Values 
('admin','admin123','admin@gmail.com',N'admin'),
('manager','manager123','manager@gmail.com',N'manager'),
('kh01','kh123','kh01@gmail.com',N'user'),
('kh02','kh123','kh02@gmail.com',N'user')
Go
Insert into NhanVien
Values
(N'Võ Thu Thủy','2001-01-15',N'Nữ',N'123 Đường Lê Văn Khương Quận 12','thuthuy@gmail.com','0777777777',N'10/12',N'Tính toán',1,60000),
(N'Lê Thành Công','2002-02-17',N'Nam',N'456 Quận Gò Vấp','thanhcong@gmail.com','0666666666',N'12/12',N'Tính toán',2,80000),
(N'Dương Thuận Quang','2003-02-17',N'Nam',N'123 Quận 11','quang@gmail.com','0888888888',N'12/12',N'Coding',2,30000),
(N'Huỳnh Hữu Đức','2002-02-12',N'Nam',N'23 Quận 7','hhduc@gmail.com','055555555',N'12/12',N'Nghiên cứu',2,80000),
(N'Lê Hoàng Nhất Thống','2003-01-11',N'Nam',N'789 Quận Bình Thạnh','lhnthong@gmail.com','0333333333',N'12/12',N'Coding',2,40000)

Go 
Insert into HopDong(idhd, loaihd,chucvu, trangthai,phucap,luongHD) Values
('987654', N'kinh doanh', N'Kế toán', N'đi làm đầy đủ', 200000,5000000),
('786786', N'kinh doanh', N'Kế toán', N'đã nghỉ', 200000,5000000)

GO
CREATE PROC ShowAllEmps
AS
select * from NhanVien


GO
CREATE PROC EditEmps
@IDNV INT,
@TENNV NVARCHAR(100),
@NGSINH DATETIME,
@GIOITINH NVARCHAR(10),
@DIACHI NVARCHAR(100),
@EMAIL VARCHAR(100),
@DIDONG INT,
@VANHOA NVARCHAR(100),
@CHUYENMON NVARCHAR(100),
@IDPB INT,
@LUONG MONEY
AS
BEGIN
	UPDATE NhanVien
	SET tennv = @TENNV, ngaysinh = @NGSINH, gioitinh = @GIOITINH, diachi = @DIACHI, email = @EMAIL, didong = @DIDONG, vanhoa = @VANHOA, chuyenmon = @CHUYENMON, idphongban = @IDPB, luong = @LUONG
	WHERE idnv = @IDNV
END

GO
CREATE PROC AddEmp
@TENNV NVARCHAR(100),
@NGSINH DATETIME,
@GIOITINH NVARCHAR(10),
@DIACHI NVARCHAR(100),
@EMAIL VARCHAR(100),
@DIDONG INT,
@VANHOA NVARCHAR(100),
@CHUYENMON NVARCHAR(100),
@IDPB INT,
@LUONG MONEY
AS
BEGIN
	INSERT INTO NhanVien
	VALUES
	(@TENNV, @NGSINH, @GIOITINH, @DIACHI, @EMAIL, @DIDONG, @VANHOA, @CHUYENMON, @IDPB, @LUONG);
END

GO
CREATE PROC DeleteEmp
@IDNV INT
AS
BEGIN
	DELETE FROM NhanVien WHERE idnv = @IDNV
END

GO
CREATE PROC ShowAllDepartment
AS
BEGIN
	SELECT * FROM PhongBan
END

GO
CREATE PROC ShowHighSalary
AS
BEGIN
	SELECT * FROM NhanVien WHERE luong > 50000
END

GO
CREATE PROC ShowLowSalary
AS
BEGIN
	SELECT * FROM NhanVien WHERE luong < 50000
END

GO
CREATE PROC Show_Expertise
@Expertise NVARCHAR(100)
AS
BEGIN
	SELECT * FROM NhanVien WHERE chuyenmon = @Expertise
END

GO
CREATE PROC ShowGender
@Gender NVARCHAR(10)
AS
BEGIN
	SELECT * FROM NhanVien WHERE gioitinh = @Gender
END


GO
CREATE PROC ShowEmptyDepartment
AS
BEGIN
	SELECT tenphongban FROM PhongBan WHERE idphongban NOT IN (SELECT idphongban FROM NhanVien)
END
