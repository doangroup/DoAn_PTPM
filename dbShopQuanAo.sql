create database QLSHOPQUANAO
go
use QLSHOPQUANAO
go

select * from TaiKhoan
go

create table TaiKhoan
(
	TenDN nvarchar(50) primary key,
	MatKhau nvarchar(50) not null,
	LoaiTK int not null -- 1 = Quản lý & 0 = Nhân viên
)
go

select * from HoaDon
go

select * from ChiTietHD
go

go

create table KhachHang
(
	MaKH int primary key,
	TenKH nvarchar(100) not null,
	DiaChi nvarchar(100),
	SDT nvarchar(20),
)
go

alter table KhachHang
add MatKhau nvarchar(50) default null;
go

create table KhuyenMai
(
	MaKM int primary key,
	TenKM nvarchar(50),
	LinkKM nvarchar(max)
)
create table NhanVien
(
	MaNV int primary key,
	TenNV nvarchar(100) not null,
	GioiTinh nvarchar(20) not null,
	DiaChi nvarchar(100) not null,
	SDT nvarchar(100) not null,
	NgaySinh datetime not null,
)
go

set dateformat dmy
go

insert into NhanVien
values (1,N'Trung',N'Nam',N'Tân Phú','045648932',1999/01/23),
		(2,N'Nhân Viên 2',N'Nữ',N'Thủ Đức','045648932',2000/07/20)
go

insert into NhanVien values (3,N'trung',N'Nam',N'thone','65465',3/2/2010)
<<<<<<< HEAD
insert into NhanVien values (2,N'fd',N'Nam',N'fads','3424',01/04/2021)
select * from NhanVien
=======

>>>>>>> Huy
go
create table DanhMuc
(
	MaDM int primary key,
	TenDM nvarchar(50)
)
go
insert into DanhMuc
values (1,'Áo sơ mi'),
		(2,'Áo thun'),
		(3,'Quần jean'),
		(4,'Quần tây'),
		(5,'Áo khoác nam'),
		(6,'Quần jogger'),
		(7,'Áo cặp')
go

create table SanPham
(
	MaSP int primary key,
	MaDM int,
	TenSP nvarchar(100) not null,
	SoLuong int not null,
	DonGia int not null,
	HinhAnh nvarchar(50),
	GhiChu nvarchar(200),
	constraint fk_SP_DM foreign key(MaDM) references DanhMuc(MaDM)
)
go

