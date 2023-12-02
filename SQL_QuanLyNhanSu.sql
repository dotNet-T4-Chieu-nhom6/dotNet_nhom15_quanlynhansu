Go
Create Database QuanLyNhanSu
Go
Use QuanLyNhanSu

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
didong varchar(100),
vanhoa nvarchar(100),
chuyenmon nvarchar(100),
idphongban int ,
luong money
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
phucap money,
luongHD money,
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
('kh01','kh123','kh01@gmail.com',N'user'),
('kh02','kh123','kh02@gmail.com',N'user')
Go
Insert into NhanVien(tennv,ngaysinh,gioitinh,diachi,didong,email,vanhoa,chuyenmon,luong) Values
(N'Võ Thu Thủy','2001-01-15',N'Nữ',N'123 Đường Lê Văn Khương Quận 12','0777777777','thuthuy@gmail.com',N'nghe nhạc',N'tính toán',6000000),
(N'Lê Thành Công','2002-02-17',N'Nam',N'456 Quận Gò Vấp','0666666666','thanhcong@gmail.com',N'đọc sách',N'tính toán',8000000)
Go 
Insert into HopDong(idhd, loaihd,chucvu, trangthai,phucap,luongHD) Values
('987654', N'kinh doanh', N'Kế toán', N'đi làm đầy đủ', 200000,5000000),
('786786', N'kinh doanh', N'Kế toán', N'đã nghỉ', 200000,5000000)

Go
select * from NhanVien
