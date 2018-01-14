create database coffe_manager
use coffe_manager
--drop database coffe_manager

create table NHANVIEN(
ID int identity (1,1)
,hoTen nvarchar(40)
,ngaySinh datetime
,gioiTinh nchar(5)
,diaChi nvarchar(100)
,dienThoai nchar(15)
,chucVu int
,luong int

constraint PK_NHANVIEN primary key (ID)
)

insert into NHANVIEN(hoten, ngaySinh, gioiTinh, diachi, dienthoai, chucvu, luong)
values (N'Nguyễn Văn A', GETDATE(), N'Nam', N'Quán Trà Sữa', '0168333444', 1, 100000)
,(N'Nguyễn Văn A', GETDATE(), N'Nam', N'Quán Trà Sữa', '0168333444', 2, 100000)
,(N'Nguyễn Thị C', GETDATE(), N'Nữ', N'Quán Trà Sữa', '0168333444', 3, 100000)
,(N'Trần Thanh Bảo', GETDATE(), N'Nữ', N'Quán Trà Sữa', '0168333444', 4 , 100000)
,(N'Lê Quốc Cường', GETDATE(), N'Nam', N'Quán Trà Sữa', '0168333444', 5, 100000)

create table MENU(
ID int
,tenMon nvarchar(40)
,gia int
,loai int

constraint PK_MENU primary key (ID)
)

insert into MENU(ID, tenMon, gia, loai)
values (1, N'Cà Phê Sữa', 15000, 1)
,(2, N'Cà Phê Đen', 17000, 1)
,(3, N'Nước Chanh', 10000, 1)
,(4, N'Trà Đá', 20000, 1)
,(5, N'Bánh Kem Socola', 20000, 2)
,(6, N'Bánh Pizza', 20000, 2)
,(7, N'Kem Caramel', 20000, 2)


select * from Menu

create table CHUCVU(
ID int identity (1,1)
,chucVu nvarchar(40)

constraint PK_CHUCVU primary key(ID)
)


insert into CHUCVU(chucVu)
values (N'Quản Lý')
,(N'Nhân Viên')
,(N'Pha Chế')
,(N'Bồi Bàn')
,(N'Nô Tì')

create table TAI_KHOAN(
tenTK nvarchar(25)
,matKhauTK nvarchar(25)
,maNV int 
constraint PK_TAI_KHOAN primary key (tenTK)
)

insert into tai_khoan(tenTK, matKhauTK, maNV) values('admin', '123456', 1)
,('boppy', '123456', 5)
,('duyanh', '123456', 2)
,('bunny', '123456', 3)
,('lucy', '123456', 4)