insert into SanPham
values (1,7,N'Áo thun đính đá hình báo',20,200000,'cap3.jpg',N'Giặt ra màu'),
		(2,7,N'Áo thun đính đá',10,100000,'cap6.jpg',null),
		(3,7,N'Áo thun đính đá đầu hổ',50,20000,'cap10.jpg',null),
		(4,7,N'Áo thun burlong thêu',10,50000,'cap5.jpg',N'Giặt ra màu'),
		(5,7,N'Áo thun cánh chim',40,100000,'cap13.jpg',null),
		(6,7,N'Áo thun cánh chim ngũ sắc',15,200000,'cap13.jpg',N'Giặt không ra màu'),
		(7,7,N'Áo sơ mi nam họa tiết sọc in',20,250000,'cap17.jpg',N'Vải dày'),
		(8,7,N'Áo thun cánh chim thiên thần có cổ đính ',50,20000,'cap14.jpg',null),
		(9,7,N'Áo thun nam đính đá versace ',20,100000,'cap2.jpg',N'Giặt ra màu'),
		(10,7,N'Áo thun cánh chim thiên thần',20,100000,'cap1.jpg',N'Giặt ra màu'),
		(11,7,N'Áo sơ mi nam họa tiết jean sọc ',20,100000,'cap16.jpg',null),
		(12,7,N'Áo thun tay dài thêu versace',20,100000,'cap4.jpg',null),
		(13,7,N'Áo thun dài tay đính đá',20,100000,'cap7.jpg',null),
		(14,7,N'Áo thun dài tay đính cườm versace',20,100000,'cap12.jpg',null),
		(15,7,N'áo thun đầu hổ 8997 Nam-Nữ',20,100000,'cap9.jpg',null),
		(16,7,N'áo sơ mi sọc 1890',20,100000,'cap18.jpg',null),
		(17,7,N'áo sơ mi mặt trời 290 (Nam -nữ)',20,100000,'cap15.jpg',null),
		(18,1,N'Áo sơ mi họa tiết versace',20,100000,'somi14.jpg',null),
		(19,1,N'Áo sơ mi họa tiết versace',20,100000,'somi15.jpg',null),
		(20,1,N'Áo sơ mi nam họa tiết D&G',20,100000,'somi16.jpg',null),
		(21,1,N'Áo sơ mi nam trắng NYC',20,100000,'somi11.jpg',null),
		(22,1,N'Áo sơ mi nam trắng trơn',20,100000,'somi20.jpg',null),
		(23,1,N'Áo sơ mi nam họa tiết versace',20,100000,'somi13.jpg',null),
		(24,1,N'Áo sơ mi nam họa tiết versace',20,100000,'somi25.jpg',null),
		(25,1,N'Áo sơ mi nam burberry ',20,100000,'somi10.jpg',null),
		(26,1,N'Áo sơ mi nam họa tiết hoa văn',20,100000,'somi12.jpg',null),
		(27,1,N'Áo sơ mi NYC',20,100000,'somi9.jpg',null),
		(28,1,N'Áo sơ mi nam sọc caro',20,100000,'somi23.jpg',null),
		(29,1,N'áo sơ mi nam trắng trơn',20,100000,'somi24.jpg',null),
		(30,1,N'Áo sơ mi nam họa tiết',20,100000,'somi3.jpg',null),
		(31,1,N'Áo sơ mi nam sọc họa',20,100000,'somi2.jpg',null),
		(32,2,N'Áo thun nam hoạ tiết burberi',20,100000,'thun1.jpg',null),
		(33,2,N'Áo thun nam hoạ tiết hình sư tử',20,100000,'thun2.jpg',null),
		(34,2,N'Áo thun nam hoạ tiết đặc biệt',20,100000,'thun3.jpg',null),
		(35,2,N'Áo thun nam hoạ tiết chuột Mickey đính',20,100000,'thun4.jpg',null),
		(36,2,N'Áo thun nam hoạ tiết đặc biệt ',20,100000,'thun5.jpg',null),
		(37,2,N'Áo thun nam đính cườm',20,100000,'thun6.jpg',null),
		(38,2,N'Áo thun nam hoạ tiết in nhũ vàng',20,100000,'thun7.jpg',null),
		(39,2,N'Áo thun đính cườm',20,100000,'thun8.jpg',null),
		(40,2,N'áo thun nam họa tiết thêu 3D đính cườm',20,100000,'thun9.jpg',null),
		(41,2,N'Áo thun có cổ LOGO',20,100000,'thun10.jpg',null),
		(42,2,N'Áo thun nam có cổ',20,100000,'thun11.jpg',null),
		(43,3,N'Quần jean đen nam rách gối',20,100000,'jean1.jpg',null),
		(44,3,N'quần jean rách nam',20,100000,'jean2',null),
		(45,3,N'quần jean rách',20,100000,'jean3',null),
		(46,3,N'quần jean rách',20,100000,'jean4',null),
		(47,3,N'Quần jean rách',20,100000,'jean5',null),
		(48,3,N'quần jean',20,100000,'jean6',null),
		(49,3,N'quần jean rách',20,100000,'jean7',null),
		(50,3,N'quần jean rách gối',20,100000,'jean8',null),
		(51,3,N'quần jean rách',20,100000,'jean9',null),
		(52,3,N'quần jean rách',20,100000,'jean10.jpg',null),
		(53,3,N'quần jean rách',20,100000,'jean11.jpg',null),
		(54,4,N'quần tây âu (big size)',20,100000,'tay1.jpg',null),
		(55,4,N'quần tây Nam size lớn ống côn',20,100000,'tay2.jpg',null),
		(56,4,N'quần tây size lớn xám chì ống ôm',20,100000,'tay3.jpg',null),
		(57,4,N'Quần Tây nam ống côn',20,100000,'tay4.jpg',null),
		(58,4,N'quần tây nam ống côn',20,100000,'tay5.jpg',null),
		(59,4,N'quần tây âu 3',20,100000,'tay6.jpg',null),
		(60,4,N'quần tây âu 5',20,100000,'tay7.jpg',null),
		(61,4,N'quần tây âu 1',20,100000,'tay8.jpg',null),
		(62,4,N'Tây slim hàn quốc',20,100000,'tay9.jpg',null),
		(63,5,N'áo khoác số c7',20,100000,'khoac1.jpg',null),
		(64,5,N'áo khoác bombor',20,100000,'khoac2.jpg',null),
		(65,6,N'quần jogger thun',20,100000,'jogger2.jpg',null),
		(66,6,N'quần jogger thun 2007',20,100000,'jogger3.jpg',null),
		(67,6,N'quần jogger thun 2009',20,100000,'jogger4.jpg',null),
		(68,6,N'quần jogger thun 2019',20,100000,'jogger5.jpg',null),
		(69,6,N'quần jogger thun 2020',20,100000,'jogger6.jpg',null),
		(70,6,N'quần jogger',20,100000,'jogger7.jpg',null),
		(71,6,N'quần jogger 1815',20,100000,'jogger8.jpg',null),
		(72,6,N'quần jogger 925',20,100000,'jogger9.jpg',null)
go

select * from KhachHang
go

insert into KhachHang
values (1,N'Tạ Quang Trung', N'Thôn 5', N'0123456','1'),
		(2,N'Nguyễn Văn Tèo', N'Thôn 2', N'0123456','1'),
		(3,N'Nguyễn Thị Bưởi', N'Thôn 8', N'0123456','1'),
		(4,N'Nguyễn Thị Đào', N'Thôn 1', N'0123456','1')
go

create table HoaDon
(
	MaHD int primary key,
	MaKH int,
	MaNV int,
	MaSP int,
	NgayBan datetime not null,
	constraint fk_HD_NV foreign key(MaNV) references NhanVien(MaNV),
	constraint fk_HD_H foreign key(MaSP) references SanPham(MaSP),
	constraint fk_HD_KH foreign key(MaKH) references KhachHang(MaKH)
)
go

create table ChiTietHD
(
	MaHD int primary key,
	SoLuong int,
	ThanhTien float,
	Tinhtrang int default 0, -- 0 = chưa thanh toán | 1 = thanh toán
	constraint fk_CTHD_HD foreign key(MaHD) references HoaDon(MaHD)
)
go
select * from ChiTietHD

insert into TaiKhoan
values ('admin','1',1),
		('admin2','1',0)

go
insert into HoaDon
values (1,1,1,3,2020/05/01),
		(2,2,2,2,2020/07/01)
go

create trigger TGThanhTien
on ChiTietHD
for insert, update
as
	update ChiTietHD
	set ThanhTien = inserted.SoLuong * SanPham.DonGia
	from inserted, SanPham, HoaDon
	where inserted.MaHD= ChiTietHD.MaHD and HoaDon.MaSP = SanPham.MaSP
go

create proc LayHDTheoNgay 
@ngayban datetime
as
begin
	select TenSP, ChiTietHD.SoLuong, SanPham.DonGia, NgayBan, TenKH, ThanhTien = ChiTietHD.SoLuong * DonGia from KhachHang, HoaDon,SanPham, ChiTietHD where NgayBan = @ngayban and SanPham.MaSP = HoaDon.MaSP and KhachHang.MaKH = HoaDon.MaKH
end
go

exec LayHDTheoNgay '1900-01-01 00:00:00.000'


insert into ChiTietHD
values (1,1,0,1),
		(2,2,0,0)
go
select * from ChiTietHD


select DonGia from SanPham, HoaDon, ChiTietHD where ChiTietHD.MaHD = HoaDon.MaHD and SanPham.MaSP = HoaDon.MaSP and HoaDon.MaHD = 1
update SanPham set TenSP = N'', SoLuong = 5, DonGiaNhap = 4, DonGiaBan = 4, GhiChu = N'' where MaSP = 1


select * from NhanVien



=======
>>>>>>> Huy




